namespace Simaira.Template.AzureFunction.Service.Cache
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using EnsureThat;
    using Microsoft.Extensions.Logging;
    using Newtonsoft.Json;
    using Polly;
    using StackExchange.Redis;

    public class RedisCacheManager : CacheManager, IRedisCacheManager
    {
        private readonly IDatabase _db;
        private readonly ILogger<RedisCacheManager> _logger;
        private readonly IConnectionMultiplexer _redis;
        private readonly IAppConfiguration _configuration;
        private readonly IBatch _batch;

        public RedisCacheManager(IConnectionMultiplexer redis, IBatch batch, ILogger<RedisCacheManager> logger, IAppConfiguration configuration)
        {
            EnsureArg.IsNotNull(redis);
            _configuration = configuration;
            _redis = redis;
            _batch = batch;
            _logger = logger;
            _db = redis.GetDatabase();
        }

        public async Task<T> GetAsync<T>(string key)
        {
            var jsonString = string.Empty;

            try
            {
                jsonString = await _db.StringGetAsync(key).ConfigureAwait(false);
            }
            catch
            {
                // return default on failure so code can fallback on a database hit
                _logger.LogError("Unable to get item {cacheKey} from cache! Falling back to database.", key);
                return default;
            }

            if (string.IsNullOrEmpty(jsonString))
            {
                return default;
            }

            return JsonConvert.DeserializeObject<T>(jsonString);
        }

        public async Task AddAsync<T>(string key, T value, int timeExpirationInMinute)
        {
            var retryNumber = 0;
            var jsonString = JsonConvert.SerializeObject(value);
            try
            {
                await Policy
                    .Handle<Exception>()
                    .WaitAndRetryAsync(
                        _configuration.RetryCount,
                        rt => TimeSpan.FromMinutes(timeExpirationInMinute),
                        (_, __) =>
                        {
                            retryNumber++;

                            _logger.LogWarning("Retry number {retryNumber} setting item with key '{cacheKey}' on cache", retryNumber, key);
                        })
                    .ExecuteAsync(async () => await _db.StringSetAsync(key, jsonString, TimeSpan.FromMinutes(timeExpirationInMinute)).ConfigureAwait(false))
                    .ConfigureAwait(false);
            }
            catch
            {
                // suppress
                _logger.LogError("Unable to set item {cacheKey} in cache!", key);
            }
        }

        public async Task InvalidateAsync()
        {
            var endpoints = _redis.GetEndPoints();
            var server = _redis.GetServer(endpoints.First());
            var keys = server.Keys(pageSize: _configuration.CachePageSize);
            var keyDeleteTasks = keys
                .Select(async key => await _db.KeyDeleteAsync(key).ConfigureAwait(false));
            await Task.WhenAll(keyDeleteTasks).ConfigureAwait(false);
        }
    }
}

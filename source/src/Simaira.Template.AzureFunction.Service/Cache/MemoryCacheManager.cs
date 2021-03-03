namespace Simaira.Template.AzureFunction.Service.Cache
{
    using System;
    using System.Collections.Concurrent;
    using Microsoft.Extensions.Caching.Memory;

    public class MemoryCacheManager : CacheManager, IMemoryCacheManager
    {
        private static readonly ConcurrentDictionary<string, object> _theLock = new ConcurrentDictionary<string, object>();
        private readonly IMemoryCache _cache;
        private readonly bool _isEnableCache;

        public MemoryCacheManager(IMemoryCache memoryCache)
        {
            _cache = memoryCache;
            _isEnableCache = true; // Fix me: read from config
        }

        public void Add<T>(T value, string key, int timeExpirationInMinute)
        {
            if (_isEnableCache)
            {
                lock (_theLock.GetOrAdd(key, _ => new object()))
                {
                    _cache.Set(
                        key,
                        value,
                        new MemoryCacheEntryOptions()
                      .SetAbsoluteExpiration(TimeSpan.FromMinutes(timeExpirationInMinute))
                      .RegisterPostEvictionCallback(
                            (key, value, reason, substate) =>
                            {
                                object o;
                                _theLock.TryRemove(key.ToString(), out o);
                            }));
                }
            }
        }

        public T Get<T>(string key)
        {
            return _cache.Get<T>(key);
        }

        public void Remove(string key)
        {
            _cache.Remove(key);
        }
    }
}

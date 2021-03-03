namespace Simaira.Template.AzureFunction.Service.Cache
{
    using System.Threading.Tasks;

    public interface IRedisCacheManager
    {
        string GenerateCacheKey(string cacheName, params object[] args);

        Task<T> GetAsync<T>(string key);

        Task AddAsync<T>(string key, T value, int timeExpirationInMinute);
    }
}

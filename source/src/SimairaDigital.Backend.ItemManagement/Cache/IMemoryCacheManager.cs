namespace SimairaDigital.Backend.ItemManagement.Cache
{
    public interface IMemoryCacheManager
    {
        T Get<T>(string key);

        void Add<T>(T value, string key, int timeExpirationInMinute);

        void Remove(string key);

        string GenerateCacheKey(string cacheName, params object[] args);
    }
}

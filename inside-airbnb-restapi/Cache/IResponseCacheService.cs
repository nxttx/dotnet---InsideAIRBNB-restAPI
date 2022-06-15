// content: https://geradegeldenhuys.net/read/distributed-caching-aspnet-core/

namespace WebApplication1.Cache
{
    public interface IResponseCacheService
    {
        Task CacheResponseAsync(string cacheKey, object response, TimeSpan timeTimeLive);
        Task<string> GetCachedResponseAsync(string cacheKey);
    }
}
using System;
using Microsoft.Extensions.Caching.Memory;

namespace iODS.Service.Cache
{
    /// <summary>
    /// 内存缓存
    /// </summary>
    public class MemoryCaching : ICaching
    {
        private readonly IMemoryCache _cache;

        //还是通过构造函数的方法，获取
        public MemoryCaching(IMemoryCache cache)
        {
            this._cache = cache;
        }
        
        public void Set(string cacheKey, object cacheValue)
        {
            this._cache.Set(cacheKey, cacheValue, TimeSpan.FromSeconds(7200));
        }

        public string GetValue(string key)
        {
          return  this._cache.Get(key).ToString();
        }

        public TEntity Get<TEntity>(string key)
        {
            return this._cache.Get<TEntity>(key);
        }

        public void Set(string key, object value, TimeSpan cacheTime)
        {
            throw new NotImplementedException();
        }

        public bool Get(string key)
        {
            throw new NotImplementedException();
        }

        public void Remove(string key)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
           
        }
    }
}
using System;
using System.Net;
using Hollysys.Common;
using StackExchange.Redis;

namespace iODS.Service.Cache
{
    public class RedisCaching : ICaching
    {
        private readonly string _redisConnectionString;

        public volatile ConnectionMultiplexer RedisConnection;

        private readonly object _redisConnectionLock = new object();

        public RedisCaching()
        {
            string redisConfiguration = AppSettings.ReadContent(new[] { "AppSettings", "RedisCachingAOP", "ConnectionString" });//获取连接字符串

            if (string.IsNullOrWhiteSpace(redisConfiguration))
            {
                throw new ArgumentException("redis config is empty", nameof(redisConfiguration));
            }
            this._redisConnectionString = redisConfiguration;
            this.RedisConnection = this.GetRedisConnection();
        }

        /// <summary>
        /// 核心代码，获取连接实例
        /// 通过双if 夹lock的方式，实现单例模式
        /// </summary>
        /// <returns></returns>
        private ConnectionMultiplexer GetRedisConnection()
        {
            //如果已经连接实例，直接返回
            if (this.RedisConnection != null && this.RedisConnection.IsConnected)
            {
                return this.RedisConnection;
            }
            //加锁，防止异步编程中，出现单例无效的问题
            lock (this._redisConnectionLock)
            {
                //释放redis连接
                this.RedisConnection?.Dispose();
                try
                {
                    this.RedisConnection = ConnectionMultiplexer.Connect(this._redisConnectionString);
                }
                catch (Exception)
                {
                    //throw new Exception("Redis服务未启用，请开启该服务，并且请注意端口号，本项目使用的的6319，而且我的是没有设置密码。");
                }
            }
            return this.RedisConnection;
        }

        /// <summary>
        /// 清除
        /// </summary>
        public void Clear()
        {
            foreach (EndPoint endPoint in this.GetRedisConnection().GetEndPoints())
            {
                IServer server = this.GetRedisConnection().GetServer(endPoint);
                foreach (RedisKey key in server.Keys())
                {
                    this.RedisConnection.GetDatabase().KeyDelete(key);
                }
            }
        }

        /// <summary>
        /// 判断是否存在
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public bool Get(string key)
        {
            return this.RedisConnection.GetDatabase().KeyExists(key);
        }

        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public string GetValue(string key)
        {
            return this.RedisConnection.GetDatabase().StringGet(key);
        }

        /// <summary>
        /// 获取
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="key"></param>
        /// <returns></returns>
        public TEntity Get<TEntity>(string key)
        {
            RedisValue value = this.RedisConnection.GetDatabase().StringGet(key);
            if (value.HasValue)
            {
                //需要用的反序列化，将Redis存储的Byte[]，进行反序列化
                return SerializeHelper.Deserialize<TEntity>(value);
            }

            return default(TEntity);
        }

        /// <summary>
        /// 移除
        /// </summary>
        /// <param name="key"></param>
        public void Remove(string key)
        {
            this.RedisConnection.GetDatabase().KeyDelete(key);
        }

        /// <summary>
        /// 设置
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <param name="cacheTime"></param>
        public void Set(string key, object value, TimeSpan cacheTime)
        {
            if (value != null)
            {
                //序列化，将object值生成RedisValue
                this.RedisConnection.GetDatabase().StringSet(key, SerializeHelper.Serialize(value), cacheTime);
            }
        }

        /// <summary>
        /// 增加/修改
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool SetValue(string key, byte[] value)
        {
            return this.RedisConnection.GetDatabase().StringSet(key, value, TimeSpan.FromSeconds(120));
        }
    }
}
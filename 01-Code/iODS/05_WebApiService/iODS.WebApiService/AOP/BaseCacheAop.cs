using System;
using System.Collections.Generic;
using System.Linq;
using Castle.DynamicProxy;
using Hollysys.Common;
using Newtonsoft.Json;

namespace iODS.WebApiService
{
    public abstract class BaseCacheAop : IInterceptor
    {
        /// <summary>
        ///     Aop的拦截方法
        /// </summary>
        /// <param name="invocation"></param>
        public abstract void Intercept(IInvocation invocation);

        /// <summary>
        /// 自定义缓存的Key
        /// </summary>
        /// <param name="invocation"></param>
        /// <returns></returns>
        protected static string CustomCacheKey(IInvocation invocation)
        {
            string       typeName        = invocation.TargetType.Name;
            string       methodName      = invocation.Method.Name;
            List<string> methodArguments = invocation.Arguments.Select(GetArgumentValue).Take(3).ToList(); //获取参数列表，最多三个
            string       key             = $"{typeName}:{methodName}:";
            key = methodArguments.Aggregate(key, (current, param) => $"{current}{param}:");
            return key.TrimEnd(':');
        }

        /// <summary>
        ///     object 转 string
        /// </summary>
        /// <param name="arg"></param>
        /// <returns></returns>
        protected static string GetArgumentValue(object arg)
        {
            switch (arg)
            {
                case DateTime time: return time.ToString("yyyyMMddHHmmss");
                case string _:
                case ValueType _: return arg.ToString();
            }

            if (arg != null)
            {
                if (arg.GetType().IsClass)
                {
                    return Md5Helper.Md5Encrypt16(JsonConvert.SerializeObject(arg));
                }
            }

            return string.Empty;
        }
    }
}
using System;
using Castle.DynamicProxy;

namespace iODS.WebApiService
{
    public class MemoryCacheAop:BaseCacheAop
    {
        /// <summary>
        /// 内存缓存拦截器的具体业务实现
        /// </summary>
        /// <param name="invocation"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Intercept(IInvocation invocation)
        {
            //TODO：内存缓存拦截器的具体业务实现
            throw new NotImplementedException();
        }
    }
}
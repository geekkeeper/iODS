using System;
using Castle.DynamicProxy;

namespace iODS.WebApiService
{
    public class LogAop:IInterceptor
    {
        /// <summary>
        /// 日志拦截器的具体业务实现
        /// </summary>
        /// <param name="invocation"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void Intercept(IInvocation invocation)
        {
            //TODO：日志拦截器的具体业务实现
            throw new NotImplementedException();
        }
    }
}
using System;
using Hollysys.Common;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Hosting;
using StackExchange.Profiling;

namespace iODS.WebApiService
{
    /// <summary>
    /// 全局异常错误日志
    /// </summary>
    public class GlobalExceptionsFilter : IExceptionFilter
    {
        private readonly IWebHostEnvironment _env;
        private readonly ILogger _logger;
        //private readonly IHubContext<ChatHub> _hubContext;

        public GlobalExceptionsFilter(IWebHostEnvironment env, ILogger logger)
        {
            this._env = env;
            this._logger = logger;
            //this._hubContext = hubContext;
        }

        public void OnException(ExceptionContext context)
        {
            var json = new JsonErrorResponse { Message = context.Exception.Message };

            //错误信息
            if (this._env.IsDevelopment())
            {
                json.DevelopmentMessage = context.Exception.StackTrace;//堆栈信息
            }
            context.Result = new InternalServerErrorObjectResult(json);

            MiniProfiler.Current.CustomTiming("Errors：", json.Message);

            //TODO：记录日志-->采用log4net 进行错误日志记录
            this._logger.Error(json.Message, WriteLog(json.Message, context.Exception));
            //TODO:发送消息（消息平台：微信、右键、短信等）
            //this._hubContext.Clients.All.SendAsync("ReceiveUpdate", LogLock.GetLogData()).Wait();
        }

        /// <summary>
        /// 自定义返回格式
        /// </summary>
        /// <param name="customMsg">自定义信息</param>
        /// <param name="ex">异常</param>
        /// <returns></returns>
        public static string WriteLog(string customMsg, Exception ex)
        {
            return
                    $"【自定义错误】：{customMsg} \r\n【异常类型】：{ex.GetType().Name} \r\n【异常信息】：{ex.Message} \r\n【堆栈调用】：{ex.StackTrace}";
        }
    }

    public class InternalServerErrorObjectResult : ObjectResult
    {
        public InternalServerErrorObjectResult(object value) : base(value)
        {
            this.StatusCode = StatusCodes.Status500InternalServerError;
        }
    }

    //返回错误信息
    public class JsonErrorResponse
    {
        /// <summary>
        /// 生产环境的消息
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// 开发环境的消息
        /// </summary>
        public string DevelopmentMessage { get; set; }
    }
}
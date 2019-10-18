using System;
using System.Threading.Tasks;
using Hollysys.Common;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace iODS.WebApiService.Controllers
{
    /// <summary>
    /// 作者：牛文杰
    /// 创始时间：2018年10月8日16点06分
    /// 描述：生产报警WebAPI接口
    /// </summary>
    [Produces("application/json")]
    [ApiController]
    [Route("iODS/AlarmConfig")]
    public class AlarmConfigController : Controller
    {
        /// <summary>
        /// 生产报警发声查询
        /// </summary>
        /// <returns></returns>
        [HttpGet("QueryAlarmVoice/{personCode}")]
        [ProducesResponseType(typeof(ResultMessage<string>),StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> QueryAlarmVoice([FromRoute] string personCode)
        {
            if (string.IsNullOrEmpty(personCode))
            {
                var aa = new ResultMessage<string>
                {
                        IsSuccess  = false,
                        Message    = "此参数不能为空",
                        StatusCode = StatusCodes.Status400BadRequest,
                        Data       = string.Empty
                };
                return this.BadRequest(aa);
            }

            return this.Ok();
        }

        /// <summary>
        /// 报警灯状态查询
        /// </summary>
        /// <returns></returns>
        [HttpGet("QueryAlarmLight/{personCode}")]
        public async Task<IActionResult> QueryAlarmLight([FromRoute] string personCode)
        {
            throw new NotImplementedException(nameof(this.QueryAlarmVoice));
        }

        /// <summary>
        /// 查询报警发声开关
        /// </summary>
        /// <returns></returns>
        [HttpGet("QueryUserConfig/{personCode}")]
        public async Task<IActionResult> QueryUserConfig([FromRoute] string personCode)
        {
            throw new NotImplementedException(nameof(this.QueryAlarmVoice));
        }

        /// <summary>
        /// 设置报警发声开关
        /// </summary>
        /// <returns></returns>
        [HttpGet("SetAlarmVoiceOff/{personCode}/{alarmVoiceOff}")]
        public async Task<IActionResult> SetAlarmVoiceOff([FromRoute] string personCode,
                                                           string alarmVoiceOff)
        {
            throw new NotImplementedException(nameof(this.QueryAlarmVoice));
        }

        /// <summary>
        /// 设置报警灯时间
        /// </summary>
        /// <returns></returns>
        [HttpGet("SetAlarmLightTime/{personCode}/{alarmVoiceOff}")]
        public async Task<IActionResult> SetAlarmLightTime([FromRoute] string personCode,
                                                           string alarmLightTime)
        {
            var result = new ResultMessage<object>();
            if (string.IsNullOrEmpty(personCode))
            {
                result.IsSuccess = false;
                result.Message = nameof(personCode) + "不能为空";
                result.Data = null;
                return this.BadRequest(result);
            }
            if (string.IsNullOrEmpty(alarmLightTime))
            {
                result.IsSuccess = false;
                result.Message   = nameof(alarmLightTime) + "不能为空";
                result.Data      = null;
                return this.BadRequest(result);
            }

            result.IsSuccess = true;
            result.Message = "成功";
            result.Data = new object();
                    
                    
            return this.Ok(result);
            

        }
    }
}
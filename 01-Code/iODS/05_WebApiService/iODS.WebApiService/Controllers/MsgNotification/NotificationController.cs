using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace iODS.WebApiService.Controllers
{
    [ApiController]
    [Route("iODS/[controller]/[action]")]
    public class NotificationController : Microsoft.AspNetCore.Mvc.Controller
    {
        ///***************************
        /// <param name="model">消息通知推送</param>
        /// <returns></returns>
        [HttpGet]
        //[Route("SM_MessageInfo/MessagePush")]
        public async Task<IActionResult> MeetingPush([FromRoute]SM_MessageInfoPush model)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 推送消息通知
        /// </summary>
        private void PushMessageInfoProxy(List<string> recPersons, string Content)
        {
            
        }
    }

    public class SM_MessageInfoPush
    {
        public string personCode { get; set; }
        public string msgContent { get; set; }
    }
}

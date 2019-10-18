using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace iODS.WebApiService.Controllers
{
    [ApiController]
    [Route("iODS/[controller]/[action]")]
    public class MsgShowController : Controller
    {
        /// <summary>
        /// 获取指定条件的分页数据 
        /// </summary>
        /// <param name="query">查询数据类</param>
        /// <returns></returns>
        [HttpGet]
        //[Route("MsgShowController/Query")]
        public async Task<IActionResult> Query([FromRoute]dynamic query)
        {
            throw  new NotImplementedException();
        }

        [HttpGet]
        //[NeedCheckUserMark]
        //[Route("MsgShowController/QueryNoReadMsgCount")]
        public async Task<IActionResult> QueryNoReadMsgCount([FromRoute]string personCode)
        {
            throw  new NotImplementedException();
        }

        /// <summary>
        /// 设置已读状态
        /// </summary>
        /// <param name="ids">ID编号值列表</param>
        /// <returns></returns>
        [HttpPut]
        //[Route("MsgShowController/ReadedForId")]
        //[WriteLog(EComLib_ActionEnum.其他, "消息通知中将消息置为已读")]
        public async Task<IActionResult> ReadedForId([FromBody]string ids)
        {
            throw  new NotImplementedException();
        }

        /// <summary>
        /// 普通用户删除操作--有DelFlag的表都是假删除
        /// </summary>
        /// <param name="ids">ID编号值列表</param>
        /// <returns></returns>
        [HttpDelete]
        //[Route("MsgShowController/DeleteForID")]
        //[WriteLog(EComLib_ActionEnum.删除, "消息通知中删除消息")]
        public async Task<IActionResult> DeleteForID([FromBody]string ids)
        {
            throw  new NotImplementedException();
        }

        /// <summary>
        /// System 用户调用----主表与子表都是真删除
        /// </summary>
        /// <param name="delModel">ID编号值列表</param>
        /// <returns></returns>
        [HttpDelete]
        //[Route("MsgShowController/AdminDeleteForID")]
        //[WriteLog(EComLib_ActionEnum.删除, "消息通知中删除消息")]
        public async Task<IActionResult> AdminDeleteForID([FromBody]AdminDelMsgModel delModel)
        {
            throw  new NotImplementedException();
        }
    }

    public class AdminDelMsgModel
    {
        public string mainPIDs { get; set; }
        public string childIDs { get; set; }
    }
}

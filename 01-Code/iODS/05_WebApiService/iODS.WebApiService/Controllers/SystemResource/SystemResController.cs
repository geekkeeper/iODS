using System;
using System.Collections.Generic;
using iODS.Model;
using Microsoft.AspNetCore.Mvc;

namespace iODS.WebApiService.Controllers
{
    [ApiController]
    [Route("iODS/[controller]/[action]")]
    public class SystemResController : Controller
    {

        /// <summary>
        /// 系统资源管理加载所有树节点
        /// </summary>
        /// <param name="strPersonCode"></param>
        /// <returns></returns>
        [HttpPost]
//        [Route("SystemRes/GetSystemResAllList")]
        public List<SystemResource> GetSystemResAllList([FromBody]string strPersonCode)
        {
            throw new NotImplementedException();
        }



        /// <summary>
        /// 刷新父节点下所有子节点
        /// </summary>
        /// <param name="strSysPoweMethod"></param>
        /// <returns></returns>
        [HttpPost]
//        [Route("SystemRes/GetSystemResList")]
        public List<SystemResource> GetSystemResList([FromBody]string strSysPoweMethod)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 刷新单个节点
        /// </summary>
        /// <param name="strSysPoweMethod">节点Code</param>
        /// <returns>刷新的节点内容</returns>
        [HttpPost]
//        [Route("SystemRes/GetSystemResObj")]
        public SystemResource GetSystemResObj([FromBody]string strSysPoweMethod)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 系统资源管理加载某树节点下的表节点in 参数
        /// </summary>
        /// <param name="strSysPowerMethod"></param>
        /// <returns></returns>
        [HttpPost]
//        [Route("SystemRes/GetSysteResDtl")]
        public List<V_SM_SystemResourceDtl> GetSysteResDtl([FromBody] string strSysPowerMethod)
        {
            throw new NotImplementedException();
        }
    }
}

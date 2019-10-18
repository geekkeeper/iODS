using System;
using System.Threading.Tasks;
using iODS.WebApiService.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace iODS.WebApiService.Controllers
{
    /// <summary>
    /// 作者：牛文杰
    /// 创始时间：2018年10月8日16点06分
    /// 描述：项目架构树权限控制WebAPI接口
    /// </summary>
    /// 
    [ApiController]
    [Route("iODS/[controller]/[action]")]
    public class ProjectPowerController : Controller
    {

        /// <summary>
        /// 项目架构权限树查询
        /// </summary>
        /// <returns></returns>
        [HttpGet]
//        [Route("ProjectPowerController/GetProjectPowerTree")]
        [AllowAnonymous]
        public async Task<IActionResult> GetProjectPowerTree()
        {
            throw new  NotImplementedException();
        }



        /// <summary>
        /// 角色项目架构树权限保存
        /// </summary>
        /// <param name="powerData"></param>
        /// <returns></returns>
        [HttpPut]
//        [Route("ProjectPowerController/Authorise")]
        //[WriteLog(EComLib_ActionEnum.角色授权)]
        public async Task<IActionResult> Authorise(PowerData powerData)
        {
            throw new  NotImplementedException();
        }

        /// <summary>
        /// 用户项目架构树权限保存
        /// </summary>
        /// <param name="powerData"></param>
        /// <returns></returns>
        [HttpPut]
//        [Route("ProjectPowerController/PersonAuthorise")]
        //[WriteLog(EComLib_ActionEnum.用户授权)]
        public async Task<IActionResult> PersonAuthorise(PowerData powerData)
        {
            throw new  NotImplementedException();
        }

        /// <summary>
        /// 角色复制
        /// </summary>
        /// <returns></returns>
        [HttpGet]
//        [Route("ProjectPowerController/CopyRole")]
        //[WriteLog(EComLib_ActionEnum.复制)]
        public async Task<IActionResult> CopyRole(string strSrcRoleCode, string strDstRoleName)
        {
            throw new  NotImplementedException();
        }
    }
}

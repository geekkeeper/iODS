using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using iODS.WebApiService.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace iODS.WebApiService.Controllers
{
    [ApiController]
    [Route("iODS/[controller]/[action]")]
    public class PermissionController : Controller
    {
        [HttpGet("{deptPcode}")]
        //[Route("Permission/GetPersonByDeptCode")]
        // ReSharper disable once IdentifierTypo
        public async Task<IActionResult> GetPersonByDeptCode([FromRoute] string deptPcode, string personCode, int curPage,
                                                       int pageSum, string condition, string draw)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///     权限
        /// </summary>
        /// <param name="personCode"></param>
        /// <returns></returns>
        [HttpGet("{personCode}")]
        //[Route("Permission/GetPermissionAll")]
        public Main_info GetPermissionAll([FromRoute] string personCode)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///     权限
        /// </summary>
        /// <param name="personCode"></param>
        /// <returns></returns>
        [HttpGet("{personCode}")]
        //[Route("Permission/GetPermissionAll")]
        public Main_info GetPermissionAll_NoUse([FromRoute] string personCode)
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        //[Route("Permission/GetMainMenu")]
        public async Task<IActionResult> GetMainMenu(string personCode)
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        //[Route("Permission/GetTreeMenu")]
        public async Task<IActionResult> GetTreeMenu(string personCode, string mainMenuCode)
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        //[Route("Permission/GetTree")]
        public List<RecursiveTreeModel> GetTree([FromRoute] string personCode)
        {
            throw new NotImplementedException();
        }

        [HttpGet]
//        [Route("Permission/QueryMenu")]
        public async Task<IActionResult> QueryMenu([FromRoute] dynamic query)
        {
            throw new NotImplementedException();
        }

        [HttpPut]
//        [Route("Permission/Authorise")]
        public string Authorise(RoleData roleData)
        {
            throw new NotImplementedException();
        }


        /// <summary>
        ///     获取页面控件配置信息
        /// </summary>
        /// <param name="moduleCode"></param>
        /// <param name="personCode"></param>
        /// <returns></returns>
        [HttpGet]
//        /[Route("Permission/QueryPageConfig")]
        public string QueryPageConfig(string moduleCode, string personCode)
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        [AllowAnonymous]
//        [Route("Permission/UserSignOut")]
        //[WriteLog(EComLib_ActionEnum.登录注销, "退出登录")]
        public async Task<IActionResult> UserSignOut()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///     用户登录
        /// </summary>
        /// <param name="person"></param>
        /// <returns></returns>
        [HttpPost]
        [AllowAnonymous]
//        [Route("Permission/UserLogin")]
        //[WriteLog(EComLib_ActionEnum.登录注销, "登录")]
        public async Task<IActionResult> UserLogin(PersonInfo person)
        {
            throw new NotImplementedException();
        }


        [HttpPost]
        [AllowAnonymous]
//        [Route("Permission/ModifyPwd")]
        public async Task<IActionResult> ModifyPwd([FromBody] PersonInfo person)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///     获取服务器当前时间,httpget方式，可以匿名访问
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [AllowAnonymous]
//        [Route("Permission/GetSystemDateTime")]
        public async Task<IActionResult> GetSystemDateTime()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///     获取服务器心跳时间,可以匿名访问
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [AllowAnonymous]
//        [Route("Permission/GetSystemHeartBeat")]
        public async Task<IActionResult> GetSystemHeartBeat()
        {
            throw new NotImplementedException();
        }

        [HttpGet]
//        [Route("Permission/GetInitPassword")]
        public async Task<IActionResult> GetInitPassword()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///     演示登录功能使能查询
        /// </summary>
        /// <returns>string</returns>
        [HttpGet]
        [AllowAnonymous]
//        [Route("Permission/QueryDemoLoginEnable")]
        public async Task<IActionResult> QueryDemoLoginEnable()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///     演示登录
        /// </summary>
        /// <returns>string</returns>
        [HttpPost]
        [AllowAnonymous]
//        [Route("Permission/DemoLogin")]
        //[WriteLog(EComLib_ActionEnum.登录注销, "演示登录")]
        public async Task<IActionResult> DemoLogin()
        {
            throw new NotImplementedException();
        }
    }

    public class Tpp
    {
        public DateTime? upTime     { get; set; }
        public DateTime? UploadTime { get; set; }
    }

    public class TreeParam
    {
        public string moduleName { get; set; }
        public string personCode { get; set; }
        public string urlHost    { get; set; }
    }

    public class RoleData
    {
        public string roleDataPowerIDs { get; set; }
        public string roleDataPowers   { get; set; }
        public string roleSysPowerIDs  { get; set; }
        public string roleSysPowers    { get; set; }
        public string role             { get; set; }
    }

    public class PageConfig
    {
        public List<string> buttonHidden { get; set; }
        public List<string> queryHidden  { get; set; }
        public List<string> gridHidden   { get; set; }
    }
}
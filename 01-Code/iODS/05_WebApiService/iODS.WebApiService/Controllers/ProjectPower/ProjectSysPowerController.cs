using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using iODS.Model;
using iODS.WebApiService.Model;
using Microsoft.AspNetCore.Mvc;

namespace iODS.WebApiService.Controllers
{
    /// <summary>
    /// 作者：牛文杰
    /// 创始时间：2018年10月8日16点06分
    /// 描述：操作权限控制WebAPI接口
    /// </summary>
    /// 
    [ApiController]
    [Route("iODS/[controller]/[action]")]
    public class ProjectSysPowerController : Controller
    {

        /// <summary>
        /// 操作权限查询所有隐藏按钮
        /// </summary>
        /// <returns></returns>
        [HttpGet]
//        [Route("ProjectSysPowerController/GetAllProjectHiddenButton")]
        public List<ProjectPageButtonConfig> GetAllProjectHiddenButton([FromRoute]string personCode)
        {
            throw new  NotImplementedException();
        }

        /// <summary>
        /// 获取页面控件配置信息
        /// </summary>
        /// <param name="powerCode"></param>
        /// <param name="projectCode"></param>
        /// <param name="personCode"></param>
        /// <param name="itemCode"></param>
        /// <returns></returns>
        [HttpGet]
//        [Route("ProjectSysPowerController/QueryProjectHiddenButtonOfPowerCode")]
        public async Task<IActionResult> QueryProjectHiddenButtonOfPowerCode(string powerCode, string itemCode, string projectCode, string personCode)
        {
            throw new  NotImplementedException();
        }



        /// <summary>
        /// 用户操作权限查询组项显示内容
        /// </summary>
        /// <returns></returns>
        [HttpGet]
//        [Route("ProjectSysPowerController/GetPowerGroupHeader")]
        public async Task<IActionResult> GetPowerGroupHeader([FromRoute]string powerCode)
        {
            throw new  NotImplementedException();
        }

        /// <summary>
        /// 角色操作权限查询
        /// </summary>
        /// <returns></returns>
        [HttpGet]
//        [Route("ProjectSysPowerController/QueryRoleSysPower")]
        public async Task<IActionResult> QueryRoleSysPower([FromRoute]string roleCode)
        {
            throw new  NotImplementedException();
        }

        /// <summary>
        /// 用户操作权限查询
        /// </summary>
        /// <returns></returns>
        [HttpGet]
//        [Route("ProjectSysPowerController/QueryPersonSysPower")]
        public SysPowerModel QueryPersonSysPower([FromRoute]string personCode)
        {
            throw new  NotImplementedException();
        }

        /// <summary>
        /// 查询单个操作权限(趋势组-设置公共趋势权限）
        /// </summary>
        /// <returns></returns>
        [HttpGet]
//        [Route("ProjectSysPowerController/QuerySingleSysPower")]
        public bool QuerySingleSysPower([FromRoute]string personCode, string projectCode, string itemCode, int btnID)
        {
            throw new  NotImplementedException();
        }
    }

    public class GroupHeader
    {
        public string Group { get; set; }
        public List<ProjectPageButtonConfig> Buttons { get; set; }
        public List<ProjectPageButtonConfig> TButtons { get; set; }
        public List<ProjectPageButtonConfig> PButtons { get; set; }
    }
}

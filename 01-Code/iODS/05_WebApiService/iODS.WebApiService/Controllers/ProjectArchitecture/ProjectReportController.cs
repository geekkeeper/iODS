using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using iODS.WebApiService.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace iODS.WebApiService.Controllers
{
    /// <summary>
    /// 作者：牛文杰
    /// 创始时间：2018年10月8日16点06分
    /// 描述：报表模板WebAPI接口
    /// </summary>
    /// 
    [ApiController]
    [Route("iODS/[controller]/[action]")]
    public class ProjectReportController : Controller
    {

        /// <summary>
        /// 报表模板查询
        /// </summary>
        /// <returns></returns>
        [HttpGet]
//        [Route("ProjectReportController/Query")]
        public async Task<IActionResult> Query([FromRoute]string strProjectCode, int iCurPage, int iPageRowNum, string sWhere, string draw)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 加载报表模板归属工程列表
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [AllowAnonymous]
//        [Route("ProjectReportController/GetReportTempletOwnList")]
        public List<ProjectOwnTreeModel> GetReportTempletOwnList()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 加载报表模板
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [AllowAnonymous]
//        [Route("ProjectReportController/QueryReportTempletList")]
        public async Task<IActionResult> QueryReportTempletList([FromRoute] QueryProjectItemModel obj)
        {
            throw new NotImplementedException();
        }
    }
}

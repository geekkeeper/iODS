using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace iODS.WebApiService.Controllers
{
    /// <summary>
    /// 作者：牛文杰
    /// 创始时间：2018年10月8日16点06分
    /// 描述：高级报表WebAPI接口
    /// </summary>
    [ApiController]
    [Route("iODS/[controller]/[action]")]
    public class SuperReportController : Controller
    {

        /// <summary>
        /// 加载所有项目架构高级报表树节点
        /// </summary>
        /// <returns></returns>
        [HttpGet]
//        [Route("SuperReportController/GetSuperReportProjectTree")]
        public async Task<IActionResult> GetSuperReportProjectTree()
        {
           throw new NotImplementedException();
        }
    }
}

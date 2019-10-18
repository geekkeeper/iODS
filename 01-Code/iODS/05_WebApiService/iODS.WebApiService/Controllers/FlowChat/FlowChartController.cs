using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace iODS.WebApiService.Controllers
{
    /// <summary>
    /// 作者：牛文杰
    /// 创始时间：2018年10月8日16点06分
    /// 描述：流程图WebAPI接口
    /// </summary>
    [ApiController]
    [Route("iODS/[controller]/[action]")]
    public class FlowChartController : Controller
    {
        /// <summary>
        /// 加载所有项目架构趋势树节点
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        //[Route("FlowChartController/GetFlowChartProjectTree")]
        public async Task<IActionResult> GetFlowChartProjectTree()
        {
           throw  new NotImplementedException();
        }
    }
}

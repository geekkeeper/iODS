using System;
using System.Threading.Tasks;
using iODS.WebApiService.Model;
using Microsoft.AspNetCore.Mvc;

namespace iODS.WebApiService.Controllers
{
    /// <summary>
    /// 作者：牛文杰
    /// 创始时间：2018年10月8日16点06分
    /// 描述：抑制报警WebAPI接口
    /// </summary>
    [ApiController]
    [Route("iODS/[controller]/[action]")]
    public class ForbidAlarmController : Controller
    {

        /// <summary>
        /// 报警抑制查询
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        //[Route("ForbidAlarmController/Query")]
        public async Task<IActionResult> Query([FromRoute]AlramSearchModel searchModel)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 取消生产报警抑制
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        //[Route("ForbidAlarmController/CancelForbid")]
        public async Task<IActionResult> CancelForbid([FromBody]string ids)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 取消整个项目结构树报警抑制
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        //[Route("ForbidAlarmController/CancelForbidByProject")]
        public async Task<IActionResult> CancelForbidByProject([FromBody]string strProjectCode)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 抑制报警筛选查询
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        //[Route("ForbidAlarmController/FilterQuery")]
        public async Task<IActionResult> FilterQuery([FromRoute]FilterQueryModel filterQueryModel)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 报警抑制设置
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        //[Route("ForbidAlarmController/ForbidConfig")]
        public async Task<IActionResult> ForbidConfig([FromBody]string strAlarmConfigModel)
        {
            throw new NotImplementedException();
        }
    }
}

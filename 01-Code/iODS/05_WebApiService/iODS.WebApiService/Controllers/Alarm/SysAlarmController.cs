using System;
using System.Threading.Tasks;
using iODS.WebApiService.Model;
using Microsoft.AspNetCore.Mvc;

namespace iODS.WebApiService.Controllers
{
    /// <summary>
    /// 作者：牛文杰
    /// 创始时间：2018年10月8日16点06分
    /// 描述：系统报警查询WebAPI接口
    /// </summary>
    /// 
    [ApiController]
    [Route("iODS/[controller]/[action]")]
    public class SysAlarmController : Controller
    {

        /// <summary>
        /// 系统报警查询
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        //[Route("SysAlarmController/Query")]
        public async Task<IActionResult> Query([FromRoute]AlramSearchModel searchModel)
        {

            throw new NotImplementedException();
        }

        /// <summary>
        /// 系统报警确认
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        //[Route("SysAlarmController/Confirm")]
        public async Task<IActionResult> Confirm([FromBody]ConfirmManyModel oManyModel)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 确认全部报警
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        //[Route("SysAlarmController/ConfirmAll")]
        public async Task<IActionResult> ConfirmAll([FromBody] string strMark)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 系统报警筛选查询
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        //[Route("SysAlarmController/FilterQuery")]
        public async Task<IActionResult> FilterQuery([FromRoute]FilterQueryModel filterQueryModel)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 获取指定条件的分页数据 
        /// </summary>
        /// <param name="model">查询数据类</param>
        /// <returns></returns>
        [HttpGet]
        //[Route("SysAlarm/QueryHis")]
        public async Task<IActionResult> QueryHis([FromRoute]dynamic model)
        {
            throw new NotImplementedException();
        }

    }
}

using System;
using System.Threading.Tasks;
using iODS.WebApiService.Model;
using Microsoft.AspNetCore.Mvc;

namespace iODS.WebApiService.Controllers
{
    /// <summary>
    /// 作者：牛文杰
    /// 创始时间：2018年10月8日16点06分
    /// 描述：隐藏报警WebAPI接口
    /// </summary>
    [ApiController]
    [Route("iODS/[controller]/[action]")]
    public class HideAlarmController : Controller
    {

        /// <summary>
        /// 隐藏报警查询
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        //[Route("HideAlarmController/Query")]
        public async Task<IActionResult> Query([FromRoute]AlramSearchModel searchModel)//string strProjectCode, int iCurPage, int iPageRowNum, string sWhere, string sOrder, string draw)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 取消生产报警隐藏
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        //[Route("HideAlarmController/CancelHide")]
        public async Task<IActionResult> CancelHide([FromBody]string ids)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 取消整个项目架构树报警隐藏
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        //[Route("HideAlarmController/CancelHideByProject")]
        public async Task<IActionResult> CancelHideByProject([FromBody]string strProjectCode)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 隐藏报警筛选查询
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        //[Route("HideAlarmController/FilterQuery")]
        public async Task<IActionResult> FilterQuery([FromRoute]FilterQueryModel filterQueryModel)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 隐藏设置标签查询
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        //[Route("HideAlarmController/TagQuery")]
        public async Task<IActionResult> TagQuery([FromRoute]AlramSearchModel searchModel)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 报警隐藏设置
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        //[Route("HideAlarmController/HideConfig")]
        public async Task<IActionResult> HideConfig([FromBody]string strAlarmConfigModel)
        {
            throw new NotImplementedException();
        }
    }
}

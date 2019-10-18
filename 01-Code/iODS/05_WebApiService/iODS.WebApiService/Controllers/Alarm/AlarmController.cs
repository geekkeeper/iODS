using System;
using System.Threading.Tasks;
using iODS.WebApiService.Model;
using Microsoft.AspNetCore.Mvc;

namespace iODS.WebApiService.Controllers
{
    /// <summary>
    /// 作者：牛文杰
    /// 创始时间：2018年10月8日16点06分
    /// 描述：生产报警WebAPI接口
    /// </summary>
    [ApiController]
    [Route("iODS/[controller]/[action]")]
    public class AlarmController : Controller
    {
        /// <summary>
        /// 报警项目架构树查询
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        //[Route("AlarmController/GetProjectTree")]
        public async Task<IActionResult> GetProjectTree()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 生产报警查询
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        //[Route("AlarmController/Query")]
        public async Task<IActionResult> Query([FromRoute] AlramSearchModel searchModel)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 查询方法
        /// </summary>
        /// <returns></returns>
        private async Task<IActionResult> PageQuery(AlramSearchModel searchModel, bool bRefresh)
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        //[Route("AlarmController/Refresh")]
        public async Task<IActionResult> Refresh([FromRoute]AlramSearchModel searchModel)
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// 其它页的固定项刷新接口
        /// </summary>
        /// <returns></returns>
        private async Task<IActionResult> NoFirstPageRefresh(AlramSearchModel searchModel)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 生产报警筛选查询
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        //[Route("AlarmController/FilterQuery")]
        public async Task<IActionResult> FilterQuery([FromRoute]FilterQueryModel filterQueryModel)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 生产报警抑制
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        //[Route("AlarmController/Forbid")]
        public async Task<IActionResult> Forbid([FromBody]string ids)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 抑制整个项目架构树分厂的生产报警
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        //[Route("AlarmController/ForbidByProject")]
        public async Task<IActionResult> ForbidByProject([FromBody]string strProjectCode)
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// 生产报警隐藏
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        //[Route("AlarmController/Hide")]
        public async Task<IActionResult> Hide([FromBody]string ids)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 隐藏整个项目架构树分厂的生产报警
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        //[Route("AlarmController/HideByProject")]
        public async Task<IActionResult> HideByProject([FromBody]string strProjectCode)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 生产报警确认
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        //[Route("AlarmController/Confirm")]
        public async Task<IActionResult> Confirm([FromBody]ConfirmManyModel oManyModel)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 确认整个项目架构树分厂的生产报警
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        //[Route("AlarmController/ConfirmByProject")]
        public async Task<IActionResult> ConfirmByProject([FromBody]ConfirmProjectModel oProjectModel)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 确认全部报警
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        //[Route("AlarmController/ConfirmAll")]
        public async Task<IActionResult> ConfirmAll([FromBody] string strMark)
        {
            throw new NotImplementedException();
        }
    }
}

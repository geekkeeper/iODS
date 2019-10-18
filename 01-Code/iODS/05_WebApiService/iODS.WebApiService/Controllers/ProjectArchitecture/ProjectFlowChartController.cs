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
    /// 描述：项目架构挂接流程图WebAPI接口
    /// </summary>
    /// 
    [ApiController]
    [Route("iODS/[controller]/[action]")]
    public class ProjectFlowChartController : Controller
    {
        /// <summary>
        /// 增加数据
        /// </summary>
        /// <param name="addList">表实体的json数组</param>
        /// <returns></returns>
        [HttpPost]
//        [Route("ProjectFlowChartController/AddList")]
        //[WriteLog(EComLib_ActionEnum.新增)]
        public async Task<IActionResult> AddList([FromBody]string addList)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 删除操作（根据多个ID字段值，从指定表中删除数据）
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        [HttpDelete]
//        [Route("ProjectFlowChartController/DeleteForID")]
        //[WriteLog(EComLib_ActionEnum.删除)]
        public async Task<IActionResult> DeleteForID([FromBody]string ids)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 流程图查询
        /// </summary>
        /// <returns></returns>
        [HttpGet]
//        [Route("ProjectFlowChartController/Query")]
        public async Task<IActionResult> Query([FromRoute]string strProjectCode, int iCurPage, int iPageRowNum, string sWhere, string draw)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 加载流程图归属工程列表
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [AllowAnonymous]
//        [Route("ProjectFlowChartController/GetFlowChartOwnList")]
        public async Task<IActionResult> GetFlowChartOwnList()
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        [AllowAnonymous]
//        [Route("ProjectFlowChartController/QueryFlowChartList")]
        public async Task<IActionResult> QueryFlowChartList([FromRoute] QueryProjectItemModel obj)
        {
            throw new NotImplementedException();
        }
    }
}

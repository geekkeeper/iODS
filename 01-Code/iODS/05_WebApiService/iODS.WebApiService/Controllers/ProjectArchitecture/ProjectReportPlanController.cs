using System;
using System.Threading.Tasks;
using iODS.WebApiService.Model;
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
    public class ProjectReportPlanController : Controller
    {
        /// <summary>
        /// 报表计划查询
        /// </summary>
        /// <returns></returns>
        [HttpGet]
//        [Route("ProjectReportPlanController/Query")]
        public async Task<IActionResult> Query([FromRoute] string strProjectCode, int iCurPage, int iPageRowNum,
                                         string sWhere, string draw)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 增加数据
        /// </summary>
        /// <param name="addReportPlanMode">表实体的json数组</param>
        /// <returns></returns>
        [HttpPost]
//        [Route("ProjectReportPlanController/AddList")]
        //[WriteLog(EComLib_ActionEnum.新增)]
        public async Task<IActionResult> AddList([FromBody] AddReportPlanModel addReportPlanMode)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 删除操作（根据多个ID字段值，从指定表中删除数据）
        /// </summary>
        /// <param name="ids">ID编号值列表</param>
        /// <returns></returns>
        [HttpDelete]
//        [Route("ProjectReportPlanController/DeleteForID")]
        //[WriteLog(EComLib_ActionEnum.删除)]
        public async Task<IActionResult> DeleteForID([FromBody] string ids)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 已经填加的报表计划ID查询
        /// </summary>
        /// <returns></returns>
        [HttpGet]
//        [Route("ProjectReportPlanController/QueryExistReportPlan")]
        public async Task<IActionResult> QueryExistReportPlan()
        {
            throw new NotImplementedException();
        }
    }
}
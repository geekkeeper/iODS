using System;
using System.Threading.Tasks;
using iODS.Model;
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
    public class ProjectSuperReportController : Controller
    {
        /// <summary>
        /// 高级报表查询
        /// </summary>
        /// <returns></returns>
        [HttpGet]
//        [Route("ProjectSuperReportController/Query")]
        public async Task<IActionResult> Query([FromRoute] string strProjectCode, int iCurPage, int iPageRowNum,
                                         string sWhere, string draw)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 增加数据
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
//        [Route("ProjectSuperReportController/Add")]
        //[WriteLog(EComLib_ActionEnum.新增)]
        public async Task<IActionResult> Add([FromBody] ProjectSuperReport model)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 删除操作（根据多个ID字段值，从指定表中删除数据）
        /// </summary>
        /// <param name="ids">ID编号值列表</param>
        /// <returns></returns>
        [HttpDelete]
//        [Route("ProjectSuperReportController/DeleteForID")]
        //[WriteLog(EComLib_ActionEnum.删除)]
        public async Task<IActionResult> DeleteForID([FromBody] string ids)
        {
            throw new NotImplementedException();
        }
    }
}
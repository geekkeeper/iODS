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
    public class ProjectVideoController : Controller
    {
        
        /// <summary>
        /// 查询视频设备信息（设备类型，帐户信息）
        /// </summary>
        /// <returns>VideoDevInfo</returns>
        [HttpGet]
//        [Route("ProjectVideoController/GetDevInfo")]
        public async Task<IActionResult> GetDevInfo()
        {
            throw new  NotImplementedException();
        }

        /// <summary>
        /// 视频查询
        /// </summary>
        /// <returns></returns>
        [HttpGet]
//        [Route("ProjectVideoController/Query")]
        public async Task<IActionResult> Query([FromRoute]string strProjectCode, int iCurPage, int iPageRowNum, string sWhere, string draw)
        {
            throw new  NotImplementedException();
        }

        /// <summary>
        /// 增加数据
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
//        [Route("ProjectVideoController/Add")]
        //[WriteLog(EComLib_ActionEnum.新增)]
        public async Task<IActionResult> Add([FromBody]ProjectVideo model)
        {
            throw new  NotImplementedException();
        }

        /// <summary>
        /// 删除操作（根据多个ID字段值，从指定表中删除数据）
        /// </summary>
        /// <param name="ids">ID编号值列表</param>
        /// <returns></returns>
        [HttpDelete]
//        [Route("ProjectVideoController/DeleteForID")]
        //[WriteLog(EComLib_ActionEnum.删除)]
        public async Task<IActionResult> DeleteForID([FromBody]string ids)
        {
            throw new  NotImplementedException();
        }
    }
}

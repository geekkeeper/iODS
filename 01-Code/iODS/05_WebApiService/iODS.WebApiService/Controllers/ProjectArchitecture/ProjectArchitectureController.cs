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
    public class ProjectArchitectureController : Controller
    {
        /// <summary>
        /// 项目架构树添加
        /// </summary>
        /// <returns></returns>
        [HttpPost]
//        [Route("ProjectArchitectureController/Add")]
        //[WriteLog(EComLib_ActionEnum.新增)]
        public async Task<IActionResult> Add([FromBody]ProjectArchitecture model)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 点击项目架构树，根据code删除
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        [HttpDelete]
//        [Route("ProjectArchitectureController/DeleteTreeForID")]
        //[WriteLog(EComLib_ActionEnum.删除)]
        public async Task<IActionResult> DeleteTreeForID([FromBody]string ids)
        {
            throw new NotImplementedException();
        }
        
    }
}

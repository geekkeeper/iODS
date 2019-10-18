using System;
using System.Threading.Tasks;
using iODS.WebApiService.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace iODS.WebApiService.Controllers
{
    /// <summary>
    /// 作者：牛文杰 创始时间：2018年10月8日16点06分 描述：标签WebAPI接口
    /// </summary>
    [ApiController]
    [Route("iODS/[controller]/[action]")]
    public class ProjectTagController : Controller
    {

        /// <summary>
        /// 增加Tag数据
        /// </summary>
        /// <returns></returns>
        [HttpPost]
//        [Route("ProjectTagController/AddTag")]
        //[WriteLog(EComLib_ActionEnum.新增)]
        public async Task<IActionResult> AddTag([FromBody] AddTagParam oParam)
        {
            throw new  NotImplementedException();
        }

        /// <summary>
        /// 删除标签
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        [HttpDelete]
//        [Route("ProjectTagController/DeleteTagForId")]
        //[WriteLog(EComLib_ActionEnum.删除)]
        public async Task<IActionResult> DeleteTagForId([FromBody] string ids)
        {
            throw new  NotImplementedException();
        }

        

        /// <summary>
        /// 导出标签
        /// </summary>
        [HttpGet]
//        [Route("ProjectTagController/Export")]
        [AllowAnonymous]
        //[WriteLog(EComLib_ActionEnum.导出)]
        public async Task<IActionResult> Export(string personCode)
        {
            throw new  NotImplementedException();
        }

        /// <summary>
        /// 加载标签归属工程树
        /// </summary>
        /// <returns></returns>
        [HttpGet]
//        [Route("ProjectTagController/GetTagOwnList")]
        public async Task<IActionResult> GetTagOwnList()
        {
            throw new  NotImplementedException();
        }

        /// <summary>
        /// 加载标签归属工程的PC名字
        /// </summary>
        /// <returns></returns>
        [HttpGet]
//        [Route("ProjectTagController/GetTagOwnPC")]
        public async Task<IActionResult> GetTagOwnPc([FromRoute] QueryProjectItemModel obj)
        {
            throw new  NotImplementedException();
        }

        /// <summary>
        /// 导入标签
        /// </summary>
        [HttpPost]
//        [Route("ProjectTagController/Import")]
        //[WriteLog(EComLib_ActionEnum.导入)]
        public async Task<IActionResult> Import()
        {
            throw new  NotImplementedException();
        }

        /// <summary>
        ///     标签查询
        /// </summary>
        /// <returns></returns>
        [HttpGet]
//        [Route("ProjectTagController/Query")]
        public async Task<IActionResult> Query([FromRoute] ProjectTagSearchModel searchModel)
        {
            throw new  NotImplementedException();
        }
        /// <summary>
        /// 查询特殊标签
        /// </summary>
        /// <returns></returns>
        [HttpGet]
//        [Route("ProjectTagController/QuerySPECTagList")]
        public async Task<IActionResult> QuerySpecTagList([FromRoute] QueryProjectItemModel obj)
        {
            throw new  NotImplementedException();
        }

        /// <summary>
        /// 查询实时库标签集合
        /// </summary>
        /// <returns></returns>
        [HttpGet]
//        [Route("ProjectTagController/QueryTagList")]
        public async Task<IActionResult> QueryTagList([FromRoute] ProjectTagSearchModel searchModel)
        {
            throw new  NotImplementedException();
        }
    }
    /// <summary>
    /// 趋势组标签
    /// </summary>
    internal class TrendGroupTag
    {
        /// <summary>
        /// 工程编码
        /// </summary>
        public string ProjectCode { set; get; }
        /// <summary>
        /// 标签名称
        /// </summary>
        public string TagName { set; get; }
    }
}
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using iODS.Model;
using iODS.WebApiService.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace iODS.WebApiService.Controllers
{
    /// <summary>
    /// 作者：刘晓凤
    /// 创始时间：2018年10月8日16点06分
    /// 描述：历史趋势，实时趋势
    /// </summary>
    [ApiController]
    [Route("iODS/[controller]/[action]")]
    public class TrendController : Controller
    {
        /// <summary>
        /// 增加数据
        /// </summary>
        /// <param name="model">表实体的json数组</param>
        /// <returns></returns>
        [HttpPost]
//        [Route("Trend/Add")]
        //[WriteLog(EComLib_ActionEnum.新增, strOperateRoute: "PM_Trend")]
        public async Task<IActionResult> Add([FromBody]TrendGroup model)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 获取趋势组类型
        /// </summary>
        /// <returns></returns>
        [HttpGet]
//        [Route("Trend/GetTrendGroupType")]
        public async Task<IActionResult> GetTrendGroupType(string personCode)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 实时趋势
        /// </summary>
        /// <param name="strTagNames">标签名字串</param>
        /// <param name="pixels">像素</param>
        /// <param name="isFirst">是否第一次查询，第一次查询查的是历史趋势，非第一次查询查的是实时趋势</param>
        /// <param name="minutes">间隔分钟</param>
        /// <returns></returns>
        [HttpGet]
        [AllowAnonymous]
//        [Route("Trend/GetRealTimeTrend")]
        public async Task<IActionResult> GetRealTimeTrend([FromRoute]string strTagNames, int pixels, int isFirst, int minutes)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 历史趋势查询
        /// </summary>
        /// <param name="strTagNames">标签名字串</param>
        /// <param name="pixels">像素</param>
        /// <param name="bTime">开始时间</param>
        /// <param name="eTime">结束时间</param>
        /// <returns></returns>
        [HttpGet]
        [AllowAnonymous]
//        [Route("Trend/GetHistoryTrend")]
        public async Task<IActionResult> GetHistoryTrend([FromRoute]string strTagNames, int pixels, DateTime bTime, DateTime eTime)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 加载所有项目架构趋势树节点
        /// </summary>
        /// <param name="personCode"></param>
        /// <returns></returns>
        [HttpGet]
//        [Route("Trend/GetProjectTrendTreeList")]
        public List<TrendTreeModel> GetProjectTrendTreeList(string personCode)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 根据项目架构树code获取标签点列表
        /// </summary>
        /// <param name="projectCode">项目架构编码</param>
        /// <param name="trendGroupID">趋势组id</param>
        /// <param name="tagName">标签名</param>
        /// <param name="iCurPage">当前页码</param>
        /// <param name="iPageRowNum">每页显示条数</param>
        /// <returns></returns>
        [HttpGet]
//        [Route("Trend/GetTagListByProjectCode")]
        public async Task<IActionResult> GetTagListByProjectCode(string projectCode, string trendGroupID, string tagName, int iCurPage, int iPageRowNum)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 获取项目架构树
        /// </summary>
        /// <param name="personAccount"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        [HttpGet]
//        [Route("Trend/GetProjectTree")]
        public List<TrendTreeModel> GetProjectTree(string personAccount = "")
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 获取指定条件的分页数据 
        /// </summary>
        /// <param name="query">查询数据类</param>
        /// <returns></returns>
        [HttpGet]
//        [Route("Trend/Query")]
        public async Task<IActionResult> Query([FromRoute]dynamic query)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 假删除操作（根据多个ID字段值，修改strDelFlag字段为1）
        /// </summary>
        /// <param name="ids">ID编号值列表</param>
        /// <returns></returns>
        [HttpDelete("{ids}")]
//        [Route("Trend/DeleteForIDFalse_StrDelFlag")]
        //[WriteLog(EComLib_ActionEnum.删除, strOperateRoute: "PM_Trend")]
        public async Task<IActionResult> DeleteForIDFalse_StrDelFlag([FromBody]string ids)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 假删除操作（根据多个ID字段值，修改strDelFlag字段为1）
        /// </summary>
        /// <param name="ids">ID编号值列表</param>
        /// <returns></returns>
        [HttpDelete("{ids}")]
//        [Route("Trend/DeleteForID")]
        //[WriteLog(EComLib_ActionEnum.删除, strOperateRoute: "PM_Trend")]
        public async Task<IActionResult> DeleteForID([FromBody]string ids)
        {
            throw new NotImplementedException();
        }


    }
}

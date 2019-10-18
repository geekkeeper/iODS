using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using iODS.Model;
using iODS.WebApiService.Model;
using Microsoft.AspNetCore.Mvc;

namespace iODS.WebApiService.Controllers
{
    /// <summary>
    /// 作者：刘晓凤
    /// 创始时间：2018年10月30日10点49分
    /// 描述：GIS地图组态和管理
    /// </summary>
    [ApiController]
    [Route("iODS/[controller]/[action]")]
    public class GISController : Controller
    {
        /// <summary>
        /// 加载所有项目架构树节点
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        //[Route("GIS/GetProjectTreeList")]
        public List<ProjectArchitecture> GetProjectTreeList()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 根据叶子节点项目架构编码获取对应的GIS组态和标签点的报警级、状态、值
        /// </summary>
        /// <param name="strProjectCode"></param>
        /// <param name="isNeedAlarm"></param>
        /// <param name="iCurPage"></param>
        /// <param name="iPageRowNum"></param>
        /// <returns></returns>
        [HttpGet]
        //[Route("GIS/GetGisDetailByProjectCode")]
        public async Task<IActionResult> GetGisDetailByProjectCode(string strProjectCode, int isNeedAlarm, int iCurPage, int iPageRowNum)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 根据项目架构编码获取子节点的GIS组态集合
        /// </summary>
        /// <param name="strPersonAccount"></param>
        /// <param name="strProjectCode"></param>
        /// <param name="IsNeedAlarm"></param>
        /// <returns></returns>
        [HttpGet]
        //[Route("GIS/GetAllGisListByProjectCode")]
        public List<SM_ProjectGISViewModel> GetAllGisListByProjectCode(string strPersonAccount, string strProjectCode, int IsNeedAlarm)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 根据项目架构编码串获取其对应的GIS绑定标签的报警集合
        /// </summary>
        /// <returns></returns>
        private List<SM_ProjectGISViewModel> GetAlarmGisTagList()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 增加数据
        /// </summary>
        /// <param name="model">表实体的json数组</param>
        /// <returns></returns>
        [HttpPost]
        //[Route("GIS/Add")]
        //[WriteLog(EComLib_ActionEnum.新增)]
        public async Task<IActionResult> Add([FromBody]ProjectGIS model)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 根据项目架构树code获取标签点列表
        /// </summary>
        /// <param name="projectCode"></param>
        /// <param name="tagName"></param>
        /// <param name="iCurPage"></param>
        /// <param name="iPageRowNum"></param>
        /// <returns></returns>
        [HttpGet]
        //[Route("Gis/GetNoCheckTagListByProjectCode")]
        public async Task<IActionResult> GetNoCheckTagListByProjectCode(string projectCode, string tagName, int iCurPage, int iPageRowNum)
        {
            throw new NotImplementedException();
        }
    }
}

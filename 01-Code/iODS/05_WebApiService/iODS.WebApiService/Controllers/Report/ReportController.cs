using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using iODS.Model;
using iODS.WebApiService.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace iODS.WebApiService.Controllers
{
    [ApiController]
    [Route("iODS/[controller]/[action]")]
    public class ReportController : Controller
    {
       

        /// <summary>
        /// 获取工程组态报表服务树列表
        /// </summary>
        /// <returns></returns>
        [HttpGet]
//        [Route("Report/GetProjectReportServiceTree")]
        public async Task<IActionResult> GetProjectReportServiceTree()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 根据工程的guid获取报表模板列表
        /// </summary>
        /// <param name="strGTGuid"></param>
        /// <returns></returns>
        [HttpGet]
//        [Route("Report/GetReportTemplateByGTGuid")]
        public async Task<IActionResult> GetReportTemplateByGTGuid(string strGTGuid)
        {
            
            throw new NotImplementedException();
        }

        /// <summary>
        /// 获取指定条件的分页数据 
        /// </summary>
        /// <param name="query">查询数据类</param>
        /// <returns></returns>
        [HttpGet]
//        [Route("Report/Query")]
        public async Task<IActionResult> Query([FromRoute] dynamic query)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 增加数据
        /// </summary>
        /// <param name="model">表实体的json数组</param>
        /// <returns></returns>
        [HttpPost]
//        [Route("Report/Add")]
        //[WriteLog(EComLib_ActionEnum.新增)]
        public async Task<IActionResult> Add([FromBody]ReportPlan model)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 根据Id修改数据
        /// </summary>
        /// <param name="modelList">表实体的json数组</param>
        /// <returns></returns>
        [HttpPut]
//        [Route("Report/UpdateForId")]
        //[WriteLog(EComLib_ActionEnum.修改)]
        public async Task<IActionResult> UpdateForId([FromBody]string modelList)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 假删除操作（根据多个ID字段值，修改strDelFlag字段为1）
        /// </summary>
        /// <param name="ids">ID编号值列表</param>
        /// <returns></returns>
        [HttpDelete]
//        [Route("Report/DeleteForIDFalse_StrDelFlag")]
        //[WriteLog(EComLib_ActionEnum.删除)]
        public async Task<IActionResult> DeleteForIDFalse_StrDelFlag([FromBody]string ids)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 获取指定条件的分页数据 
        /// </summary>
        /// <param name="iCurPage"></param>
        /// <param name="iPageRowNum"></param>
        /// <param name="strPlanID"></param>
        /// <param name="strProjectCode"></param>
        /// <returns></returns>
        [HttpGet]
//        [Route("Report/QueryReportRecord")]
        public async Task<IActionResult> QueryReportRecord([FromRoute]int iCurPage,int iPageRowNum,string strPlanID,string strProjectCode)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 假删除操作（根据多个ID字段值，修改strDelFlag字段为1）
        /// </summary>
        /// <param name="recordID">ID编号值列表</param>
        /// <param name="planID"></param>
        /// <param name="strReportNameAndTime"></param>
        /// <param name="strGTName"></param>
        /// <param name="strReportServiceA"></param>
        /// <returns></returns>
        [HttpDelete]
//        [Route("Report/RecordDeleteForIDFalse_StrDelFlag")]
        //[WriteLog(EComLib_ActionEnum.删除)]
        public async Task<IActionResult> RecordDeleteForIDFalse_StrDelFlag([FromBody]string recordID, string planID, string strReportNameAndTime,string strGTName,string strReportServiceA)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 查看html报表文件,已经不用了
        /// </summary>
        /// <param name="account"></param>
        /// <param name="planID"></param>
        /// <param name="strReportNameAndTime"></param>
        /// <param name="strGTName"></param>
        /// <param name="strReportServiceA"></param>
        /// <returns></returns>
        [HttpGet]
//        [Route("Report/ReturnHtmlByReportOld")]
        //[WriteLog(EComLib_ActionEnum.查看)]
        public async Task<IActionResult> ReturnHtmlByReportOld(string account, string planID, string strReportNameAndTime, string strGTName, string strReportServiceA)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 下载报表文件
        /// </summary>
        /// <param name="account"></param>
        /// <param name="planID"></param>
        /// <param name="strReportNameAndTime"></param>
        /// <param name="strGTName"></param>
        /// <param name="strReportServiceA"></param>
        /// <returns></returns>
        [HttpGet]
        [AllowAnonymous]
        //[WriteLog(EComLib_ActionEnum.下载文件)]
//        [Route("Report/DownLoadReportFile")]
        public async Task<IActionResult> DownLoadReportFile(string account, string planID, string strReportNameAndTime, string strGTName, string strReportServiceA)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 加载所有项目架构报表计划树节点
        /// </summary>
        /// <returns></returns>
        [HttpGet]
//        [Route("Report/GetReportPlanTree")]
        public List<ReportTemplateProjectTreeModel> GetReportPlanTree()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 点击执行
        /// </summary>
        /// <param name="account"></param>
        /// <param name="planID"></param>
        /// <param name="strStartTime"></param>
        /// <param name="strEndTime"></param>
        /// <returns></returns>
        [HttpGet]
//        [Route("Report/ExecReportPlan")]
        //[WriteLog(EComLib_ActionEnum.执行)]
        public async Task<IActionResult> ExecReportPlan(string account, string planID, DateTime strStartTime, DateTime strEndTime)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 返回pdf文件
        /// </summary>
        /// <param name="account"></param>
        /// <param name="planID"></param>
        /// <param name="strReportNameAndTime"></param>
        /// <param name="strGTName"></param>
        /// <param name="strReportServiceA"></param>
        /// <returns></returns>
        [HttpGet]
//        [Route("Report/ReturnPdfByReport")]
        //[WriteLog(EComLib_ActionEnum.打印)]
        public async Task<IActionResult> ReturnPdfByReport(string account, string planID, string strReportNameAndTime, string strGTName, string strReportServiceA)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 有没有安装openoffice
        /// </summary>
        /// <returns></returns>
        private bool CheckOpenOffice()
        {
            Microsoft.Win32.RegistryKey uninstallNode = Microsoft.Win32.Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Uninstall");
            if (uninstallNode != null)
            {
                foreach (string subKeyName in uninstallNode.GetSubKeyNames())
                {
                    Microsoft.Win32.RegistryKey subKey      = uninstallNode.OpenSubKey(subKeyName);
                    object displayName = subKey?.GetValue("DisplayName");
                    if (displayName != null)
                    {
                        if (displayName.ToString().Contains("OpenOffice"))
                        {
                            return true;
                        }
                    }
                }
            }

            return false;
        }

        [HttpGet]
        [AllowAnonymous]
//        [Route("Report/TestReport")]
        public async Task<IActionResult> TestReport(string format)
        {
            throw new NotImplementedException();
        }


       
        [HttpGet]
//        [Route("Report/ExcelToHtml")]
        private void ExcelToHtml(string fileName)
        {
            throw new NotImplementedException();
        }

        [HttpGet]
//        [Route("Report/ReturnHtmlByReport")]
        //[WriteLog(EComLib_ActionEnum.查看)]
        public async Task<IActionResult> ReturnHtmlByReport(string account, string planID, string strReportNameAndTime, string strGTName, string strReportServiceA)
        {
            throw new NotImplementedException();
        }
    }

}

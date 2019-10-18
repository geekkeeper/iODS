using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace iODS.WebApiService.Controllers
{
    [ApiController]
    [Route("iODS/[controller]/[action]")]
    public class PersonController : Controller
    {
        /// <summary>
        /// 添加人员---主表增加，子表增加
        /// </summary>
        /// <param name="model">自定义类对象</param>
        /// <returns></returns>
        [HttpPost]
//        [Route("PersonController/Add")]
        public async Task<IActionResult> Add([FromBody] dynamic model)
        {
            throw new NotImplementedException();
        }

        [HttpGet]
//        [Route("PersonController/GetPersonByDepartCode")]
        public async Task<IActionResult> GetPersonByDepartCode([FromRoute] string deptPcode, string personCode, int curPage,
                                                         int pageSum, string condition, string draw)
        {
            throw new NotImplementedException();
        }

        [HttpPut]
//        [Route("PersonController/UpdatePerson")]
        public async Task<IActionResult> UpdatePerson([FromBody] string personList)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///     人员导入
        /// </summary>
        [HttpPost]
//        [Route("PersonController/Import")]
        //[WriteLog(EComLib_ActionEnum.导入)]
        public async Task<IActionResult> Import()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 人员导出
        /// <param name="personCode">传入操作用户编码，因为导出功能必须加入AllowAnonymous，所以无法记录日志-操作人，这边参数传入相关参数</param>
        /// </summary>
        [HttpGet]
//        [Route("PersonController/Export")]
        [AllowAnonymous]
        //[WriteLog(EComLib_ActionEnum.导出)]
        public async Task<IActionResult> Export(string personCode)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 逻辑删除操作（根据多个Code字段值，从指定表中设置DelFlag字段为1）
        /// </summary>
        /// <param name="codes">Code编号值列表</param>
        /// <returns></returns>
        [HttpDelete]
//        [Route("Person/DeleteForCodeFalse")]
        public async Task<IActionResult> DeleteForCodeFalse([FromBody] string codes)
        {
            throw new NotImplementedException();
        }

        private class DepartmentInfo
        {
            public string DeptCode       { set; get; }
            public string CorpCode       { set; get; }
            public string DepartmentName { set; get; }
        }
    }
}
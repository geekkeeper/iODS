using System;
using System.Collections.Generic;
using iODS.Model;
using Microsoft.AspNetCore.Mvc;

namespace iODS.WebApiService.Controllers
{
    [ApiController]
    [Route("iODS/[controller]/[action]")]
    public class SysPowerController : Controller
    {
        [HttpPost]
//        [Route("SysPower/GetAllRes")]
        public List<V_SM_SystemResourceAll> GetAllRes([FromBody] string strSysPoweMethod)
        {
            throw new NotImplementedException();
        }

        [HttpPost]
//        [Route("SysPower/GetAllDept")]
        public List<V_SM_Department> GetAllDept([FromBody] string strSysPoweMethod)
        {
            throw new NotImplementedException();
        }
    }

    public class SysMethod
    {
        public string Code     { get; set; }
        public string TabIndex { get; set; }
    }
}
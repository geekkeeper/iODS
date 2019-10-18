using System;
using System.Collections.Generic;
using iODS.Model;
using Microsoft.AspNetCore.Mvc;

namespace iODS.WebApiService.Controllers
{
    [ApiController]
    [Route("iODS/[controller]/[action]")]
    public class QueryDeptController : Controller
    {

        [HttpPost]
//        [Route("QueryDept/GetQueryDepts")]
        public List<V_SM_Department> GetQueryDepts([FromBody]string strQueryDeptParameter)
        {
            throw new NotImplementedException();
        }

        public class QueryDeptParameter
        {
            public string PersonCode { get; set; }
            public string DeptCode { get; set; }
            public string AuthorityType { get; set; }
        }
    }
}

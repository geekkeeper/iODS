using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace iODS.WebApiService.Controllers
{
    [ApiController]
    [Route("iODS/[controller]/[action]")]
    public class NodeStateController : Controller
    {
        /// <summary>
        /// 获取指定条件的分页数据 
        /// </summary>
        /// <param name="query">查询数据类</param>
        /// <returns></returns>
        [HttpGet]
        //[Route("NodeState/Query")]
        public async Task<IActionResult> Query([FromRoute]dynamic query)
        {
            throw new NotImplementedException();
        }
    }
}

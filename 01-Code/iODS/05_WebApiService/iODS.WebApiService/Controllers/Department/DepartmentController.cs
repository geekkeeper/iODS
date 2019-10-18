using System;
using System.Threading.Tasks;
using FluentValidation;
using iODS.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace iODS.WebApiService.Controllers
{
    [ApiController]
    [Route("iODS/[controller]/[action]")]
    public class DepartmentController : Controller
    {
        private readonly IValidator<Department> _validator;


        /// <summary>
        /// 增加数据
        /// </summary>
        /// <param name="model">表实体的json数组</param>
        /// <returns></returns>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        //[Route("DepartmentController/Add")]
        public async Task<IActionResult> Add([FromBody]Department model)
        {
            if (model == null)
            {
                return this.BadRequest();
            }

            var aa = this._validator.Validate(model);
            if (!aa.IsValid)
            {
                return this.BadRequest(string.Join(":", aa.Errors));
            }
//            JsonResult result1 = new JsonResult(null);
//            RedirectResult result2 = new RedirectResult(null);
//            FileResult fileResult;
//            ViewResult viewResult = new ViewResult();
//            ContentResult contentResult = new ContentResult();
            //StatusCodes
            
            return this.Ok();
            
        }


        [HttpGet("{query}")]
        //[Route("Department/QueryMenu")]
        public string QueryMenu([FromRoute]dynamic query)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 点击树，根据code删除
        /// </summary>
        /// <param name="delTreeCode"></param>
        /// <returns></returns>
        [HttpDelete("{delTreeCode}")]
        //[Route("Department/DeleteTreeForCode")]
        public async Task<IActionResult> DeleteTreeForCode([FromRoute]string delTreeCode)
        {
            throw new NotImplementedException();
        }


        

        [HttpPut]
        //[Route("Department/UpdateGrid")]
        public string UpdateGrid([FromBody]string personList)
        {
            throw new NotImplementedException();
        }


        [HttpPut]
        //[Route("Department/Authorise")]
        public string Authorise(dynamic roleData)
        {
            throw new NotImplementedException();
        }
        
    }
}

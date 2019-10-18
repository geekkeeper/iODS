using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace iODS.WebApiService.Controllers
{
    [ApiController]
    [Route("iODS/[controller]/[action]")]
    public class UploadFileController : Controller
    {

        /// <summary>
        /// 上传文件
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [AllowAnonymous]
        //[Route("UploadFile/PostFromData")]
        public async Task<Dictionary<string,object>> PostFromData(string moduleId, string uid)
        {
            throw  new  NotImplementedException();
        }


        /// <summary>
        /// 下载文件
        /// </summary>
        /// <param name="moduleId">模块</param>
        /// <param name="fileCode">文件Code</param>
        /// <returns></returns>
        [HttpGet]
        [AllowAnonymous]
        //[Route("UploadFile/Download")]
        public async Task<IActionResult> Download(string moduleId, string fileCode)
        {
            throw  new  NotImplementedException();
        }


        [HttpGet("{query}")]
        //[Route("UploadFile/GetFilesInfo")]
        public async Task<IActionResult> GetFilesInfo([FromRoute]dynamic query)
        {
            throw  new  NotImplementedException();
        }

        [HttpGet]
        //[Route("UploadFile/DeleteUploadFiles")]
        public bool DeleteUploadFiles(string delFiles)
        {
            throw  new  NotImplementedException();
        }
    }
}

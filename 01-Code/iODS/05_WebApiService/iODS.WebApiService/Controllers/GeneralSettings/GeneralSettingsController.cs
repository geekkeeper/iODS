using System;
using System.Threading.Tasks;
using iODS.WebApiService.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace iODS.WebApiService.Controllers
{
    [ApiController]
    [Route("iODS/[controller]/[action]")]
    public class GeneralSettingsController : Controller
    {
        [HttpGet]
        [AllowAnonymous]
        //[Route("GeneralSettings/GetImage")]
        public async Task<IActionResult> GetImage(string type)
        {
            throw new NotImplementedException();
        }


        [HttpPost]
        //[Route("GeneralSettings/UpLoadImage")]
        public async Task<IActionResult> UpLoadImage(string imageName = "")
        {
            throw new NotImplementedException();
        }
        [HttpGet]
        [AllowAnonymous]
        //[Route("GeneralSettings/Query")]
        public async Task<IActionResult> Query()
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 增加数据
        /// </summary>
        /// <param name="model">表实体的json数组</param>
        /// <returns></returns>
        [HttpPost]
        //[Route("GeneralSettings/Add")]
        //[WriteLog(EComLib_ActionEnum.新增)]
        public async Task<IActionResult> Add([FromBody]SM_GeneralSettingsViewModel  model)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 根据Id修改数据
        /// </summary>
        /// <param name="modelList">表实体的json数组</param>
        /// <returns></returns>
        [HttpPut]
        //[Route("GeneralSettings/UpdateForId")]
        //[WriteLog(EComLib_ActionEnum.修改)]
        public async Task<IActionResult> UpdateForId([FromBody]string modelList)
        {
            throw new NotImplementedException();
        }

    }
}

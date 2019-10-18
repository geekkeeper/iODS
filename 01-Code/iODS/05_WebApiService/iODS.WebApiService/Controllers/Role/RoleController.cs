using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace iODS.WebApiService.Controllers
{
    [ApiController]
    [Route("iODS/[controller]/[action]")]
    public class RoleController : Controller
    {

        /// <summary>
        /// 为角色增加用户
        /// </summary>
        /// <param name="model">Delete_Add自定义类对象</param>
        /// <returns></returns>
        [HttpPost]
//        [Route("RoleController/RoleAddPersons")]
        //[WriteLog(EComLib_ActionEnum.新增,"新增角色用户")]
        public async Task<IActionResult> RoleAddPersons([FromBody]dynamic model)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 为角色删除用户
        /// </summary>
        /// <param name="model">Delete_Add自定义类对象</param>
        /// <returns></returns>
        [HttpPost]
//        [Route("RoleController/RoleDelPersons")]
        //[WriteLog(EComLib_ActionEnum.删除,"删除角色用户")]
        public async Task<IActionResult> RoleDelPersons([FromBody]dynamic model)
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// 主表增加，子表增加
        /// </summary>
        /// <param name="model">自定义类对象</param>
        /// <returns></returns>
        [HttpPost]
//        [Route("Role/MainAdd_ChildAdd")]
        public async Task<IActionResult> MainAdd_ChildAdd([FromBody]dynamic model)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 根据Id修改数据
        /// </summary>
        /// <param name="modelList">表实体的json数组</param>
        /// <returns></returns>
        [HttpPut]
//        [Route("Role/UpdateForId")]
        public async Task<IActionResult> UpdateForId([FromBody]string modelList)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 主表假删除（Code），子表真删除（ID）
        /// </summary>
        /// <param name="modelMainDelChildDel"></param>
        /// <returns></returns>
        [HttpPost]
//        [Route("Role/MainDelForCode_ChildDelForId")]
        public async Task<IActionResult> MainDelForCode_ChildDelForId([FromBody]dynamic modelMainDelChildDel)
        {
            throw new NotImplementedException();
        }
    }
}

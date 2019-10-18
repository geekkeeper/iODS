//using System.Collections.Generic;
//using iODS.IRepository;
//using iODS.Service;
//using iODS.Service.ViewModel;
//using Microsoft.AspNetCore.Mvc;
//
//namespace iODS.WebApiService.Controllers
//{
//    /// <summary>
//    /// 部门
//    /// </summary>
//    [ApiController]
//    [Route("iODS/[controller]/[action]")]
//    public class DepartmentController : Controller
//    {
//        private readonly IDepartmentService              _service;
//        //private readonly IValidator<DepartmentViewModel> _validator;
//
//        public DepartmentController(IDepartmentService service)
//        {
//            this._service   = service;
//            //this._validator = validator;
//        }
//
//        /// <summary>
//        /// 获取所有部门
//        /// </summary>
//        /// <returns></returns>
//        [HttpGet]
//        public ResultMessage<List<DepartmentViewModel>> GetAll()
//        {
//            return new ResultMessage<List<DepartmentViewModel>>();
//        }
//
//        /// <summary>
//        /// 获取单个部门
//        /// </summary>
//        /// <param name="id">部门ID</param>
//        /// <returns></returns>
//        [HttpGet("{id}",Name = "GetById")]
//        public ResultMessage<DepartmentViewModel> Get(int id)
//        {
//            return new ResultMessage<DepartmentViewModel>();
//        }
//
//        /// <summary>
//        /// 添加部门
//        /// </summary>
//        /// <param name="model"></param>
//        /// <returns></returns>
//        [HttpPost]
//        public IActionResult AddDepartment([FromBody] DepartmentViewModel model)
//        {
//            if (model == null)
//            {
//                return this.BadRequest();
//            }
//            var result           = new ResultMessage<string>();
////            var validationResult = this._validator.Validate(model);
////            if (!validationResult.IsValid)
////            {
////                result.IsSuccess = false;
////                //result.Message   = string.Join(";", validationResult.Errors);
////            }
////            else
////            {
////                result.IsSuccess = true;
////                result.Message   = "成功!";
////            }
//            return this.Ok(result);
//        }
//    }
//}
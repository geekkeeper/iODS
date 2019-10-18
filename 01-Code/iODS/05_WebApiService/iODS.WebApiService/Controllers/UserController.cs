using System.Threading.Tasks;
using Hollysys.Common;
using iODS.Model;
using iODS.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace iODS.WebApiService.Controllers
{
    [Produces("application/json")]
    [ApiController]
    [Route("iODS/User")]
    public class UserController : Controller
    {
        private IUserService _service;
        private readonly ILogger<WeatherForecastController> _logger;

        public UserController(IUserService service, ILogger<WeatherForecastController> logger)
        {
            this._service = service;
            this._logger = logger;
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] User model)
        {
            var resultMessage = new ResultMessage<string>
            {
                    IsSuccess = true,
                    Message   = "添加成功",
                    Data      = ""
            };
            return this.Ok(resultMessage);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var resultMessage = new ResultMessage<string>
            {
                    IsSuccess = true,
                    Message   = "删除成功",
                    Data      = ""
            };
            return this.Ok(resultMessage);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update([FromRoute] int id, [FromBody] User model)
        {
            var resultMessage = new ResultMessage<string>
            {
                    IsSuccess = true,
                    Message   = "修改成功",
                    Data      = ""
            };
            return this.Ok(resultMessage);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Select(int id)
        {
            var resultMessage = new ResultMessage<User>
            {
                    IsSuccess = true,
                    Message   = "查询成功",
                    Data      = new User
                    {
                            UserName = "王勋",
                            Sex = "M",
                            Age = 28
                    }
            };
            return this.Ok(resultMessage);
        }
        
        [HttpGet("{id}/{name}")]
        public async Task<IActionResult> Select(int id,string name)
        {
            var resultMessage = new ResultMessage<User>
            {
                    IsSuccess = true,
                    Message   = "查询成功",
                    Data = new User
                    {
                            UserName = "王勋",
                            Sex      = "M",
                            Age      = 28
                    }
            };
            return this.Ok(resultMessage);
        }
    }
}
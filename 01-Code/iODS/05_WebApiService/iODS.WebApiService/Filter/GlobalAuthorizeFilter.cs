using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ApplicationModels;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Mvc.Filters;

namespace iODS.WebApiService
{
    /// <summary>
    /// Summary:全局路由权限公约
    /// Remarks:目的是针对不同的路由，采用不同的授权过滤器
    /// 如果 controller 上不加 [Authorize] 特性，默认都是 Permission 策略
    /// 否则，如果想特例其他授权机制的话，需要在 controller 上带上  [Authorize]，然后再action上自定义授权即可，比如 [Authorize(Roles = "Admin")]
    /// </summary>
    public class GlobalRouteAuthorizeConvention : IApplicationModelConvention
    {
        public void Apply(ApplicationModel application)
        {
            /*
            foreach (ControllerModel c in application.Controllers)
            {
                if (!c.Filters.Any(e => e is AuthorizeFilter))
                {
                    // 没有写特性，就用全局的 Permission 授权
                    c.Filters.Add(new AuthorizeFilter(Permissions.NAME));
                }
            }
            */
        }
    }

    public class GlobalAuthorizeFilter : AuthorizeFilter
    {
        public override Task OnAuthorizationAsync(AuthorizationFilterContext context)
        {
            //return base.OnAuthorizationAsync(context);
            //TODO:自定义认证过滤器的业务逻辑实现
            return null;
        }
    }
}
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc.ApplicationModels;
using Microsoft.AspNetCore.Mvc.Routing;

namespace iODS.WebApiService
{
    /// <summary>
    /// 全局路由前缀公约
    /// </summary>
    public class GlobalRoutePrefixFilter : IApplicationModelConvention
    {
        private readonly AttributeRouteModel _centralPrefix;

        public GlobalRoutePrefixFilter(IRouteTemplateProvider routeTemplateProvider)
        {
            this._centralPrefix = new AttributeRouteModel(routeTemplateProvider);
        }

        //接口的Apply方法
        public void Apply(ApplicationModel application)
        {
            //遍历所有的 Controller
            foreach (ControllerModel controller in application.Controllers)
            {
                // 已经标记了 RouteAttribute 的 Controller
                List<SelectorModel> matchedSelectors = controller.Selectors.Where(x => x.AttributeRouteModel != null).ToList();
                if (matchedSelectors.Any())
                {
                    foreach (SelectorModel selectorModel in matchedSelectors)
                    {
                        // 在 当前路由上 再 添加一个 路由前缀
                        selectorModel.AttributeRouteModel = AttributeRouteModel.CombineAttributeRouteModel(this._centralPrefix,
                            selectorModel.AttributeRouteModel);
                    }
                }

                // 没有标记 RouteAttribute 的 Controller
                List<SelectorModel> unmatchedSelectors = controller.Selectors.Where(x => x.AttributeRouteModel == null).ToList();
                if (unmatchedSelectors.Any())
                {
                    foreach (SelectorModel selectorModel in unmatchedSelectors)
                    {
                        // 添加一个 路由前缀
                        selectorModel.AttributeRouteModel = this._centralPrefix;
                    }
                }
            }
        }
    }
}
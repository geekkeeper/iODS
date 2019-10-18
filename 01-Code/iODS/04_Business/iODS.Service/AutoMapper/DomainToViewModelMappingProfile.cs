using AutoMapper;
using iODS.Model;
using iODS.Service.ViewModel;

namespace iODS.Service.AutoMapper
{
    public class DomainToViewModelMappingProfile: Profile
    {
        /// <summary>
        /// 配置构造函数，用来创建关系映射
        /// </summary>
        public DomainToViewModelMappingProfile()
        {
            this.CreateMap<Department, DepartmentViewModel>();



        }
    }
}

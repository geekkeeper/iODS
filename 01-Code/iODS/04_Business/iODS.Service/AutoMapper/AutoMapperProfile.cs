using AutoMapper;
using iODS.Model;
using iODS.Service.ViewModel;

namespace iODS.Service.AutoMapper
{
    public class AutoMapperProfile: Profile
    {
        public AutoMapperProfile()
        {
            this.CreateMap<Department, DepartmentViewModel>();
            this.CreateMap<DepartmentViewModel, Department>();
        }
    }
}

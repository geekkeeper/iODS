using AutoMapper;
using iODS.Model;
using iODS.Service.ViewModel;

namespace iODS.Service.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            //手动进行配置
            this.CreateMap<DepartmentViewModel, Department>();
            
        }
    }
}

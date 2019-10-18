using AutoMapper;

namespace iODS.Service.AutoMapper
{
    public class AutoMapperConfig
    {
        public static MapperConfiguration RegisterMapping()
        {
            return new MapperConfiguration(config =>
            {
                //领域模型--》视图模型
                config.AddProfile(new DomainToViewModelMappingProfile());
                //视图模型--》领域模型
                config.AddProfile(new ViewModelToDomainMappingProfile());
            });
        }
    }
}
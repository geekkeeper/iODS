using System;
using AutoMapper;
using iODS.Service.AutoMapper;
using Microsoft.Extensions.DependencyInjection;

namespace iODS.WebApiService
{
    public static class AutoMapperSetup
    {
        /// <summary>
        /// 注入/配置AutoMapper
        /// </summary>
        /// <param name="services"></param>
        public static void RegisterAutoMapper(this IServiceCollection services)
        {
            //TODO:注入/配置AutoMapper
            if (services == null)
            {
                throw new ArgumentNullException(nameof(services));
            }

            services.AddAutoMapper(typeof(AutoMapperProfile));

            AutoMapperConfig.RegisterMapping();
        }
    }
}
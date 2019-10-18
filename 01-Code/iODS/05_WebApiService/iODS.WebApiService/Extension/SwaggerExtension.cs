using System;
using System.IO;
using System.Reflection;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;

namespace iODS.WebApiService
{
    public static class SwaggerExtension
    {
        public static void AddSwagger(this IServiceCollection services)
        {
            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1",
                        new OpenApiInfo
                        {
                                Title       = "iODS API",
                                Description = "iODS 服务接口文档",
                                Version     = "v1.0.0.0",
                                Contact = new OpenApiContact
                                {
                                        Name = "WangXun", Email = "wangxun183963@hollysys.net"
                                }
                        });
                //为 Swagger JSON and UI设置xml文档注释路径
                string xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                string xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                if (File.Exists(xmlPath))
                {
                    options.IncludeXmlComments(xmlPath);
                }
            });
        }

        public static void UseSwagger(this IApplicationBuilder app, IWebHostEnvironment env)
        {
            //启用中间件服务生成Swagger作为JSON终结点
            app.UseSwagger();
            //启用中间件服务对swagger-ui，指定Swagger JSON终结点
            app.UseSwaggerUI(options =>
            {
                options.SwaggerEndpoint("/swagger/v1/swagger.json", "iODS API V1");
                //options.RoutePrefix = string.Empty;
            });
        }
    }
}
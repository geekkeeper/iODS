using System;
using System.Reflection;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using AutoMapper;
using Hollysys.Common;
using Hollysys.Common.Extension;
using iODS.Service;
using iODS.Service.AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace iODS.WebApiService
{
    public class Startup
    {
        private static readonly string AppName = Assembly.GetExecutingAssembly().GetName().Name;

        public Startup(IConfiguration configuration, IWebHostEnvironment environment)
        {
            this.Configuration = configuration;
            this.Environment   = environment;
        }

        public IContainer          ApplicationContainer { set; get; }
        public IConfiguration      Configuration        { get; }
        public IWebHostEnvironment Environment          { get; }

        /// <summary>
        /// 此方法运行时被调用. 使用此方法添加服务到容器.
        /// </summary>
        /// <param name="services">.Net Core 原生DI容器</param>
        /// <returns></returns>
        public IServiceProvider ConfigureServices(IServiceCollection services)
        {
            //实例化 AutoFac 容器
            var builder = new ContainerBuilder();
            
            services.AddAutoMapper(typeof(AutoMapperProfile));

            services.AddSingleton(new object());
            services.AddSingleton(new AppSettings(this.Environment.ContentRootPath));
            services.AddSingleton(new LogLock(this.Environment));

            services.AddControllers();

            //swagger注入
            services.AddSwagger();

            //服务层注入
//            string serviceDllFile = Path.Combine(AppContext.BaseDirectory, "iODS.Service.dll");
//            Assembly serviceAssembly = Assembly.LoadFrom(serviceDllFile);
//            builder.RegisterAssemblyTypes(serviceAssembly).AsImplementedInterfaces();
            services.RegisterService("iODS.Service.dll");

            //持久层注入
//            string repositoryDllFile = Path.Combine(AppContext.BaseDirectory, "iODS.Repository.SQLSugar.dll");
//            Assembly repositoryAssembly = Assembly.LoadFrom(repositoryDllFile);
//            builder.RegisterAssemblyTypes(repositoryAssembly).AsImplementedInterfaces();
            services.RegisterRepository("iODS.Repository.SQLSugar.dll");

            //AutoFac容器接管原生容器
            builder.Populate(services);
            this.ApplicationContainer = builder.Build();
            return new AutofacServiceProvider(this.ApplicationContainer);
        }

        /// <summary>
        /// 此方法运行时被调用. 使用此方法配置HTTP请求管道.
        /// </summary>
        /// <param name="app"></param>
        /// <param name="env"></param>
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //
            app.UseHttpsRedirection();

            //
            app.UseRouting();

            //
            app.UseAuthorization();

            //
            app.UseEndpoints(endpoints => { endpoints.MapControllers(); });

            //
            app.UseSwagger(env);
        }
    }
}
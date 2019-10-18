using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using Hollysys.Common.Attribute;
using Microsoft.Extensions.DependencyInjection;

namespace Hollysys.Common.Extension
{
    public static class ServiceCollectionExtension
    {
        /// <summary>
        /// 仓储层注入
        /// </summary>
        /// <param name="services"></param>
        /// <param name="repositoryAssembleName"></param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="FileNotFoundException"></exception>
        public static void RegisterRepository(this IServiceCollection services, string repositoryAssembleName)
        {
            if (string.IsNullOrEmpty(repositoryAssembleName))
            {
                throw new ArgumentNullException();
            }

            if (!repositoryAssembleName.Contains(".dll"))
            {
                repositoryAssembleName += ".dll";
            }

            string dllPath = AppContext.BaseDirectory + repositoryAssembleName;
            if (!File.Exists(dllPath))
            {
                throw new FileNotFoundException();
            }

            Assembly assembly = Assembly.LoadFrom(dllPath);
            List<Type> ts = assembly.GetTypes().Where(t =>
                    t.IsClass && !t.IsAbstract && !t.IsGenericType &&
                    t.GetCustomAttributes(true).FirstOrDefault(x =>
                                    x.GetType() == typeof(RepositoryAttribute)) is
                            RepositoryAttribute).ToList();
            foreach (Type item in ts.Where(t => !t.IsInterface))
            {
                Type[] interfaces = item.GetInterfaces();
                foreach (Type @interface in interfaces)
                {
//                    if (@interface.Name.Contains("Repository"))
                    //                    {
                    //                        services.AddTransient(@interface, item);
                    //                    }
                    if (string.Equals(@interface.Name, "I" + item.Name))
                    {
                        services.AddTransient(@interface, item);
                    }
                }
            }
        }

        /// <summary>
        /// 服务层注入
        /// </summary>
        /// <param name="services">DI容器</param>
        /// <param name="serviceAssembleName">服务层程序集名称</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="FileNotFoundException"></exception>
        public static void RegisterService(this IServiceCollection services, string serviceAssembleName)
        {
            if (string.IsNullOrEmpty(serviceAssembleName))
            {
                throw new ArgumentNullException();
            }

            if (!serviceAssembleName.Contains(".dll"))
            {
                serviceAssembleName += ".dll";
            }

            string dllPath = AppContext.BaseDirectory + serviceAssembleName;
            if (!File.Exists(dllPath))
            {
                throw new FileNotFoundException();
            }

            Assembly assembly = Assembly.LoadFrom(dllPath);
            List<Type> ts = assembly.GetTypes().Where(t =>
                                            t.IsClass && !t.IsAbstract && !t.IsGenericType &&
                                            t.GetCustomAttributes(true).FirstOrDefault(x =>
                                                    x.GetType() == typeof(ServiceAttribute)) is ServiceAttribute)
                                    .ToList();
            foreach (Type item in ts.Where(t => !t.IsInterface))
            {
                var firstOrDefault = item.GetCustomAttributes(true)
                                         .FirstOrDefault(x => x.GetType() == typeof(ServiceAttribute));
                if (firstOrDefault is ServiceAttribute aa)
                {
                    if (aa.InterfaceType != null)
                    {
                        services.AddTransient(aa.InterfaceType, item);
                    }
                }

//                Type[] interfaces = item.GetInterfaces();
//                foreach (Type @interface in interfaces)
//                {
//                    if (@interface.Name.Contains("Service"))
//                    {
//                        services.AddTransient(@interface, item);
//                    }
//                }
            }
        }
    }
}
using System;
using System.Linq;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;

namespace Hollysys.Common
{
    /// <summary>
    ///     appsettings.json操作类
    /// </summary>
    public class AppSettings
    {
        public AppSettings(string contentPath)
        {
            const string path = "appsettings.json";
            ContentPath = contentPath;
            Configuration = new ConfigurationBuilder()
                            .SetBasePath(ContentPath)
                            .Add(new JsonConfigurationSource
                            {
                                    Path = path, Optional = false, ReloadOnChange = true
                            }) //这样的话，可以直接读目录里的json文件，而不是 bin 文件夹下的，所以不用修改复制属性
                            .Build();
        }

        private static IConfiguration      Configuration { get; set; }
        private static string              ContentPath   { get; set; }

        /// <summary>
        ///     读取配置信息
        /// </summary>
        /// <param name="sections"></param>
        /// <returns></returns>
        public static string ReadContent(params string[] sections)
        {
            try
            {
                string val = sections.Aggregate(string.Empty, (current, t) => current + t + ":");

                return Configuration[val.TrimEnd(':')];
            }
            catch (Exception)
            {
                return "";
            }
        }
    }
}
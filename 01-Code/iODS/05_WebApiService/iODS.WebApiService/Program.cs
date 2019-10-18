using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace iODS.WebApiService
{
    public class Program
    {
        public static void Main(string[] args)
        {
           IWebHost host = CreateHostBuilder(args).Build();
           //TODO：服务启动前的业务逻辑
           host.Run();
        }

        public static IWebHostBuilder CreateHostBuilder(string[] args) =>
                WebHost.CreateDefaultBuilder(args).UseStartup<Startup>();

        //.ConfigureWebHostDefaults(webBuilder => { webBuilder.UseStartup<Startup>(); });
    }
}
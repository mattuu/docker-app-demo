using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace app_demo.api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args)
        {
            return Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseKestrel(options => { options.Configure(); });
                    webBuilder.UseStartup<Startup>();
                });
        }
    }
}
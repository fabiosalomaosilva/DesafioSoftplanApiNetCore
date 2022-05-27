using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace DesafioSoftplan.Api
{
    public class Program
    {
        private static string[] urls => new string[] { "https://localhost:5000", "http://localhost:5001" };

        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
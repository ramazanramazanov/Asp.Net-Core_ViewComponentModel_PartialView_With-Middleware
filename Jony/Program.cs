using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Jony2.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Jony2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();
            using(var scoped = host.Services.CreateScope())
            {
                DatabaseInitializer.Seed(scoped);
            }
            host.Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });

        //public static IHostBuilder CreateHostBuilder(string[] args)
        //{
        //    HostBuilder hostBuilder = new HostBuilder();
        //    hostBuilder.ConfigureAppConfiguration((x, y) =>
        //    {
        //      string env=x.HostingEnvironment.EnvironmentName;
        //        y.AddJsonFile($"appsettings{env}.json");
        //    });
        //}
    }
}

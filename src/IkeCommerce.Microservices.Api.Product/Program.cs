using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Serilog;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace IkeCommerce.Microservices.Api.Product
{
    public class Program
    {
        
        public static void Main(string[] args)
        {
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Override("Microsoft.AspNetCore", Serilog.Events.LogEventLevel.Warning)
                .MinimumLevel.Override("Microsoft.AspNetCore", Serilog.Events.LogEventLevel.Error)
                .Enrich.FromLogContext()
                .WriteTo.Console(outputTemplate: "")
                .WriteTo.Logger(x => {
                    x.WriteTo.File("Logs/Info/app_log_.log", rollingInterval: RollingInterval.Day);
                })
                .CreateLogger();

            try
            {
                Log.Information("app@ init app");
                CreateHostBuilder(args).Build().Run();
                Log.Information("app@ finished app");
            }
            catch (Exception ex)
            {
                Log.Fatal(ex, "app@ finished host");
            }
            finally
            {
                Log.CloseAndFlush();
            }
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
            .UseSerilog()
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}

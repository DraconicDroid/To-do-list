using System.Collections.Generic;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SqlLiteUtils;

namespace App1
{
    public class Program
    {
        public static SqlDatabase Server;

        public static void Main(string[] args)
        {
            var builder = CreateHostBuilder(args);

            builder.ConfigureServices((hostContext, services) => { services.AddSignalR(); });

            var app = builder.Build();
            

            app.Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args)
        {
            return Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder => { webBuilder.UseStartup<Startup>(); });
        }
    }
}
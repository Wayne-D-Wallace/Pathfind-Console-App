using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Pathfinder_Character_Sheets_Server;
using System;

namespace Pathfinder_Character_Sheets
{
    public class Program
    {
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

using LaunchDarkly.EventSource;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using System;
using System.Diagnostics;

namespace AspNetCoreWebApi_Core31
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //CreateHostBuilder(args).Build().Run();
            //var source = new EventSource(new Configuration(new Uri("https://smee.io/3fUXIBJELWjqgj8Q")));
            //source.MessageReceived += (sender, eventArgs) =>
            //{
            //    Debugger.Break();
            //};

            //source.CommentReceived += (sender, eventArgs) =>
            //{
            //    Debugger.Break();
            //};

            //source.StartAsync();

            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder => webBuilder.UseStartup<Startup>())
                .Build()
                .Run();
            //source.Close();
            Console.ReadLine();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}

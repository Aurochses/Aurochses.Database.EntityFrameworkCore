using System;
using System.IO;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.CommandLineUtils;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Aurochses.Database.EntityFrameworkCore
{
    public abstract class ProgramBase
    {
        public static void Main<TType, TService>(string[] args)
            where TType : StartupBase
            where TService : ServiceBase
        {
            // get environment name
            var environmentName = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");

            // startup
            var startup = (TType) Activator.CreateInstance(typeof(TType), BuildConfiguration(environmentName));

            // service collection
            var serviceCollection = new ServiceCollection();
            startup.ConfigureServices(serviceCollection);

            // add Service
            serviceCollection.AddTransient<TService>();

            // service provider
            var serviceProvider = serviceCollection.BuildServiceProvider();

            // service
            var service = serviceProvider.GetService<TService>();

            // app
            var app = DatabaseCommandLineApplication.Create(service);

            try
            {
                app.Execute(args);
            }
            catch (CommandParsingException ex)
            {
                Console.WriteLine(ex.Message);
                Environment.Exit(1);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unable to execute application: {0}", ex.Message);
                Environment.Exit(1);
            }
        }

        public static IWebHostBuilder CreateWebHostBuilder<TStartup>(string[] args)
            where TStartup : class
        {
            return WebHost.CreateDefaultBuilder(args)
                .UseStartup<TStartup>();
        }

        public static IConfigurationRoot BuildConfiguration(string environmentName) =>
            new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .AddJsonFile($"appsettings.{environmentName}.json", true)
                .AddEnvironmentVariables()
                .Build();
    }
}
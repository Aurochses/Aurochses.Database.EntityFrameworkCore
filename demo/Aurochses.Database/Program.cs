using Aurochses.Database.EntityFrameworkCore;
using Microsoft.AspNetCore.Hosting;

namespace Aurochses.Database
{
    public class Program : ProgramBase
    {
        public static void Main(string[] args)
        {
            Main<Startup, Service>(args);
        }

        // ReSharper disable once UnusedMember.Global
        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            CreateWebHostBuilder<Startup>(args);
    }
}
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace Aurochses.Database.EntityFrameworkCore
{
    public abstract class ProgramBase
    {
        public static IWebHostBuilder CreateWebHostBuilder<TStartup>(string[] args)
            where TStartup : class
        {
            return WebHost.CreateDefaultBuilder(args)
                .UseStartup<TStartup>();
        }
    }
}
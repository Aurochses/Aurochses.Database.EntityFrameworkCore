using Aurochses.Database.Contexts;
using Aurochses.Database.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Aurochses.Database
{
    public class Startup : StartupBase
    {
        public Startup(IConfiguration configuration)
            : base(configuration)
        {

        }

        public override void ConfigureServices(IServiceCollection services)
        {
            // Contexts
            services.AddDbContext<BaseContext>(
                options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
        }
    }
}
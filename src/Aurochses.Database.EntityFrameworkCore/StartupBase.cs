using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Aurochses.Database.EntityFrameworkCore
{
    public abstract class StartupBase
    {
        public StartupBase(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public virtual void ConfigureServices(IServiceCollection services)
        {
//            // Logging
//            App.Logging.Startup.Configure(services, Configuration);
//
//            // Contexts
//            services.AddDbContext<BaseContext>(
//                options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
//
//            services.AddDbContext<WorkflowContext>(
//                options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
//
//            // have to add this context because WorkflowContext use it
//            services.AddDbContext<WorkflowDbContext>(
//                options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
//
//            services.AddOptions();
//
//            services.AddTransient<Service>();
        }

        public virtual void Configure()
        {

        }
    }
}
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Aurochses.Database.EntityFrameworkCore
{
    /// <summary>
    /// Base class for Startup.
    /// </summary>
    public abstract class StartupBase
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="configuration">Configuration.</param>
        protected StartupBase(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        /// <summary>
        /// Configuration.
        /// </summary>
        public IConfiguration Configuration { get; }

        /// <summary>
        /// Method for configure services.
        /// </summary>
        /// <param name="services">Service collection.</param>
        public virtual void ConfigureServices(IServiceCollection services)
        {

        }

        /// <summary>
        /// Method for configure.
        /// </summary>
        public virtual void Configure()
        {

        }
    }
}
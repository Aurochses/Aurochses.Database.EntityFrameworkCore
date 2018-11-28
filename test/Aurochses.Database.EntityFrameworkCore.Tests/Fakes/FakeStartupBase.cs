using Microsoft.Extensions.Configuration;

namespace Aurochses.Database.EntityFrameworkCore.Tests.Fakes
{
    public class FakeStartupBase : StartupBase
    {
        public FakeStartupBase(IConfiguration configuration)
            : base(configuration)
        {

        }
    }
}
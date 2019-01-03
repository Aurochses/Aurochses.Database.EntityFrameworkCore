using Microsoft.EntityFrameworkCore;

namespace Aurochses.Database.Contexts
{
    public class BaseContext : DbContext
    {
        public BaseContext(DbContextOptions<BaseContext> dbContextOptions)
            : base(dbContextOptions)
        {

        }
    }
}
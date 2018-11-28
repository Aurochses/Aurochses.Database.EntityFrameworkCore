using Aurochses.Database.Contexts;
using Aurochses.Database.EntityFrameworkCore;

namespace Aurochses.Database
{
    public class Service : ServiceBase
    {
        public Service(BaseContext baseContext)
            : base(baseContext)
        {

        }
    }
}
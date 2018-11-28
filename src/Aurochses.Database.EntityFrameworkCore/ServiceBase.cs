using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Aurochses.Database.EntityFrameworkCore
{
    public abstract class ServiceBase
    {
        private readonly IList<DbContext> _dbContexts;

        protected ServiceBase(params DbContext[] dbContexts)
        {
            _dbContexts = new List<DbContext>(dbContexts);
        }

        public void Update()
        {
            foreach (var dbContext in _dbContexts)
            {
                dbContext.Database.Migrate();
            }
        }

        public void Update(string contextName)
        {
            _dbContexts.First(x => x.GetType().Name == contextName).Database.Migrate();
        }

        public void Update(string contextName, string migration)
        {
            _dbContexts.First(x => x.GetType().Name == contextName).GetService<IMigrator>().Migrate(migration);
        }

        public void Reset()
        {
            foreach (var dbContext in _dbContexts.Reverse())
            {
                dbContext.GetService<IMigrator>().Migrate("0");
            }
        }

        public void ApplyDataFromSqlFile(string filePath = "data.sql")
        {
            _dbContexts.First().Database.ExecuteSqlCommand(File.ReadAllText(filePath));
        }
    }
}
using Microsoft.EntityFrameworkCore;
using UniversityManager.DataAccess;
using UniversityManager.Test.Database;

namespace UniversityManager.Test.Steps
{
    public class BaseRepositoryStep
    {
        protected UniversityManagerDbContext dbContext;
        
        protected void InitialiseDatabase()
        {
            InitialisatorDatabase database = new InitialisatorDatabase();

            
            DbContextOptionsBuilder<UniversityManagerDbContext> optionBuilder = new DbContextOptionsBuilder<UniversityManagerDbContext>();
            optionBuilder.UseSqlServer(database.connexion + $"Initial Catalog = {ScriptSQL.DatabaseName};", sqlServerOptions => sqlServerOptions.CommandTimeout(360));
            dbContext = new UniversityManagerDbContext(optionBuilder.Options);
        }

    }
}

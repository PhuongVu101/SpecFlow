using UniversityManager.Test.Database;
using TechTalk.SpecFlow;

namespace UniversityManager.Test.Steps
{
    [Binding]
    
    public static class DatabaseInitialisation
    {
        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            InitialisatorDatabase database= new InitialisatorDatabase();
            database.InitialiseDatabase();
        }

        [BeforeScenario]
        [Scope(Tag = "Database")]
        public static void BeforeScenario()
        {
            InitialisatorDatabase database = new InitialisatorDatabase();
            database.ClearAllTables();
        }

    }
}

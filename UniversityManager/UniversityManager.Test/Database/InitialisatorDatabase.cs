using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Text;
using Microsoft.Extensions.Configuration;

namespace UniversityManager.Test.Database
{
    public class InitialisatorDatabase
    {
        public string connexion;
        public InitialisatorDatabase()
        {
            var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsetting.json", optional: false, reloadOnChange: true);

            IConfigurationRoot configuration = builder.Build();
            connexion = configuration.GetConnectionString("UniversityManagerDbContext");
        }

        private void Execute(string sql)
        {
            using SqlConnection connection = new SqlConnection(connexion);

            SqlCommand command = new SqlCommand(sql, connection);
            connection.Open();
            command.ExecuteNonQuery();
        }

        private bool CheckDatabaseExists(string databaseName)
        {
            using (var connection = new SqlConnection(connexion))
            {
                using (var command = new SqlCommand($"SELECT db_id('{databaseName}')", connection))
                {
                    connection.Open();
                    return (command.ExecuteScalar() != DBNull.Value);
                }
            }
        }

        public void InitialiseDatabase()
        { 
            if(this.CheckDatabaseExists(ScriptSQL.DatabaseName))
                this.Execute($"DROP DATABASE {ScriptSQL.DatabaseName}");
                //Create database
                this.Execute($"CREATE DATABASE {ScriptSQL.DatabaseName}");

                //Create Tables
                this.Execute(ScriptSQL.TablesMasterData);
        }


        public void ClearAllTables()
        {
            this.Execute($@"
            use {ScriptSQL.DatabaseName}
            EXEC sp_MSForEachTable 'ALTER TABLE ? NOCHECK CONSTRAINT ALL'
            EXEC sp_MSForEachTable 'DELETE FROM ?'
            EXEC sp_MSForEachTable 'ALTER TABLE ? CHECK CONSTRAINT ALL'");
        }


    }
}


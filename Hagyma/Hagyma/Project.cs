using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hagyma
{
    public class Project
    {
        protected string path;
        protected string dbPath;
        protected SqliteConnection sqliteConnection;

        
        public static Project NewProject(string _path)
        {
            // Create project
            return new Project(_path);
        }
        


        public Project(string _path)
        {
            this.path = _path;
            this.dbPath = System.IO.Path.Combine(
                this.path,
                Constants.database_file);

            // Create directory.
            this.createProjectDirectory();

            // Create DB in directory.
            this.createConnection();

            // Connect to db.
            this.connect();

            // Create tables.
            this.createTables();            
        }

        protected void createProjectDirectory()
        {
            System.IO.Directory.CreateDirectory(this.path);
        }

        protected void createConnection()
        {
            this.sqliteConnection = new SqliteConnection(
                String.Format(
                    "Data Source = {0}",
                    this.dbPath));
        }

        protected void connect()
        {
            this.sqliteConnection.Open();
        }

        protected void disconnect()
        {
            this.sqliteConnection.Close();
        }


        protected void createTables()
        {
            this.createTablePage();
            this.createTableSettings();
        }

        protected void createTablePage()
        {
            SqliteCommand command = new SqliteCommand();
            command.Connection = this.sqliteConnection;
            command.CommandText = Constants.database_table_page_create;
            command.ExecuteNonQuery();
        }

        protected void createTableSettings()
        {
            SqliteCommand command = new SqliteCommand();
            command.Connection = this.sqliteConnection;
            command.CommandText = Constants.database_table_settings_create;
            command.ExecuteNonQuery();
        }


    }
}

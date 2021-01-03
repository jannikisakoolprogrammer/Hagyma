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
        protected string name;
        protected SqliteConnection sqliteConnection;


        static NewProject(string _name)
        {
            // Create project
        }


        public Project(string _name)
        {
            this.name = _name;

            this.createDB();
            this.connect();
            this.createTables();
        }

        protected void createDB()
        {
            this.sqliteConnection = new SqliteConnection(String.Format("Data Source = {0}.db", this.name));
        }

        protected void connect()
        {
            this.sqliteConnection.Open();
        }


        protected void createTables()
        {
            this.createTablePage();
            this.createTableSettings();
        }

        protected void createTablePage()
        {
        }

        protected void createTableSettings()
        {
        }


    }
}

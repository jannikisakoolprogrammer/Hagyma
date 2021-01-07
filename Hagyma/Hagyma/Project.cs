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
        protected string dirPathOutput;
        protected string dirPathResources;
        protected string dirPathCSS;
        protected string filePathCSS;
        protected string dirPathJS;
        protected string filePathJS;

        protected SqliteConnection sqliteConnection;

        
        public static Project NewProject(string _path)
        {
            // Create project
            return new Project(
                _path,
                true);
        }

        public static Project OpenProject(string _path)
        {
            // Open project
            return new Project(
                _path,
                false);
        }

        public Project(
            string _path,
            bool _create = false)
        {
            this.init(_path);
            // root path.


            if (_create == true)
            {
                // Create directory.
                this.createProjectDirectories();
                this.createProjectFiles();

                // Create DB in directory.
                this.createConnection();

                // Connect to db.
                this.connect();

                // Create tables.
                this.createTables();
            }
            else
            {
                // Connect to db.
                this.createConnection();
                this.connect();
            }          
        }

        protected void init(string _path)
        {
            this.initPaths(_path); 
        }

        protected void initPaths(string _path)
        {
            this.path = _path;
            this.dbPath = System.IO.Path.Combine(
                this.path,
                Constants.database_file);

            this.dirPathOutput = System.IO.Path.Combine(
                this.path,
                Constants.output_dir);

            this.dirPathResources = System.IO.Path.Combine(
                this.dirPathOutput,
                Constants.resources_dir);

            this.dirPathCSS = System.IO.Path.Combine(
                this.dirPathOutput,
                Constants.css_dir);

            this.filePathCSS = System.IO.Path.Combine(
                this.dirPathCSS,
                Constants.css_file);

            this.dirPathJS = System.IO.Path.Combine(
                this.dirPathOutput,
                Constants.js_dir);

            this.filePathJS = System.IO.Path.Combine(
                this.dirPathJS,
                Constants.js_file);
    }

        protected void createProjectDirectories()
        {
            this.createRootDirectory();
            this.createOutputDirectory();
            this.createResourcesDirectory();
            this.createCSSDirectory();
            this.createJSDirectory();
        }

        protected void createRootDirectory()
        {
            System.IO.Directory.CreateDirectory(this.path);
        }

        protected void createOutputDirectory()
        {
            System.IO.Directory.CreateDirectory(this.dirPathOutput);
        }

        protected void createResourcesDirectory()
        {
            System.IO.Directory.CreateDirectory(this.dirPathResources);
        }

        protected void createCSSDirectory()
        {
            System.IO.Directory.CreateDirectory(this.dirPathCSS);
        }

        protected void createJSDirectory()
        {
            System.IO.Directory.CreateDirectory(this.dirPathJS);
        }

        protected void createProjectFiles()
        {
            this.createCSSFile();
            this.createJSFile();
        }

        protected void createCSSFile()
        {
            System.IO.File.Create(this.filePathCSS);
        }

        protected void createJSFile()
        {
            System.IO.File.Create(this.filePathJS);
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

        public System.Collections.ArrayList getPages(
            bool _content = true)
        {
            SqliteCommand command = new SqliteCommand();
            command.Connection = this.sqliteConnection;
            command.CommandText = Constants.database_table_page_selectall_order_by_sort_id_asc;
            SqliteDataReader dataReader = command.ExecuteReader();
            
            System.Collections.ArrayList rows = new System.Collections.ArrayList();
            System.Object[] row;
            while (dataReader.Read())
            {
                row = new System.Object[dataReader.FieldCount];
                dataReader.GetValues(row);
                rows.Add(row);
            }

            return rows;
        }

        public void createPage(
            string _pageName)
        {
            SqliteCommand command = new SqliteCommand();
            command.Connection = this.sqliteConnection;
            command.CommandText = Constants.database_table_page_insert;

            command.Parameters.AddWithValue(
                "@parent_id",
                0);
            command.Parameters.AddWithValue(
                "@sort_id",
                0);
            command.Parameters.AddWithValue(
                "@name",
                _pageName);
            command.Parameters.AddWithValue(
                "@content",
                "");
            command.ExecuteNonQuery();
        }


    }
}

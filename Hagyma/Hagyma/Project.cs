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

        protected int newSortId;

        
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

        public void close()
        {
            this.disconnect();
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

                this.insertSettings();
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
            System.IO.FileStream file = System.IO.File.Create(this.filePathCSS);
            file.Close();
        }

        protected void createJSFile()
        {
            System.IO.FileStream file = System.IO.File.Create(this.filePathJS);
            file.Close();
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

        public System.Object[] getPageById(
            int _pageId,
            bool _content = true)
        {
            SqliteCommand command = new SqliteCommand();
            command.Connection = this.sqliteConnection;
            command.CommandText = Constants.database_table_page_select_id;
            command.Parameters.AddWithValue(
                "@id",
                _pageId);
            SqliteDataReader dataReader = command.ExecuteReader();
            
            dataReader.Read();
            System.Object[] row = new System.Object[dataReader.FieldCount];
            dataReader.GetValues(row);

            return row;
        }

        public System.Object[] getPageBySortId(
            int _sortId,
            bool _content = true)
        {
            SqliteCommand command = new SqliteCommand();
            command.Connection = this.sqliteConnection;
            command.CommandText = Constants.database_table_page_select_sort_id;
            command.Parameters.AddWithValue(
                "@sort_id",
                _sortId);
            SqliteDataReader dataReader = command.ExecuteReader();

            dataReader.Read();
            System.Object[] row = new System.Object[dataReader.FieldCount];
            dataReader.GetValues(row);

            return row;
        }

        public void createPage(
            string _pageName)
        {
            this.ascertainNewSortId();

            SqliteCommand command = new SqliteCommand();
            command.Connection = this.sqliteConnection;
            command.CommandText = Constants.database_table_page_insert;

            command.Parameters.AddWithValue(
                "@parent_id",
                0);
            command.Parameters.AddWithValue(
                "@sort_id",
                this.newSortId);
            command.Parameters.AddWithValue(
                "@name",
                _pageName);
            command.Parameters.AddWithValue(
                "@content",
                "");
            command.ExecuteNonQuery();
        }

        public void renamePage(
            string _newPageName,
            int _pageID)
        {
            // Get old sort id.
            System.Object[] row = this.getPageById(
                _pageID);
            int sortId = int.Parse(
                row.GetValue(2).ToString());

            SqliteCommand command = new SqliteCommand();
            command.Connection = this.sqliteConnection;
            command.CommandText = Constants.database_table_page_update_id;

            command.Parameters.AddWithValue(
                "@parent_id",
                0);
            command.Parameters.AddWithValue(
                "@sort_id",
                sortId);
            command.Parameters.AddWithValue(
                "@name",
                _newPageName);
            command.Parameters.AddWithValue(
                "@content",
                "");
            command.Parameters.AddWithValue(
                "@id",
                _pageID);
            command.ExecuteNonQuery();
        }

        public void deletePage(
            int _pageId)
        {
            SqliteCommand command = new SqliteCommand();
            command.Connection = this.sqliteConnection;
            command.CommandText = Constants.database_table_page_delete_id;
            command.Parameters.AddWithValue(
                "@id",
                _pageId);

            command.ExecuteNonQuery();

            // Reassign sort ids.  Start from 0 and count up.
            this.reassignSortIds();
        }

        protected void reassignSortIds()
        {
            int currentSortId = 1;
            System.Collections.ArrayList pages = this.getPages();
            foreach (System.Object[] page in pages)
            {
                int id = int.Parse(page.GetValue(0).ToString());
                int parent_id = int.Parse(page.GetValue(1).ToString());                
                string name = page.GetValue(3).ToString();
                string content = page.GetValue(4).ToString();

                SqliteCommand command = new SqliteCommand();
                command.Connection = this.sqliteConnection;
                command.CommandText = Constants.database_table_page_update_id;
                command.Parameters.AddWithValue(
                    "@id",
                    id);
                command.Parameters.AddWithValue(
                    "@parent_id",
                    parent_id);
                command.Parameters.AddWithValue(
                    "@sort_id",
                    currentSortId);
                command.Parameters.AddWithValue(
                    "@name",
                    name);
                command.Parameters.AddWithValue(
                    "@content",
                    content);

                command.ExecuteNonQuery();

                currentSortId++;
            }
        }

        public void movePageUp(
            int _pageId)
        {
            // Get selected page.
            System.Object[] selectedPage = this.getSelectedPage(
                _pageId);

            // Get previous page.
            System.Object[] previousPage = this.getPreviousPage(
                _pageId);

            // Reverse sort ids.
            this.reverseSortIds(
                int.Parse(
                    selectedPage.GetValue(0).ToString()),
                int.Parse(
                    previousPage.GetValue(2).ToString()),
                int.Parse(
                    previousPage.GetValue(0).ToString()),
                int.Parse(
                    selectedPage.GetValue(2).ToString()));
        }

        public void movePageDown(
            int _pageId)
        {
            // Get selected page.
            System.Object[] selectedPage = this.getSelectedPage(
                _pageId);

            // Get next page.
            System.Object[] nextPage = this.getNextPage(
                _pageId);

            // Reverse sort ids.
            this.reverseSortIds(
                int.Parse(
                    nextPage.GetValue(0).ToString()),
                int.Parse(
                    selectedPage.GetValue(2).ToString()),
                int.Parse(
                    selectedPage.GetValue(0).ToString()),
                int.Parse(
                    nextPage.GetValue(2).ToString()));
        }

        public void reverseSortIds(
            int _selectedPageId,
            int _selectedPageNewSortId,
            int _otherPageId,
            int _otherPageNewSortId)
        {
            SqliteCommand command;

            command = new SqliteCommand();
            command.Connection = this.sqliteConnection;
            command.CommandText = Constants.database_table_page_update_sort_id_by_id;
            command.Parameters.AddWithValue(
                "@id",
                _selectedPageId);
            command.Parameters.AddWithValue(
                "@sort_id",
                _selectedPageNewSortId);
            command.ExecuteNonQuery();

            command = new SqliteCommand();
            command.Connection = this.sqliteConnection;
            command.CommandText = Constants.database_table_page_update_sort_id_by_id;
            command.Parameters.AddWithValue(
                "@id",
                _otherPageId);
            command.Parameters.AddWithValue(
                "@sort_id",
                _otherPageNewSortId);
            command.ExecuteNonQuery();
        }

        protected void ascertainNewSortId()
        {
            int nPages = this.countPages();
            nPages++;
            this.newSortId = nPages;
        }

        protected System.Object[] getSelectedPage(
            int _pageId)
        {
            return this.getPageById(
                _pageId);
        }

        protected System.Object[] getPreviousPage(
            int _pageId)
        {
            int sortId = int.Parse(
                this.getPageById(                
                    _pageId).GetValue(2).ToString());

            return this.getPageBySortId(
                sortId - 1);
        }

        protected System.Object[] getNextPage(
            int _pageId)
        {
            int sortId = int.Parse(
                this.getPageById(
                    _pageId).GetValue(2).ToString());

            return this.getPageBySortId(
                sortId + 1);
        }

        protected int countPages()
        {
            return this.getPages().Count;
        }

        public string loadCSS()
        {
            return System.IO.File.ReadAllText(
                this.filePathCSS,
                new System.Text.UTF8Encoding());
        }

        public void writeCSS(
            string _css)
        {
            System.IO.File.WriteAllText(
                this.filePathCSS,
                _css);
        }

        public string loadJS()
        {
            return System.IO.File.ReadAllText(
                this.filePathJS,
                new System.Text.UTF8Encoding());
        }

        public void writeJS(
            string _js)
        {
            System.IO.File.WriteAllText(
                this.filePathJS,
                _js);
        }

        public void updatePageContent(
            int _pageId,
            string _content)
        {
            SqliteCommand command = new SqliteCommand();
            command.Connection = this.sqliteConnection;
            command.CommandText = Constants.database_table_page_update_content_by_id;
            command.Parameters.AddWithValue(
                "@id",
                _pageId);
            command.Parameters.AddWithValue(
                "@content",
                _content);
            command.ExecuteNonQuery();
        }

        public void copyFile(
            string _filePath)
        {
            string fileName = System.IO.Path.GetFileName(
                _filePath);

            string destpath = System.IO.Path.Combine(
                this.dirPathResources,
                fileName);

            System.IO.File.Copy(
                _filePath,
                destpath,
                true);
        }

        public System.Object[] getFiles()
        {
            IEnumerable<string> fileList = System.IO.Directory.GetFiles(
                this.dirPathResources).Select(System.IO.Path.GetFileName);

            IEnumerator<string> fileListEnumerator = fileList.GetEnumerator();

            System.Object[] files = new System.Object[fileList.Count()];

            int count = 0;
            while (fileListEnumerator.MoveNext())
            {
                files[count] = fileListEnumerator.Current;
                count++;
            }

            return files;
        }

        public void deleteFile(
            string _fileName)
        {
            string filePath = System.IO.Path.Combine(
                this.dirPathResources,
                _fileName);
            System.IO.File.Delete(
                filePath);
        }

        public void writeSettings(
            Settings _settings)
        {
            this.updateSettings(
                _settings);
        }

        public Settings readSettings()
        {
            SqliteCommand command = new SqliteCommand();
            command.Connection = this.sqliteConnection;
            command.CommandText = Constants.database_table_settings_read;
            SqliteDataReader dataReader = command.ExecuteReader();
            System.Object[] values = new System.Object[dataReader.FieldCount];
            dataReader.Read();
            dataReader.GetValues(values);

            Settings settings = new Settings();
            settings.projectName = values.GetValue(0).ToString();
            settings.testServerHostname = values.GetValue(1).ToString();
            settings.testServerPort = int.Parse(values.GetValue(2).ToString());
            settings.ftpServerAddress = values.GetValue(3).ToString();
            settings.ftpServerPort = int.Parse(values.GetValue(4).ToString());
            settings.ftpServerBaseDir = values.GetValue(5).ToString();
            settings.ftpServerUsername = values.GetValue(6).ToString();
            settings.ftpServerPassword = values.GetValue(7).ToString();

            int force = int.Parse(values.GetValue(8).ToString());
            settings.ftpForceCompleteUpload = System.Convert.ToBoolean(force);

            return settings;
        }

        protected void insertSettings()
        {
            SqliteCommand command = new SqliteCommand();
            command.Connection = this.sqliteConnection;
            command.CommandText = Constants.database_table_settings_insert;
            
            command.Parameters.AddWithValue(
                "@project_name",
                "");            
            command.Parameters.AddWithValue(
                "@test_server_hostname",
                "localhost");
            command.Parameters.AddWithValue(
                "@test_server_port",
                8080);
            command.Parameters.AddWithValue(
                "@ftp_server_address",
                "");
            command.Parameters.AddWithValue(
                "@ftp_server_port",
                20);
            command.Parameters.AddWithValue(
                "@ftp_server_base_dir",
                "");
            command.Parameters.AddWithValue(
                "@ftp_server_username",
                "");
            command.Parameters.AddWithValue(
                "@ftp_server_password",
                "");
            command.Parameters.AddWithValue(
                "@ftp_force_complete_upload",
                false);

            command.ExecuteNonQuery();
        }

        protected void updateSettings(
            Settings _settings)
        {
            SqliteCommand command = new SqliteCommand();
            command.Connection = this.sqliteConnection;
            command.CommandText = Constants.database_table_settings_update;
            command.Parameters.AddWithValue(
                "@project_name",
                _settings.projectName);
            command.Parameters.AddWithValue(
                "@test_server_hostname",
                _settings.testServerHostname);
            command.Parameters.AddWithValue(
                "@test_server_port",
                _settings.testServerPort);
            command.Parameters.AddWithValue(
                "@ftp_server_address",
                _settings.ftpServerAddress);
            command.Parameters.AddWithValue(
                "@ftp_server_port",
                _settings.ftpServerPort);
            command.Parameters.AddWithValue(
                "@ftp_server_base_dir",
                _settings.ftpServerBaseDir);
            command.Parameters.AddWithValue(
                "@ftp_server_username",
                _settings.ftpServerUsername);
            command.Parameters.AddWithValue(
                "@ftp_server_password",
                _settings.ftpServerPassword);
            command.Parameters.AddWithValue(
                "@ftp_force_complete_upload",
                _settings.ftpForceCompleteUpload);

            command.ExecuteNonQuery();
        }

    }
}

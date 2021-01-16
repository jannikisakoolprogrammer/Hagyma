using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hagyma
{
    public class Constants
    {
        public const string database_dir = "database"; // Obsolete.
        public const string database_file = "db.sqlite";

        // Settings and queries for table "page"
        public const string database_table_page = "page";
        public const string database_table_page_create = @"
        CREATE TABLE IF NOT EXISTS page(
            id INTEGER PRIMARY KEY AUTOINCREMENT,
            parent_id INTEGER,
            sort_id INTEGER,
            name TEXT NOT NULL,
            content TEXT);";
        public const string database_table_page_insert = @"
        INSERT INTO page(
            parent_id,
            sort_id,
            name,
            content)
        VALUES(
            @parent_id,
            @sort_id,
            @name,
            @content)";
        public const string database_table_page_selectall = @"
        SELECT * FROM page;";
        public const string database_table_page_selectall_order_by_sort_id_asc = @"
        SELECT * FROM page
            ORDER BY sort_id ASC;";
        public const string database_table_page_selectall_order_by_sort_id_desc = @"
        SELECT * FROM page
            ORDER BY sort_id DESC;";
        public const string database_table_page_select_id = @"
        SELECT * FROM page
            WHERE id = @id;";
        public const string database_table_page_select_sort_id = @"
        SELECT * FROM page
            WHERE sort_id = @sort_id;";
        public const string database_table_page_select_parent_id = @"
        SELECT * FROM page
            WHERE parent_id = @parent_id;";
        public const string database_table_page_select_parent_id_order_by_sort_id_asc = @"
        SELECT * FROM page
            WHERE parent_id = @parent_id
            ORDER BY sort_id ASC;";
        public const string database_table_page_select_parent_id_order_by_sort_id_desc = @"
        SELECT * FROM page
            WHERE parent_id = @parent_id
            ORDER BY sort_id DESC;";
        public const string database_table_page_deleteall = @"
        DELETE FROM page;";
        public const string database_table_page_delete_id = @"
        DELETE FROM page
            WHERE id = @id";
        public const string database_table_page_delete_parent_Id = @"
        DELETE FROM page
            WHERE parent_id = @parent_Id;";
        public const string database_table_page_update_id = @"
        UPDATE page SET
            parent_id = @parent_id,
            name = @name,
            content = @content,
            sort_id = @sort_id
        WHERE
            id = @id;";
        public const string database_table_page_update_sort_id_by_id = @"
        UPDATE page SET
            sort_id = @sort_id
        WHERE
            id = @id;";
        public const string database_table_page_update_content_by_id = @"
        UPDATE page SET
            content = @content
        WHERE
            id = @id;";

        // Settings for table "settings"
        public const string database_table_settings = "settings";
        public const string database_table_settings_create = @"
        CREATE TABLE IF NOT EXISTS settings(
            project_name TEXT,
            test_server_hostname TEXT,
            test_server_port INTEGER,
            ftp_server_address TEXT,
            ftp_server_port INTEGER,
            ftp_server_base_dir TEXT,
            ftp_server_username TEXT,
            ftp_server_password TEXT,
            ftp_force_complete_upload INTEGER);";
        public const string database_table_settings_insert = @"
        INSERT INTO settings(
            project_name,
            test_server_hostname,
            test_server_port,
            ftp_server_address,
            ftp_server_port,
            ftp_server_base_dir,
            ftp_server_username,
            ftp_server_password,
            ftp_force_complete_upload)
        VALUES(
            @project_name,
            @test_server_hostname,
            @test_server_port,
            @ftp_server_address,
            @ftp_server_port,
            @ftp_server_base_dir,
            @ftp_server_username,
            @ftp_server_password,
            @ftp_force_complete_upload);";
        public const string database_table_settings_update = @"
        UPDATE settings SET
            project_name = @project_name,
            test_server_hostname = @test_server_hostname,
            test_server_port = @test_server_port,
            ftp_server_address = @ftp_server_address,
            ftp_server_port = @ftp_server_port,
            ftp_server_base_dir = @ftp_server_base_dir,
            ftp_server_username = @ftp_server_username,
            ftp_server_password = @ftp_server_password,
            ftp_force_complete_upload = @ftp_force_complete_upload";
        public const string database_table_settings_read = @"
        SELECT * FROM settings;";
        public const string database_table_settings_delete = @"
        DELETE FROM settings;";

        // Other constants for specific website project.
        // All projects are contained in a projects dir.
        public const string projects_dir = "projects";
        // Each project contains the following structure
        // projets/PROJECT_NAME/
        /*
         * database
         * output
         *  css
         *   css.css
         *  js
         *   js.js
         *  resources (images, files, downloads are in here.)
         *  html_page_1|html_page_2|... (Each contains a index.html file.)
         */
        public const string output_dir = "output";
        public const string css_dir = "css";
        public const string js_dir = "js";
        public const string resources_dir = "resources";
        public const string css_file = "css.css";
        public const string js_file = "js.js";
        public const string html_template = @"
        <!DOCTYPE html>
        <html>
            <head>
                <title>#TITLE#</title>
	            <meta charset='utf-8' content-type='text/html' />
		        <link rel = 'stylesheet' href='#CSS_FILE#'  type='text/css' />
                <script src='#JS_FILE#'></script>
            </head>
            <body>
                <header></header>
                <navigation>
                    #NAVIGATION#
                </navigation>
                <main>
                    #CONTENT#
                </main>
            </body>
        </html>";
        public const string html_file = "template.html";

        public const string comparison_file = "comparison.txt";
    }
}
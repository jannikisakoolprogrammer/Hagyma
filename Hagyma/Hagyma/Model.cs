using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hagyma
{
    public class Model
    {
        protected string projectToCreatePath;
        protected string projectsDirPath;
        protected string projectName;

        protected string[] projects;

        protected Project project;

        protected string css;
        protected string js;

        protected Dictionary<int, Page> tempPages;

        public Model(Project _project = null)
        {
            this.project = _project;

            this.projectsDirPath = System.IO.Path.Combine(
                System.IO.Directory.GetCurrentDirectory(),
                Constants.projects_dir);

            // Get list of all projects that exist in the "project" directory.
            this.loadExistingProjects();

            this.tempPages = new Dictionary<int, Page>();
        }

        public Project getProject()
        {
            return this.project;
        }

        public void setProject(Project _project)
        {
            this.project = _project;
        }

        public void createProject(string _projectToCreatePath)
        {
            this.project = Project.NewProject(_projectToCreatePath);
        }

        protected void loadExistingProjects()
        {
            this.projects = System.IO.Directory.GetDirectories(this.projectsDirPath);
        }

        public string[] getProjects()
        {
            return this.projects;
        }

        public void openProject(string _projectToOpenPath)
        {
            this.project = Project.OpenProject(_projectToOpenPath);
        }

        public void createNewPage(
            string _pageName)
        {
            this.project.createPage(
                _pageName);
        }

        public void renamePage(
            string _newPageName,
            int _pageID)
        {
            this.project.renamePage(
                _newPageName,
                _pageID);
        }

        public void deletePage(
            int _pageId)
        {
            this.project.deletePage(
                _pageId);
        }

        public void movePageUp(
            int _pageId)
        {
            this.project.movePageUp(
                _pageId);
        }

        public void movePageDown(
            int _pageId)
        {
            this.project.movePageDown(
                _pageId);
        }

        public void closeProject()
        {
            this.project.close();
            this.project = null;
        }

        public void loadCSS()
        {
            this.css = this.project.loadCSS();
        }

        public string getCSS()
        {
            return this.css;
        }

        public void setCSS(
            string _css)
        {
            this.css = _css;
        }

        public void writeCSS()
        {
            this.project.writeCSS(
                this.css);
        }

        public void loadJS()
        {
            this.js = this.project.loadJS();
        }

        public string getJS()
        {
            return this.js;
        }

        public void setJS(
            string _js)
        {
            this.js = _js;
        }

        public void writeJS()
        {
            this.project.writeJS(
                this.js);
        }

        public string loadPage(
            int _pageId)
        {
            // Load page from db if not already loaded.
            bool result;

            result = this.isPageAlreadyLoaded(
                _pageId);

            if (result == false)
            {
                // Load from db, and write in tempPages first.
                string content = this.getPageContent(
                    _pageId);

                Page page = new Page(
                    _pageId,
                    content);

                tempPages.Add(
                    _pageId,
                    page);
            }

            // Now load from tempPages.
            return tempPages[_pageId].getContent();
        }

        public bool isPageAlreadyLoaded(
            int _pageId)
        {
            return tempPages.ContainsKey(
                _pageId);
        }

        public string getPageContent(
            int _pageId)
        {
            return this.getProject().getPageById(
                _pageId).GetValue(4).ToString();
        }

        public void updateTempPageContent(
            int _pageId,
            string _content)
        {
            bool result = this.isPageAlreadyLoaded(
                _pageId);

            if (result == true)
            {
                Page page = tempPages[_pageId];
                page.setContent(_content);
                tempPages[_pageId] = page;
            }
        }

        public void writeTempPageContent(
            int _pageId)
        {
            bool result = this.isPageAlreadyLoaded(
                _pageId);

            if (result == true)
            {
                Page page = tempPages[_pageId];
                this.getProject().updatePageContent(
                    page.getId(),
                    page.getContent());
            }
        }

        public void syncTempPagesWithDBPages()
        {
            System.Collections.ArrayList dbPages = this.getProject().getPages();
            int[] idPagesDB = new int[dbPages.Count];
            foreach (System.Object[] page in dbPages)
            {
                idPagesDB.Append(int.Parse(
                        page.GetValue(0).ToString()));
            }

            int[] idTempPages = new int[this.tempPages.Count];
            foreach (KeyValuePair<int, Page> entry in this.tempPages)
            {
                idTempPages.Append(entry.Key);
            }

            System.Collections.Generic.IEnumerable<int> pagesToDelete = idTempPages.Except(idPagesDB);

            foreach (int id in pagesToDelete)
            {
                this.tempPages.Remove(id);
            }
        }

        public void copyFile(
            string _filePath)
        {
            this.getProject().copyFile(
                _filePath);
        }

        public System.Object[] getFileList()
        {
            System.Object[] files =
                this.getProject().getFiles();
            return files;
        }

        public void deleteFile(
            string _fileName)
        {
            this.getProject().deleteFile(
                _fileName);
        }

        public void writeSettings(
            Settings _settings)
        {
            this.getProject().writeSettings(
                _settings);
        }

        public Settings readSettings()
        {
            return this.getProject().readSettings();
        }

        public void generate()
        {
            this.getProject().generate();
        }
    }
}

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

        public Model(Project _project = null)
        {
            this.project = _project;

            this.projectsDirPath = System.IO.Path.Combine(
                System.IO.Directory.GetCurrentDirectory(),
                Constants.projects_dir);

            // Get list of all projects that exist in the "project" directory.
            this.loadExistingProjects();
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
            // Open CSS file for reading.
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
    }
}

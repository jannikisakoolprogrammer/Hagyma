using System;
using System.Collections.Generic;
using System.Text;

namespace Hagyma
{
    public class OpenProjectModel : Model
    {
        protected string projectToCreatePath;
        protected string projectsDirPath;
        protected string projectName;

        protected string[] projects;

        public OpenProjectModel(Project _project = null)
            : base(_project)
        {
            this.projectsDirPath = System.IO.Path.Combine(
                System.IO.Directory.GetCurrentDirectory(),
                Constants.projects_dir);

            // Get list of all projects that exist in the "project" directory.
            this.loadExistingProjects();
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
    }
}

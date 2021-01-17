using System;
using System.Collections.Generic;
using System.Text;

namespace Hagyma
{
    class Startup
    {
        public static void CreateProjectsDirectory()
        {
            string currentWorkingDirectory = System.IO.Directory.GetCurrentDirectory();
            string projectsPath = System.IO.Path.Combine(
                currentWorkingDirectory,
                Constants.projects_dir);

            System.IO.Directory.CreateDirectory(projectsPath);
        }
    }
}

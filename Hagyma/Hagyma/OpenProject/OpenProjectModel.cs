using System;
using System.Collections.Generic;
using System.Text;

namespace Hagyma
{
    public class OpenProjectModel : Model
    {

        public OpenProjectModel(Project _project = null)
            : base(_project)
        {
            // Get list of all projects that exist in the "project" directory.
            this.loadExistingProjects();
        }

        public void loadExistingProjects()
        { 

        }
    }
}

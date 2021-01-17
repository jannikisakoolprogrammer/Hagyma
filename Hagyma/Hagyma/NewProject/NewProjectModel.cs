using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hagyma
{
    public class NewProjectModel : Model
    {
        public NewProjectModel(Project _project = null) :
            base(_project)
        {
        }

        public void createProject(string _projectToCreatePath)
        {
            this.project = Project.NewProject(_projectToCreatePath);
        }
    }
}

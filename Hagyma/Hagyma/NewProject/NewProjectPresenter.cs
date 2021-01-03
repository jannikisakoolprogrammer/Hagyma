using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hagyma
{
    public class NewProjectPresenter : Presenter
    {
        protected NewProjectView newProjectView;
        protected NewProjectModel newProjectModel;

        public NewProjectPresenter(Presenter _parentPresenter) :
            base(_parentPresenter)
        {
            this.newProjectView = new NewProjectView();
            this.newProjectModel = new NewProjectModel();

            // Connect eventhandlers here.
        }

        public void run()
        {
            this.newProjectView.ShowDialog();
        }
    }
}

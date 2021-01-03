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

        protected string project_name;

        public NewProjectPresenter(Presenter _parentPresenter) :
            base(_parentPresenter)
        {
            this.newProjectView = new NewProjectView();
            this.newProjectModel = new NewProjectModel();

            // Connect eventhandlers here.
            this.newProjectView.buttonOkClicked += this.on_buttonOkClicked;
        }

        public void run()
        {
            this.newProjectView.ShowDialog();
        }

        public void on_buttonOkClicked(
            Object _sender,
            EventArgs _eventArgs)
        {
            // Fetch user input.
            this.project_name = this.newProjectView.getTextBoxNewProject().Text;
            // Validate user input
            this.validateProjectName();
            // Make sure project with the same name does not yet exist.
            // TODO
            // Create project.
        }

        protected void validateProjectName()
        {
        }
    }
}

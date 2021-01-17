using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hagyma
{
    public class OpenProjectPresenter : Presenter
    {
        protected OpenProjectView openProjectView;

        protected string projectToOpenPath;
        protected string projectsDirPath;
        protected string projectName;

        public OpenProjectPresenter(Presenter _parentPresenter)
            : base(_parentPresenter)
        {
            this.openProjectView = new OpenProjectView();
            this.model = new OpenProjectModel();

            // Connect eventhandlers here.
            this.openProjectView.buttonOkClicked += this.on_buttonOkClicked;
            this.openProjectView.buttonCancelClicked += this.on_buttonCancelClicked;

            // Fill combobox.
            this.openProjectView.comboBoxSetProjects(this.model.getProjects());
        }

        public void run()
        {
            this.openProjectView.ShowDialog();
        }

        public void on_buttonOkClicked(
            object _sender,
            EventArgs _e)
        {
            // Create project.
            this.projectToOpenPath = this.openProjectView.getSelectedProjectPath();
            this.model.openProject(this.projectToOpenPath);

            // Close dialog.
            this.openProjectView.Hide();
        }

        public void on_buttonCancelClicked(
            object _sender,
            EventArgs _e)
        {
            this.openProjectView.Hide();
        }
        /*
        public Project getProject()
        {
            return this.openProjectModel.getProject();
        }
        */
    }
}

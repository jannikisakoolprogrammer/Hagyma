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

        protected string projectToCreatePath;
        protected string projectsDirPath;
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
            bool result = true;

            // Fetch user input.
            this.project_name = this.newProjectView.getTextBoxNewProject().Text;

            this.projectsDirPath = System.IO.Path.Combine(
                System.IO.Directory.GetCurrentDirectory(),
                Constants.projects_dir);

            this.projectToCreatePath = System.IO.Path.Combine(
                this.projectsDirPath,
                this.project_name);

            // Validate user input
            result = this.validateProjectName();
            if (result == false)
            {
                return;
            }

            // Make sure project with the same name does not yet exist.
            result = this.validateProjectNotExists();
            if (result == false)
            {
                return;
            }

            // Close dialog.
            this.newProjectView.Hide();

            // Create project.
            Project.NewProject(this.projectToCreatePath);
        }

        protected bool validateProjectName()
        {
            if (this.project_name == "")
            {
                System.Windows.Forms.MessageBox.Show(
                    "Kérem szépen írj egy projektnevet.",
                    "Hiba");
                return false;
            }
            else
            {
                return true;
            }
        }

        protected bool validateProjectNotExists()
        {
            // Build projects_dir path.
            string projectsDirPath = System.IO.Path.Combine(
                System.IO.Directory.GetCurrentDirectory(),
                Constants.projects_dir);

            if (System.IO.Directory.Exists(projectsDirPath) == false)
            {
                System.Windows.Forms.MessageBox.Show(
                    "Projects directory does not exist.",
                    "Hiba");
                return false;
            }

            string[] dirs = System.IO.Directory.GetDirectories(projectsDirPath);



            foreach (string d in dirs)
            {
                if (d == projectToCreatePath)
                {
                    System.Windows.Forms.MessageBox.Show(
                        "Projektet ez a név már létezik.",
                        "Hiba");
                    return false;
                }
            }
            return true;
        }
    }
}

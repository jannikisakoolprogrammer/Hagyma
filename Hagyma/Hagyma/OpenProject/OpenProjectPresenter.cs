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
        protected OpenProjectModel openProjectModel;

        protected string projectToCreatePath;
        protected string projectsDirPath;
        protected string projectName;

        public OpenProjectPresenter(Presenter _parentPresenter)
            : base(_parentPresenter)
        {
            this.openProjectView = new OpenProjectView();
            this.openProjectModel = new OpenProjectModel();

            // Connect eventhandlers here.
            //this.newProjectView.buttonOkClicked += this.on_buttonOkClicked;
            //this.newProjectView.buttonCancelClicked += this.on_buttonCancelClicked;

            // Fill combobox.
            // TODO:  Get data from model.
            System.Object[] items = new System.Object[2];
            items[0] = "Jannik";
            items[1] = "vagyok";
            this.openProjectView.comboBoxSetProjects(items);
        }

        public void run()
        {
            this.openProjectView.ShowDialog();
        }
    }
}

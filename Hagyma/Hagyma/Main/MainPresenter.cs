using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hagyma
{
    public class PresenterMain : Presenter
    {
        ViewMain view;

        public PresenterMain() : base()
        {
            this.onNoProjectLoaded();
        }

        protected override void initModel()
        {
            base.initModel();
        }

        protected override void initView()
        {
            base.initView();
            this.view = new ViewMain();
        }

        protected override void connectEventHandlers()
        {
            base.connectEventHandlers();

            this.view.newProjectClicked += this.on_newProjectToolStripMenuItem_Click;
            this.view.openProjectClicked += this.on_openProjectToolStripMenuItem_Click;
            this.view.closeProjectClicked += this.on_closeProjectToolStripMenuItem_Click;
            this.view.quitClicked += this.on_quit_Click;

            this.view.pageTreeToolStripMenuItemClicked += this.on_pageTreeToolStripMenuItemClick;
        }

        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Startup.CreateProjectsDirectory();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            PresenterMain presenterMain = new PresenterMain();

            Application.Run(presenterMain.view);
        }


        public void on_newProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Show dialog to create a new project.
            NewProjectPresenter newProjectPresenter = new NewProjectPresenter(this);
            newProjectPresenter.run();

            // Set project if one was created just now.
            Project localProject = newProjectPresenter.getProject();
            if (localProject != null)
            {
                // Set project in MainModel so we can work with it later.
                this.model.setProject(localProject);
                this.onProjectLoaded();
            }
        }

        public void on_openProjectToolStripMenuItem_Click(
            object _sender,
            EventArgs _e)
        {
            // Create presenter to show open project dialog and show the dialog.
            OpenProjectPresenter openProjectPresenter = new OpenProjectPresenter(this);
            openProjectPresenter.run();

            // Set project if one was opened just now.
            Project localProject = openProjectPresenter.getProject();
            if (localProject != null)
            {
                // Set project in MainModel so we can work with it later.
                this.model.setProject(localProject);
                this.onProjectLoaded();
            }
        }

        public void on_closeProjectToolStripMenuItem_Click(
            object _sender,
            EventArgs _e)
        {
            this.model.closeProject();
            if (this.model.getProject() == null)
            {
                this.onNoProjectLoaded();
            }
        }

        public void on_quit_Click(
            object _sender,
            EventArgs _e)
        {
            if (this.model.getProject() != null)
            {
                this.model.closeProject();
            }
            Application.Exit();
        }

        public void on_pageTreeToolStripMenuItemClick(
            object _sender,
            EventArgs _e)
        {
            PageTreePresenter pageTreePresenter = new PageTreePresenter(this);
            pageTreePresenter.run();
        }

        protected void onNoProjectLoaded()
        {
            this.view.enableFileMenuNewProjectItem();
            this.view.enableFileMenuOpenProjectItem();
            this.view.disableFileMenuCloseProjectItem();
        }

        protected void onProjectLoaded()
        {
            this.view.disableFileMenuNewProjectItem();
            this.view.disableFileMenuOpenProjectItem();
            this.view.enableFileMenuCloseProjectItem();
        }
    }
}

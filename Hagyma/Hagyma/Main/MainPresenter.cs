﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hagyma
{
    public class PresenterMain : Presenter
    {
        ViewMain view;

        public PresenterMain()
        {
            view = new ViewMain();
            model = new Model();
            view.newProjectClicked += this.on_newProjectToolStripMenuItem_Click;
            view.openProjectClicked += this.on_openProjectToolStripMenuItem_Click;
            view.pageTreeToolStripMenuItemClicked += this.on_pageTreeToolStripMenuItemClick;
            this.onNoProjectLoaded();
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

        public void on_pageTreeToolStripMenuItemClick(
            object _sender,
            EventArgs _e)
        {
            PageTreePresenter pageTreePresenter = new PageTreePresenter(this);
            pageTreePresenter.run();
        }

        protected void onNoProjectLoaded()
        {
            // TODO
        }

        protected void onProjectLoaded()
        {
            // TODO
        }
    }
}

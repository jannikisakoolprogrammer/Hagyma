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

        System.Collections.ArrayList pages;
        TreeNode[] treeNodesPages;

        int pageId;
        int previousPageId;

        public PresenterMain() : base()
        {
            this.onNoProjectLoaded();
            this.pageId = -1;
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

            this.view.buttonSaveCSSClicked += this.on_buttonSaveCSSClick;
            this.view.buttonSaveJSClicked += this.on_buttonSaveJSClick;

            this.view.buttonSavePageClicked += this.on_buttonSavePageClick;
            this.view.pageTreeNodeAfterClicked += this.on_pageTreeNodeAfterClick;

            this.view.filesClicked += this.on_filesClick;

            //this.view.fil
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
            // Save last page to temporary store.
            if (this.pageId != -1)
            {
                this.tempSavePage();
            }

            PageTreePresenter pageTreePresenter = new PageTreePresenter(this);
            pageTreePresenter.run();
            
            this.loadPages();
        }

        protected void onNoProjectLoaded()
        {
            this.view.enableFileMenuNewProjectItem();
            this.view.enableFileMenuOpenProjectItem();
            this.view.disableFileMenuCloseProjectItem();
            this.view.disableActionsToolStripMenuItem();
            this.view.disableButtonSaveCSS();
            this.view.disableButtonSaveJS();
            this.view.disableCopyToolStripMenuItem();
            this.view.disableCutToolStripMenuItem();
            this.view.disableDeleteToolStripMenuItem();
            this.view.disableEditToolStripMenuItem();
            this.view.disableGenerateToolStripMenuItem() ;
            this.view.disableHelpToolStripMenuItem();
            this.view.disablePageTreeToolStripMenuItem();
            this.view.disablePasteToolStripMenuItem();
            this.view.disableProjectToolStripMenuItem();
            this.view.disableSaveButtonPages();
            this.view.disableSettingsToolStripMenuItem();
            this.view.disableStartTestserverToolStripMenuItem();
            this.view.disableStopTestserverToolStripMenuItem();
            this.view.disableTabControlEditor();
            this.view.disableTextBoxCSS();
            this.view.disableTextBoxJS();
            this.view.disableTextBoxPages();
            this.view.disableTreeViewPages();
            this.view.disableUploadToolStripMenuItem();

            this.unloadView();
        }

        protected void onProjectLoaded()
        {
            this.view.disableFileMenuNewProjectItem();
            this.view.disableFileMenuOpenProjectItem();
            this.view.enableFileMenuCloseProjectItem();
            this.view.enableActionsToolStripMenuItem();
            this.view.enableButtonSaveCSS();
            this.view.enableButtonSaveJS();
            this.view.enableCopyToolStripMenuItem();
            this.view.enableCutToolStripMenuItem();
            this.view.enableDeleteToolStripMenuItem();
            this.view.enableEditToolStripMenuItem();
            this.view.enableGenerateToolStripMenuItem();
            this.view.enableHelpToolStripMenuItem();
            this.view.enablePageTreeToolStripMenuItem();
            this.view.enablePasteToolStripMenuItem();
            this.view.enableProjectToolStripMenuItem();
            this.view.enableSaveButtonPages();
            this.view.enableSettingsToolStripMenuItem();
            this.view.enableStartTestserverToolStripMenuItem();
            this.view.enableStopTestserverToolStripMenuItem();
            this.view.enableTabControlEditor();
            this.view.enableTextBoxCSS();
            this.view.enableTextBoxJS();
            this.view.enableTextBoxPages();
            this.view.enableTreeViewPages();
            this.view.enableUploadToolStripMenuItem();

            // Load pages into tree control.
            this.loadView();            
        }

        protected void loadView()
        {
            this.loadPages();
            this.loadCSS();
            this.loadJS();
        }

        protected void unloadView()
        {
            this.resetPageId();
            this.view.clearPagesTabPage();
            this.view.clearCSSTabPage();
            this.view.clearJSTabPage();
        }

        protected void loadPages()
        {
            this.resetPageId();
            this.view.clearPagesTabPage();
            this.getPageStructureData();
            this.preparePageStructureData();
            this.updatePageTree();
        }

        protected void resetPageId()
        {
            this.pageId = -1;
        }

        protected void getPageStructureData()
        {
            this.pages = this.model.getProject().getPages();
        }

        protected void preparePageStructureData()
        {
            System.Windows.Forms.TreeNode treeNode;
            this.treeNodesPages = new TreeNode[this.pages.Count];
            int counter = 0;
            foreach (System.Object[] pageData in this.pages)
            {
                treeNode = new System.Windows.Forms.TreeNode();
                treeNode.Text = pageData.GetValue(3).ToString();
                treeNode.Tag = pageData.GetValue(0);
                this.treeNodesPages[counter] = treeNode;
                counter++;
            }
        }

        protected void updatePageTree()
        {
            this.view.refreshPageTree(
                this.treeNodesPages);
        }

        protected void loadCSS()
        {
            this.model.loadCSS();
            string css = this.model.getCSS();
            this.view.displayCSS(css);
        }
        
        protected void loadJS()
        {
            this.model.loadJS();
            string js = this.model.getJS();
            this.view.displayJS(js);

        }

        protected void saveCSS()
        {
            string css = this.view.getCSS();
            this.model.setCSS(css);
            this.model.writeCSS();
        }


        protected void saveJS()
        {
            string js = this.view.getJS();
            this.model.setJS(js);
            this.model.writeJS();
        }

        public void on_buttonSaveCSSClick(
            object _sender,
            EventArgs _e)
        {
            this.saveCSS();
        }

        public void on_buttonSaveJSClick(
            object _sender,
            EventArgs _e)
        {
            this.saveJS();
        }

        public void on_pageTreeNodeAfterClick(
            object _sender,
            TreeViewEventArgs _e)
        {
            // Save previous page before we open new page.
            if (this.pageId != -1)
            {
                this.tempSavePage();
            }

            pageId = int.Parse(
                _e.Node.Tag.ToString());

            this.setPageId(
                pageId);

            this.loadPage();
        }

        protected void setPageId(
            int _pageId)
        {
            this.pageId = _pageId;
        }

        protected void loadPage()
        {
            string content = this.model.loadPage(
                this.pageId);
            this.view.textBoxPagesSetContent(
                content);
        }

        public void on_buttonSavePageClick(
            object _sender,
            EventArgs _e)
        {
            this.savePage();
        }

        protected void savePage()
        {
            string content = this.getSelectedPageContent();

            this.model.updateTempPageContent(
                this.pageId,
                content);

            this.model.writeTempPageContent(
                this.pageId);
        }

        protected string getSelectedPageContent()
        {
            return this.view.textBoxPagesGetContent();
        }

        protected void tempSavePage()
        {
            string content = this.getSelectedPageContent();
            this.model.updateTempPageContent(
                this.pageId,
                content);
        }

        public void on_filesClick(
            object _sender,
            EventArgs _e)
        {
            FilesPresenter localPresenter = new FilesPresenter(
                this);
            localPresenter.run();
        }
    }
}

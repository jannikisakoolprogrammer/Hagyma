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
        PythonWebServerProcess pythonWebServerProcess;

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
            this.view.buttonSaveHTMLTemplateClicked += this.on_buttonSaveHTMLTemplateClick;

            this.view.buttonSavePageClicked += this.on_buttonSavePageClick;
            this.view.pageTreeNodeAfterClicked += this.on_pageTreeNodeAfterClick;

            this.view.filesClicked += this.on_filesClick;
            this.view.settingsClicked += this.on_settingsClick;

            this.view.generateClicked += this.on_generateClick;
            this.view.uploadClicked += this.on_uploadClick;
            this.view.startTestServerClicked += this.on_startTestServerClick;
            this.view.stopTestServerClicked += this.on_stopTestServerClick;

            this.view.htmlMenuItemClicked += this.on_htmlMenuItemClick;

            this.view.textBoxPageKeyDown += this.on_textBoxPageKeyDownClick;
            this.view.textBoxCSSKeyDown += this.on_textBoxCSSKeyDownClick;
            this.view.textBoxJSKeyDown += this.on_textBoxJSKeyDownClick;
            this.view.textBoxHTMLTemplateKeyDown += this.on_textBoxHTMLTemplateKeyDownClick;

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

            this.view.disableButtonSaveHTMLTemplate();
            this.view.disableTextBoxHTMLTemplate();

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
            this.view.enableTabControlEditor();
            this.view.enableTextBoxCSS();
            this.view.enableTextBoxJS();
            this.view.enableTreeViewPages();
            this.view.enableUploadToolStripMenuItem();

            this.view.enableButtonSaveHTMLTemplate();
            this.view.enableTextBoxHTMLTemplate();

            // Load pages into tree control.
            this.loadView();            
        }

        protected void loadView()
        {
            this.loadPages();
            this.loadCSS();
            this.loadJS();
            this.loadHTML();
        }

        protected void unloadView()
        {
            this.resetPageId();
            this.view.clearPagesTabPage();
            this.view.clearCSSTabPage();
            this.view.clearJSTabPage();
            this.view.clearHTMLTemplateTabPage();
        }

        protected void loadPages()
        {
            this.view.disableTextBoxPages();
            System.Collections.Generic.List<int> unsavedPagesIds = this.getUnsavedPagesIds();

            this.resetPageId();
            this.view.clearPagesTabPage();
            this.getPageStructureData();
            this.preparePageStructureData();
            this.updatePageTree();

            this.setIndicatorUnsavedPages(
                unsavedPagesIds);

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

        protected void loadHTML()
        {
            this.model.loadHTML();
            string html = this.model.getHTML();
            this.view.displayHTML(
                html);
        }

        protected void saveCSS()
        {
            string css = this.view.getCSS();
            this.model.setCSS(css);
            this.model.writeCSS();
            this.view.tabPageCSSSetIndicatorSaved();
        }


        protected void saveJS()
        {
            string js = this.view.getJS();
            this.model.setJS(js);
            this.model.writeJS();
            this.view.tabPageJSSetIndicatorSaved();
        }

        protected void saveHTML()
        {
            string html = this.view.getHTML();
            this.model.setHTML(html);
            this.model.writeHTML();
            this.view.tabPageHTMLTemplateSetIndicatorSaved();
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
            this.view.enableTextBoxPages();

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
            string pageName = this.model.getPageName(
                 this.pageId);
            this.view.tabPagePagesSetIndicatorSaved(
                pageName,
                this.pageId);
            bool allPagesSaved = this.checkAllPagesSaved();
            if (allPagesSaved == true)
            {
                this.view.tabPagePageSetIndicatorAllSaved();
            }
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

        public void on_settingsClick(
            object _sender,
            EventArgs _e)
        {
            SettingsPresenter settingsPresenter = new SettingsPresenter(
                this);
            settingsPresenter.run();

        }

        public void on_generateClick(
            object _sender,
            EventArgs _e)
        {
            this.model.generate();
        }

        public void on_uploadClick(
            object _sender,
            EventArgs _e)
        {
            FTPSync ftpSync = new FTPSync(
                this.model.getProject());
            ftpSync.init();
            ftpSync.run();
        }

        public void on_startTestServerClick(
            object _sender,
            EventArgs _e)
        {
            this.pythonWebServerProcess = new PythonWebServerProcess(
                this.model.readSettings(),
                this.getProject().getOutputDirectory());
        }

        public void on_stopTestServerClick(
            object _sender,
            EventArgs _e)
        {
            this.pythonWebServerProcess.stopServer();
        }

        public void on_htmlMenuItemClick(
            object _sender,
            EventArgs _e)
        {
            HTMLView htmlView = new HTMLView();
            htmlView.setHTMLTemplate(
                this.model.getProject().getHTML());
            htmlView.Show();
        }

        public void on_buttonSaveHTMLTemplateClick(
            object _sender,
            EventArgs _e)
        {
            this.saveHTML();
        }

        public void on_textBoxPageKeyDownClick(
            object _sender,
            KeyEventArgs _e)
        {
            if (_e.Control == true)
            {
                switch (_e.KeyCode)
                {
                    case Keys.S:
                        this.savePage();
                        string pageName = this.model.getPageName(
                            this.pageId);
                        this.view.tabPagePagesSetIndicatorSaved(
                            pageName,
                            this.pageId);
                        bool allPagesSaved = this.checkAllPagesSaved();
                        if (allPagesSaved == true)
                        {
                            this.view.tabPagePageSetIndicatorAllSaved();
                        }
                        break;
                    default:
                        break;
                }
            }
            else
            {
                TreeNode treeNode = this.view.getSelectedTreeNode();
                if (treeNode.Text.Contains("*") == false)
                {
                    string pageName = this.model.getPageName(
                        this.pageId);
                    this.view.tabPagePagesSetIndicatorUnsaved(
                        pageName,
                        this.pageId);
                    this.view.tabPagePagesSetIndicatorNotAllSaved();
                }
            }
        }

        public void on_textBoxCSSKeyDownClick(
            object _sender,
            KeyEventArgs _e)
        {
            if (_e.Control == true)
            {
                switch (_e.KeyCode)
                {
                    case Keys.S:
                        this.saveCSS();
                        this.view.tabPageCSSSetIndicatorSaved();
                        break;
                    default:
                        break;
                }
            }
            else
            {
                this.view.tabPageCSSSetIndicatorUnsaved();
            }
        }

        public void on_textBoxJSKeyDownClick(
            object _sender,
            KeyEventArgs _e)
        {
            if (_e.Control == true)
            {
                switch (_e.KeyCode)
                {
                    case Keys.S:
                        this.saveJS();
                        this.view.tabPageJSSetIndicatorSaved();
                        break;
                    default:
                        break;
                }
            }
            else
            {
                this.view.tabPageJSSetIndicatorUnsaved();
            }
        }

        public void on_textBoxHTMLTemplateKeyDownClick(
            object _sender,
            KeyEventArgs _e)
        {
            if (_e.Control == true)
            {
                switch (_e.KeyCode)
                {
                    case Keys.S:
                        this.saveHTML();
                        this.view.tabPageHTMLTemplateSetIndicatorSaved();
                        break;
                    default:
                        break;
                }
            }
            else
            {
                this.view.tabPageHTMLTemplateSetIndicatorUnsaved();
            }
        }

        protected Boolean checkAllPagesSaved()
        {
            TreeNodeCollection treeNodeCollectionPage = this.view.getTreeViewPageNodes();
            System.Collections.IEnumerator treeNodeEnumerator = treeNodeCollectionPage.GetEnumerator();
            while (treeNodeEnumerator.MoveNext())
            {
                TreeNode treeNode = (TreeNode)treeNodeEnumerator.Current;
                if (treeNode.Text.Contains(
                    "*") == true)
                {
                    return false;
                }
            }
            return true;
        }

        protected System.Collections.Generic.List<int> getUnsavedPagesIds()
        {
            System.Collections.Generic.List<int> unsavedPagesIds = new System.Collections.Generic.List<int>();
            TreeNodeCollection treeNodeCollectionPage = this.view.getTreeViewPageNodes();
            System.Collections.IEnumerator treeNodeEnumerator = treeNodeCollectionPage.GetEnumerator();
            while (treeNodeEnumerator.MoveNext())
            {
                TreeNode treeNode = (TreeNode)treeNodeEnumerator.Current;
                if (treeNode.Text.Contains(
                    "*") == true)
                {
                    unsavedPagesIds.Add(
                        int.Parse(
                            treeNode.Tag.ToString()));
                }
            }
            return unsavedPagesIds;
        }

        protected void setIndicatorUnsavedPages(
            System.Collections.Generic.List<int> _unsavedPagesIds)
        {
            TreeNodeCollection treeNodeCollectionPage = this.view.getTreeViewPageNodes();
            System.Collections.IEnumerator treeNodeEnumerator = treeNodeCollectionPage.GetEnumerator();
            while (treeNodeEnumerator.MoveNext())
            {
                TreeNode treeNode = (TreeNode)treeNodeEnumerator.Current;
                int pageId = int.Parse(
                    treeNode.Tag.ToString());

                if (_unsavedPagesIds.Contains(
                    pageId) == true)
                {
                    string pageName = this.model.getPageName(
                        pageId);
                    treeNode.Text = pageName + "*";
                    this.view.tabPagePagesSetIndicatorNotAllSaved();
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hagyma
{
    public partial class ViewMain : Form, IViewMain
    {
        public event MenuItemClicked newProjectClicked;
        public event MenuItemClicked openProjectClicked;
        public event MenuItemClicked closeProjectClicked;
        public event MenuItemClicked quitClicked;

        public event MenuItemClicked pageTreeToolStripMenuItemClicked;

        public event ButtonClicked buttonSaveCSSClicked;
        public event ButtonClicked buttonSaveJSClicked;

        public ViewMain()
        {
            InitializeComponent();
        }

        public void newProjectToolStripMenuItem_Click(
            object _sender,
            EventArgs _e)
        {
            if (_sender != null)
            {
                this.newProjectClicked(
                    _sender,
                    _e);
            }
        }

        public void openProjectToolStripMenuItem_Click(
            object _sender,
            EventArgs _e)
        {
            if (_sender != null)
            {
                this.openProjectClicked(
                    _sender,
                    _e);
            }
        }

        public void closeProjectToolStripMenuItem_Click(
            object _sender,
            EventArgs _e)
        {
            if (_sender != null)
            {
                this.closeProjectClicked(
                    _sender,
                    _e);
            }
        }

        public void quitToolStripMenuItem_Click(
            object _sender,
            EventArgs _e)
        {
            if (_sender != null)
            {
                this.quitClicked(
                    _sender,
                    _e);
            }
        }

        public void pageTreeToolStripMenuItem_Click(
            object _sender,
            EventArgs _e)
        {
            if (_sender != null)
            {
                this.pageTreeToolStripMenuItemClicked(
                    _sender,
                    _e);
            }
        }

        public void enableSaveButtonPages()
        {
            this.buttonSavePage.Enabled = true;
        }
        public void disableSaveButtonPages()
        {
            this.buttonSavePage.Enabled = true;
        }
        public void enableTreeViewPages()
        {
            this.treeViewPages.Enabled = true;
        }
        public void disableTreeViewPages()
        {
            this.treeViewPages.Enabled = false;
        }

        public void enableTextBoxPages()
        {
            this.textBoxPage.Enabled = true;
        }
        public void disableTextBoxPages()
        {
            this.textBoxPage.Enabled = false;
        }
        public void enableFileMenuNewProjectItem()
        {
            this.newProjectToolStripMenuItem.Enabled = true;
        }
        public void disableFileMenuNewProjectItem()
        {
            this.newProjectToolStripMenuItem.Enabled = false;
        }
        public void enableFileMenuOpenProjectItem()
        {
            this.openProjectToolStripMenuItem.Enabled = true;
        }
        public void disableFileMenuOpenProjectItem()
        {
            this.openProjectToolStripMenuItem.Enabled = false;
        }
        public void enableFileMenuCloseProjectItem()
        {
            this.closeProjectToolStripMenuItem.Enabled = true;
        }
        public void disableFileMenuCloseProjectItem()
        {
            this.closeProjectToolStripMenuItem.Enabled = false;
        }
        public void enableEditToolStripMenuItem()
        {
            this.editToolStripMenuItem.Enabled = true;
        }
        public void disableEditToolStripMenuItem()
        {
            this.editToolStripMenuItem.Enabled = false;
        }
        public void enableCutToolStripMenuItem()
        {
            this.cutToolStripMenuItem.Enabled = true;
        }
        public void disableCutToolStripMenuItem()
        {
            this.cutToolStripMenuItem.Enabled = false;
        }

        public void enableCopyToolStripMenuItem()
        {
            this.copyToolStripMenuItem.Enabled = true;
        }
        public void disableCopyToolStripMenuItem()
        {
            this.copyToolStripMenuItem.Enabled = false;
        }
        public void enablePasteToolStripMenuItem()
        {
            this.pasteToolStripMenuItem.Enabled = false;
        }
        public void disablePasteToolStripMenuItem()
        {
            this.pasteToolStripMenuItem.Enabled = true;
        }
        public void enableDeleteToolStripMenuItem()
        {
            this.deleteToolStripMenuItem.Enabled = true;
        }
        public void disableDeleteToolStripMenuItem()
        {
            this.deleteToolStripMenuItem.Enabled = false;
        }
        public void enableProjectToolStripMenuItem()
        {
            this.projectToolStripMenuItem.Enabled = true;
        }
        public void disableProjectToolStripMenuItem()
        {
            this.projectToolStripMenuItem.Enabled = false;
        }
        public void enablePageTreeToolStripMenuItem()
        {
            this.pageTreeToolStripMenuItem.Enabled = true;
        }
        public void disablePageTreeToolStripMenuItem()
        {
            this.pageTreeToolStripMenuItem.Enabled = false;
        }
        public void enableFilesToolStripMenuItem()
        {
            this.filesToolStripMenuItem.Enabled = true;
        }
        public void disableFilesToolStripMenuItem()
        {
            this.filesToolStripMenuItem.Enabled = false;
        }
        public void enableSettingsToolStripMenuItem()
        {
            this.settingsToolStripMenuItem.Enabled = true;
        }
        public void disableSettingsToolStripMenuItem()
        {
            this.settingsToolStripMenuItem.Enabled = false;
        }
        public void enableActionsToolStripMenuItem()
        {
            this.actionsToolStripMenuItem.Enabled = true;
        }
        public void disableActionsToolStripMenuItem()
        {
            this.actionsToolStripMenuItem.Enabled = false;
        }
        public void enableGenerateToolStripMenuItem()
        {
            this.generateToolStripMenuItem.Enabled = true;
        }
        public void disableGenerateToolStripMenuItem()
        {
            this.generateToolStripMenuItem.Enabled = false;
        }
        public void enableUploadToolStripMenuItem()
        {
            this.uploadToolStripMenuItem.Enabled = true;
        }
        public void disableUploadToolStripMenuItem()
        {
            this.uploadToolStripMenuItem.Enabled = false;
        }
        public void enableStartTestserverToolStripMenuItem()
        {
            this.startTestserverToolStripMenuItem.Enabled = true;
        }
        public void disableStartTestserverToolStripMenuItem()
        {
            this.startTestserverToolStripMenuItem.Enabled = false;
        }
        public void enableStopTestserverToolStripMenuItem()
        {
            this.stopTestserverToolStripMenuItem.Enabled = true;
        }
        public void disableStopTestserverToolStripMenuItem()
        {
            this.stopTestserverToolStripMenuItem.Enabled = false;
        }
        public void enableHelpToolStripMenuItem()
        {
            this.helpToolStripMenuItem.Enabled = true;
        }
        public void disableHelpToolStripMenuItem()
        {
            this.helpToolStripMenuItem.Enabled = false;
        }
        public void enableTabControlEditor()
        {
            this.tabControlEditor.Enabled = true;
        }
        public void disableTabControlEditor()
        {
            this.tabControlEditor.Enabled = false;
        }
        public void enableTabPage1()
        {
        }
        public void disableTabPage1()
        {
        }
        public void enableTabPage2()
        {
        }
        public void disableTagPage2()
        {
        }
        public void enableButtonSaveCSS()
        {
            this.buttonSaveCSS.Enabled = true;
        }
        public void disableButtonSaveCSS()
        {
            this.buttonSaveCSS.Enabled = false;
        }
        public void enableTextBoxCSS()
        {
            this.textBoxCSS.Enabled = true;
        }
        public void disableTextBoxCSS()
        {
            this.textBoxCSS.Enabled = false;
        }
        public void enableTabPage3()
        {
        }
        public void disableTabPage3()
        {
        }
        public void enableTextBoxJS()
        {
            this.textBoxJS.Enabled = true;
        }
        public void disableTextBoxJS()
        {
            this.textBoxJS.Enabled = false;
        }
        public void enableButtonSaveJS()
        {
            this.buttonSaveJS.Enabled = true;
        }
        public void disableButtonSaveJS()
        {
            this.buttonSaveJS.Enabled = false;
        }

        public void refreshPageTree(
            TreeNode[] _pages)
        {
            this.treeViewPages.Nodes.Clear();
            this.treeViewPages.Nodes.AddRange(
                _pages);
        }

        public void displayCSS(
            string _css)
        {
            this.textBoxCSS.Clear();
            this.textBoxCSS.Text = _css;
        }

        public string getCSS()
        {
            return this.textBoxCSS.Text;
        }

        private void buttonSaveCSS_Click(
            object _sender,
            EventArgs _e)
        {
            if (_sender != null)
            {
                this.buttonSaveCSSClicked(
                    _sender,
                    _e);
            }
        }
        public void displayJS(
            string _js)
        {
            this.textBoxJS.Clear();
            this.textBoxJS.Text = _js;
        }

        public string getJS()
        {
            return this.textBoxJS.Text;
        }

        private void buttonSaveJS_Click(
            object _sender,
            EventArgs _e)
        {
            if (_sender != null)
            {
                this.buttonSaveJSClicked(
                    _sender,
                    _e);
            }
        }

        public void clearPagesTabPage()
        {
            this.treeViewPages.Nodes.Clear();
        }
        public void clearCSSTabPage()
        {
            this.textBoxCSS.Clear();
        }
        public void clearJSTabPage()
        {
            this.textBoxJS.Clear();
        }
    }
}

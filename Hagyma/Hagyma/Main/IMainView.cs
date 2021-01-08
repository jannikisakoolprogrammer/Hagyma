using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hagyma
{
    public interface IViewMain : IView
    {        
        public event MenuItemClicked newProjectClicked;
        public event MenuItemClicked openProjectClicked;
        public event MenuItemClicked closeProjectClicked;
        public event MenuItemClicked quitClicked;

        public event MenuItemClicked pageTreeToolStripMenuItemClicked;

        public event ButtonClicked buttonSaveCSSClicked;

        public void enableEditToolStripMenuItem();
        public void disableEditToolStripMenuItem();
        public void enableCutToolStripMenuItem();
        public void disableCutToolStripMenuItem();
        public void enableCopyToolStripMenuItem();
        public void disableCopyToolStripMenuItem();
        public void enablePasteToolStripMenuItem();
        public void disablePasteToolStripMenuItem();
        public void enableDeleteToolStripMenuItem();
        public void disableDeleteToolStripMenuItem();
        public void enableProjectToolStripMenuItem();
        public void disableProjectToolStripMenuItem();
        public void enablePageTreeToolStripMenuItem();
        public void disablePageTreeToolStripMenuItem();
        public void enableFilesToolStripMenuItem();
        public void disableFilesToolStripMenuItem();
        public void enableSettingsToolStripMenuItem();
        public void disableSettingsToolStripMenuItem();
        public void enableActionsToolStripMenuItem();
        public void disableActionsToolStripMenuItem();
        public void enableGenerateToolStripMenuItem();
        public void disableGenerateToolStripMenuItem();
        public void enableUploadToolStripMenuItem();
        public void disableUploadToolStripMenuItem();
        public void enableStartTestserverToolStripMenuItem();
        public void disableStartTestserverToolStripMenuItem();
        public void enableStopTestserverToolStripMenuItem();
        public void disableStopTestserverToolStripMenuItem();
        public void enableHelpToolStripMenuItem();
        public void disableHelpToolStripMenuItem();
        public void enableTabControlEditor();
        public void disableTabControlEditor();
        public void enableTabPage1();
        public void disableTabPage1();
        public void enableTabPage2();
        public void disableTagPage2();
        public void enableButtonSaveCSS();
        public void disableButtonSaveCSS();
        public void enableTextBoxCSS();
        public void disableTextBoxCSS();
        public void enableTabPage3();
        public void disableTabPage3();
        public void enableTextBoxJS();
        public void disableTextBoxJS();
        public void enableButtonSaveJS();
        public void disableButtonSaveJS();
        public void enableFileMenuNewProjectItem();
        public void disableFileMenuNewProjectItem();
        public void enableFileMenuOpenProjectItem();
        public void disableFileMenuOpenProjectItem();
        public void enableFileMenuCloseProjectItem();
        public void disableFileMenuCloseProjectItem();
        public void enableSaveButtonPages();
        public void disableSaveButtonPages();
        public void enableTreeViewPages();
        public void disableTreeViewPages();
        public void enableTextBoxPages();
        public void disableTextBoxPages();
        public void refreshPageTree(
            TreeNode[] _pages);
        public void displayCSS(
            string _css);
        public string getCSS();

    }
}

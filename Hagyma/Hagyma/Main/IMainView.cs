using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hagyma
{
    public interface IViewMain : IView
    {        
        public event MenuItemClicked newProjectClicked;
        public event MenuItemClicked openProjectClicked;
        public event MenuItemClicked closeProjectClicked;
        public event MenuItemClicked quitClicked;

        public event MenuItemClicked pageTreeToolStripMenuItemClicked;

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

    }
}

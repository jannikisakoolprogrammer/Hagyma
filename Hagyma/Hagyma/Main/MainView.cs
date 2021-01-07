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
        }

        public void disableSaveButtonPages()
        {
        }

        public void enableTreeViewPages()
        {
        }

        public void disableTreeViewPages()
        {
        }

        public void enableTextBoxPages()
        {
        }

        public void disableTextBoxPages()
        {
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
    }
}

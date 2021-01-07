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
        public event ButtonClicked newProjectClicked;
        public event ButtonClicked openProjectClicked;
        public event ButtonClicked pageTreeToolStripMenuItemClicked;

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

        public void disableSaveButtonPages()
        {
        }

        public void disableTreeViewPages()
        {
        }

        public void disableTextBoxPages()
        {
        }
    }
}

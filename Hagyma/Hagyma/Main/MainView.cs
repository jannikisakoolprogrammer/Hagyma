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
        public event NewProjectClicked newProjectClicked;

        public ViewMain()
        {
            InitializeComponent();
        }

        public void newProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.newProjectClicked(sender, e);
        }

        public void test()
        {
        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}

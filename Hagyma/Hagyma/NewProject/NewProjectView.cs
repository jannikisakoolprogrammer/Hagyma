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
    public partial class NewProjectView : Form, NewProjectIView
    {
        public event ButtonOkClicked buttonOkClicked;
        public event ButtonCancelClicked buttonCancelClicked;

        public NewProjectView()
        {
            InitializeComponent();
        }

        private void buttonOk_MouseClick(object _sender, MouseEventArgs _e)
        {
            if (_sender == null)
            {
                this.buttonOkClicked(_sender, _e);
            }
        }

        public System.Windows.Forms.TextBox getTextBoxNewProject()
        {
            return this.textBoxNewProject;
        }
    }
}

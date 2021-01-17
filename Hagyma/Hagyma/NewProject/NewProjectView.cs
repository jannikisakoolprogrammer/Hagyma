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
        public event ButtonClicked buttonOkClicked;
        public event ButtonClicked buttonCancelClicked;

        public NewProjectView()
        {
            InitializeComponent();
        }

        private void buttonOk_MouseClick(object _sender, MouseEventArgs _e)
        {
            if (_sender != null)
            {
                this.buttonOkClicked(
                    _sender,
                    _e);
            }
        }

        public System.Windows.Forms.TextBox getTextBoxNewProject()
        {
            return this.textBoxNewProject;
        }

        private void buttonCancel_Click(
            object _sender,
            EventArgs _e)
        {
            if (_sender != null)
            {
                this.buttonCancelClicked(
                    _sender,
                    _e);
            }
        }
    }
}

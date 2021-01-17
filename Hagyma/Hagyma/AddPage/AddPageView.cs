using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Hagyma
{
    public partial class AddPageView : Form, AddPageIView
    {
        public event ButtonClicked buttonOkClicked;
        public event ButtonClicked buttonCancelClicked;

        public AddPageView()
        {
            InitializeComponent();
        }

        public string getEnteredPageName()
        {
            return this.textBoxPagename.Text;
        }

        private void buttonOk_Click(
            object _sender,
            EventArgs _e)
        {
            this.Hide();
        }

        private void buttonCancel_Click(
            object _sender,
            EventArgs _e)
        {
            this.Hide();
        }
    }
}

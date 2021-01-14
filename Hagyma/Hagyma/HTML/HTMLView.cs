using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Hagyma
{
    public partial class HTMLView : Form, HTMLIView
    {
        public HTMLView()
        {
            InitializeComponent();
        }

        public void setHTMLTemplate(
            string _htmlTemplate)
        {
            this.textBoxHTML.Text = _htmlTemplate;
        }
    }
}

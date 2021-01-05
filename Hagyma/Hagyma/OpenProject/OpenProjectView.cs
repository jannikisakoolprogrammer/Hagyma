using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Hagyma
{
    public partial class OpenProjectView : Form, OpenProjectIView
    {
        public event ButtonClicked buttonOkClicked;
        public event ButtonClicked buttonCancelClicked;

        public OpenProjectView()
        {
            InitializeComponent();
        }

        public void comboBoxSetProjects(System.Object[] _items)
        {
            this.comboBoxProjects.Items.AddRange(_items);
        }
    }
}

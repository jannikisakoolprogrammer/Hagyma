using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Hagyma
{
    public partial class FilesView : Form, FilesIView
    {
        public event ButtonClicked buttonImportClicked;
        public event ButtonClicked buttonDeleteClicked;

        public FilesView()
        {
            InitializeComponent();
        }

        public void listBoxFilesRefresh(
            System.Object[] _elements)
        {
            this.listBoxFiles.Items.Clear();
            this.listBoxFiles.Items.AddRange(
                _elements);
        }

        private void buttonImport_MouseClick(
            object _sender,
            MouseEventArgs _e)
        {
            if (_sender != null)
            {
                this.buttonImportClicked(
                    _sender,
                    _e);
            }
        }

        private void buttonImport_Click(
            object _sender,
            EventArgs _e)
        {
            if (_sender != null)
            {
                this.buttonDeleteClicked(
                    _sender,
                    _e);
            }
        }
    }
}

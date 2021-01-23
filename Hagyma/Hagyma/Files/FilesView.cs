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

        public System.Object listBoxGetSelection()
        {
            return this.listBoxFiles.SelectedItem;
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

        private void buttonDelete_Click(
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

        private void listBoxFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            Clipboard.SetText(
                String.Format(
                    "resources/{0}",
                    this.listBoxFiles.SelectedItem.ToString()));
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Hagyma
{
    public partial class PageTreeView : Form, PageTreeIView
    {
        public event ButtonClicked buttonAddClicked;
        public event ButtonClicked buttonRenameClicked;
        public event ButtonClicked buttonDeleteClicked;
        public event ButtonClicked buttonUpClicked;
        public event ButtonClicked buttonDownClicked;
        public event FormClosed formClosed;
        public event TreeNodeClickedAfter pageTreeNodeAfterClicked;

        public PageTreeView()
        {
            InitializeComponent();
        }

        private void PageTreeView_FormClosed(
            object _sender,
            FormClosedEventArgs _e)
        {
            if (_sender != null)
            {
                this.formClosed(
                    _sender,
                    _e);
            }
        }

        public TreeNode getSelectedTreeNode()
        {
            return this.treeView1.SelectedNode;
        }

        public void refreshPageTree(
            TreeNode[] _treeNodes)
        {
            this.treeView1.Nodes.Clear();
            this.treeView1.Nodes.AddRange(_treeNodes);
        }

        private void buttonAdd_Click(
            object _sender,
            EventArgs _e)
        {
            if (_sender != null)
            {
                this.buttonAddClicked(
                    _sender,
                    _e);
            }
        }

        private void buttonRename_Click(
            object _sender,
            EventArgs _e)
        {
            if (_sender != null)
            {
                this.buttonRenameClicked(
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

        private void buttonMovePageUp_Click(
            object _sender,
            EventArgs _e)
        {
            if (_sender != null)
            {
                this.buttonUpClicked(
                    _sender,
                    _e);
            }
        }

        private void buttonMovePageDown_Click(
            object _sender,
            EventArgs _e)
        {
            if (_sender != null)
            {
                this.buttonDownClicked(
                    _sender,
                    _e);
            }
        }

        public void enableButtonAdd()
        {
            this.buttonAdd.Enabled = true;
        }
        public void enableButtonRename()
        {
            this.buttonRename.Enabled = true;
        }
        public void enableButtonDelete()
        {
            this.buttonDelete.Enabled = true;
        }
        public void enableButtonUp()
        {
            this.buttonMovePageUp.Enabled = true;
        }
        public void enableButtonDown()
        {
            this.buttonMovePageDown.Enabled = true;
        }

        public void disableButtonUp()
        {
            this.buttonMovePageUp.Enabled = false;
        }
        public void disableButtonDown()
        {
            this.buttonMovePageDown.Enabled = false;
        }

        public void TreeView1_AfterSelect_Click(
            object _sender,
            TreeViewEventArgs _e)
        {
            if (_sender != null)
            {
                this.pageTreeNodeAfterClicked(
                    _sender,
                    _e);
            }
        }
    }
}

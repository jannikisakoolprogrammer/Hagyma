using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Hagyma
{
    interface PageTreeIView : IView
    {
        public event ButtonClicked buttonAddClicked;
        public event ButtonClicked buttonRenameClicked;
        public event ButtonClicked buttonDeleteClicked;
        public event ButtonClicked buttonUpClicked;
        public event ButtonClicked buttonDownClicked;
        public event FormClosed formClosed;

        public TreeNode getSelectedTreeNode();
        public void refreshPageTree(
            TreeNode[] _treeNodes);
    }
}

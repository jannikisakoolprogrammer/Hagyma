using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Hagyma
{
    class PageTreePresenter : Presenter
    {
        public PageTreeView view;

        protected System.Collections.ArrayList pages;
        protected System.Windows.Forms.TreeNode[] treeNodes;
        public PageTreePresenter(
            Presenter _parentPresenter)
            : base(_parentPresenter)
        {
            this.view = new PageTreeView();
            this.model = new Model(
                this.parentPresenter.getProject());

            // Connect eventhandlers.
            this.view.buttonAddClicked += this.on_buttonAddClicked;
            this.view.buttonRenameClicked += this.on_buttonRenameClicked;
            this.view.buttonDeleteClicked += this.on_buttonDeleteClicked;
            this.view.buttonUpClicked += this.on_buttonUpClicked;
            this.view.buttonDownClicked += this.on_buttonDownClicked;
            this.view.formClosed += this.on_formClosed;
            this.view.pageTreeNodeAfterClicked += this.on_pageTreeNodeAfterClick;

            this.refreshView();
        }

        public void run()
        {
            this.view.ShowDialog();
        }

        protected void refreshView()
        {
            this.getPageStructureData();
            this.preparePageStructureData();
            this.updatePageTree();
        }

        protected void getPageStructureData()
        {
            this.pages = this.model.getProject().getPages();
        }

        protected void preparePageStructureData()
        {
            System.Windows.Forms.TreeNode treeNode;
            this.treeNodes = new TreeNode[this.pages.Count];
            int counter= 0;
            foreach (System.Object[] pageData in this.pages)
            {
                treeNode = new System.Windows.Forms.TreeNode();                
                treeNode.Text = pageData.GetValue(3).ToString();
                treeNode.Tag = pageData.GetValue(0);
                this.treeNodes[counter] = treeNode;
                counter++;
            }
        }

        protected void updatePageTree()
        {
            this.view.refreshPageTree(
                this.treeNodes);
        }

        protected void on_buttonAddClicked(
            object _sender,
            EventArgs _e)
        {
            // We only have a small view for such a dialog.
            AddPageView view = new AddPageView();
            view.ShowDialog();
            string enteredPageName = view.getEnteredPageName();
            if (enteredPageName != "")
            {
                bool pageExists = this.model.checkPageExists(
                    enteredPageName);
                if (pageExists == true)
                {
                    MessageBox.Show(
                        String.Format(
                            "A page with the name '{0}' already exists.  Please enter another name.",
                            enteredPageName));

                    this.on_buttonAddClicked(
                        _sender,
                        _e);
                }
                else
                {
                    this.model.createNewPage(
                        enteredPageName);

                    this.refreshView();
                }
            }
        }

        public void on_buttonRenameClicked(
            object _sender,
            EventArgs _e)
        {
            // Only a view for such a small dialog.
            EditPageView localView = new EditPageView();
            localView.buttonOkClicked += on_buttonOkClicked;
            localView.buttonCancelClicked += on_buttonCancelClicked;
            localView.setTextboxEditPageNameValue(
                this.view.getSelectedTreeNode().Text);
            object tag = this.view.getSelectedTreeNode().Tag;
            localView.setPageID(
                int.Parse(this.view.getSelectedTreeNode().Tag.ToString()));
            localView.ShowDialog();

            void on_buttonOkClicked(
                object _sender,
                EventArgs _e)
            {
                string editedPageName = localView.getTextboxEditPageNameValue();
                int pageID = localView.getPageID();

                if (editedPageName != "")
                {
                    this.model.renamePage(
                        editedPageName,
                        pageID);

                    this.refreshView();
                }

                localView.Hide();
            }

            void on_buttonCancelClicked(
                object _sender,
                EventArgs _e)
            {
                localView.Hide();
            }
        }

        public void on_buttonDeleteClicked(
            object _sender,
            EventArgs _e)
        {
            this.model.deletePage(
                int.Parse(
                    this.view.getSelectedTreeNode().Tag.ToString()));

            this.refreshView();
        }

        public void on_buttonUpClicked(
            object _sender,
            EventArgs _e)
        {
            this.model.movePageUp(
                int.Parse(
                    this.view.getSelectedTreeNode().Tag.ToString()));

            this.refreshView();
        }

        public void on_buttonDownClicked(
            object _sender,
            EventArgs _e)
        {
            this.model.movePageDown(
                int.Parse(
                    this.view.getSelectedTreeNode().Tag.ToString()));

            this.refreshView();
        }

        public void on_formClosed(
            object _sender,
            EventArgs _e)
        {
            this.model.syncTempPagesWithDBPages();

            this.view.Hide();
        }

        public void on_pageTreeNodeAfterClick(
            object _sender,
            EventArgs _e)
        {
            int selectedNodeId = int.Parse(
                this.view.getSelectedTreeNode().Tag.ToString());

            Project project = this.getProject();

            int lowestSortId = project.getLowestSortId();

            int selectedSortId = int.Parse(
                project.getPageById(
                    selectedNodeId).GetValue(2).ToString());
            int highestSortId = project.getHighestSortId();

            this.view.enableButtonAdd();
            this.view.enableButtonRename();
            this.view.enableButtonDelete();

            if (selectedSortId == lowestSortId)
            {
                this.view.disableButtonUp();
                this.view.enableButtonDown();
            }
            else if (selectedSortId == highestSortId)
            {
                this.view.disableButtonDown();
                this.view.enableButtonUp();
            }
            else
            {
                this.view.enableButtonUp();
                this.view.enableButtonDown();
            }




        }
    }
}

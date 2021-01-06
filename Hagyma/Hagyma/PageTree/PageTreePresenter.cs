using System;
using System.Collections.Generic;
using System.Text;

namespace Hagyma
{
    class PageTreePresenter : Presenter
    {
        public PageTreeView view;

        public PageTreePresenter(
            Presenter _parentPresenter)
            : base(_parentPresenter)
        {
            this.view = new PageTreeView();
            this.model = new PageTreeModel(
                this.parentPresenter.getProject());

            this.refreshView();
        }

        protected void refreshView()
        {
            this.getPageStructureData();
            this.preparePageStructureData();
            this.updatePageTree();
        }

        protected void getPageStructureData()
        {
        }

        protected void preparePageStructureData()
        {
        }

        protected void updatePageTree()
        {
        }
    }
}

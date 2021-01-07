using System;
using System.Collections.Generic;
using System.Text;

namespace Hagyma
{
    class PageTreeModel : Model
    {
        public PageTreeModel(
            Project _project)
            : base(_project)
        {
        }

        public void createNewPage(
            string _pageName)
        {
            this.project.createPage(
                _pageName);
        }
    }
}

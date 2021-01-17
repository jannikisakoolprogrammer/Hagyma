using System;
using System.Collections.Generic;
using System.Text;

namespace Hagyma
{
    interface EditPageIView
    {
        public event ButtonClicked buttonOkClicked;
        public event ButtonClicked buttonCancelClicked;

        public string getTextboxEditPageNameValue();
        public void setTextboxEditPageNameValue(string _pageName);

        public void setPageID(int _pageID);
        public int getPageID();

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Hagyma
{
    interface AddPageIView : IView
    {
        public event ButtonClicked buttonOkClicked;
        public event ButtonClicked buttonCancelClicked;

        public string getEnteredPageName();
    }
}

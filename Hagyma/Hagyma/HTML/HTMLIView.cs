using System;
using System.Collections.Generic;
using System.Text;

namespace Hagyma
{
    interface HTMLIView : IView
    {
        public void setHTMLTemplate(
            string _htmlTemplate);
    }
}

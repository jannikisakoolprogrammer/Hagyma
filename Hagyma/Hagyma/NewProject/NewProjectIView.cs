using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hagyma
{
    public delegate void ButtonOkClicked(
        object _sender,
        EventArgs _eventArgs);

    public delegate void ButtonCancelClicked(
        object _sender,
        EventArgs _eventArgs);

    public interface NewProjectIView : IView
    {
        public event ButtonOkClicked buttonOkClicked;
        public event ButtonCancelClicked buttonCancelClicked;

        public System.Windows.Forms.TextBox getTextBoxNewProject();
    }
}

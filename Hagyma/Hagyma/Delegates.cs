using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hagyma
{
    public delegate void ButtonClicked(
        object _sender,
        EventArgs _eventArgs);

    public delegate void FormClosed(
        object _sender,
        FormClosedEventArgs _e);
}
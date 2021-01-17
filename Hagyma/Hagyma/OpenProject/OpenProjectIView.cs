using System;
using System.Collections.Generic;
using System.Text;

namespace Hagyma
{
    interface OpenProjectIView : IView
    {
        public event ButtonClicked buttonOkClicked;
        public event ButtonClicked buttonCancelClicked;

        public void comboBoxSetProjects(System.Object[] _items);
    }
}

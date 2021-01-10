using System;
using System.Collections.Generic;
using System.Text;

namespace Hagyma
{
    interface FilesIView
    {
        public event ButtonClicked buttonImportClicked;
        public event ButtonClicked buttonDeleteClicked;

        public void listBoxFilesRefresh(
            System.Object[] _elements);
    }
}

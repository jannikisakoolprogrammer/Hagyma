﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hagyma
{
    public interface IViewMain : IView
    {        
        public event ButtonClicked newProjectClicked;
        public event ButtonClicked openProjectClicked;
        public event ButtonClicked pageTreeToolStripMenuItemClicked;

        public void disableSaveButtonPages();
        public void disableTreeViewPages();
        public void disableTextBoxPages();

    }
}

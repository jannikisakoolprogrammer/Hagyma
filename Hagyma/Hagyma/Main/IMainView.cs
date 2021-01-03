using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hagyma
{
    

    public interface IViewMain : IView
    {
        public delegate void NewProjectClicked(object sender, EventArgs e);
        // public event NewProjectClicked newProjectClicked;

        void test();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hagyma
{
    public class Presenter
    {
        protected Presenter parentPresenter;

        public Presenter(
            Presenter _parentPresenter = null)
        {
            this.parentPresenter = _parentPresenter;
        }
    }
}

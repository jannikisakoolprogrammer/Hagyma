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
        protected Model model;

        public Presenter(
            Presenter _parentPresenter = null)
        {
            this.parentPresenter = _parentPresenter;
        }

        public void setModel(
            Model _model)
        {
            this.model = _model;
        }

        public Project getProject()
        {
            return this.model.getProject();
        }
    }
}

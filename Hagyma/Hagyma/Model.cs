﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hagyma
{
    public class Model
    {
        protected Project project;

        public Model(Project _project = null)
        {
            this.project = _project;
        }

        public Project getProject()
        {
            return this.project;
        }

        public void setProject(Project _project)
        {
            this.project = _project;
        }
    }
}

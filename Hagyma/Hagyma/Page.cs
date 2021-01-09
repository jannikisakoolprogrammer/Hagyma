using System;
using System.Collections.Generic;
using System.Text;

namespace Hagyma
{
    public class Page
    {
        protected int id;
        protected string content;

        public Page(
            int _id,
            string _content)
        {
            this.id = _id;
            this.content = _content;
        }

        public int getId()
        {
            return this.id;
        }

        public string getContent()
        {
            return this.content;
        }

        public void setContent(
            string _content)
        {
            this.content = _content;
        }
    }
}

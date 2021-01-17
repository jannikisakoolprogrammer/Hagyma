using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Hagyma
{
    public partial class EditPageView : Form, EditPageIView
    {
        public event ButtonClicked buttonOkClicked;
        public event ButtonClicked buttonCancelClicked;

        int pageID;

        public EditPageView()
        {
            InitializeComponent();
        }

        private void buttonOk_Click(
            object _sender,
            EventArgs _e)
        {
            if (_sender != null)
            {
                this.buttonOkClicked(
                    _sender,
                    _e);
            }
        }

        public string getTextboxEditPageNameValue()
        {
            return this.textBoxEditPageName.Text;
        }

        public void setTextboxEditPageNameValue(
            string _pageName)
        {
            this.textBoxEditPageName.Text = _pageName;
        }

        public void setPageID(
            int _pageID)
        {
            this.pageID = _pageID;
        }

        public int getPageID()
        {
            return this.pageID;
        }

        private void buttonCancel_Click(
            object _sender,
            EventArgs _e)
        {
            if (_sender != null)
            {
                this.buttonCancelClicked(
                    _sender,
                    _e);
            }
        }
    }
}

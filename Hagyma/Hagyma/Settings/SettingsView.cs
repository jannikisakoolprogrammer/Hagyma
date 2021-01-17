using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Hagyma
{
    public partial class SettingsView : Form, SettingsIView
    {
        public event ButtonClicked buttonOkClicked;
        public event ButtonClicked buttonCancelClicked;

        public SettingsView()
        {
            InitializeComponent();
        }

        private void buttonOk_Click(
            object _sender,
            EventArgs _e)
        {
            this.buttonOkClicked(
                _sender,
                _e);
        }

        private void buttonCancel_Click(
            object _sender,
            EventArgs _e)
        {
            this.buttonCancelClicked(
                _sender,
                _e);
        }

        public string getProjectName()
        {
            return this.textBoxProjectName.Text;
        }

        public void setProjectName(
            string _value)
        {
            this.textBoxProjectName.Text = _value;
        }

        public string getTestServerHostname()
        {
            return this.textBoxTestServerHostname.Text;
        }

        public void setTestServerHostname(
            string _value)
        {
            this.textBoxTestServerHostname.Text = _value;
        }

        public int getTestServerPort()
        {
            return int.Parse(this.textBoxTestServerPort.Text);
        }
        public void setTestServerPort(
            int _value)
        {
            this.textBoxTestServerPort.Text = _value.ToString();
        }

        public string getFTPServerAddress()
        {
            return this.textBoxFTPServerAddress.Text;
        }

        public void setFTPServerAddress(
            string _value)
        {
            this.textBoxFTPServerAddress.Text = _value;
        }

        public int getFTPServerPort()
        {
            return int.Parse(this.textBoxFTPServerPort.Text);
        }

        public void setFTPServerPort(
            int _value)
        {
            this.textBoxFTPServerPort.Text = _value.ToString();
        }

        public string getFTPServerBaseDir()
        {
            return this.textBoxFTPServerBaseDir.Text;
        }

        public void setFTPServerBaseDir(
            string _value)
        {
            this.textBoxFTPServerBaseDir.Text = _value;
        }

        public string getFTPServerUsername()
        {
            return this.textBoxFTPServerUsername.Text;
        }

        public void setFTPServerUsername(
            string _value)
        {
            this.textBoxFTPServerUsername.Text = _value;
        }

        public string getFTPServerPassword()
        {
            return this.textBoxFTPServerPassword.Text;
        }

        public void setFTPServerPassword(
            string _value)
        {
            this.textBoxFTPServerPassword.Text = _value;
        }

        public bool getFTPForceCompleteUpload()
        {
            return this.checkBoxFTPForceCompleteUpload.Checked;
        }
        public void setFTPForceCompleteUpload(
            bool _value)
        {
            this.checkBoxFTPForceCompleteUpload.Checked = _value;
        }
    }
}

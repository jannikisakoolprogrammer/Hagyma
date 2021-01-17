using System;
using System.Collections.Generic;
using System.Text;

namespace Hagyma
{
    interface SettingsIView : IView
    {
        public event ButtonClicked buttonOkClicked;
        public event ButtonClicked buttonCancelClicked;

        public string getProjectName();
        public void setProjectName(
            string _value);

        public string getTestServerHostname();
        public void setTestServerHostname(
            string _value);

        public int getTestServerPort();
        public void setTestServerPort(
            int _value);

        public string getFTPServerAddress();
        public void setFTPServerAddress(
            string _value);

        public int getFTPServerPort();
        public void setFTPServerPort(
            int _value);

        public string getFTPServerBaseDir();
        public void setFTPServerBaseDir(
            string _value);

        public string getFTPServerUsername();
        public void setFTPServerUsername(
            string _value);

        public string getFTPServerPassword();
        public void setFTPServerPassword(
            string _value);

        public bool getFTPForceCompleteUpload();
        public void setFTPForceCompleteUpload(
            bool _value);

    }
}

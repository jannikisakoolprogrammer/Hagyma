using System;
using System.Collections.Generic;
using System.Text;

namespace Hagyma
{
    class SettingsPresenter : Presenter
    {
        public SettingsView view;

        public SettingsPresenter(
            Presenter _parentPresenter)
            : base(_parentPresenter)
        {
            this.model.setProject(
                _parentPresenter.getProject());

            Settings settings = this.model.readSettings();

            this.view.setProjectName(
                settings.projectName);
            this.view.setTestServerHostname(
                settings.testServerHostname);
            this.view.setTestServerPort(
                settings.testServerPort);
            this.view.setFTPServerAddress(
                settings.ftpServerAddress);
            this.view.setFTPServerPort(
                settings.ftpServerPort);
            this.view.setFTPServerBaseDir(
                settings.ftpServerBaseDir);
            this.view.setFTPServerUsername(
                settings.ftpServerUsername);
            this.view.setFTPServerPassword(
                settings.ftpServerPassword);
            this.view.setFTPForceCompleteUpload(
                settings.ftpForceCompleteUpload);

        }

        protected override void initView()
        {
            this.view = new SettingsView();
        }

        protected override void connectEventHandlers()
        {
            this.view.buttonOkClicked += this.on_buttonOkClick;

            this.view.buttonCancelClicked += this.on_buttonCancelClick;
        }

        public void run()
        {
            this.view.ShowDialog();
        }

        public void on_buttonOkClick(
            object _sender,
            EventArgs _e)
        {
            Settings settings = new Settings();

            settings.projectName = this.view.getProjectName();
            settings.testServerHostname = this.view.getTestServerHostname();
            settings.testServerPort = this.view.getTestServerPort();
            settings.ftpServerAddress = this.view.getFTPServerAddress();
            settings.ftpServerPort = this.view.getFTPServerPort();
            settings.ftpServerBaseDir = this.view.getFTPServerBaseDir();
            settings.ftpServerUsername = this.view.getFTPServerUsername();
            settings.ftpServerPassword = this.view.getFTPServerPassword();
            settings.ftpForceCompleteUpload = this.view.getFTPForceCompleteUpload();

            this.model.writeSettings(
                settings);

            this.view.Hide();
        }

        public void on_buttonCancelClick(
            object _sender,
            EventArgs _e)
        {
            this.view.Hide();
        }

    }
}

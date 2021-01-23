using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Hagyma
{
    class FilesPresenter : Presenter
    {
        public FilesView view;

        public FilesPresenter(
            Presenter _parentPresenter)
            : base(_parentPresenter)
        {
            this.model.setProject(
                _parentPresenter.getProject());
        }

        protected override void initView()
        {
            this.view = new FilesView();
        }

        protected override void connectEventHandlers()
        {
            this.view.buttonImportClicked += this.on_buttonImportClick;

            this.view.buttonDeleteClicked += this.on_buttonDeleteClick;
        }

        public void run()
        {
            System.Object[] fileList = this.model.getFileList();
            this.view.listBoxFilesRefresh(fileList);

            this.view.Show();
        }

        public void on_buttonImportClick(
            object _sender,
            EventArgs _e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            DialogResult dialogResult = openFileDialog.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                bool fileExists = this.model.checkFileExists(
                    openFileDialog.FileName);

                if (fileExists == true)
                {
                    MessageBox.Show(
                        String.Format(
                            "A file with the name '{0}' already exists.",
                            openFileDialog.FileName));

                    this.on_buttonImportClick(
                        _sender,
                        _e);
                }
                else
                {
                    this.model.copyFile(
                        openFileDialog.FileName);
                }
            }

            System.Object[] fileList = this.model.getFileList();
            this.view.listBoxFilesRefresh(fileList);
        }

        public void on_buttonDeleteClick(
            object _sender,
            EventArgs _e)
        {
            string fileName = this.view.listBoxGetSelection().ToString();

            this.model.deleteFile(
                fileName);

            System.Object[] fileList = this.model.getFileList();
            this.view.listBoxFilesRefresh(fileList);
        }
    }
}

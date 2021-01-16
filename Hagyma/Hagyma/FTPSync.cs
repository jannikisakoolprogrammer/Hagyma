using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;
using System.Net;

namespace Hagyma
{
    class FTPSync
    {
        Project project;
        System.Net.FtpWebRequest ftpRequest;

        string ftpServerAddress;
        string ftpServerBaseDir;
        string ftpServerUsername;
        string ftpServerPassword;

        public FTPSync(
            Project _project)
        {
            this.project = _project;
        }

        public void init()
        {
            this.ftpServerAddress = this.project.getFTPServerAddress();
            this.ftpServerBaseDir = this.project.getFTPServerBaseDir();
            this.ftpServerUsername = this.project.getFTPServerUsername();
            this.ftpServerPassword = this.project.getFTPServerPassword();
        }

        public void run()
        {
            this.connect();
            this.syncDir(
                this.project.getOutputDirectory());
            this.listDir();
            this.disconnect();
        }

        protected void connect()
        {
            this.ftpRequest = (FtpWebRequest)WebRequest.Create(
                String.Format(
                    "ftp://{0}",
                    this.ftpServerAddress));

            this.ftpRequest.Credentials = new NetworkCredential(
                this.ftpServerUsername,
                this.ftpServerPassword);

            this.ftpRequest.KeepAlive = true;
        }

        protected void listDir()
        {
            this.ftpRequest.Method = System.Net.WebRequestMethods.Ftp.ListDirectory;
            System.Net.FtpWebResponse response = (FtpWebResponse)this.ftpRequest.GetResponse();
            System.IO.Stream stream = response.GetResponseStream();
            System.IO.StreamReader sr = new System.IO.StreamReader(
                stream);
            string contents = sr.ReadToEnd();
            sr.Close();
            response.Close();
        }

        protected void disconnect()
        {
            this.ftpRequest = null;
        }

        protected void syncDir(
            string _dirPath)
        {
            string comparisonFilePath = this.createComparisionFile(
                _dirPath);

            // Fetch remote comparision file from FTP and save as "comparison_ftp.txt".
            // If it does not exist, upload all.
            // Convert both comparision files to dictionaries.
            // Get dictionary of files to be added or updated.
            // Get dictionary of files to be deleted.
            // Upload all files to be added or updated.
            // Delete all files to be deleted.
        }

        protected string createComparisionFile(
            string _dirPath)
        {
            string comparisonFilePath = System.IO.Path.Combine(
                _dirPath,
                Constants.comparison_file);

            System.IO.FileStream comparisonFile = System.IO.File.Create(
                comparisonFilePath);
            comparisonFile.Close();

            this.updateComparisonFile(
                _dirPath,
                comparisonFilePath);

            return comparisonFilePath;
        }

        protected void updateComparisonFile(
            string _dirPath,
            string _comparisonFilePath)
        {
            string[] files = System.IO.Directory.GetFiles(
                _dirPath,
                "",
                System.IO.SearchOption.TopDirectoryOnly);

            SHA256 mySHA256 = SHA256.Create();

            System.IO.StreamWriter sw = new System.IO.StreamWriter(
                _comparisonFilePath);

            foreach (string file in files)
            {
                string fileName = System.IO.Path.GetFileName(file);
                if (fileName == Constants.comparison_file)
                {
                    continue; // Ignore "comparison.txt".
                }
                else
                {
                    System.IO.FileStream fs = System.IO.File.OpenRead(
                        file);
                    fs.Position = 0;
                    byte[] hashValue = mySHA256.ComputeHash(
                        fs);

                    string hashValueString = Convert.ToBase64String(hashValue);

                    sw.WriteLine(
                        String.Format(
                            "{0}|{1}",
                            file,
                            hashValueString));
                }
            }

            sw.Close();
        }
    }
}

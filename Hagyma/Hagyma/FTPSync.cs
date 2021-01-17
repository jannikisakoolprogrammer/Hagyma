using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;
using System.Net;
using FluentFTP;


namespace Hagyma
{
    class FTPSync
    {
        Project project;
        FtpClient ftpClient;

        string outputDirectory;
        string cssDirectory;
        string jsDirectory;
        string resourcesDirectory;

        string remoteOutputDirectory;
        string remoteJSDirectory;
        string remoteResourcesDirectory;
        string remoteCSSDirectory;

        string ftpServerAddress;
        string ftpServerBaseDir;
        string ftpServerUsername;
        string ftpServerPassword;
        bool ftpForceCompleteUpload;

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
            this.ftpForceCompleteUpload = this.project.getFTPForceCompleteUpload();

            this.outputDirectory = this.project.getOutputDirectory();
            this.cssDirectory = this.project.getCSSDirectory();
            this.jsDirectory = this.project.getJSDirectory();
            this.resourcesDirectory = this.project.getResourcesDirectory();

            this.remoteOutputDirectory = System.IO.Path.Combine(
                "/",
                this.ftpServerBaseDir);

            this.remoteJSDirectory = System.IO.Path.Combine(
                this.remoteOutputDirectory,
                Constants.js_dir);

            this.remoteCSSDirectory = System.IO.Path.Combine(
                this.remoteOutputDirectory,
                Constants.css_dir);

            this.remoteResourcesDirectory = System.IO.Path.Combine(
                this.remoteOutputDirectory,
                Constants.resources_dir);

        }

        public void run()
        {
            this.connect();

            this.syncDir(
                this.outputDirectory,
                this.remoteOutputDirectory);

            if (!this.ftpClient.DirectoryExists(
                this.remoteCSSDirectory))
            {
                this.ftpClient.CreateDirectory(
                    this.remoteCSSDirectory);
            }
            this.syncDir(
                this.cssDirectory,
                this.remoteCSSDirectory);

            if (!this.ftpClient.DirectoryExists(
                this.remoteJSDirectory))
            {
                this.ftpClient.CreateDirectory(
                    this.remoteJSDirectory);
            }
            this.syncDir(
                this.jsDirectory,
                this.remoteJSDirectory);

            if (!this.ftpClient.DirectoryExists(
                this.remoteResourcesDirectory))
            {
                this.ftpClient.CreateDirectory(
                    this.remoteResourcesDirectory);
            }
            this.syncDir(
                this.resourcesDirectory,
                this.remoteResourcesDirectory);

            this.disconnect();
        }

        protected void connect()
        {
            this.ftpClient = new FtpClient(
                this.ftpServerAddress);

            this.ftpClient.Credentials = new NetworkCredential(
                this.ftpServerUsername,
                this.ftpServerPassword);

            this.ftpClient.Connect();
        }

        protected void disconnect()
        {
            this.ftpClient.Disconnect();
        }

        protected void syncDir(
            string _localDir,
            string _remoteDir)
        {
            string comparisonFilePath = this.createComparisionFile(
                _localDir);


            string comparisonFileRemote = System.IO.Path.Combine(
                _remoteDir,
                Constants.comparison_file).Replace(
                    '\\', '/');

            // Make sure remote path exists.
            bool result = this.ftpClient.FileExists(
                comparisonFileRemote);

            if (result == false || this.ftpForceCompleteUpload == true)
            {
                // Never been synced. Remove and upload all files.
                FtpListItem[] fileList = this.ftpClient.GetListing(
                    _remoteDir);

                foreach (FtpListItem f in fileList)
                {
                    if (f.Type == FtpFileSystemObjectType.File)
                    {
                        string remoteFilePath = System.IO.Path.Combine(
                            _remoteDir,
                            f.Name).Replace(
                                '\\', '/');

                        this.ftpClient.DeleteFile(
                            remoteFilePath);
                    }
                }

                string[] files = System.IO.Directory.GetFiles(
                    _localDir,
                    "",
                    System.IO.SearchOption.TopDirectoryOnly);

                foreach (string file in files)
                {
                    string fileName = System.IO.Path.GetFileName(file);
                    string remoteFilePath = System.IO.Path.Combine(
                        _remoteDir,
                        fileName).Replace(
                            '\\', '/');

                    this.ftpClient.UploadFile(
                        file,
                        remoteFilePath);
                }
            }
            else
            {
                // Fetch remote comparision file from FTP and save as "comparison_remote.txt".
                string comparisonFileLocalRemote = System.IO.Path.Combine(
                    _localDir,
                    Constants.comparison_file_remote);

                this.ftpClient.DownloadFile(
                    comparisonFileLocalRemote,
                    comparisonFileRemote);

                Dictionary<string, string> dictLocal = this.convertComparisonFileToDict(
                    comparisonFilePath);
                Dictionary<string, string> dictRemote = this.convertComparisonFileToDict(
                    comparisonFileLocalRemote);

                // Get dictionary of files to be written.
                Dictionary<string, string> dictWrite = this.filesToWrite(
                    dictLocal,
                    dictRemote);

                // Get dictionary of files to be deleted.
                Dictionary<string, string> dictDelete = this.filesToDelete(
                    dictLocal,
                    dictRemote);

                // Upload all files to be added or updated.
                foreach (KeyValuePair<string, string> entry in dictWrite)
                {
                    string key = entry.Key;
                    string value = entry.Value;

                    string fileName = System.IO.Path.GetFileName(key);
                    string remoteFilePath = System.IO.Path.Combine(
                        _remoteDir,
                        fileName).Replace(
                            '\\', '/');

                    this.ftpClient.UploadFile(
                        key,
                        remoteFilePath);
                }

                // Delete all files to be deleted.
                foreach (KeyValuePair<string, string> entry in dictDelete)
                {
                    string key = entry.Key;
                    string value = entry.Value;

                    string fileName = System.IO.Path.GetFileName(key);
                    string remoteFilePath = System.IO.Path.Combine(
                        _remoteDir,
                        fileName).Replace(
                            '\\', '/');

                    this.ftpClient.DeleteFile(
                        remoteFilePath);
                }

                this.ftpClient.UploadFile(
                    comparisonFilePath,
                    comparisonFileRemote);
            }
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
                if (fileName == Constants.comparison_file
                 || fileName == Constants.comparison_file_remote)
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

        protected Dictionary<string, string> convertComparisonFileToDict(
            string _path)
        {
            System.IO.StreamReader sr = new System.IO.StreamReader(
                _path);
            Dictionary<string, string> dict = new Dictionary<string, string>();

            try
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    // Split by pipe.
                    string[] parts = line.Split('|');
                    dict.Add(
                        parts[0],
                        parts[1]);
                }
            }
            catch
            {
            }
            finally
            {
                if (sr != null)
                {
                    sr.Close();
                }
            }

            return dict;
        }

        protected Dictionary<string, string> filesToWrite(
            Dictionary<string, string> _srcDict,
            Dictionary<string, string> _dstDict)
        {
            Dictionary<string, string> dictFilesToWrite = new Dictionary<string, string>();

            foreach(KeyValuePair<string, string> entry in _srcDict)
            {
                string key = entry.Key;
                string value = entry.Value;

                bool result = _dstDict.ContainsKey(key);
                if (result == true)
                {
                    string dstValue = _dstDict[key];
                    if (dstValue != value)
                    {
                        // Upload this file.
                        dictFilesToWrite.Add(
                            key,
                            value);
                    }
                }
            }

            return dictFilesToWrite;
        }

        protected Dictionary<string, string> filesToDelete(
            Dictionary<string, string> _srcDict,
            Dictionary<string, string> _dstDict)
        {
            Dictionary<string, string> dictFilesToDelete = new Dictionary<string, string>();

            foreach (KeyValuePair<string, string> entry in _dstDict)
            {
                string key = entry.Key;
                string value = entry.Value;

                bool result = _srcDict.ContainsKey(key);
                if (result == true)
                {
                    string srcValue = _dstDict[key];
                    if (srcValue != value)
                    {
                        // Delete this file.
                        dictFilesToDelete.Add(
                            key,
                            value);
                    }
                }
            }

            return dictFilesToDelete;
        }
    }
}

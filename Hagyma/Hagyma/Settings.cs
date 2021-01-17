using System;
using System.Collections.Generic;
using System.Text;

namespace Hagyma
{
    public class Settings
    {
        public string projectName { get; set; }
        public string testServerHostname { get; set; }
        public int testServerPort { get; set; }
        public string ftpServerAddress { get; set; }
        public int ftpServerPort { get; set; }
        public string ftpServerBaseDir { get; set; }
        public string ftpServerUsername { get; set; }
        public string ftpServerPassword { get; set; }
        public bool ftpForceCompleteUpload { get; set; }

        public Settings()
        {
        }
    }
}

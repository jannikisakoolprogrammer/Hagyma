using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace Hagyma
{
    class PythonWebServerProcess : System.Diagnostics.Process
    {
        public PythonWebServerProcess(
            Settings _settings,
            string _projectOutputDir)
        {
            Uri root = new Uri(_projectOutputDir);
            string command = "/c python -m http.server --bind {0} --directory \"{1}\" {2}";
            command = String.Format(
                command,
                _settings.testServerHostname,
                _projectOutputDir,
                _settings.testServerPort);
            this.StartInfo.FileName = "cmd.exe ";
            this.StartInfo.Arguments = command;
            this.StartInfo.UseShellExecute = true;
            this.StartInfo.RedirectStandardOutput = false;
            this.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal;
            this.StartInfo.CreateNoWindow = false;
            this.Start();
            //this.WaitForExit();
        }

        public void stopServer()
        {
            this.Kill(true);
        }
    }
}

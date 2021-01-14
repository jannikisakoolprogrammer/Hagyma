using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace Hagyma
{
    class ComparisonFile : XmlDocument
    {
        XmlReader xmlReader;
        XmlWriter xmlWriter;

        string filePath;

        public ComparisonFile(
            string _filePath)
        {
            // XmlReader -> Read file and put contents in a dictionary.
            // Compare dictionary files with files that exist or don't exist yet.
            // Add new dictionary entries for files that don't exist; overwrite dictionary entries for files that exist.
            // Delete dictionary entries of files that don't exist anymore.
            // Write back the file using XmlWriter.
        }

        protected void init()
        {

        }
    }
}

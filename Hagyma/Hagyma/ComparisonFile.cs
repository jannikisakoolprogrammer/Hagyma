﻿using System;
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
        System.Collections.Generic.Dictionary<string, int> dict;

        public ComparisonFile(
            string _filePath)
        {
            this.filePath = _filePath;

            this.init();
            this.loadFilesIntoDictionary();

            // Compare dictionary files with files that exist or don't exist yet.
            // Add new dictionary entries for files that don't exist; overwrite dictionary entries for files that exist.
            // Delete dictionary entries of files that don't exist anymore.
            // Write back the file using XmlWriter.
        }

        protected void init()
        {
            // XmlReader -> Read file and put contents in a dictionary.
            string xmlData = System.IO.File.ReadAllText(
                this.filePath);

            this.xmlReader = XmlReader.Create(
                new System.IO.StringReader(
                    xmlData));

            this.dict = new System.Collections.Generic.Dictionary<string, int>();
        }

        protected void loadFilesIntoDictionary()
        {
            while (this.xmlReader.Read())
            {
            }
        }
    }
}

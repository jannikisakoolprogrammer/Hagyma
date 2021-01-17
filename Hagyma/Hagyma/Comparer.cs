using System;
using System.Collections.Generic;
using System.Text;

namespace Hagyma
{
    class Comparer
    {
        public Comparer(
            string _filePathSrc,
            string _filePathDst)
        {
            // XmlReader: Read both files, and write contents into dictionary.
            // Compare the two dictionaries and make a new dictionary with elements that have changed. (using hashes).
                // This new dict is a new class that tells FTP later, to either write or delete a file on the FTP server.
                // <string(filepath), FTPFile(string filepath, int hash, int mode (write, delete))
        }
    }
}

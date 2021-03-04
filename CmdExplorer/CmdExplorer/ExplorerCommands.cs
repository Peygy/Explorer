using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace CmdExplorer
{
    class ExplorerCommands
    {        
        public void ContentOutPut(string path)
        {
            DirectoryInfo info = new DirectoryInfo(path);
            string[] folders = Directory.GetDirectories(path);
            string[] files = Directory.GetFiles(path);
            foreach (string fold in folders)
            {
                fold.
                Console.Write(fold);
            }

            foreach (string file in files)
            {

            }
        }

        public void Moving()
        {

        }

        public void AddressMove()
        {

        }
    }
}

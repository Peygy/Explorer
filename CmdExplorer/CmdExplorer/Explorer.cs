using System;
using System.Collections.Generic;
using System.Text;

namespace CmdExplorer
{
    class Explorer
    {
        ExplorerCommands commands;

        public Explorer()
        {
            commands = new ExplorerCommands();
        }

        public void Interaction()
        {
            string path = @"C:\";
            string accept = "";
            Console.WriteLine();
            while(!accept.Contains("esc"))
            {
                Console.WriteLine();
                Console.Write($"{path} ");
                accept = Console.ReadLine();           
                switch (accept)
                {
                    case "dir":
                        {
                            commands.ContentOutPut(path);
                            break;
                        }
                }
            }
        }
    }
}

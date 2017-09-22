using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Cont
{
    class direct
    {
        public void direc(String cmd)
        {

            try
            {
                string[] internalfiles = Directory.GetFileSystemEntries(cmd);
                for (int i = 0; i < internalfiles.GetLength(0); i++)
                {
                    Console.WriteLine(Directory.GetLastWriteTime((internalfiles[i])).ToString("dd/MM/yyyy hh:mm tt") + " " + "<DIR>" + " " + internalfiles[i]);
                }
            }
            catch(Exception e)
            { Console.WriteLine(e.Message); }

        }
    }
}

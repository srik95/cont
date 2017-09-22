using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Cont
{
    class deletefol
    {
        public void del(String cmd, String comdir)
        {
            string[] st = cmd.Split(' ');

            int c = st.Length;
           

            if (c == 1)
            {
                Console.WriteLine("Argument cant be empty");
                return;
            }
            for (int i = 1; i < c; i++)
            {
                try
                {
                    Directory.Delete(comdir + @"\\" + st[i]);
                }
                catch (DirectoryNotFoundException e)
                {
                    Console.WriteLine("Directory not found!");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}

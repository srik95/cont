using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Cont
{
    class changdir
    {
      public void cdr(String cmd)
        { try
            {
                Directory.SetCurrentDirectory(cmd);
                Console.WriteLine(cmd);

            }
            catch (DirectoryNotFoundException e)
            {
                Console.WriteLine(" specified Directory not found!");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            } }
    }
}

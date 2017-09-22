using System;
using System.Collections.Generic;
using System.IO;
using System.Text;


namespace Cont
{
    class makedirec
    {
        public void mkdr(String cmd, String comdir)
        {

            string[] st = cmd.Split(' ');

            int c = st.Length;
           // Console.WriteLine(c);


            if (c == 1)
            {
                Console.WriteLine("Argument cant be empty");
                return;
            }




            for (int i = 1; i < c; i++)
            {


                {
                    if (System.IO.Directory.Exists(st[i]))
                        Console.WriteLine("Given Directory already exist");
                    else
                    {
                        try
                        {
                            Directory.CreateDirectory(comdir + @"\\" + st[i]);
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);

                        }

                    }

                }
            }
        }
    }
}

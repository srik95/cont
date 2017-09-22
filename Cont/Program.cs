using System;
using System.Collections.Generic;

using System.Text;
using System.Diagnostics;
using System.IO;
namespace Cont
{
    class Program
    {
        public static String comdir = @"Z:";

        static void Main(string[] args)
        {
           
            String cmd = " ";
            String str = " ";
           
            String dir = @"Z:";
            
            while (str !="q")
            {
                try
                {
                    Directory.SetCurrentDirectory(dir);
                }
                catch (DirectoryNotFoundException e)
                {
                    Console.WriteLine("The specified directory does not exist. {0}", e);
                }

                comdir = Directory.GetCurrentDirectory();
                Console.Write(comdir + ">");


              

                str = Console.ReadLine();
                while (str.Contains("  "))
                    str = str.Replace("  ", " ");
                //  Console.WriteLine(str);

                string[] st = str.Split(' ');
            switch(st[0].ToUpper())
                {
                    case "MD":
                        {
                            makedirec ob = new makedirec();
                            
                            
                                cmd = str;
                                ob.mkdr(cmd, comdir);
                            
                          
                            break;
                        }

                    case "DEL":
                        {
                            deletefol ob = new deletefol();
                            cmd = str;
                           ob.del(cmd, comdir);
                            break;

                        }
                    case "CD":
                        {
                            changdir ob = new changdir();
                            try
                            {
                                cmd = st[1];
                            }

                            catch (Exception e)
                            {
                                cmd = comdir;
                            }

                            //else
                            //    cmd = comdir;
                            ob.cdr(cmd);
                            
                           
                            
                            break;

                        }
                    case "DIR":
                        {
                            direct ob = new direct();
                            try { cmd = st[1]; }
                            catch (IndexOutOfRangeException e) { cmd = Directory.GetCurrentDirectory(); }

                            ob.direc(cmd);
                            break;
                        }    
                    
                    case "Q":
                        {
                            System.Environment.Exit(0);
                            break;
                        }

                    default:
                        {
                            Console.WriteLine("invalid command \n do you want to see help menu?(Y/N)");
                            string c= Console.ReadLine();
                            if(c.Equals("Y") || c.Equals("y"))
                            { Console.WriteLine("Welcome to the Contosso File System" + "\n" + "Please follow the syntax as mentioned to execute commands \n");
                                Console.WriteLine("MD (Make/Create a Directory) : md <fullpath> or md <folder name>");
                                Console.WriteLine("DEL (Delete directory): del <fullpath> or deldir <folder name>");
                                Console.WriteLine("CD (Change Directory) : cd.. (To return to immediate parent folder) cd \\ (to return to root directory");
                                Console.WriteLine("DIR (List all folder and directories) ");
                                Console.WriteLine("q to quit");
                            }
                            break;
                        }

                }

                
            }
                 }
    }
}

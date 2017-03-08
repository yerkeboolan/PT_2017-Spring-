using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2program
{
    class Program
    {
        string s = "yes";
        static void Main(string[] args)
        {
            f1();
        }

        static void f1()
        {
            Console.CursorVisible = false;

            DirectoryInfo dir = new DirectoryInfo(@"c:\test2");

            FileInfo[] files = dir.GetFiles();

            foreach (FileInfo f in files)
            {
                if(f == s)
                {

                }
            }

            Console.ReadKey();
        }
    }
}

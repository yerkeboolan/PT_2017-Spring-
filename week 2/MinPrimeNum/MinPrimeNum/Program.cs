using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinPrimeNum
{
    class Program
    {
        static int IsPrime(int x)
        {
            int a = x;
            int с = 0;
            for (int i = 2; i <= a; i++)
            {
                if (a % i == 0)
                    с++;
            }

            if (с == 2)
                return a;

            else
                return 0;
        }
        static void f1()
        {
            FileStream fs = new FileStream(@"c:\test\file new.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);

            string s = sr.ReadLine();
            string[] arr = s.Split();


            int mini = int.Parse(arr[0]);
            for (int i = 0; i < arr.Length ; i++)
            {
                int t = int.Parse(arr[i]);
                if(IsPrime(t) == t)
                {
                        if (t < mini)
                        {
                            mini = t;
                        }
                    }
            }


           
            sr.Close();
            fs.Close();
            f2(mini);

        }

        static void f2(int k)
        { 
            FileStream sf = new FileStream(@"c:\test\newfile2.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamWriter rs = new StreamWriter(sf);

            int a = k;
            rs.Write(a);
            rs.Close();
            sf.Close();
            


            Console.ReadKey();
        }


        static void Main(string[] args)
        {
            f1();
        }
    }
}

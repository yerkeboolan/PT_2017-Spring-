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
            for (int i = 1; i <= a; i++)
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


            int mini = 900000000;
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


            f2(mini);
            sr.Close();
            fs.Close();

            Console.ReadKey();
        }

        static void f2(int k)
        { 
            FileStream sf = new FileStream(@"c:\test\new file.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamWriter rs = new StreamWriter(sf);

            int a = k;
            rs.WriteLine(a);

            sf.Close();


            Console.ReadKey();
        }


        static void Main(string[] args)
        {
            f1();
        }
    }
}

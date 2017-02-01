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
        static void f1()
        {
            FileStream fs = new FileStream(@"c:\test\file new.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);

            string s = sr.ReadLine();
            string[] arr = s.Split();

            string[] arr = 

            for (Int64 i = 0; i < arr.Length; i++)
            {
                if (array[i] < array[minVal])
                {
                    minVal = array[i];
                }
            }

            foreach (string ss in arr)
            {
                minVal = int.Parse(ss);
            }

            Console.Write(minVal);

            sr.Close();
            fs.Close();

            Console.ReadKey();

            /*      bool prime = true;

                  for (int i = 2; i <= mini / 2; i++)
                  {
                      if (mini % i == 0)
                      {
                          prime = false;
                          break;
                      }
                  } */




        }


        static void Main(string[] args)
        {
            f1();
        }
    }
}

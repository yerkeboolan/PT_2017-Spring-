using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileReadWrite
{
    class Program
    {
        static void Main(string[] args)
        {
            f2();   
        }

        static void f1()
        {
            FileStream fs = new FileStream(@"c:\test\test.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamWriter sw = new StreamWriter(fs);

            sw.Write("сопрано");

            sw.Close();
            fs.Close();
        }

        static void f2()
        {
            FileStream fs = new FileStream(@"c:\test\test.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);

            string s = sr.ReadLine(); // "1 2 3 4 5"
            string[] arr = s.Split(); // ["1", "2", "3", "4", "5"];

            int sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
          int tmp = int.Parse(arr[i]);
                sum += tmp;
            }

            foreach(string ss in arr)
            {
                sum += int.Parse(ss);
            }
            Console.Write(sum);


            sr.Close();
            fs.Close();

            Console.ReadKey();
        }
    }
}

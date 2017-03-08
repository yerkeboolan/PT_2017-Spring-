using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1program
{
    class Program
    {


        static void Main(string[] args)
        {
            Solve();
            Console.ReadKey();
        }



        public static void Solve()
        {
            string s = Console.ReadLine();
            foreach (char i in s)
                if (int.Parse(i.ToString()) % 2 == 0)
                    Console.Write(i + " ");
        }
    }
}  
           


        
  
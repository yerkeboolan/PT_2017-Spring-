using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complex
{
    class Program
    {
        static void Main(string[] args)
        {
            Complex x = new Complex(4, 8);
            Complex y = new Complex(3, 7);
            Complex c = x - y;

            Console.Write(c);

            Console.ReadKey();
        }
    }
}

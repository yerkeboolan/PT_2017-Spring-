using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexNum
{
    class Program
    {
           static void Main(string[] args)
        {
            Console.Write("Press first number:");
            string s = Console.ReadLine();
            string[] arr = s.Split('/');



            Console.Write("\nPress any operation:");
            string s1 = Console.ReadLine();

            Console.Write("\nPress second number:");
            string s2 = Console.ReadLine();
            string[] arr1 = s2.Split('/');


            Complex a = new Complex(int.Parse(arr[0]), int.Parse(arr[1]));
            Complex b = new Complex(int.Parse(arr1[0]), int.Parse(arr1[1]));
            Complex c;

            if(s1 == "+")
            {
                c = a + b;
            } else if(s1 == "*")
            {
                c = a * b;
            } else
            {
                c = a / b;
            }

            Console.Write("\nThe result is:" + c);
            Console.ReadKey();
        }
    }
}

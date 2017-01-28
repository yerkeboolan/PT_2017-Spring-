using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNum
{
    class Program
    {
        static void Main(string[] args)
        {
            bool prime = true;

            Console.WriteLine("Enter the number:\n");
            int n = int.Parse(Console.ReadLine());

            for (int i = 2; i <= n / 2; i++)
            {
                if (n % i == 0)
                {
                    prime = false;
                    break;
                }
            }
            if (prime)
            {
                Console.WriteLine("prime number");
            }
            else
            {
                Console.WriteLine("is not a prime number");
            }
            Console.ReadKey();
        }
    }
}


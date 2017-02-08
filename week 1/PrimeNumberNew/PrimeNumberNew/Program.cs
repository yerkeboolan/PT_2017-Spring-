using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumberNew
{
     class Program
     {
        
         static int IsPrime(int x)
         {
             int a = x;
             int c = 0;
            for (int i = 1; i <= a; i++)
             {
                 if (a % i == 0)
                     c++;
             }

             if (c == 2 || a == 1)
             {
                 return a;
             } else
             {
                 return 0;
             }

             }

             static void Main(string[] args)
             {

                 Console.WriteLine("Enter your numbers: ");


                 string s = Console.ReadLine();

                 string[] arr = s.Split();

                 int y;
                 int z;
                 Console.WriteLine("Prime numbers are:");

                 for (int i = 0; i < arr.Length; i++)
                 {
                     y = int.Parse(arr[i]);
                     z = IsPrime(y);
                     if (z == y)
                     {
                         Console.Write(y + " ");
                     }

                 }


                 Console.ReadKey();
             }
         }
     }
     
   
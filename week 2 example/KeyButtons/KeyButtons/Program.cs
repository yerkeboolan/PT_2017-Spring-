using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyButtons
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                ConsoleKeyInfo btn = Console.ReadKey();

                if (btn.Key == ConsoleKey.Backspace)
                {
                    Console.WriteLine("Backspace");
                }
                else if (btn.Key == ConsoleKey.Delete)
                {
                    Console.WriteLine("Delete");
                }
                else if (btn.Key == ConsoleKey.Escape)
                {
                    Console.Clear();
                }
            }
        }
    }
}

    
    
    


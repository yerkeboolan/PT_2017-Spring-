using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySnakeSuperClasses.Models
{
    public class Drawer
    {
        public ConsoleColor color;
        public char sign;
        public List<Point> body = new List<Point>();
        

        public Drawer() { }
        public Drawer(ConsoleColor color, char sign, List<Point> body)
        {
            this.color = color;
            this.sign = sign;
            this.body = body;
           
            
        }

        public void Draw()
        {
            Console.ForegroundColor = color;
            foreach (Point p in body)
            {
                Console.SetCursorPosition(p.x, p.y);
                Console.Write(sign);
            }
        }

    }
}

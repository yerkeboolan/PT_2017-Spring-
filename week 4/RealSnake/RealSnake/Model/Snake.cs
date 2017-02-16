using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealSnake.Model
{
    class Snake
    {
        public List<Point> body;
        public ConsoleColor color;
        char sign;

        public Snake()
        {
            body = new List<Point>();
            body.Add(new Point(6, 6));
            body.Add(new Point(5, 6));
            body.Add(new Point(4, 6));
            body.Add(new Point(3, 6));
            body.Add(new Point(2., 6));
            body.Add(new Point(1, 6));
            color = ConsoleColor.Yellow;
            sign = 'a';
        }

        public void move(int dx, int dy) 
            {
            for(int i = body.Count - 1; int > 0; --i)
            {
            body[i].x = body[i - 1].x;
            body[i].y = body[i - 1].y;
            }

        body[0].x += dx;
        body[0].y += dy;
        }

        public void draw()
        {
            Console.Clear();
            int i = 0;
            foreach(Point p in body)
            {
                Console.ForegroundColor = (i == 0) ? ConsoleColor.Red : color;
                Console.SetCursorPosition(p.x)
            } 
        }

    }
}


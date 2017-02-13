using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySnake.Model
{
    class Snake
    {
        public List<Point> body;
        public ConsoleColor color;
        char sign;

        public Snake()
        {
            body = new List<Point>();
            body.Add(new Point(5, 5));
            body.Add(new Point(4, 5));
            body.Add(new Point(3, 5));
            body.Add(new Point(2, 5));
            body.Add(new Point(1, 5));
            color = ConsoleColor.Blue;
            sign = 'q';
        }

        public void move(int dx, int dy)
        {
            for (int i = body.Count - 1; i > 0; --i)
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
            foreach (Point p in body)
            {
                Console.ForegroundColor = (i == 0) ? ConsoleColor.Red : color;
                Console.SetCursorPosition(p.x, p.y);
                Console.Write(sign);
                i++;
            }
        }
    }
}
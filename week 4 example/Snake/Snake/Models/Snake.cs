using Snake.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Snake
    {
        public int[,] u = new int[50, 50];
        public int GM;
        public ConsoleColor color = ConsoleColor.Yellow;
        public List<Point> body = new List<Point>();
        public char sign = 'o';

        public Snake()
        {
            body.Add(new Point(10, 10));
            body.Add(new Point(9, 10));
        }

        public void Move(int dx, int dy)
        {
            for (int i = 0; i < 50; i++)
                for (int j = 0; j < 50; j++)
                    u[i, j] = 0;
            for (int i = body.Count - 1; i > 0; --i)
            {
                body[i].x = body[i - 1].x;
                body[i].y = body[i - 1].y;
                u[body[i].x, body[i].y] = 1;
            }

            body[0].x += dx;
            body[0].y += dy;
            if (body[0].x >= 20)
                body[0].x = 0;
            if (body[0].y >= 20)
                body[0].y = 0;

            if (body[0].x < 0)
                body[0].x = 19;
            if (body[0].y < 0)
                body[0].y = 19;
            if (u[body[0].x, body[0].y] == 1)
                GM = 1;
            u[body[0].x, body[0].y] = 1;
        }
        public void Game_Over(Wall wall)
        {
            if (wall.u[body[0].x, body[0].y] == 1)
                GM = 1;
        }

        public bool CanEat(Food f)
        {
            if (body[0].x == f.location.x && body[0].y == f.location.y)
            {
                body.Add(new Point(f.location.x, f.location.y)); // new Point(body[0].x, body[0].y
                return true;
            }
            return false;
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

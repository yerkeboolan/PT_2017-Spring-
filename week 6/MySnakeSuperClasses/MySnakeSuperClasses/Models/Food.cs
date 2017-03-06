using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySnakeSuperClasses.Models
{
    [Serializable]
    public class Food : Drawer
    {
        public Food(ConsoleColor color, char sign, List<Point> body) : base(color, sign, body)
        {
            Delete();
            SetRandomPosition();
        }
        public Food() { }

        public void SetRandomPosition()
        {
            Delete();
            bool ok = true;
            int x;
            int y;

            while (ok)
            {
                ok = false;

                x = new Random().Next(1, 69);
                y = new Random().Next(1, 34);

                body[0] = new Point(x, y);

                if (ItisNot(body[0], Game.wall.body) && ItisNot(body[0], Game.snake.body))
                {
                    ok = true;
                }
            }
            Draw();
        }

        public void Delete()
        {
            Console.SetCursorPosition(body[0].x, body[0].y);
            Console.Write(' ');
        }

        public bool ItisNot(Point food, List<Point> body)
        {
            foreach (Point p in body)
            {
                if (food.x == p.x && food.y == p.y)
                {
                    return true;
                }
            }
            return false;
        }
    }
}




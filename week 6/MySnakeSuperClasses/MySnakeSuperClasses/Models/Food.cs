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

            int x = new Random().Next(0, 70);
            int y = new Random().Next(0, 35);


            body[0] = new Point(x, y);

            CollesionSW(body[0]);

        }

        public void CollesionSW(Point p)
        {
            for (int i = 0; i < Game.wall.body.Count; i++)
            {

                if (p.x == Game.wall.body[i].x && p.y == Game.wall.body[i].y)
                {
                    SetRandomPosition();
                }
            }

            for (int i = 0; i < Game.snake.body.Count; i++)
            {

                if (p.x == Game.snake.body[i].x && p.y == Game.snake.body[i].y)
                {
                    SetRandomPosition();
                }
            }
            Draw();
        }

        public void Delete()
        {
            Console.SetCursorPosition(body[0].x, body[0].y);
            Console.Write(' ');
        }
    }
}

       





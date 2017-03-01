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

            SetRandomPosition();
            Delete();
        }
        public Food() { }



        public void SetRandomPosition()
        {
            int x = new Random().Next(0, 70);
            int y = new Random().Next(0, 35);
            body[0] = new Point(x, y);

            if (ItisNot(body[0], Game.wall.body) || ItisNot(body[0], Game.snake.body))
            {

            }


               
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


    /* while (Game.snake.body.Contains(p) ||
                  Game.wall.body.Contains(p))
                p = new Point(new Random().Next(0, 70), new Random().Next(0, 35));
            body = new List<Point> { p }; */




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySnakeSuperClasses.Models
{
    public class Food : Drawer
    {
        public Food(ConsoleColor color, char sign, List<Point> body) : base(color, sign, body)
        {
            SetRandomPosition();
        }

        public void SetRandomPosition()
        {
            int x = new Random().Next(0, 70);
            int y = new Random().Next(0, 35);
            body[0] = new Point(x, y);
        
       


            for (int i = 0; i < Game.snake.body.Count; i++)
            {
                if (Game.food.body[0].x == Game.snake.body[i].x && Game.food.body[0].y == Game.snake.body[i].y)
                {
                    SetRandomPosition();
                }
            }

            for (int i = 0; i < Game.wall.body.Count; i++)
            {
                if (Game.food.body[0].x == Game.wall.body[i].x && Game.food.body[0].y == Game.wall.body[i].y)
                {
                    SetRandomPosition();
                }
            }
        }

    }
}



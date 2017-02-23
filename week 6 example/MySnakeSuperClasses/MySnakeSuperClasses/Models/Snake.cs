using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;


namespace MySnakeSuperClasses.Models
{
   [Serializable]
    public class Snake : Drawer
    { 
    
            
        public Snake(ConsoleColor color, char sign, List<Point> body) : base(color, sign, body) { }

       
        public void Move(int dx, int dy)
        {
            for(int i = body.Count - 1; i > 0; i--)
            {
                body[i].x = body[i - 1].x;
                body[i].y = body[i - 1].y;
            }

            body[0].x += dx;
            body[0].y += dy;
            if(body[0].x >= 70)
                body[0].x = 0;
            if (body[0].y >= 35)
                body[0].y = 0;

            if (body[0].x < 0)
                body[0].x = 70;
            if (body[0].y < 0)
                body[0].y = 35;

            for(int i = 0; i < Game.wall.body.Count; i++)
            {
                if(Game.snake.body[0].x == Game.wall.body[i].x && Game.snake.body[0].y == Game.wall.body[i].y)
                {
                    Console.Clear();
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.SetCursorPosition(10, 10);
                    Console.WriteLine("GAME OVER!");
                    Console.ReadKey();
                    Game.GameOver = true;
                }
            }
                for(int i = 2; i < Game.snake.body.Count; i++)
            {
                if(Game.snake.body[0].x == Game.snake.body[i].x && Game.snake.body[0].y == Game.snake.body[i].y)
                {
                    Console.Clear();
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.SetCursorPosition(10, 10);
                    Console.WriteLine("GAME OVER!");
                    Console.ReadKey();
                    Game.GameOver = true;
                }
            }
        }

        public bool CanEat(Food f)
        {
            if (body[0].x == f.body[0].x && body[0].y == f.body[0].y)
            {
                body.Add(new Point(f.body[0].x, f.body[0].y));
                return true;
            }
            return false;
        }
           
            
        }
    }   


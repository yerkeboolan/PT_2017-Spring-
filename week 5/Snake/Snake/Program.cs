using Snake.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Snake
{
    class Program
    {
        
        static bool GameOver = false;
        static Snake snake = new Snake();
        static Food food = new Food();
        static Wall wall = new Wall(1);
        
    
        static void Main(string[] args)
        {
           
            Console.CursorVisible = false;
            Console.SetWindowSize(70, 35);


            while (!GameOver)
            {
                Console.Clear();
                snake.Draw();
                food.Draw();
                wall.Draw();

                ConsoleKeyInfo btn = Console.ReadKey();
                switch (btn.Key)
                {
                    case ConsoleKey.UpArrow:
                        snake.Move(0, -1);
                        break;
                    case ConsoleKey.DownArrow:
                        snake.Move(0, 1);
                        break;
                    case ConsoleKey.LeftArrow:
                        snake.Move(-1, 0);
                        break;
                    case ConsoleKey.RightArrow:
                        snake.Move(1, 0);
                        break;
                    case ConsoleKey.Escape:
                        GameOver = true;
                        break;
                }
                if (snake.CanEat(food))
                {
                    food.SetRandomPosition();
                }
                if (snake.body.Count == 10)
                {
                    wall = new Wall(2);
                }
                if (snake.body.Count == 15)
                {
                    wall = new Wall(3);
                }
            }

        }
    }
}

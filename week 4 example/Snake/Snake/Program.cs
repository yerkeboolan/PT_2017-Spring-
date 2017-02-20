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
        public static void Game_Over(int cnt, int Max)
        {
            Console.Clear();
            Console.SetCursorPosition(10, 5);
            Console.WriteLine("GAME OVER");
            Console.SetCursorPosition(10, 6);
            Console.WriteLine("Your score: " + cnt);
            Console.SetCursorPosition(10, 7);
            Console.WriteLine("Max score: " + Max);
            Console.SetCursorPosition(10, 8);
            Console.WriteLine("Repeate?");
            Console.SetCursorPosition(10, 9);
            Console.WriteLine("Y || N");
            while (true)
            {
                ConsoleKeyInfo p = Console.ReadKey();
                if (p.Key == ConsoleKey.Y)
                    break;
                if (p.Key == ConsoleKey.N)
                    Environment.Exit(0);
            }
        }
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
                if (snake.body.Count == 4)
                {
                    wall = new Wall(2);
                }
                if (snake.body.Count == 10)
                {
                    wall = new Wall(3);
                }
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p = new Point(4,5,'*');
            HorizontalLine hl1 = new HorizontalLine(0, 78, 0, '+');
            HorizontalLine hl2 = new HorizontalLine(0, 78, 24, '+');
            VerticalLine vl1 = new VerticalLine(0, 24, 0, '+');
            VerticalLine vl2 = new VerticalLine(0, 24, 78, '+');
            hl1.Draw(); vl1.Draw(); hl2.Draw(); vl2.Draw();
            Snake snake = new Snake(p, 4, Direction.Right);
            snake.Draw();
            FoodCreator foodCreator = new FoodCreator(80, 25, '$');
            Point food = foodCreator.CreateFood();
            food.Draw();
            while (true)
            {
                if (snake.Eat(food))
                { food = foodCreator.CreateFood(); food.Draw(); }
                else snake.Move();
                Thread.Sleep(100);
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }
                Thread.Sleep(100); snake.Move();
            }
        }
    }
}

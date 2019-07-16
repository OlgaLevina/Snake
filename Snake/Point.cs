using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Point
    {
        int x;
        int y;
        char simb;
        public Point(int X, int Y, char Simb)
        {
            x = X; y = Y; simb = Simb;
        }
        public Point(Point p)
        {
            x = p.x; y = p.y;simb = p.simb;
        }
        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(simb);
        }
        public void Move(int ofset, Direction dir)
        {
            switch (dir)
            {
                case Direction.Down: y+=ofset; break;
                case Direction.Left: x -= ofset; break;
                case Direction.Right: x += ofset;break;
                case Direction.Up: y -= ofset;break;

            }
        }

        public void Clear()
        {
            simb=' ';Draw();
        }
    }
}

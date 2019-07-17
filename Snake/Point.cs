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
        const int xMax= 78;
        const int yMax = 24;
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
            if (y == yMax && dir == Direction.Down) y = 1;
            else if (y == 0 && dir == Direction.Up) y = yMax - 1;
            else if (x == xMax && dir == Direction.Right) x = 1;
            else if (x == 0 && dir == Direction.Left) x = xMax - 1;
        }

        public void Clear()
        {
            simb=' ';Draw();
        }
        public void Change(Point p)
        {
            simb = p.simb; Draw();
        }

        internal bool IsHit(Point p)
        {
           return p.x == this.x && p.y == this.y;
        }
    }
}

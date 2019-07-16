using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Point
    {
        public int x;
        public int y;
        public char simb;
        public Point(int X, int Y, char Simb)
        {
            x = X; y = Y; simb = Simb;
        }
        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(simb);
        }
    }
}

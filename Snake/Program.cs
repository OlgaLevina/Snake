using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p = new Point(4,5,'*');
            p.Draw();
            Point p2 = new Point(1,3, '*');
            p2.Draw();
            HorizontalLine hl1 = new HorizontalLine(0, 78, 0, '+');
            HorizontalLine hl2 = new HorizontalLine(0, 78, 24, '+');
            VerticalLine vl1 = new VerticalLine(0, 24, 0, '+');
            VerticalLine vl2 = new VerticalLine(0, 24, 78, '+');
            hl1.Draw(); vl1.Draw(); hl2.Draw(); vl2.Draw();
            Console.ReadLine();
        }
    }
}

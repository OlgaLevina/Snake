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
            Console.ReadLine();
        }
    }
}

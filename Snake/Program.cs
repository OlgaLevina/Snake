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
            Point p = new Point();
            p.x = 1; p.y = 3; p.simb = '*';
            p.Draw();
            Console.ReadLine();
        }
    }
}

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
            Draw(1,3,'*');
            Console.ReadLine();
        }
        static void Draw (int x,int y, char simb)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(simb);
        }
    }
}

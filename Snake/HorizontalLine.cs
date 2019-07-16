using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class HorizontalLine: Figure
    {
        public HorizontalLine (int xleft, int xright, int y, char sym)
        {
            pline = new List<Point>();
            for (int x = xleft; x <= xright; x++)
            {
                pline.Add(new Point(x, y, sym));
            }
        }
    }
}

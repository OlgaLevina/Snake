﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class VerticalLine: Figure
    {
        public VerticalLine(int yUp, int yDown, int x, char sym)
        {
            pline = new List<Point>();
            for (int y = yUp; y <= yDown; y++)
            {
                pline.Add(new Point(x, y, sym));
            }
        }
    }
}

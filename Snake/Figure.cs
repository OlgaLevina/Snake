using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Figure
    {
        protected List<Point> pline;
        public void Draw()
        {
            foreach (Point p in pline)
            {
                p.Draw();
            }
        }
    }
}

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
        public virtual void Draw()
        {
            foreach (Point p in pline)
            {
                p.Draw();
            }
        }
        public bool IsHit(Figure figure)
        {
            foreach (Point p in pline)
            {
                if (figure.IsHit(p)) return true;
            }
            return false;
        }
        public bool IsHit(Point point)
        {
            foreach (Point p in pline)
            {
                if (p.IsHit(point)) return true;
            }
            return false;
        }
    }
}

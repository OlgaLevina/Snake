using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Walls
    {
        List<Figure> walllist;
        public Walls (int mapWide, int mapHeight)
        {
            walllist = new List<Figure>() { new HorizontalLine(0, mapWide-2, 0, '+'),
            new HorizontalLine(0, mapWide-2, mapHeight-2, '+'),
            new VerticalLine(0, mapHeight-2, 0, '+'),
            new VerticalLine(0, mapHeight-2, mapWide-2, '+')
            };
        }
        public bool IsHit(Figure figure)
        {
            foreach (Figure wall in walllist)
            {
                if (wall.IsHit(figure)) return true;
            }
            return false;
        }
        public void Draw()
        {
            foreach (Figure wall in walllist)
            {
                wall.Draw();
            }
        }
    }
}

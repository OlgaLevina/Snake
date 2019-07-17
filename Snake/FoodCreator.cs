using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class FoodCreator
    {
        int mapwidth;
        int mapheight;
        char sym;
        Random rand = new Random();
        public FoodCreator(int Mapwidth, int Mapheight, char Sym)
        {
            mapheight = Mapheight;
            mapwidth = Mapwidth;
            sym = Sym;
        }
        public Point CreateFood()
        {
            int x = rand.Next(2, mapwidth - 2);
            int y = rand.Next(2, mapheight - 2);
            return new Point(x,y,sym);
        }
    }
}

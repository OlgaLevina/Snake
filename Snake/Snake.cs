using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Snake: Figure
    {
        Direction direction;
        public Snake(Point tail, int length, Direction dir )
        {
            pline = new List<Point>();
            direction = dir;
            for (int i = 0; i < length; i++)
            {
                Point p = new Point(tail);
                p.Move(i, dir);
                pline.Add(p);
            }

        }

        internal void Move()
        {
            Point tail=pline.First();
            pline.Remove(tail);
            Point head = GetNextPoint();
            pline.Add(head);
            tail.Clear();
            head.Draw();

        }

        public Point GetNextPoint()
        {
            Point head = pline.Last();
            Point nextPoint = new Point(head);
            nextPoint.Move(1,direction);
            return nextPoint;
        }

        internal bool Eat(Point food)
        {
            Point head=GetNextPoint();
            if (head.IsHit(food))
            {
                food.Change(head);
                pline.Add(head);
                return true;
            }
            return false;
        }

        public void HandleKey(ConsoleKey key)
        {
            switch (key)
            {
                case ConsoleKey.RightArrow: direction = Direction.Right; break;
                case ConsoleKey.LeftArrow: direction = Direction.Left; break;
                case ConsoleKey.UpArrow: direction = Direction.Up; break;
                case ConsoleKey.DownArrow: direction = Direction.Down; break;
            }

        }
    }
}

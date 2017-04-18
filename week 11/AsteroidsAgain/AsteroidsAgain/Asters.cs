using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsteroidsAgain
{
    public class Asters
    {
        public Point location;
        public SolidBrush sbr;
        public Graphics g;
        
        public int dx=15, dy=15;

        public Asters() { }
        public Asters(Graphics _g, Point p)
        {
            location = new Point();
            g = _g;

            sbr = new SolidBrush(Color.Red);
            location = p;

        }

         
        public void Draw()
        {
            Point[] part1 =
           {
                new Point(location.X, location.Y - 25),
                new Point(location.X + 25, location.Y + 10),
                new Point(location.X - 25, location.Y + 10)
            };
            Point[] part2 =
            {
                new Point(location.X - 25, location.Y - 10),
                new Point(location.X + 25, location.Y - 10),
                new Point(location.X, location.Y + 25)
            };

            g.FillPolygon(sbr, part1);
            g.FillPolygon(sbr, part2);
        }

        public void Move(int width, int height)
        {
            if ((location.X > width) || (location.X < 0))
                dx *= -1;

            if ((location.Y > height) || (location.Y < 0))
                dy *= -1;


            location.X += dx;
            location.Y += dy;
        }

        public void check(List<Asters> asters)
        {
            foreach(Asters ars in asters)
            {
                if(ars != this)
                {
                    if (cross(ars))
                    {
                        dx *= -1;
                        dy *= -1;

                        ars.dx *= -1;
                        ars.dy *= -1;
                    }
                }
            }
        }

        public bool cross(Asters a)
        {
            if ((location.X == a.location.X) || (a.location.X == location.X))
                return true;
            return false;  
          }

    }


}

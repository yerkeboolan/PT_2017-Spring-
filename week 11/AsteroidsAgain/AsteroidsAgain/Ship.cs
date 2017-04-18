using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsteroidsAgain
{
    public class Ship
    {
        public Point location;
        public SolidBrush sbr;
        public Graphics g;
        public int dx, dy;

        public Ship(Graphics _g, Point p)
        {
            location = new Point();
            g = _g;
            sbr = new SolidBrush(Color.Yellow);
            location = p;
        }

        public void Draw()
        {
            Point[] p =
           {
                new Point(location.X, location.Y - 65),
                new Point(location.X + 65, location.Y - 35),
                new Point(location.X + 65, location.Y + 35),
                new Point(location.X, location.Y + 65),
                new Point(location.X - 65, location.Y + 35),
                new Point(location.X - 65, location.Y - 35)
        };
            g.FillPolygon(sbr, p);

            Point[] gun =
           {
                new Point(location.X-15,location.Y-5),
                new Point(location.X,location.Y-25),
                new Point(location.X+15,location.Y-5),
                new Point(location.X+6,location.Y-5),
                new Point(location.X+6, location.Y+25),
                new Point(location.X-6,location.Y+25),
                new Point(location.X-6,location.Y-5)
            };
            g.FillPolygon(sbr, gun); 

        }

        public void Move(int width, int height, int i, Gun gun)
        {
            if ((location.X > width) || (location.X < 0))
                dx *= -1;

            if ((location.Y > height) || (location.Y < 0))
                dy *= -1;

            switch (i) {
                case 1:
                    location.Y -= 15;
                    gun.location.Y -= 15;
                    break;
                case 2:
                    location.Y += 15;
                    gun.location.Y += 15;
                    break;
                case 3:
                    location.X += 15;
                    gun.location.X += 15;
                    break;
                case 4:
                    location.X -= 15;
                    gun.location.X -= 15;
                    break;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsteroidsAgain
{
    public class Stars
    {
        public Point location;
        public SolidBrush sbr;
        public Graphics g;

        int dx = 15;
        int dy = 15;

        public Stars(Graphics _g, Point p)
        {
            location = new Point();
            g = _g;
            sbr = new SolidBrush(Color.White);
            location = p;
        }

        public void Draw()
        {
            g.FillEllipse(sbr, location.X, location.Y, 30, 30);
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
    }
}

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
        public int dx, dy, wh;


        public Asters(Graphics _g, Point p)
        {
            location = new Point();
            g = _g;
            wh = 100;
            sbr = new SolidBrush(Color.Red);
            location = p;
            dx = 1;
            dy = 1;
        }

        public void Move(int width, int height)
        {
            if ((location.X + wh > width) || (location.X < 0))
                dx *= -1;

            if((location.Y + wh > height) || location.Y < 0))
                dy *= -1;


            location.X += dx;
            location.Y += dy;
    }

        public void Draw()
        {
            g.Fill
        }
}

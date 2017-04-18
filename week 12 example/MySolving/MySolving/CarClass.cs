using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySolving
{
    class CarClass
    {
        
        public GraphicsPath path = new GraphicsPath();
        public GraphicsPath path1 = new GraphicsPath();



        public void Polygon(int x, int y)
        {
            Point[] p =
            {
                new Point(20, 200),
                new Point(20, 150),
                new Point(60, 150),
                new Point(60, 120),
                new Point(160, 120),
                new Point(160, 150),
                new Point(200, 150),
                new Point(200, 200)
            };
            path.AddPolygon(p);
        }

        public void Kolesa(int x, int y)
        {
            path1.AddEllipse(x, y, 30, 30);   
        }
    }
}

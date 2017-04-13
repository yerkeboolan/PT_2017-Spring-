using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsteroidsGame
{
    class DepictClass { 
    Graphics g;

    public GraphicsPath path1 = new GraphicsPath();
    public GraphicsPath path2 = new GraphicsPath();
    public GraphicsPath path3 = new GraphicsPath();
    public GraphicsPath path4 = new GraphicsPath();
    public GraphicsPath path5 = new GraphicsPath();
    public GraphicsPath path6 = new GraphicsPath();
    public GraphicsPath path7 = new GraphicsPath();
    public GraphicsPath path8 = new GraphicsPath();

    public void Cosmos(int x, int y, int a, int b)
    {
        Rectangle r = new Rectangle(x, y, a, b);
        path1.AddRectangle(r);
    }

    public void Stars(int x, int y)
    {
        path2.AddEllipse(x, y, 30, 30);
    }

    public void Ship(int x, int y)
    {
        Point[] p =
        {
                new Point(x, y - 65),
                new Point(x + 65, y - 35),
                new Point(x + 65, y + 35),
                new Point(x, y + 65),
                new Point(x - 65, y + 35),
                new Point(x - 65, y - 35)
        };

        path3.AddPolygon(p);
    }

    public void Asteroids(int x, int y)
    {
        Point[] part1 =
        {
                new Point(x, y - 25),
                new Point(x + 25, y + 10),
                new Point(x - 25, y + 10)
            };
        Point[] part2 =
        {
                new Point(x - 25, y - 10),
                new Point(x + 25, y - 10),
                new Point(x, y + 25)
            };

        path4.AddPolygon(part1);
        path5.AddPolygon(part2);

    }

    public void Bullet(int x, int y)
    {
        path6.AddEllipse(x - 5, y - 13, 10, 26);
        path7.AddEllipse(x - 13, y - 5, 26, 10);
    }

    public void Gun(int x, int y)
    {
        Point[] gun =
        {
                new Point(x-15,y-5),
                new Point(x,y-25),
                new Point(x+15,y-5),
                new Point(x+4,y-5),
                new Point(x+4,y+25),
                new Point(x-4,y+25),
                new Point(x-4,y-5)
            };

        path8.AddPolygon(gun);
    }
}
}

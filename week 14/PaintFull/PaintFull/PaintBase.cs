using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintFull
{
    public class PaintBase
    {
        public enum Shape { Pen, Line, Rectangle, Erazer, Fill, Ellipse, Circle,
            Rhombus, Triangle, RTriangle };

        public Graphics g;
        public GraphicsPath path;
        public PictureBox pict;
        public Pen pen;
        public Pen pen2;
        public Bitmap btm;
        public Point prev;
        public Shape shape;


        public Color origin;
        public Color fill;
        public Queue<Point> q;
        public Point cur;
        public int val;
        public SolidBrush wh;

        public PaintBase(PictureBox pictureBox1)
        {
            pict = pictureBox1;
            btm = new Bitmap(pict.Width, pict.Height);
            pict.Image = btm;
            pen = new Pen(Color.Black);
            g = Graphics.FromImage(btm);
            g.Clear(Color.White);
            path = new GraphicsPath();
            shape = Shape.Pen;
            pen2 = new Pen(Color.Blue, 50);
            pict.Paint += Pict_Paint;

            fill = new Color();
            origin = new Color();
            q = new Queue<Point>();
            wh = new SolidBrush(Color.White);
        }

        private void Pict_Paint(object sender, PaintEventArgs e)
        {
            if (path != null)
                e.Graphics.DrawPath(pen, path);
        }

        public void SaveLastPath()
        {
            if (path != null)
                g.DrawPath(pen, path);
        }

        public void Draw(Point cur)
        {
            switch (shape)
            {
                case Shape.Pen:
                    g.DrawLine(pen, prev, cur);
                    prev = cur;
                    break;
                case Shape.Line:
                    path.Reset();
                    path.AddLine(prev, cur);
                    break;
                case Shape.Rectangle:
                    path.Reset();

                    Point[] pts =
                    {
                    new Point(cur.X, cur.Y),
                    new Point(prev.X, cur.Y),
                    new Point(prev.X, prev.Y),
                    new Point(cur.X, prev.Y)
                    };
                    path.AddPolygon(pts);
                    break;
                case Shape.Erazer:
                    path.Reset();
                    g.FillRectangle(wh, prev.X - val / 2, prev.Y - val / 2, val + 20, val + 20);
                    prev = cur;
                    break;
                case Shape.RTriangle

            }
        }





        public void SaveImage(string filename)
        {
            btm.Save(filename);
        }

        public void Fill()
        {
            while (q.Count > 0)
            {
                cur = q.Dequeue();
                Check(cur.X, cur.Y - 1);
                Check(cur.X + 1, cur.Y);
                Check(cur.X, cur.Y + 1);
                Check(cur.X - 1, cur.Y);
            }
            pict.Refresh();
        }


        public void Check(int x, int y)
        {
            if (x > 0 && y > 0 && x < pict.Width && y < pict.Height)
            {
                if (btm.GetPixel(x, y) == origin)
                {
                    btm.SetPixel(x, y, fill);
                    q.Enqueue(new Point(x, y));
                }
            }
        }

        public void TADraw(Point curn)
        {

            Point[] p2 =
                   {
                            new Point(curn.X, curn.Y),
                            new Point(prev.X, curn.Y),
                            new Point(prev.X, prev.Y)

                        };

            Point[] p =
                      {
                            new Point(curn.X, curn.Y),
                            new Point(curn.X, prev.Y),
                            new Point(prev.X, curn.Y)

                        };

            Point[] p3 =
                    {
                            new Point(curn.X, curn.Y),
                            new Point(curn.X, prev.Y),
                            new Point(prev.X, prev.Y)

                        };

            Point[] p4 =
                    {
                            new Point(prev.X, curn.Y),
                            new Point(curn.X, prev.Y),
                            new Point(prev.X, prev.Y)

                        };

            if (curn.X >= prev.X && curn.Y >= prev.Y)
            {
                path.AddPolygon(p2);
            }
            else if (curn.X <= prev.X && curn.Y >= prev.Y)
            {
                path.AddPolygon(p);
            }
            else if (curn.Y <= prev.Y && curn.X <= prev.X)
            {
                path.AddPolygon(p3);
            }
            else
            {
                path.AddPolygon(p4);
            }
        }

        public void ElDraw(Point cur)
        {
            Point[] p =
                        {
                            new Point(cur.X, cur.Y),
                            new Point(prev.X, cur.Y),
                            new Point(prev.X, prev.Y),
                            new Point(cur.X, prev.Y)
                        };


            path.AddEllipse(new Rectangle(p[2].X, p[2].Y, cur.X - prev.X, cur.Y - prev.Y));
        }

        public void ClDraw(Point cur)
        {

            Point[] p =
                        {
                            new Point(cur.X, cur.Y),
                            new Point(prev.X, cur.Y),
                            new Point(prev.X, prev.Y),
                            new Point(cur.X, prev.Y)
                        };

            if (cur.X >= prev.X && cur.Y >= prev.Y)
            {
                path.AddEllipse(new Rectangle(prev.X, prev.Y, cur.X - prev.X, cur.X - prev.X));
            }
            else if (cur.X <= prev.X && cur.Y >= prev.Y)
            {
                path.AddEllipse(new Rectangle(prev.X, prev.Y, cur.X - prev.X, Math.Abs(cur.X - prev.X)));
            }
            else if (cur.X <= prev.X && cur.Y <= prev.Y)
            {
                path.AddEllipse(new Rectangle(prev.X, prev.Y, cur.X - prev.X, cur.X - prev.X));
            }
            else if (cur.X >= prev.X && cur.Y <= prev.Y)
            {
                path.AddEllipse(new Rectangle(prev.X, prev.Y, Math.Abs(cur.X - prev.X), (cur.X - prev.X) * -1));
            }


        }
    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AsteroidsWithClasses.Creation.Stars;

namespace AsteroidsWithClasses
{
   internal  class Creation
    { 
        internal class Aster : GameObject
        {
            public GraphicsPath gp, gp1;
            
            
            public Aster(int x, int y)
            {
                this.X = x;
                this.Y = y;
                realise();
             }


            public void realise()
            {
                gp = new GraphicsPath();
                gp1 = new GraphicsPath();
                Point[] part1 =
            {
                new Point(X, Y - 25),
                new Point(X + 25, Y + 10),
                new Point(X - 25, Y + 10)
            };
                Point[] part2 =
                {
                new Point(X - 25, Y - 10),
                new Point(X + 25, Y - 10),
                new Point(X, Y + 25)
            };
                gp.AddPolygon(part1);
                gp1.AddPolygon(part2);
            }

            public void Draw(Graphics e)
            {
                SolidBrush sbr = new SolidBrush(Color.Red);
                e.FillPath(sbr, gp);
                e.FillPath(sbr, gp1);
            }
        }

        internal class Stars : GameObject
        {
            GraphicsPath Gp;
            

            public Stars(int x, int y) 
            {
                this.X = x;
                this.Y = y;
                realise();
            }


            public void realise()
            {
                Gp = new GraphicsPath();
                Gp.AddEllipse(X, Y, 30, 30);  
            }
            public void Draw(Graphics e)
            {
                SolidBrush sb = new SolidBrush(Color.White);
                e.FillPath(sb, Gp);
            }
        }

        internal class Bullet : GameObject
        {
            GraphicsPath gpath, gpath1;

            public Bullet(int x, int y)
            {
                this.X = x;
                this.Y = y;
                realise();
            }

            public void realise()
            {
                gpath = new GraphicsPath();
                gpath1 = new GraphicsPath();
                gpath.AddEllipse(X - 5, Y - 13, 10, 26);
                gpath1.AddEllipse(X - 13, Y - 5, 26, 10);
            }

            public void Draw(Graphics e)
            {
                SolidBrush sbr = new SolidBrush(Color.Green);
                e.FillPath(sbr, gpath);
                e.FillPath(sbr, gpath1);
            }
        }

        internal class Ship : GameObject
        {
            GraphicsPath gpath2;

            public Ship(int x, int y)
            {
                this.X = x;
                this.Y = y;
                realise();
            }

            public void realise()
            {
                gpath2 = new GraphicsPath();
                Point[] p =
           {
                new Point(X, Y - 65),
                new Point(X + 65, Y - 35),
                new Point(X + 65, Y + 35),
                new Point(X, Y + 65),
                new Point(X - 65, Y + 35),
                new Point(X - 65, Y - 35)
        };
                gpath2.AddPolygon(p);
            }

            public void Draw(Graphics e)
            {
                SolidBrush sbr = new SolidBrush(Color.Yellow);
                e.FillPath(sbr, gpath2);
            }
        }

        internal class Gun : GameObject
        {
            GraphicsPath gpath3;

            public Gun(int x, int y)
            {
                this.X = x;
                this.Y = y;
                realise();
            }

            public void realise()
            {
                gpath3 = new GraphicsPath();
                Point[] gun =
           {
                new Point(X-15,Y-5),
                new Point(X,Y-25),
                new Point(X+15,Y-5),
                new Point(X+6,Y-5),
                new Point(X+6,Y+25),
                new Point(X-6,Y+25),
                new Point(X-6,Y-5)
            };

                gpath3.AddPolygon(gun);
            }

            public void Draw(Graphics e)
            {
                SolidBrush sbr = new SolidBrush(Color.Green);
                e.FillPath(sbr, gpath3);
            }
            
        }

        public void DrawObjects(Graphics e)
        {
            
        }

























































































































































           public class GameObject
            {
            public int X, Y;
            private int dx, dy;
            private int Dx

              
            }
        }
    }
}

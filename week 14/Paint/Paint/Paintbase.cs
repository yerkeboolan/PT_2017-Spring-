using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint
{
    public class Paintbase
    {
        public enum Shape {
            Pen, Line, Ellipse, Triangle, Rectangle, Rhombus, RTriangle,
            Fill, Erase
        }
        public Shape currentShape;
        public Color color;
        public Pen pen;
        public float width;

        public PictureBox pictureBox;
        public Bitmap bitmap;
        public Graphics g;
        public GraphicsPath gp;
        public Point prev;
        public Color origin, fill;
        public bool Clicked = false;


        public Queue<Point> q = new Queue<Point>();


        public Paintbase(PictureBox pictureBox)
        {
            this.pictureBox = pictureBox;
            bitmap = new Bitmap(pictureBox.Width, pictureBox.Height);
            this.pictureBox.Image = bitmap;
            g = Graphics.FromImage(bitmap);
            g.Clear(Color.White);

            gp = new GraphicsPath();
            color = Color.DarkBlue;
            width = 1;
            pen = new Pen(color, width);

            currentShape = Shape.Pen;
        }

        public void MouseDown(MouseEventArgs mouseEventArgs)
        {
            if (currentShape == Shape.Fill)
            {
                Fill(mouseEventArgs.Location.X, mouseEventArgs.Location.Y);
                pictureBox.Refresh();
                return;
            }
            Clicked = true;
            prev = mouseEventArgs.Location;

             
        }
        private void Fill(int x, int y)
        {
            q.Enqueue(new Point(x, y));
            Color inColor = bitmap.GetPixel(x, y);
            
            while (q.Count > 0) 
            {
                Point v = q.Dequeue();
                Check(v.X - 1, v.Y, inColor);
                Check(v.X + 1, v.Y, inColor);
                Check(v.X, v.Y - 1, inColor);
                Check(v.X, v.Y + 1, inColor);
            }
           
            pictureBox.Refresh();
        }

        private void Check(int x, int y, Color getPixel)
        {
            if (x <= 0 || y <= 0 || x >= pictureBox.Width || y >= pictureBox.Height) return;
            if (getPixel != bitmap.GetPixel(x, y)) return;
            bitmap.SetPixel(x, y, color);
            
            q.Enqueue(new Point(x, y));
        }

        public void MouseUp(object sender, MouseEventArgs e)
        {
            Clicked = false;
            if (gp != null)
                g.DrawPath(pen, gp);
            pictureBox.Refresh();
        }

        public void SetColor(Color c)
        {
            color = c;
            pen = new Pen(c, width);
        }

        public void ChangeShape(string name)
        {
            switch (name)
            {
                case "Pen":
                    currentShape = Shape.Pen;
                    break;
                case "Rectangle":
                    currentShape = Shape.Rectangle;
                    break;
                case "Ellipse":
                    currentShape = Shape.Ellipse;
                    break;
                case "Erase":
                    currentShape = Shape.Erase;
                    break;
                case "Line":
                    currentShape = Shape.Line;
                    break;
                case "Triangle":
                    currentShape = Shape.Triangle;
                    break;
                case "Rhombus":
                    currentShape = Shape.Rhombus;
                    break;
                case "Fill":
                    currentShape = Shape.Fill;
                    break;
                case "RTriangle":
                    currentShape = Shape.RTriangle;
                    break;
              
               
            }
        }

        public void Save()
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "JPEG|*.jpg|PNG|*.png";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string FileName = sfd.FileName;
                bitmap.Save(FileName);
            }
        }

        public void New()
        {
            g.Clear(Color.White);
            gp.Reset();
            pictureBox.Image = bitmap;
        }

        public void Open()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "JPEG|*.jpg|PNG|*.png";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string filename = ofd.FileName;
                bitmap = new Bitmap(Image.FromFile(filename), pictureBox.Size);

                pictureBox.Image = bitmap;
                g = Graphics.FromImage(bitmap);
            }
        }

        public void onPaint(object sender, PaintEventArgs e)
        {
            if(gp != null)
                e.Graphics.DrawPath(pen, gp);
        }

        public void SetWidth(float w)
        {
            width = w;
            pen = new Pen(color, w);
        }


        public void MouseMove(object sender, MouseEventArgs e)
        {
            if (!Clicked) return;
            switch (currentShape)
            {
                case Shape.Pen:
                    g.DrawLine(pen, prev, e.Location);
                    prev = e.Location;
                    break;
                case Shape.Rectangle:
                    gp.Reset();
                    Point[] pt = {
                        prev, new Point(e.Location.X, prev.Y), e.Location, new Point(prev.X, e.Location.Y)
                    };
                    gp.AddPolygon(pt);
                    break;
                case Shape.Ellipse:
                    gp.Reset();
                    gp.AddEllipse(new Rectangle(prev, new Size(e.Location.X - prev.X, e.Location.Y - prev.Y)));
                    break;
                case Shape.Erase:
                    gp.Reset();
                    g.FillEllipse(Brushes.White, e.Location.X - 10, e.Location.Y - 10, 20, 20);
                    break;
                case Shape.Line:    
                    gp.Reset();
                    gp.AddLine(prev, e.Location);
                    break;
                case Shape.Triangle:
                    gp.Reset();
                    if (e.Location.X >= prev.X && e.Location.Y >= prev.Y)
                    {
                        gp.AddPolygon(new Point[]
                        {
                            new Point(e.Location.X, e.Location.Y),
                            new Point(prev.X, e.Location.Y),
                            new Point(prev.X, prev.Y)
                        });
                    }
                    else if (e.Location.X <= prev.X && e.Location.Y >= prev.Y)
                    {
                        gp.AddPolygon(new Point[]
                        {
                            new Point(e.Location.X, e.Location.Y),
                            new Point(e.Location.X, prev.Y),
                            new Point(prev.X, e.Location.Y)
                        });
                    }
                    else if (e.Location.Y <= prev.Y && e.Location.X <= prev.X)
                    {
                        gp.AddPolygon(new Point[]
                        {
                            new Point(e.Location.X, e.Location.Y),
                            new Point(e.Location.X, prev.Y),
                            new Point(prev.X, prev.Y)
                        });
                    }
                    else
                    {
                        gp.AddPolygon(new Point[]
                        {
                            new Point(prev.X, e.Location.Y),
                            new Point(e.Location.X, prev.Y),
                            new Point(prev.X, prev.Y)
                        });
                    }
                    break;
                case Shape.Rhombus:
                    gp.Reset();
                    gp.AddPolygon(new Point[]
                    {
                        e.Location,
                        new Point((e.Location.X + prev.X) / 2, (e.Location.Y - prev.Y)*2 + prev.Y),
                        new Point(prev.X, e.Location.Y),
                        new Point(((e.Location.X + prev.X) / 2), prev.Y)
                    
                    });
                    break;
                case Shape.RTriangle:
                    gp.Reset();
                    gp.AddPolygon(new Point[]                            {
                        new Point(e.Location.X, e.Location.Y),
                            new Point((e.Location.X - prev.X) / 2 + prev.X, (e.Location.Y - prev.Y) + prev.Y),
                            new Point(prev.X, e.Location.Y),
                            new Point((e.Location.X - prev.X) / 2 + prev.X, prev.Y)
                        });
                    break;
              
                   
            }


            pictureBox.Refresh();
        }



       
        
        }
    }
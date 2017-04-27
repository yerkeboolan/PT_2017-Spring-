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
    class Paint
    {
        enum Shape {
            Pen, Line, Ellipse, Circle, Triangle, Rectangle, Rhombus,
            Fill, Erase
        }
        Shape currentShape;
        Color color;
        Pen pen;
        float width;

        PictureBox pictureBox;
        Bitmap bitmap;
        Graphics g;
        GraphicsPath gp;

        public Paint(PictureBox pictureBox)
        {
            this.pictureBox = pictureBox;
            bitmap = new Bitmap(pictureBox.Width, pictureBox.Height);
            this.pictureBox.Image = bitmap;
            g = Graphics.FromImage(bitmap);
            g.Clear(Color.White);

            gp = new GraphicsPath();
            color = Color.Red;
            width = 1;
            pen = new Pen(color, width);

            currentShape = Shape.Pen;
        }

        internal void MouseUp(object sender, MouseEventArgs e)
        {
            Clicked = false;
            g.DrawPath(pen, gp);
        }

        public void SetColor(Color c)
        {
            color = c;
            pen = new Pen(c, width);
        }

        internal void ChangeShape(string name)
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
                // ...
            }
        }

        internal void Save()
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "JPEG|*.jpg|PNG|*.png";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string FileName = sfd.FileName;
                bitmap.Save(FileName);
            }
        }

        internal void New()
        {
            g.Clear(Color.White);
            pictureBox.Image = bitmap;
        }

        internal void Open()
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

        internal void onPaint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawPath(pen, gp);
        }

        public void SetWidth(float w)
        {
            width = w;
            pen = new Pen(color, w);
        }

        Point prev;
        bool Clicked = false;

        public void MouseDown(object sender, MouseEventArgs e)
        {
            if (currentShape == Shape.Fill)
            {
                Fill(e.Location);
                return;
            }
            Clicked = true;
            prev = e.Location;
        }

        private void Fill(Point location)
        {

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
                    g.FillEllipse(Brushes.White, e.Location.X - 10, e.Location.Y - 10, 20, 20);
                    break;
            }
            pictureBox.Refresh();
        }

    }
}

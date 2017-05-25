using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrafficLight
{
    public partial class Form1 : Form
    {

        Graphics g;
        SolidBrush red = new SolidBrush(Color.Red);
        SolidBrush yellow = new SolidBrush(Color.Yellow);
        SolidBrush green = new SolidBrush(Color.Green);
        Pen pen = new Pen(Color.Black, 3);


        int c = 0;

        GraphicsPath path = new GraphicsPath();

        public Form1()
        { 
          InitializeComponent();

            g = this.CreateGraphics();
            timer1.Interval = 300;
            timer1.Enabled = true;
            
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            path.AddEllipse(200, 100, 100, 100);
            path.AddEllipse(200, 200, 100, 100);
            path.AddEllipse(200, 300, 100, 100);
            path.AddRectangle(new Rectangle(200, 100, 100, 300));
            g.DrawPath(pen, path);

            if (c <= 2)
            {
                g.FillEllipse(red, 200, 100, 100, 100);
            }
            else if (c > 2 && c <= 4)
            {
                g.FillEllipse(yellow, 200, 200, 100, 100);
            }
            else
            {
                g.FillEllipse(green, 200, 300, 100, 100);
            }

            if (c > 6)
            {
                c = 0;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            c++;
            Refresh();
            path.Reset();
        }
    }
}

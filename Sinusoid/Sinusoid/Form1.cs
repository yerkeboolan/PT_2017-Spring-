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

namespace Sinusoid
{
    public partial class Form1 : Form
    {

        Graphics g;
        Pen pen1 = new Pen(Color.Red);
        Pen pen2 = new Pen(Color.Blue, 2);
        SolidBrush b1 = new SolidBrush(Color.Black);
        GraphicsPath path1 = new GraphicsPath();

        Font f = new Font(FontFamily.GenericSerif, 20);

        static double x = 0;
        static double y = 0;

        static int c = 1;
        static int xp;
        static int yp;

        public Form1()
        {
            InitializeComponent();
            g = this.CreateGraphics();
            timer1.Enabled = true;
            timer1.Interval = 3;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (c == 1)
            {
                g.DrawLine(pen1, 93, 50, 93, 350);
            }

            path1.AddLine(xp, yp, (int)x, (int)y + 310);
            g.DrawPath(pen2, path1);
            g.DrawLine(pen1, 0, 250, 797, 250);
            g.FillEllipse(b1, new Rectangle((int)x, (int)y + 200, 1, 1));

            for(int i = 0; i < 797; i++)
            {
                if(i % 20 == 0)
                {
                    g.DrawLine(pen1, i, 310, i + 10, 310);
                    g.DrawLine(pen1, i, 195, i + 7, 195);
                }
            }

            g.DrawString("1", f, b1, 70, 160);
            g.DrawString("-1", f, b1, 60, 310);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            xp = (int)x;
            yp = (int)y + 310;

            x++;
            y += Math.Sin((180 + x) * (Math.PI / 180));
            if (x > Width)
            {
                path1.Reset();
                x = 0;
                y = 0;
                xp = (int)x;
                yp = (int)y + 310;
                c = 2;

            }
            Refresh();

        }
    }
}

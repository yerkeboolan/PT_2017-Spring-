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

namespace DrivingCar
{
    public partial class Form1 : Form
    {
        class Car
        {
            private int x, y;
            private GraphicsPath gp, gp2;
            public Car(int x, int y)
            {
                this.x = x;
                this.y = y;
                init(); 
            }


            public void init()
            {
                gp = new GraphicsPath();
                gp.AddPolygon(new Point[]
                {
                    new Point(x, y),
                    new Point(x + 100, y),
                    new Point(x + 100, y + 50),
                    new Point(x + 150, y + 50),
                    new Point(x + 150, y + 100),
                    new Point(x - 50, y + 100),
                    new Point(x - 50, y + 50),
                    new Point(x, y + 50)
                });
                gp2 = new GraphicsPath();
                gp2.AddEllipse(x - 10, y + 75, 50, 50);
                gp2.AddEllipse(x + 50, y + 75, 50, 50);
                    
            }

            public void Draw(Graphics e)
            {
                e.FillPath(Brushes.Red, gp);
                e.FillPath(Brushes.Green, gp2);
            }

            private int dx = 3, dy = 0;


            public void Move(int W, int H)
            {
                W -= 150;
                H -= 100;

                var nX = x + dx;
                var nY = y + dy;
                if (nX < 50 || nX > W) dx = -dx;
                if (nY < 50 || nY > H) dy = -dy;
                x = x + dx;
                y = y + dy;
            }
        }

        private Car c;
        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 5;
            timer1.Enabled = true;
            c = new Car(50, 50);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            c.Move(Width, Height);
            c.init();
            pictureBox1.Refresh();
            
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            c.Draw(e.Graphics);
        }
    }
}
 
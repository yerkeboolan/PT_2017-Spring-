using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameAsteroids
{
    public partial class Form1 : Form
    {
        Graphics graph;
        SolidBrush brush;
        int x = 0, dx = 10;
        public Form1()
        {
            InitializeComponent();
            graph = this.CreateGraphics();
            brush = new SolidBrush(Color.Red);

            mytimer.Enabled = true;
            mytimer.Interval = 100;
           }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            graph.FillEllipse(brush, x, 100, 100, 100);
        }

        private void mytimer_Tick(object sender, EventArgs e)
        {
            if (x + 100 > Width)
                dx = -10;
            else if (x < 0)
                dx = 10;

            x += dx;

            Refresh();              
            
        }
    }
}

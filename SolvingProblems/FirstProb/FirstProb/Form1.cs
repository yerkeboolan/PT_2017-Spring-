using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstProb
{
    public partial class Form1 : Form
    {
        Graphics g;
        SolidBrush brush;
        int x, y;
        public Form1()
        {
            InitializeComponent();
            g = this.CreateGraphics();
            brush = new SolidBrush(Color.Red);

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            x = e.Location.X;
            y = e.Location.Y;
            
            
            Refresh();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            g.FillEllipse(brush, x-50,  y-50, 100, 100);
        }
    }
}

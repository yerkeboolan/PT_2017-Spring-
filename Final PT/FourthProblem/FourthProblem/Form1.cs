using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FourthProblem
{
    public partial class Form1 : Form
    {
        Graphics g;
        SolidBrush sbr;
        int x, y;

        public Form1()
        {
            InitializeComponent();
            g = this.CreateGraphics();
            sbr = new SolidBrush(Color.Red);
            timer1.Enabled = true;
            timer1.Interval = 100;
            
            
        }

      

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            x = e.Location.X;
            y = e.Location.Y;


            Refresh();
        }

        

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            g.FillEllipse(sbr, x - 25, y - 25, 50, 50);
        }

        
    }
}















    


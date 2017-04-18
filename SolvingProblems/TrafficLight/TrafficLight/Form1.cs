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
        GraphicsPath path;

        public Form1()
        { 
          InitializeComponent();

            g = this.CreateGraphics();

            path = new GraphicsPath(); 
            
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}

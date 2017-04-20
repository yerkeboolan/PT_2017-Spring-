using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Increase
{
    public partial class Form1 : Form
    {
        Graphics g;
        Pen pen;
  
        
        

        public Form1()
        {
            InitializeComponent();
            g = this.CreateGraphics();
            pen = new Pen(Color.Red);
            

        }

      
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            g.DrawEllipse(pen, trackBar2.Value, trackBar3.Value, trackBar1.Value, trackBar1.Value);
            
           

            
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

            Refresh();
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            Refresh();
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            
            Refresh();
        }

      
    }
}

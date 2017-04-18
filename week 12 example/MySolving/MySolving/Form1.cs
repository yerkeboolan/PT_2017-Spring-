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

namespace MySolving
{
    public partial class Form1 : Form
    {
        CarClass create = new CarClass();
        Graphics g;
       
        SolidBrush brush;
        SolidBrush brush1;
        
               
        public Form1()
        {
            InitializeComponent();
            g = this.CreateGraphics();


            brush = new SolidBrush(Color.Blue);
            brush1 = new SolidBrush(Color.Black);

            create.Polygon(500, 550);

            create.Kolesa(50, 200);
            create.Kolesa(50, 200);
            
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            g.FillPath(brush, create.path);
            g.FillPath(brush1, create.path1);
        }
    }
}

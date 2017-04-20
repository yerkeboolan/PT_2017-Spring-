using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ValueChanging
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Text = "Value is:" + " " + "0";  
         
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label1.Text = "Value is:" + " " + trackBar1.Value.ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace masele
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


            label1.Font = new Font("Times New Roman", 18, FontStyle.Bold);
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label1.Font = new Font("Times New Roman", trackBar1.Value, FontStyle.Bold);
        }
    }
}

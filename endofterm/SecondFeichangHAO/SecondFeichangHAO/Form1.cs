using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecondFeichangHAO
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();

            label2.Font = new Font("Arial", 14, FontStyle.Bold);
           

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label2.Font = new Font("Arial", trackBar1.Value, FontStyle.Bold);

            Refresh();
        }
    }
}

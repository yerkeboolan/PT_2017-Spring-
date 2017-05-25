using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ThirdProblem
{

    public partial class Form1 : Form
    {
        static int x = 0;

        
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            x++;
            if (x == 1)
            {
                btn.BackColor = Color.Red;
            }
            if (x == 2)
            {
                btn.BackColor = Color.Yellow;
            }
                
            if (x == 3)
            {
                btn.BackColor = Color.Blue;
                x = 0;
            }
                
            
           

        }
    }
}





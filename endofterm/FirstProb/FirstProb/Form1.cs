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
        private string a = "admin";
        private string b = "password123!";

        public Form1()
        {
            InitializeComponent();

           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == a && textBox2.Text == b)
                MessageBox.Show("Success");
            else if (textBox1.Text == "" && textBox2.Text == "")
                MessageBox.Show("Error validation");
            else if ((textBox1.Text == a && textBox2.Text == "") || (textBox1.Text == "" && textBox2.Text == b))
                MessageBox.Show("Error validation");
            else if (textBox2.TextLength < 8)
                MessageBox.Show("Error validation" + "\n" + "Password length should be greater than 8");
            else MessageBox.Show("Error validation");
        }
    }
}

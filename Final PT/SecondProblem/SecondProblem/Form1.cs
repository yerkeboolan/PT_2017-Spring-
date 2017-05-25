using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecondProblem
{
  
public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
            textBox1.Text = "0";
    }
    int c = 0;

    private void button1_Click(object sender, EventArgs e)
    {
        Button btn = sender as Button;
        int a = int.Parse(btn.Text);
        a++;
        if (a % 2 == 0)
        {
            c++;
            textBox1.Text = c.ToString();
        }
        btn.Text = a.ToString();
    }
}
}
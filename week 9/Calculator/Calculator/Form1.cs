using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        CalcClass calc = new CalcClass();
        


        public Form1()
        {
            InitializeComponent();
        }

        

        private void numbers_click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (display.Text == "Error")
                display.Text = btn.Text;
            else if (display.Text == "0")
                display.Text = btn.Text;
            else
                display.Text += btn.Text;
        }

        private void operation_click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            calc.firstnum = double.Parse(display.Text); 
            calc.operation = btn.Text;
            calc.again = false;
            
            display.Text = "";       
        }

        private void OperationOnce_click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            calc.firstnum = double.Parse(display.Text);
            calc.operation = btn.Text;
            calc.CalculateOnce();
            if (calc.mistake)
            {
                display.Text = "Error";
                calc = new CalcClass();
            } else
            {
                display.Text = calc.result.ToString();
            }
        }

        private void result_click(object sender, EventArgs e)
        { 
            if(calc.secondnum == 0)
            {
                calc.secondnum = calc.firstnum;
            } else  
            calc.secondnum = double.Parse(display.Text);
            calc.calculate();
            if (calc.mistake)
            {
                display.Text = "Error";
            }
            else
            {
                display.Text = calc.result.ToString();
            }
        }

        private void Ce_click(object sender, EventArgs e)
        {
            display.Clear();
            calc.memory = 0;
            display.Text = "0"; 
        }

        private void c_click(object sender, EventArgs e)
        {
            display.Text = "";
            calc.firstnum = 0;
            calc.secondnum = 0;
            calc.result = 0;
            calc.operation = "";
            display.Text = "0";
        }

        private void erase_click(object sender, EventArgs e)
        {
            if (display.Text != "")
            {
                display.Text = display.Text.Remove(display.Text.Length - 1);
            }   

            if(display.Text == "")
            {
                display.Text = "0";
            }  
        }

        private void plusminus_click(object sender, EventArgs e)
        {
            if (display.Text != "")
                if (display.Text[0] == '-')
                    display.Text = display.Text.Remove(0, 1);
                else display.Text = '-' + display.Text;
        }

        private void p_click(object sender, EventArgs e)
        {
            if (display.Text == ",")
                display.Text = "0,";

            if (display.Text.IndexOf(",") == -1)
                display.Text = display.Text + ",";
        }

     

        private void ms_click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            calc.memory = double.Parse(display.Text);
        }

        private void mr_click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            display.Text = "";
            display.Text = calc.memory.ToString();
            
        }

        private void mc_click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            calc.memory = 0;
        }

        private void mplus_click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            calc.mplus = double.Parse(display.Text);
            calc.result = calc.memory + calc.mplus;
            calc.memory = calc.result;
            
            
        }

        private void mminus_click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            calc.mminus = double.Parse(display.Text);
            calc.result = calc.memory - calc.mminus;
            calc.memory = calc.result;
            
        }

       
    }
    }


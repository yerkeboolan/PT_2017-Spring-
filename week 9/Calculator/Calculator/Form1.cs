﻿using System;
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
            display.Text = "0";
        }

        private void numbers_click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if(display.Text == "0")
                    display.Text = btn.Text;
           else 
            display.Text += btn.Text;
        }

        private void operation_click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            calc.firstnum = double.Parse(display.Text); 
            calc.operation = btn.Text;
            display.Text = "";
            
        }

        private void result_click(object sender, EventArgs e)
        {
            calc.secondnum = double.Parse(display.Text);
            calc.calculate();
            display.Text = calc.result.ToString();
        }

        private void Ce_click(object sender, EventArgs e)
        {
            display.Clear();
            display.Text = "0";
        }

        private void c_click(object sender, EventArgs e)
        {
            display.Text = "";
            calc.firstnum = 0;
            calc.secondnum = 0;
            calc.result = 0;
            calc.operation = "";
        }

        private void erase_click(object sender, EventArgs e)
        {
            if (display.Text != "")
            {
                display.Text = display.Text.Remove(display.Text.Length - 1);
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
            if (display.Text == ".")
                display.Text = "0.";

            if (display.Text.IndexOf(".") == -1)
                display.Text = display.Text + ".";
        }

       
        }
    }

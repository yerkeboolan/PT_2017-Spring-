using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class CalcClass
    {
        public double firstnum;
        public double secondnum;
        public double result;
        public string operation;
        public double memory;
        public double mplus;
        public double mminus;


        public void calculate()
        {
            switch(operation)
            {
                case "+":
                    result = firstnum + secondnum;
                    break;
                case "-":
                    result = firstnum - secondnum;
                    break;
                case "*":
                    result = firstnum * secondnum;
                    break;
                case "/":
                    result = firstnum / secondnum;
                    break;
                case "%":
                    result = (firstnum * secondnum) / 100;
                    break;
                case "x^y":
                    result = Math.Pow(firstnum, secondnum);
                    break;
            }
        }


        public int fact(int n)
        {
            int res;
            res = 1;
            for (int i = 1; i <= n; i++)
                res *= i;
            return res;
        }

    }
    }


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
                    result = firstnum / 100;
                    break;
            }
        }
    }
}

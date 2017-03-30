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
        public double recent;

        public bool mistake = false;
        public bool again = false;
        public double foronce = 1;


        public void calculate()
        {
            if (!again)
            {
                switch (operation)
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
                        if (secondnum == 0)
                        {
                            mistake = true;
                        }
                        result = firstnum / secondnum;
                        break;
                    case "%":
                        result = (firstnum * secondnum) / 100;
                        break;
                    case "x^y":
                        if (firstnum < 0 && (1 / secondnum) % 2 == 0)
                        {
                            mistake = true;
                        }
                        result = Math.Pow(firstnum, secondnum);
                        break;
                    case "n√m":
                        if (firstnum < 0 && secondnum % 2 == 0)
                        {
                            mistake = true;
                        }
                        else
                        {
                            result = Math.Pow(firstnum, 1 / secondnum);
                            break;
                        }
                        break;
                }
                recent = secondnum;
            }
            else if (again)
            {
                switch(operation)
                {
                    case "+":
                        result += recent;
                        break;
                    case "-":
                        result -= recent;
                        break;
                    case "*":
                        result *= recent;
                        break;
                    case "/":
                        if(secondnum == 0)
                        {
                            mistake = false;
                        }
                        result /= recent;
                        break;
                    case "%":
                        result *= (recent / 100);
                        break;
                    case "x^y":
                        result = Math.Pow(result, recent);
                        break;
                    case "n√m":
                        result = Math.Pow(result, 1 / recent);
                        break;
                }
            }
            again = true;
        }


        public void CalculateOnce()
        {
            switch(operation)
            {
                case "n!":
                    if(firstnum % 1 == 0)
                    {
                        for(int i = 2; i < firstnum + 1; i++)
                        {
                            foronce *= i;
                        }
                        result = foronce;
                        foronce = 1;
                    }
                    else
                    {
                        mistake = true;
                    }
                    break;
                case "1/x":
                    if(firstnum == 0)
                    {
                        mistake = true;
                    }
                    result = 1 / firstnum;
                    break;
                case "x^2":
                    result = Math.Pow(firstnum, 2);
                    break;
                case "x^3":
                    result = Math.Pow(firstnum, 3);
                    break;
                case "sin":
                    result = Math.Sin((firstnum * Math.PI) / 180);
                    break;
                case "cos":
                    result = Math.Cos((firstnum * Math.PI) / 180);
                    break;
                case "tan":
                    result = Math.Tan((firstnum * Math.PI) / 180);
                    break;
                case "√":
                    if(firstnum < 0)
                    {
                        mistake = true;
                    }
                    result = Math.Sqrt(firstnum);
                    break;
                case "e^x":
                    if(firstnum <= 0)
                    {
                        mistake = true;
                    }   else
                    {
                        result = Math.Exp(firstnum);
                    }
                    break;
            }
        }

    }
    }


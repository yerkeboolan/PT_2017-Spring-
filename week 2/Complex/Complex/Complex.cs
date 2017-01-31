using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complex
{
    class Complex
    {
        private int a, b;

        public Complex() { }

        public Complex(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public int A
        {
            get { return a; }
            set
            {
                a = value;
            }

        }

        public int B
        {
            get { return b; }
            set
            {
                b = value;
            }
        }

        public static Complex operator +(Complex x, Complex y)
        {
            Complex c = new Complex();
            c.A = x.A + y.A;
            c.B = x.B + y.B;
            return c; 
        }

        public override string ToString()
        {
            return a + " " + "+" + " " + b + "i";
        }
    }
}

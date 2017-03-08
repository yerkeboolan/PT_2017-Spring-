using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializationComplex
{
    [Serializable]
    class Complex
    {

        private int x, y;
        public Complex() { }
        public Complex(int _x, int _y)
        {
            x = _x;
            y = _y;
        }

        public int X
        {
            get { return x; }
            set
            {
                x = value;
            }
        }

        public int Y
        {
            get { return y; }
            set
            {
                y = value;
            }
        }

        public static Complex operator +(Complex a, Complex b)
        {
            Complex c = new Complex();
            c.X = a.X * b.Y + b.X * a.Y;
            c.Y = a.Y * b.Y;
            return c;
        }

        public static Complex operator -(Complex a, Complex b)
        {
            Complex c = new Complex();
            c.X = a.X * b.Y - b.X * a.Y;
            c.Y = a.Y * b.Y;
            return c;
        }


        public static Complex operator *(Complex a, Complex b)
        {
            Complex c = new Complex();
            c.X = a.X * b.X;
            c.Y = a.Y * b.Y;
            return c;
        }

        public static Complex operator /(Complex a, Complex b)
        {
            Complex c = new Complex();
            c.X = a.X * b.Y;
            c.Y = a.Y * b.X;
            return c;

        }
       

        public override string ToString()
        {
            int d = gcd(x, y);
            if (x / d == 0)
            {
                return "0";
            }
            else if (x / d == y / d)
            {
                return "1";
            }
            else if (y / d == 0)
            {
                return "Error";
            }
            else
            {
                return x / d + "/" + y / d;
            }   
        }
        static int gcd(int x, int y)
        {
            if (x == 0)
            {
                return y;
            }
            else
            {
                return gcd(y % x, x);
            }
        }

    }
}

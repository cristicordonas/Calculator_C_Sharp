using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Complex
    {
        private float real, imaginary;
        public Complex()
        {
            real = 0;
            imaginary = 0;
        }
        public float getReal()
        { return real; }
        public float getImaginary()
        { return imaginary; }
        public void setReal(float r)
        { real = r; }
        public void setImaginary(float i)
        { imaginary = i; }
        public float modulus()
        {
            float m;
            m = (float)Math.Sqrt(real * real + imaginary * imaginary);
            return m;
        }
        public static Complex operator+ (Complex c1,Complex c2)
        {
            Complex c=new Complex();
            c.real = c1.real + c2.real;
            c.imaginary = c1.imaginary + c2.imaginary;
            return c;
        }
        public static Complex operator- (Complex c1, Complex c2)
        {
            Complex c = new Complex();
            c.real = c1.real - c2.real;
            c.imaginary = c1.imaginary - c2.imaginary;
            return c;
        }
        public static Complex operator* (Complex c1, Complex c2)
        {
            Complex c = new Complex();
            c.real = c1.real * c2.real - c1.imaginary * c2.imaginary;
            c.imaginary = c1.real * c2.imaginary + c1.imaginary * c2.real;
            return c;
        }
        public static Complex operator/ (Complex c1, Complex c2)
        {
            Complex c = new Complex();
            c.real = (c1.real * c2.real + c1.imaginary * c2.imaginary) / (c2.real * c2.real + c2.imaginary * c2.imaginary);
            c.imaginary = (c1.imaginary * c2.real - c1.real * c2.imaginary) / (c2.real * c2.real + c2.imaginary * c2.imaginary);
            return c;
        }
        public string writeComplex()
        {
            string s;
            s = real.ToString();
            if (real == 0 && imaginary == 0)
                s = "0";
            if (real == 0 && imaginary != 0)
                s = imaginary.ToString() + 'i';
            if (real != 0)
            {
                s = real.ToString();
                if (imaginary > 0)
                    s += '+' + imaginary.ToString() + 'i';
                else if (imaginary < 0)
                    s += imaginary.ToString() + 'i';
            }
            return s;
        }
    }
}

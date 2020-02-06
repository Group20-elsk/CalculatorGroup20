using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorGroup20
{
    public class Calculator
    {
        public double Accumulator { get; private set; }

        public double Add(double a, double b)
        {
            Accumulator = a + b;
            return Accumulator;
        }

        public double Subtract(double a, double b)
        {
            Accumulator = a - b;
            return Accumulator;

        }
        public double Multiply(double a, double b)
        {
            Accumulator = a * b;
            return Accumulator;
        }

        public double Power(double x, double exp)
        {
            Accumulator = Math.Pow(x,exp);
            return Accumulator;
        }

        public double Divide(double a, double b)
        {
            try
            {
                if (b == 0)
                {
                    throw new DivideByZeroException("Divided by zero");
                }

                Accumulator = a / b;
                return Accumulator;

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            
        }

        public void Clear()
        {
            Accumulator = 0;
        }
    }
}

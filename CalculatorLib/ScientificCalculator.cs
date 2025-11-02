using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLib
{
    public class ScientificCalculator : Calculator
    {
        public override double Subtract(double a, double b)
        {
            if (Math.Abs(a - b) < 1e-8 * Math.Max(Math.Abs(a), Math.Abs(b)))
            {
                Console.WriteLine("The numbers are too close - possible loss of accuracy!");
            }
            return base.Subtract(a, b);
        }

        public double Pow(double a, double b)
        {
            LastResult = Math.Pow(a, b);
            CheckResult();
            return LastResult;
        }

        public double Sqrt(double a)
        {
            LastResult = Math.Sqrt(a);
            CheckResult();
            return LastResult;
        }

        public double Sin(double a)
        {
            LastResult = Math.Sin(a);
            CheckResult();
            return LastResult;
        }

        public double Cos(double a)
        {
            LastResult = Math.Cos(a);
            CheckResult();
            return LastResult;
        }
    }
}

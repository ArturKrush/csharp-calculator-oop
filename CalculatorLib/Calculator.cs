namespace CalculatorLib
{
    public class Calculator
    {
        private double lastResult;
        public double LastResult
        {
            get { return lastResult; }
            protected set { lastResult = value; }
        }

        public double Add(double a, double b)
        {
            LastResult = a + b;
            CheckResult();
            return LastResult;
        }

        public virtual double Subtract(double a, double b)
        {
            LastResult = a - b;
            CheckResult();
            return LastResult;
        }

        public double Multiply(double a, double b)
        {
            LastResult = a * b;
            CheckResult();
            return LastResult;
        }

        public double Divide(double a, double b)
        {
            LastResult = a / b;
            CheckResult();
            return LastResult;
        }

        public void CheckResult()
        {
            if (double.IsInfinity(LastResult))
                Console.WriteLine("Result is infinity — overflow occurred.");
            else if (double.IsNaN(LastResult))
                Console.WriteLine("Result is undefined — NaN occurred.");
        }
    }
}

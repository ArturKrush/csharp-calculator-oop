using CalculatorLib;
using System;
using System.Text;

namespace CalculatorApp
{
    public class Program
    {
        private static void Main(string[] args)
        {
            //Console.OutputEncoding = Encoding.UTF8;
            bool result;

            int CalcCode;
            int OpCode;
            double Op1;
            double Op2;

            while (true)
            {
                Console.WriteLine("Which calculator do you want to choose?");
                Console.WriteLine("1 - Standart, 2 - Programmer calculator, " +
                    "3 - Scientific calculator");
                do
                {
                    result = int.TryParse(Console.ReadLine(), out CalcCode);
                    if (!result)
                        Console.WriteLine("Code must be integer from 1 to 3. " +
                            "Try again.");
                }
                while (!result || CalcCode < 1 || CalcCode > 3);

                Console.WriteLine("Which operation to execute?");
                SuggestOperation(CalcCode);

                do
                {
                    result = int.TryParse(Console.ReadLine(), out OpCode);
                    if (!result)
                        Console.WriteLine("Code must be integer from 1 to 8. " +
                        "Try again.");
                }
                while (!result || CalcCode < 1 || CalcCode > 8);

                if (CalcCode == 1 && OpCode > 4)
                {
                    do
                    {
                        Console.WriteLine("There are no 5-8 operations for " +
                                                "Standart Calculator. Try again and check " +
                                                "that input is an integer.");
                        result = int.TryParse(Console.ReadLine(), out OpCode);
                    }
                    while (!result || OpCode < 1 || OpCode > 4);
                }

                Console.WriteLine("Enter first floating point or integer operator:");
                do
                {
                    result = double.TryParse(Console.ReadLine(), out Op1);
                    if (!result)
                        Console.WriteLine("Input error. Only numbers in n or n,###... format. " +
                    "Try again");
                }
                while (!result);

                Console.WriteLine("Enter second floating point or integer operator:");
                do
                {
                    result = double.TryParse(Console.ReadLine(), out Op2);
                    if (!result)
                        Console.WriteLine("Input error. Only numbers in n or n,###... format. " +
                    "Try again");
                    if(result && Op2 == 0)
                        throw new DivideByZeroException("You can not divide by zero.");
                }
                while (!result);

                ExecuteOp(CalcCode, OpCode, Op1, Op2);
            }
        }

        private static void SuggestOperation(int CalcCode)
        {
            switch (CalcCode)
            {
                case 1:
                    Console.WriteLine("1 - Add, 2 - Substruct, 3 - Multiply, " +
                        "4 - Divide");
                    break;
                case 2:
                    Console.WriteLine("1 - Add, 2 - Substract, 3 - Multiply," +
                        "4 - Divide, 5 - To Binary, 6 - To Hex, 7 - And, 8 - Or");
                    break;
                case 3:
                    Console.WriteLine("1 - Add, 2 - Substract (override), 3 - Multiply, " +
                        "4 - Divide, 5 - Pow, 6 - Sqrt, 7 - Sin, 8 - Cos");
                    break;
                default:
                    break;
            }
        }

        private static void ExecuteOp(int CalcCode, int OpCode, double Op1, double Op2)
        {
            if (CalcCode == 1)
            {
                Calculator calculator = new Calculator();
                switch (OpCode)
                {
                    case 1:
                        Console.WriteLine("Addition is: " + calculator.Add(Op1, Op2));
                        break;
                    case 2:
                        Console.WriteLine("Difference is: " + calculator.Subtract(Op1, Op2));
                        break;
                    case 3:
                        Console.WriteLine("Product is: " + calculator.Multiply(Op1, Op2));
                        break;
                    case 4:
                        Console.WriteLine("Division is: " + calculator.Divide(Op1, Op2));
                        break;
                }
            }
            else if (CalcCode == 2)
            {
                //ProgrammerCalculator progCalculator = new ProgrammerCalculator();
            }
            else if (CalcCode == 3)
            {
                //ScientificСalculator scienCalculator = new ScientificСalculator();
            }
        }
    }
}
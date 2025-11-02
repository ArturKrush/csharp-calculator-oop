using CalculatorLib;
using System;
using System.Text;

namespace CalculatorApp
{
    public class Program
    {
        private static void Main(string[] args)
        {
            bool result;
            //Console.OutputEncoding = Encoding.UTF8;
            while (true)
            {
                Console.WriteLine("Which calculator do you want to choose?");
                Console.WriteLine("1 - Standart, 2 - Programmer calculator, " +
                    "3 - Scientific calculator");
                result = int.TryParse(Console.ReadLine(), out int CalcCode);
                if (!result || CalcCode < 1 || CalcCode > 3)
                {
                    Console.WriteLine("Code must be integer from 1 to 3. " +
                        "Try again.");
                    continue;
                }

                Console.WriteLine("Which operation to execute?");
                SuggestOperation(CalcCode);

                result = int.TryParse(Console.ReadLine(), out int OpCode);
                if (!result || OpCode < 1 || OpCode > 8)
                {
                    Console.WriteLine("Code must be integer from 1 to 8. " +
                        "Try again.");
                    continue;
                }

                if (CalcCode == 1 && OpCode > 4)
                {
                    Console.WriteLine("There are no 5-8 operations for " +
                        "Standart Calculator. Try again.");
                    continue;
                }

                Console.WriteLine("Enter first floating point or integer operator:");
                result = double.TryParse(Console.ReadLine(), out double Op1);
                if (!result)
                {
                    Console.WriteLine("Input error. Only numbers in n or n.###... format. " +
                    "Try again");
                    continue;
                }

                Console.WriteLine("Enter second floating point or integer operator:");
                result = double.TryParse(Console.ReadLine(), out double Op2);
                if (!result)
                {
                    Console.WriteLine("Input error. Only numbers in n or n.###... format. " +
                    "Try again");
                    continue;
                }
                if (OpCode == 4 && Op2 == 0)
                    throw new DivideByZeroException("You can not divide by zero.");

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
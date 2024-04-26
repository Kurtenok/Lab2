using System;

namespace SolidPrinciplesExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculator = new Calculator();

            Console.WriteLine("Enter first number:");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Select operation (+, -, *, /):");
            char operation = Convert.ToChar(Console.ReadLine());

            IOperation op = null;

            switch (operation)
            {
                case '+':
                    op = new Addition();
                    break;
                case '-':
                    op = new Subtraction();
                    break;
                case '*':
                  //  op = new Multiplication();
                    break;
                case '/':
                 //   op = new Division();
                    break;
                default:
                    Console.WriteLine("Invalid operation selected.");
                    break;
            }

            if (op != null)
            {
                double result = calculator.Calculate(num1, num2, op);
                Console.WriteLine("Result: " + result);
            }

            Console.ReadLine();
        }
    }

    interface IOperation
    {
        double Execute(int num1, int num2);
    }
    public class Addition : IOperation
    {
        public double Execute(int num1, int num2)
        {
            return num1 + num2;
        }
    }

    public class Subtraction : IOperation
    {
        public double Execute(int num1, int num2)
        {
            return num1 - num2;
        }
    }

    


    class Calculator
    {
        public double Calculate(int num1, int num2, IOperation operation)
        {
            return operation.Execute(num1, num2);
        }
    }
}
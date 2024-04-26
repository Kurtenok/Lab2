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

            double result = 0;

            switch (operation)
            {
                case '+':
                    result = calculator.Add(num1, num2);
                    break;
                case '-':
                    result = calculator.Subtract(num1, num2);
                    break;
                case '*':
                    result = calculator.Multiply(num1, num2);
                    break;
                case '/':
                    result = calculator.Divide(num1, num2);
                    break;
                default:
                    Console.WriteLine("Invalid operation selected.");
                    break;
            }

            Console.WriteLine("Result: " + result);

            Console.ReadLine();
        }
    }

    class Calculator
    {
        public double Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public double Subtract(int num1, int num2)
        {
            return num1 - num2;
        }

        public double Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        public double Divide(int num1, int num2)
        {
            if (num2 == 0)
            {
                Console.WriteLine("Error: division by zero.");
                return 0;
            }
            return (double)num1 / num2;
        }
    }
}
using System;

namespace Math_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            double first = double.Parse(Console.ReadLine());
            char op= char.Parse(Console.ReadLine());
            double second = double.Parse(Console.ReadLine());
            Console.WriteLine(calculate(first, op, second));
        }
        static double calculate(double a, char op, double b)
        {
            double result = 0;
            switch (op)
            {
                case '+':
                    result = a + b;
                    break;
                case '-':
                    result = a - b;
                    break;
                case '/':
                    result = a / b;
                    break;
                case '*':
                    result = a * b;
                    break;
            }
            return result;
        }
    }
}

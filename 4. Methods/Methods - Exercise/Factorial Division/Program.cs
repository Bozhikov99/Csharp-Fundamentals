using System;


namespace Factorial_Division
{
    class Program
    {
        static void Main(string[] args)
        {
            double first = double.Parse(Console.ReadLine());
            double second = double.Parse(Console.ReadLine());
            double divideFactorial=(Factorial(first)/Factorial(second));
            Console.WriteLine($"{divideFactorial:f2}");
        }
        static double Factorial(double num)
        {
            double factorial = 1;
            for (int i = 1; i <= num; i++)
            {
                factorial *= i;
            }
            return factorial;
        }
    }
}

using System;
using System.ComponentModel;

namespace Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            string action = Console.ReadLine();
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            switch (action)
            {
                case "subtract":
                    substract(a, b);
                    break;
                case "add":
                    sum(a, b);
                    break;
                case "divide":
                    divide(a, b);
                    break;
                case "multiply":
                    multiply(a, b);
                    break;
            }
        }
        static void substract(int a, int b)
        {
            Console.WriteLine(a - b); 
        }
        static void sum(int a, int b)
        {
            Console.WriteLine(a+b);
        }
        static void divide(int a, int b)
        {
            Console.WriteLine(a/b);
        }
        static void multiply(int a, int b)
        {
            Console.WriteLine(a*b);
        }
    }
}

using System;
using System.Runtime.Serialization.Json;

namespace Math_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            double pow = double.Parse(Console.ReadLine());
            Console.WriteLine(power(number, pow));
        }
        static double power(double number, double pow)
        {
            double save = number;
            for (int i = 1; i < pow; i++)
            {
                number *= save;
            }
            return number;
        }
    }
}

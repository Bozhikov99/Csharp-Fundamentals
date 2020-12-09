using System;

namespace _2._3_Floating_equality
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double eps = 0.000001;
            double difference = a +(- b);
            bool isTrue = Math.Abs(difference) < eps;
            Console.WriteLine(isTrue);
        }
    }
}

using System;

namespace Center_Point
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstX = double.Parse(Console.ReadLine());
            double firstY = double.Parse(Console.ReadLine());
            double secondX = double.Parse(Console.ReadLine());
            double secondY = double.Parse(Console.ReadLine());
            if (GetDistance(firstX, firstY)<GetDistance(secondX, secondY))
            {
                Console.WriteLine($"({firstX}, {firstY})");
            }
            else
            {
                Console.WriteLine($"({secondX}, {secondY})");
            }
        }
        static double GetDistance(double X, double Y)
        {
            double distance = Math.Sqrt(Math.Pow(X, 2) + Math.Pow(Y, 2));
            return distance;
        }
    }
}

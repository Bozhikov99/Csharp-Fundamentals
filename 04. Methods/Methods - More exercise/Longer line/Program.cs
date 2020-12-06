using System;

namespace Longer_line
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            double x12 = double.Parse(Console.ReadLine());
            double y12 = double.Parse(Console.ReadLine());
            double x22 = double.Parse(Console.ReadLine());
            double y22 = double.Parse(Console.ReadLine());

            bool firstIsLonger = LineLength(x1, y1, x2, y2) >= LineLength(x12, y12, x22, y22);
            if (firstIsLonger==true)
            {
                bool firstIsCloser = DistanceFromCenter(x1, y1) <= DistanceFromCenter(x2, y2);
                if (firstIsCloser==true)
                {
                    Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
                }
                else
                {
                    Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
                }
            }
            else
            {
                bool firstIsCloser = DistanceFromCenter(x12, y12) <= DistanceFromCenter(x22, y22);
                if (firstIsCloser == true)
                {
                    Console.WriteLine($"({x12}, {y12})({x22}, {y22})");
                }
                else
                {
                    Console.WriteLine($"({x22}, {y22})({x12}, {y12})");
                }
            }
            
        }
        static double DistanceFromCenter(double X, double Y)
        {
            double distance = Math.Sqrt(Math.Pow(X, 2) + Math.Pow(Y, 2));
            return distance;
        }
        static double LineLength(double X, double Y, double secX ,double secY)
        {
            double length = Math.Sqrt(Math.Pow(X-secX,2)+Math.Pow(Y-secY,2));
            return length;
        }
    }
}

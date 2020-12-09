using System;

namespace Rectangle_area
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = int.Parse(Console.ReadLine());
            double height= int.Parse(Console.ReadLine());
            double area=Area(width, height);
            Console.WriteLine(area);
        }
        static double Area(double a, double b)
        {
            return a*b;
        }
    }
}

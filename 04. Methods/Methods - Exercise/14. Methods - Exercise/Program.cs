using System;
using System.Net.Http.Headers;

namespace _14._Methods___Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            Console.WriteLine(LowestNumber(a,b,c));
        }
        static double LowestNumber(double a, double b, double c)
        {
            double lowest =0;

            if (a<=b&&a <=c)
            {
                lowest = a;
            }
            else if (b <= c && b <= a)
            {
                lowest = b;
            }
            else if (c <= b && c <= a)
            {
                lowest = c;
            }
            return lowest;
        }
    }
}

using System;
using System.Linq;


namespace _3._Rounding_numbers
{
    class Program
    {
        static void Main(string[] args)
        {

            double[] raw =Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();

            for (int i = 0; i <= raw.Length-1; i++)
            {
                Console.WriteLine($"{Convert.ToDecimal(raw[i])} => {Convert.ToDecimal(Math.Round(raw[i], MidpointRounding.AwayFromZero))}");
            }
        }
    }
}

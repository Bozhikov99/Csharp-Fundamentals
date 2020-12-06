using System;

namespace _2._Data_Types_and_Variables___Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal dollar = decimal.Parse(Console.ReadLine());
            Console.WriteLine($"{(decimal)1.31*dollar:f3}");
        }
    }
}

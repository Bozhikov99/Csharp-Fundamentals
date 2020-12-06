using System;

namespace _2._Numbers_in_reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            for (int i = numbers.Length-1; i >=0; i--)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
            for (int k = 0; k <numbers.Length ; k++)
            {
                Console.Write($"{numbers[k]} ");
            }
        }
    }
}

using System;

namespace _2._5
{
    class Program
    {
        static void Main(string[] args)
        {
            int from = int.Parse(Console.ReadLine());
            int to= int.Parse(Console.ReadLine());
            for (int i = from; i <= to; i++)
            {
                char currentSymbol = (char)i;
                Console.Write($"{currentSymbol} ");
            }

        }
    }
}

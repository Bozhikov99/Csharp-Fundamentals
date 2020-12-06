using System;
using System.Collections.Generic;
using System.Linq;

namespace Associative_Arrays___Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();
            var numbers = new SortedDictionary<double, int>();
            foreach (var x in input)
            {
                if (numbers.ContainsKey(x))
                {
                    numbers[x]++;
                }
                else
                {
                    numbers.Add(x, 1);
                }
            }
            foreach (var x in numbers)
            {
                Console.WriteLine($"{x.Key} -> {x.Value}");
            }
        }
    }
}

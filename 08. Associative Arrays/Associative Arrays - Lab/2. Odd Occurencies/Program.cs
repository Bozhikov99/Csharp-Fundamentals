using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Odd_Occurencies
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .ToLower()
                .Split()
                .ToArray();
            Dictionary<string, int> sequence = new Dictionary<string, int>();
            foreach (string x in input)
            {
                if (sequence.ContainsKey(x))
                {
                    sequence[x]++;
                }
                else
                {
                    sequence.Add(x, 1);
                }
            }
            foreach (var s in sequence)
            {
                if (s.Value%2!=0)
                {
                    Console.Write($"{s.Key} ");
                }
            }

        }
    }
}

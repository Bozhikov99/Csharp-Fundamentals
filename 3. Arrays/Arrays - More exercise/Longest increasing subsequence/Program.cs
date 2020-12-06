using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;

namespace Longest_increasing_subsequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            List<int> seq = new List<int>();
            List<int> longest = new List<int>();
            int max;
            int length = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                max = int.MinValue;
                for (int j = i; j < numbers.Length; j++)
                {
                    if (numbers[j]>max)
                    {
                        seq.Add(numbers[j]);
                        max = numbers[j];
                    }
                }
                if (length<seq.Count)
                {
                    length = seq.Count;
                    longest = new List<int>(seq);
                }
                seq.Clear();
            }
            
            Console.WriteLine(string.Join(" ",longest));
        }
    }
}

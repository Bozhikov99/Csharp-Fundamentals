using System;
using System.Collections.Generic;
using System.Linq;

namespace Remove_Negatives_and_Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine()
                 .Split()
                 .Select(int.Parse)
                 .ToList();
            List<int> result = nums
                .Where(n => n > 0)
                .Reverse()
                .ToList();
            string output = string.Empty;
            if (result.Count == 0)
            {
                output = "empty";
            }
            else
            {
                output=string.Join(" ", result);
            }
            Console.WriteLine(output);
        }
    }
}

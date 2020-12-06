using System;
using System.Collections.Generic;
using System.Linq;

namespace Append_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> arrays = Console.ReadLine()
                .Split('|')
                .ToList();
            arrays.Reverse();
            List<string> result = new List<string>();
            foreach (string currentitem in arrays)
            {
                string[] numbers = currentitem
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                foreach (string x in numbers)
                {
                    result.Add(x);
                }
            }
            Console.WriteLine(string.Join(" ",result));
        }
    }
}

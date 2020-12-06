using System;
using System.Linq;

namespace _7._Equal_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstArr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int[] secArr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int sum = 0;
            string result = string.Empty;
            for (int i = 0; i <  firstArr.Length; i++)
            {
                if (firstArr[i] != secArr[i])
                {
                    result = $"Arrays are not identical. Found difference at {i} index";
                    break;
                }
                else
                {
                    sum += firstArr[i];
                    result = $"Arrays are identical. Sum: {sum}";
                }
            }
            Console.WriteLine(result);
        }
    }
}

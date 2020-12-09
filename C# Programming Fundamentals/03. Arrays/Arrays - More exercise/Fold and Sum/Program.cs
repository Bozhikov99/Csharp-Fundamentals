using System;
using System.Linq;

namespace Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] allNumbers = Console.ReadLine()
                 .Split()
                 .Select(int.Parse)
                 .ToArray();
            int[] firstRow = new int[allNumbers.Length / 2];
            int[] secondRow = new int[allNumbers.Length / 2];
            int halfrow = secondRow.Length / 2;
            //1 23 4
            for (int i = 0; i < secondRow.Length; i++)
            {
                secondRow[i] = allNumbers[secondRow.Length / 2 + i];
            }
            for (int i = 0; i < firstRow.Length; i++)
            {
                if (i+1<=halfrow)
                {
                    firstRow[i] = allNumbers[halfrow-(i+1)];
                }
                else 
                {
                    firstRow[i] = allNumbers[allNumbers.Length-1-(i-halfrow)];
                }
            }
            //summing
            for (int i = 0; i < secondRow.Length; i++)
            {
                secondRow[i] += firstRow[i];
            }
            Console.WriteLine(string.Join(" ", secondRow));
        }
    }
}

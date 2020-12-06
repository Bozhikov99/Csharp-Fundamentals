using System;
using System.Linq;

namespace _5._TopKek
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            bool isTopKek = true;
            for (int i = 0; i < arr.Length; i++)
            {
                int currentInt = arr[i];
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] >= currentInt)
                    {
                        isTopKek = false;
                        break;
                    }
                }
                    if (isTopKek)
                    {
                        Console.Write($"{currentInt} ");
                    }
                    isTopKek = true;
                
            }
        }
    }
}

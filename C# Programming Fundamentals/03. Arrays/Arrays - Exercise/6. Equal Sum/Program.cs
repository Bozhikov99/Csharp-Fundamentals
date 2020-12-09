using System;
using System.Linq;

namespace _6._Equal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int leftSum = 0;
            int rightSum = 0;
            string result = string.Empty;
            bool isFound = false;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i+1; j < arr.Length; j++)
                {
                    rightSum += arr[j];
                }
                for (int k = i-1; k >=0 ; k--)
                {
                    leftSum += arr[k];
                }
                if (rightSum==leftSum)
                {
                    isFound = true;
                    result =$"{i}";
                    break;
                }
                else
                {
                    rightSum = 0;
                    leftSum = 0;
                    result = "no";
                }

            }
            Console.WriteLine(result);

        }
    }
}

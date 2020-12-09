using System;
using System.Linq;

namespace _4._Array_rotation
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] arr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int rotations = int.Parse(Console.ReadLine());
            for (int i = 0; i < rotations; i++)
            {
                int numToRotate = arr[0];
                for (int j = 1; j < arr.Length; j++)
                {
                    int currentNum = arr[j];
                    arr[j - 1] = currentNum;
                }
                arr[arr.Length - 1] = numToRotate;
            }
            Console.WriteLine(string.Join(" ", arr));
        }
    }
}

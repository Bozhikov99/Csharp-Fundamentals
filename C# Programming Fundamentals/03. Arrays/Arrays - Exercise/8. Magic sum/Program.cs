using System;
using System.Linq;

namespace _8._Magic_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int number = int.Parse(Console.ReadLine());
            for (int i = 0; i < array.Length; i++)
            {
                int current = array[i];
                for (int j = i+1; j < array.Length; j++)
                {
                    int afterCurrent = array[j];
                    if (current+afterCurrent==number)
                    {
                        Console.WriteLine($"{current} {afterCurrent}");
                    }
                }
            }
        }
    }
}

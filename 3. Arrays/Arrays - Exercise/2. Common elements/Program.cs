using System;
using System.Linq;

namespace _2._Common_elements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] first = Console.ReadLine()
                .Split();
            string[] second = Console.ReadLine()
                .Split();
            for (int i = 0; i < second.Length; i++)
            {
                for (int k = 0; k < first.Length; k++)
                {
                    if (first[k]==second[i])
                    {
                        Console.Write($"{second[i]} ");
                    }
                }
            }
        }
    }
}

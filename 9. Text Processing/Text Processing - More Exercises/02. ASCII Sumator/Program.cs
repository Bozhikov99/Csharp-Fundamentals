using System;

namespace _02._ASCII_Sumator
{
    class Program
    {
        static void Main(string[] args)
        {
            char first = char.Parse(Console.ReadLine());
            int start = (int)first;
            char second = char.Parse(Console.ReadLine());
            int end = (int)second;
            string input = Console.ReadLine();
            int sum = 0;
            foreach (char c in input)
            {
                int current =(int)c;
                if (start<current&&current<end)
                {
                    sum += current;
                }
            }
            Console.WriteLine(sum);
        }
    }
}

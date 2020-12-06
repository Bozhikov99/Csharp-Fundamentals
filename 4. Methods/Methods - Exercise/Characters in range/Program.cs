using System;
using System.Runtime.ExceptionServices;

namespace Characters_in_range
{
    class Program
    {
        static void Main(string[] args)
        {
            char start = char.Parse(Console.ReadLine());
            char stop = char.Parse(Console.ReadLine());
            Console.WriteLine(GetChars(start, stop));
        }
        static string GetChars(char start, char stop)
        {
            string symbols = string.Empty;
            char first;
            char second;
            if (start < stop)
            {
                first = start;
                second = stop;
            }
            else
            {
                first = stop;
                second = start;
            }
            for (int i = first+1; i < second; i++)
            {
                symbols += $"{(char)i} ";
            }

            return symbols;
        }
    }
}

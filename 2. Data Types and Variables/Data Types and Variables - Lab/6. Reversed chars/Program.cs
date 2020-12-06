using System;

namespace _6._Reversed_chars
{
    class Program
    {
        static void Main(string[] args)
        {
            string result = string.Empty;
            for (int i = 0; i < 3; i++)
            {
                char newChar = char.Parse(Console.ReadLine());
                result += $"{newChar} ";
            }
            for (int i = result.Length-2; i >= 0; i--)
            {
                Console.Write($"{result[i]}");
            }
        }
    }
}

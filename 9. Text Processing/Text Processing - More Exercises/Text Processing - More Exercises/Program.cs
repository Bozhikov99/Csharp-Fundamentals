using System;

namespace Text_Processing___More_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string name = string.Empty;
                string age = string.Empty;

                int start = input.IndexOf('@');
                int end = input.IndexOf('|');
                name = input.Substring(start + 1, end - start - 1);

                int startAge = input.IndexOf('#');
                int endAge = input.IndexOf('*');
                age = input.Substring(startAge + 1, endAge - startAge - 1);
                Console.WriteLine($"{name} is {age} years old.");
            }
        }
    }
}

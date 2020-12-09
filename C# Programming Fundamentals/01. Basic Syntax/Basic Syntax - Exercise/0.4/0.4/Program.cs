using System;

namespace _0._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumb = int.Parse(Console.ReadLine());
            int secNumb = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = firstNumb; i <= secNumb; i++)
            {
                Console.Write($"{i} ");
                sum += i;
            }
            Console.WriteLine();
            Console.Write($"Sum: {sum}");
        }
    }
}

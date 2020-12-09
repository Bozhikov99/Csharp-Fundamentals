using System;

namespace _0._8
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNum = int.Parse(Console.ReadLine());
            for (int i = 1; i <= inputNum; i++)
            {
                Console.WriteLine();
                for (int j = 1; j <=i; j++)
                {
                    Console.Write($"{i} ");
                }
            }
        }
    }
}

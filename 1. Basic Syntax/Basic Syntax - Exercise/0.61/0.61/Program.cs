using System;

namespace _0._6
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int input = number;
            int current = 0;
            int sum = 0;
            while (number!=0)
            {
                current = number % 10;
                number /= 10;
                int currentFact = 1;
                for (int i = 1; i <= current; i++)
                {
                    currentFact *= i;
                }
                sum += currentFact;
            }
            if (input==sum)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}

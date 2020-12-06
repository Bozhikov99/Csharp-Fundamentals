using System;

namespace _2._4_Refactoring_Prime_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 2; i <= n; i++)
            {
                bool check = true;
                for (int k = 2; k < i; k++)
                {
                    if (i % k== 0)
                    {
                        check = false;
                        break;
                    }
                }
                Console.WriteLine($"{i} -> {Convert.ToString(check).ToLower()}");
            }

        }
    }
}


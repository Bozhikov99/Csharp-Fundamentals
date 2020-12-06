using System;
using System.Net.Http.Headers;
using System.Reflection.Emit;

namespace Tribunaka
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Tribonacci(num);
        }

        static int Tribonacci(int num)
        {
            int tribonacciNum = 0;
            int a = 1;
            int b = 1;
            int c = 2;
            if (num <= 3)
            {
                switch (num)
                {
                    case 1:
                        Console.Write($"{a}");
                        break;
                    case 2:
                        Console.Write($"{a} {b}");
                        break;
                    case 3:
                        Console.Write($"{a} {b} {c} ");
                        break;
                }
            }
            for (int i = 4; i <= num; i++)
            {
                if (i == 4)
                {
                    Console.Write($"{a} {b} {c} ");
                }
                tribonacciNum = a + b + c;
                Console.Write($"{tribonacciNum} ");
                a = b;
                b = c;
                c = tribonacciNum;
            }
            return tribonacciNum;
        }
    }
}

using System;
using System.Net.Http.Headers;

namespace Recursive_Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int sum = 0;
            int a = 0;
            int b = 1;
            for (int i = 0; i < input; i++)
            {
                sum = a + b;
                b = a;
                a = sum;
            }
            Console.WriteLine(sum);
        }
    }
}

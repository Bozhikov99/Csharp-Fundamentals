using System;

namespace Printing_triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <=n; i++)
            {
                linePrint(1, i);
            }
            for (int i = n-1; i >= 1; i--)
            {
                linePrint(1, i);
            }
            
            
        }
        static void linePrint(int start, int end)
        {
            for (int i = start; i <=end; i++)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        }
    }
}

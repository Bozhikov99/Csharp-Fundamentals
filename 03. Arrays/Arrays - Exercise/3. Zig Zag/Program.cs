using System;
using System.Linq;

namespace _3._Zig_Zag
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] up = new int[n];
            int[] down= new int[n];
            for (int i = 0; i < n; i++)
            {
                int[] twoNums = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();
                int nula = twoNums[0];
                int one = twoNums[1];
                if (i%2==0)
                {
                    up[i] = nula;
                    down[i] = one;
                }
                else
                {
                    up[i] = one;
                    down[i] = nula;
                }
            }
            Console.WriteLine(string.Join(" ", up));
            Console.WriteLine(string.Join(" ", down));
        }
    }
}

using System;
using System.Linq;
using System.Threading;

namespace _5._Sum_even_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int[] cure = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i <= cure.Length-1; i++)
            {
                bool isEven = cure[i]%2 == 0;
                if (isEven==true)
                {
                    sum += cure[i];
                }
            }
            Console.WriteLine(sum);
        }
    }
}

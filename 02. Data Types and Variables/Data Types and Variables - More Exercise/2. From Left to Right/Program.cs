using System;
using System.Linq;

namespace _2._From_Left_to_Right
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            for (int i = 1; i <= lines; i++)
            {
                string[] line = Console.ReadLine()
                    .Split();
                long left = long.Parse(line[0]);
                long right = long.Parse(line[1]);
                long sum = 0;
                if (left>right)
                {
                    while (left>0)
                    {
                        sum += Math.Abs(left ) % 10;
                        left /= 10;
                    }
                    Console.WriteLine(sum);
                }
                else 
                {
                    while (right > 0)
                    {
                        sum +=Math.Abs(right) % 10;
                        right /= 10;
                    }
                    Console.WriteLine(sum);
                }
            }

        }
    }
}

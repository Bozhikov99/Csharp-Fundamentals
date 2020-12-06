using System;
using System.Linq;

namespace _3._Heart_Delivery
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] neighbourhood = Console.ReadLine()
                .Split("@", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            string[] cmd = Console.ReadLine()
                .Split();

            int houseIndex = 0;
            while (cmd[0]!="Love!")
            {
                int jumpLength = int.Parse(cmd[1]);
                if (houseIndex + jumpLength >= neighbourhood.Length)
                {
                    houseIndex = 0;
                }
                else
                {
                    houseIndex = houseIndex + jumpLength;
                }
                    if (neighbourhood[houseIndex]>0)
                    {
                        neighbourhood[houseIndex] -=2;
                        if (neighbourhood[houseIndex]==0)
                        {
                        Console.WriteLine($"Place {houseIndex} has Valentine's day.");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Place {houseIndex} already had Valentine's day.");
                    }
                
                cmd = Console.ReadLine()
                    .Split();
            }
            int failed = 0;
            for (int i = 0; i < neighbourhood.Length; i++)
            {
                if (neighbourhood[i]>0)
                {
                    failed++;
                }
            }
            Console.WriteLine($"Cupid's last position was {houseIndex}.");
            if (failed==0)
            {
                Console.WriteLine("Mission was successful.");
            }
            else
            {
                Console.WriteLine($"Cupid has failed {failed} places.");
            }
        }
    }
}

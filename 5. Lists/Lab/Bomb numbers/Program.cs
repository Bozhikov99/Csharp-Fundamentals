using System;
using System.Collections.Generic;
using System.Linq;

namespace Bomb_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sequence = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            int[] bombArr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int bomb = bombArr[0];
            int bombPower = bombArr[1];
            for (int i = 0; i < sequence.Count; i++)
            {
                int startIndex = i-bombPower;
                int stopIndex = i+bombPower;
                if (sequence[i]==bomb)
                {
                    
                    if (i-bombPower<0)
                    {
                        startIndex = 0;    
                    }
                    if (i+bombPower>=sequence.Count)
                    {
                        stopIndex = sequence.Count-1;
                    }
                    sequence.RemoveRange(startIndex, stopIndex-startIndex+1);
                    i = startIndex - 1;
                }
            }
            Console.WriteLine(sequence.Sum());
        }
    }
}

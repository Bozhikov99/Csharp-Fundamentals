using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Drum_Set
{
    class Program
    {
        static void Main(string[] args)
        {
            double savings = double.Parse(Console.ReadLine());
            List<int> drumSet = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<int> values = new List<int>();
            foreach (int x in drumSet)
            {
                values.Add(x);
            }
            string cmd = Console.ReadLine()
                .ToLower();
            while (cmd!="hit it again, gabsy!")
            {
                int power = int.Parse(cmd);
                for (int i = 0; i < drumSet.Count; i++)
                {
                    int initialValue = values[i];
                    drumSet[i] -= power;
                    if (drumSet[i]<=0)
                    {
                        if (savings-initialValue*3>0)
                        {
                            drumSet[i] = initialValue;
                            savings -=initialValue*3;
                        }
                        else
                        {
                            drumSet.RemoveAt(i);
                            values.RemoveAt(i);
                            i--;
                        }
                    }
                }
                cmd = Console.ReadLine().ToLower();
            }
            Console.WriteLine(string.Join(" ",drumSet));
            Console.WriteLine($"Gabsy has {savings:f2}lv.");
        }
    }
}

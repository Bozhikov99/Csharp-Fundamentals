using System;
using System.Linq;
using System.Collections.Generic;

namespace Lab___Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //train
            List<int> wagons = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            int capacity = int.Parse(Console.ReadLine());
            string[] cmd = Console.ReadLine()
                .ToLower()
                .Split()
                .ToArray();

            while (cmd[0] != "end")
            {

                    switch (cmd[0])
                    {
                        case "add":
                                wagons.Add(int.Parse(cmd[1]));
                            break;
                        default:
                        for (int i = 0; i < wagons.Count; i++)
                        {
                            bool hasCapacity = wagons[i] + int.Parse(cmd[0]) <= capacity;
                            if (hasCapacity)
                            {
                                wagons[i] += int.Parse(cmd[0]);
                                break;
                            }
                            
                        }
                        break;
                    }

                cmd = Console.ReadLine()
                        .ToLower()
                        .Split()
                        .ToArray();

            }
            Console.WriteLine(string.Join(" ",wagons));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Sugar_Cubesw
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> cubes = Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string cmd = Console.ReadLine();
            while (cmd!="Mort")
            {
                string command = cmd.Split()[0];
                switch (command)
                {
                    case "Add":
                        int value = int.Parse(cmd.Split()[1]);
                        cubes.Add(value);
                        break;
                    case "Remove":
                        int remValue = int.Parse(cmd.Split()[1]);
                        cubes.Remove(remValue);
                        break;
                    case "Replace":
                        int oldValue = int.Parse(cmd.Split()[1]);
                        int index = cubes.IndexOf(oldValue);
                        int newValue = int.Parse(cmd.Split()[2]);
                        cubes.RemoveAt(index);
                        cubes.Insert(index, newValue);
                        break;
                    case "Collapse":
                        int max = int.Parse(cmd.Split()[1]);
                        for (int i = 0; i < cubes.Count; i++)
                        {
                            if (cubes[i]<max)
                            {
                                cubes.RemoveAt(i);
                                i--;
                            }
                        }
                        break;
                }
                cmd = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ",cubes));
        }
    }
}

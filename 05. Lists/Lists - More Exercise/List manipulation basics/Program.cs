using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Xml;

namespace List_manipulation_basics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            string[] cmd = Console.ReadLine().ToUpper()
                .Split();

            while (cmd[0] != "END")
            {
                switch (cmd[0])
                {
                    case "ADD":
                        nums.Add(int.Parse(cmd[1]));
                        break;
                    case "REMOVE":
                        nums.Remove(int.Parse(cmd[1]));
                        break;
                    case "REMOVEAT":
                        nums.RemoveAt(int.Parse(cmd[1]));
                        break;
                    case "INSERT":
                        nums.Insert(int.Parse(cmd[2]), int.Parse(cmd[1]));
                        break;
                    case "CONTAINS":
                        if (nums.Contains(int.Parse(cmd[1])))
                        {
                            Console.WriteLine("Yes");
                        }
                        else
                        {
                            Console.WriteLine("No such number");
                        }
                        break;
                }
                cmd = Console.ReadLine().ToUpper()
                .Split();
            }
            Console.WriteLine(string.Join(" ", nums));
        }
    }
}

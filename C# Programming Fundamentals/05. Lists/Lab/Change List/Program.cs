using System;
using System.Collections.Generic;
using System.Linq;

namespace Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> ints = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            string[] command = Console.ReadLine()
                .ToLower()
                .Split();
            while (command[0]!="end")
            {
                switch (command[0])
                {
                    case "delete":
                        ints.RemoveAll(n=>n==int.Parse(command[1]));
                        break;
                    case "insert":
                        ints.Insert(int.Parse(command[2]), int.Parse(command[1]));
                        break;
                    default:
                        break;
                }
                command = Console.ReadLine()
                .ToLower()
                .Split();
            }
            Console.WriteLine(string.Join(" ",ints));
        }
    }
}

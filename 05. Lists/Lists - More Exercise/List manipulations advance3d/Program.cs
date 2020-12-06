using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Xml;

namespace List_manipulations_advance3d
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

            bool print = false;

            while (cmd[0] != "END")
            {
                switch (cmd[0])
                {
                    case "ADD":
                        nums.Add(int.Parse(cmd[1]));
                        print = true;
                        break;
                    case "REMOVE":
                        nums.Remove(int.Parse(cmd[1]));
                        print = true;
                        break;
                    case "REMOVEAT":
                        nums.RemoveAt(int.Parse(cmd[1]));
                        print = true;
                        break;
                    case "INSERT":
                        nums.Insert(int.Parse(cmd[2]), int.Parse(cmd[1]));
                        print = true;
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
                    case "PRINTEVEN":
                        List<int> evens = nums
                            .Where(n => n % 2 == 0)
                            .ToList();
                        Console.WriteLine(string.Join(" ", evens));
                        break;
                    case "PRINTODD":
                        List<int> odds = nums
                            .Where(n => n % 2 == 1)
                            .ToList();
                        Console.WriteLine(string.Join(" ", odds));
                        break;
                    case "GETSUM":
                        int sum = 0;
                        for (int i = 0; i < nums.Count; i++)
                        {
                            sum += nums[i];
                        }
                        Console.WriteLine(sum);
                        break;
                    case "FILTER":
                        if (cmd[1]=="<=")
                        {
                            List<int> less = nums
                                .Where(n => n <= int.Parse(cmd[2]))
                                .ToList();
                            Console.WriteLine(string.Join(" ",less));
                        }
                        else if (cmd[1]=="<")
                        {
                            List<int> less= nums
                                .Where(n => n < int.Parse(cmd[2]))
                                .ToList();
                            Console.WriteLine(string.Join(" ", less));
                        }
                        else if (cmd[1]==">=")
                        {
                            List<int> more = nums
                                .Where(n => n >= int.Parse(cmd[2]))
                                .ToList();
                            Console.WriteLine(string.Join(" ", more));
                        }
                        else if (cmd[1]==">")
                        {
                            List<int> more = nums
                                .Where(n => n > int.Parse(cmd[2]))
                                .ToList();
                            Console.WriteLine(string.Join(" ", more));
                        }
                        break;

                    
                }
                cmd = Console.ReadLine().ToUpper()
                .Split();
            }
            if (print==true)
            {
                Console.WriteLine(string.Join(" ",nums));
            }
        }
    }
}

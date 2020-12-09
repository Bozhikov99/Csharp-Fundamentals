using System;
using System.Collections.Generic;
using System.Linq;

namespace List_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            string[] cmd = Console.ReadLine()
                .ToLower()
                .Split();
            while (cmd[0] != "end")
            {
                switch (cmd[0])
                {
                    case "add":
                        numbers.Add(int.Parse(cmd[1]));
                        break;
                    case "insert":
                        if (InvalidIndex(int.Parse(cmd[2]), numbers.Count))
                        {
                            Console.WriteLine("Invalid index");
                        }
                        else
                        {
                            numbers.Insert(int.Parse(cmd[2]), int.Parse(cmd[1]));
                        }
                        break;
                    case "remove":
                        if (InvalidIndex(int.Parse(cmd[1]), numbers.Count))
                        {
                            Console.WriteLine("Invalid index");
                        }
                        else
                        {
                            numbers.RemoveAt(int.Parse(cmd[1]));
                        }
                        break;
                    case "shift":
                        int rotation = int.Parse(cmd[2]);
                        if (cmd[1] == "left")
                        {
                            for (int i = 0; i < rotation; i++)
                            {
                                int firstElement = numbers[0];
                                for (int j = 0; j < numbers.Count - 1; j++)
                                {
                                    numbers[j] = numbers[j + 1];
                                }
                                numbers[numbers.Count - 1] = firstElement;
                            }
                        }
                        else if (cmd[1] == "right")
                        {
                            for (int i = 0; i < rotation; i++)
                            {
                                int lastElement = numbers[numbers.Count - 1];
                                for (int j = numbers.Count - 1; j > 0; j--)
                                {
                                    numbers[j] = numbers[j - 1];
                                }
                                numbers[0] = lastElement;
                            }
                        }
                        break;
                }
                cmd = Console.ReadLine()
                .ToLower()
                .Split();
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
        public static bool InvalidIndex(int index, int count)
        {
            return index > count - 1 || index < 0;
        }
    }
}

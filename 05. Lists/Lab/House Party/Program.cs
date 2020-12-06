using System;
using System.Collections.Generic;


namespace House_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> guests = new List<string>();
            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine()
                    .Split();

                if (command.Length == 3)
                {
                    if (guests.Contains(command[0]))
                    {
                        Console.WriteLine($"{command[0]} is already in the list!");
                    }
                    else
                    {
                        guests.Add(command[0]);
                    }
                }
                else if (command.Length > 3)
                {
                    if (guests.Contains(command[0]))
                    {
                        guests.Remove(command[0]);
                    }
                    else
                    {
                        Console.WriteLine($"{command[0]} is not in the list!");
                    }

                }
            }
            for (int i = 0; i < guests.Count; i++)
            {
                Console.WriteLine($"{guests[i]}");
            }
        }
    }
}

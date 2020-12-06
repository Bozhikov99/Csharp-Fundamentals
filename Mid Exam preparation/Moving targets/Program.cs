using System;
using System.Collections.Generic;
using System.Linq;

namespace Moving_targets
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> targets = Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string[] cmd = Console.ReadLine()
                .ToUpper()
                .Split();
            while (cmd[0]!="END")
            {
                string command = cmd[0];
                int index= int.Parse(cmd[1]);
                switch (command)
                {
                    case "SHOOT":
                        if (IsValidIndex(targets, index))
                        {
                            int power = int.Parse(cmd[2]);
                            if (targets[index] - power <= 0)
                            {
                                targets.RemoveAt(index);
                            }
                            else
                            {
                                targets[index] -= power;
                            }
                        }
                            break;
                    case "ADD":
                        if (IsValidIndex(targets, index))
                        {
                            targets.Insert(index, int.Parse(cmd[2]));
                        }
                        else
                        {
                            Console.WriteLine("Invalid placement!");
                        }
                        break;
                    case "STRIKE":
                        int radius = int.Parse(cmd[2]);
                        int startIndex = index - radius;
                        int stopIndex = index + radius;
                        int range = radius*2+1;
                        int end = targets.Count;
                        if (IsValidIndex(startIndex,stopIndex,end))
                        {
                            targets.RemoveRange(startIndex,range);
                        }
                        else
                        {
                            Console.WriteLine("Strike missed!");
                        }
                        break;
                }
                cmd = Console.ReadLine()
                .ToUpper()
                .Split();
            }
            Console.WriteLine(string.Join("|",targets));
        }
        public static bool IsValidIndex(List<int> list, int index)
        {
            bool isValid = false;
            if (index >= 0 && index < list.Count)
            {
                isValid = true;
            }
            return isValid;
        }
        public static bool IsValidIndex(int start, int stop, int end)
        {
            bool isValid = true;
            if (start<0||stop>=end)
            {
                isValid = false;
            }
            return isValid;
        }
    }
    
}

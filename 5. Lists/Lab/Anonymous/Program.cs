using System;
using System.Collections.Generic;
using System.Linq;

namespace Anonymous
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            string[] cmd = Console.ReadLine()
                .Split();
            while (cmd[0] != "3:1")
            {
                switch (cmd[0])
                {
                    case "merge":
                        int startIndex = int.Parse(cmd[1]);
                        int stopIndex = int.Parse(cmd[2]);
                        if (stopIndex>=input.Count)
                        {
                            stopIndex = input.Count - 1;
                        }
                        if (startIndex<0)
                        {
                            startIndex = 0;
                        }
                        else if (startIndex>=input.Count)
                        {
                            startIndex = input.Count - 2;
                        }
                        for (int i = startIndex; i < stopIndex; i++)
                        {
                            input[startIndex] += input[i+1];
                            
                        }
                        for (int i = stopIndex; i > startIndex; i--)
                        {
                            input.RemoveAt(i);
                        }
                        break;
                    case "divide":
                        char[] letters = input[int.Parse(cmd[1])].ToCharArray();
                        int ordinaryLength = letters.Length / int.Parse(cmd[2]);
                        int lastStringLength;
                        startIndex = 0;
                        stopIndex = 0;
                        bool isOdd = false;
                        //determining string lengths
                        if (input[int.Parse(cmd[1])].Length % int.Parse(cmd[2]) != 0)
                        {
                            lastStringLength = ordinaryLength + 1;
                            isOdd = true;
                        }
                        else
                        {
                            lastStringLength = ordinaryLength;
                        }
                        //loading the letters in the divided new strings
                        string[] dividedStrings = new string[int.Parse(cmd[2])];
                        for (int i = 0; i <= dividedStrings.Length - 1; i++)
                        {
                            if (i!=dividedStrings.Length-1)
                            {
                                stopIndex = ordinaryLength * (i + 1);
                                for (int j = startIndex; j < stopIndex; j++)
                                {
                                    dividedStrings[i] += letters[j];

                                }
                            }
                            if ( i == dividedStrings.Length-1)
                            {
                                stopIndex = letters.Length - 1;
                                for (int j = startIndex; j <= stopIndex; j++)
                                {
                                    dividedStrings[i] += letters[j];
                                }
                            }
                            startIndex = stopIndex;
                        }
                        //loading the newly divided strings in the list
                        input.RemoveAt(int.Parse(cmd[1]));
                        input.InsertRange(int.Parse(cmd[1]), dividedStrings);
                        
                        break;

                }
                cmd = Console.ReadLine()
                    .Split()
                    .ToArray();
            }
            Console.WriteLine(string.Join(" ", input));
        }
    }
}

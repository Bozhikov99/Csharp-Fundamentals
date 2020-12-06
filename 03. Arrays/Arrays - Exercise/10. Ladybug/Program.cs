using System;
using System.Linq;

namespace _10._Ladybug
{
    class Program
    {
        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine());
            long[] indexesOfBugs = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(long.Parse)
                .ToArray();
            long[] field = new long[fieldSize];
            for (int i = 0; i < indexesOfBugs.Length; i++)
            {
                if (indexesOfBugs[i]>=0&&indexesOfBugs[i]<fieldSize)
                {
                    field[indexesOfBugs[i]] = 1;
                }
            }

            string[] cmd = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            while (cmd[0] != "end")

            {
                int index = int.Parse(cmd[0]);
                string direction = cmd[1];
                int flyLength = int.Parse(cmd[2]);

                bool isValidIndex = index >= 0 &&
                    index < field.Length&&
                    field[index]==1;
                
                if (isValidIndex)
                {
                    switch (direction)
                    {
                        case "left":
                            if (flyLength < 0)
                            {
                                direction = "right";
                                flyLength *= -1;
                            }
                            break;
                        case "right":
                            if (flyLength < 0)
                            {
                                direction = "left";
                                flyLength *= -1;
                            }
                            break;
                    }
                    field[index]--;
                    if (direction == "left")
                    {
                        if (index - flyLength >= 0)
                        {
                            for (int i = index - flyLength; i >= 0; i--)
                            {
                                if (field[i] == 0)
                                {
                                    field[i]++;
                                    break;
                                }
                                
                            }
                        }
                    }
                    else if (direction == "right")
                    {
                        if (index + flyLength < field.Length)
                        {
                            for (int i = index + flyLength; i < fieldSize; i+=flyLength)
                            {
                                if (field[i] == 0)
                                {
                                    field[i]++;
                                    break;
                                }
                                
                            }
                        }
                    }
                }
                cmd = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }
            Console.WriteLine(string.Join(" ", field));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace Softuni_Course_Planning
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> program = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            string[] command = Console.ReadLine()
                    .Split(":", StringSplitOptions.RemoveEmptyEntries);
            while (command[0] != "course start")
            {
                
                switch (command[0])
                {
                    case "Add":
                        if (!program.Contains(command[1]))
                        {
                            program.Add(command[1]);
                        }
                        break;

                    case "Insert":
                        if (!program.Contains(command[1]))
                        {
                            program.Insert(int.Parse(command[2]),command[1]);
                        }
                        break;

                    case "Remove":
                        if (program.Contains(command[1]))
                        {
                            program.Remove(command[1]);
                            if (program.Contains($"{command[1]}-Exercise"))
                            {
                                program.Remove($"{command[1]}-Exercise");
                            }
                        }
                        break;

                    case "Swap":
                        if (program.Contains(command[1])&& program.Contains(command[2]))
                        {
                            int indexA = program.IndexOf(command[1]);
                            int indexB = program.IndexOf(command[2]);
                            program.Remove(command[1]);
                            program.Remove(command[2]);
                            program.Insert(indexA, command[2]);
                            program.Insert(indexB, command[1]);
                            if (program.Contains($"{command[1]}-Exercise"))
                            {
                                int indexExercise = program.IndexOf(command[1])+1;
                                program.Remove($"{command[1]}-Exercise");
                                if (indexExercise == program.Count)
                                {
                                    program.Add($"{command[1]}-Exercise");
                                }
                                else
                                {
                                    program.Insert(program.IndexOf(command[1])+1, $"{command[1]}-Exercise");
                                }
                            }
                            if (program.Contains($"{command[2]}-Exercise"))
                            {
                                int indexExercise = program.IndexOf(command[2]) + 1;
                                program.Remove($"{command[2]}-Exercise");
                                if (indexExercise == program.Count)
                                {
                                    program.Add($"{command[2]}-Exercise");
                                }
                                else
                                {
                                    program.Insert(program.IndexOf(command[2])+1, $"{command[2]}-Exercise");
                                }
                            }
                            
                        }
                        break;

                    case "Exercise":
                        if (program.Contains(command[1]))
                        {
                            int indexExercise = program.IndexOf(command[1])+1;
                            program.Insert(indexExercise,$"{command[1]}-Exercise");
                        }
                        else 
                        {
                            program.Add(command[1]);
                            program.Add($"{command[1]}-Exercise");
                        }
                        break;                  
                }
                command = Console.ReadLine()
                    .Split(":", StringSplitOptions.RemoveEmptyEntries);
            }
            for (int i = 0; i < program.Count; i++)
            {
                Console.WriteLine($"{i+1}.{program[i]}");
            }
        }
    }
}

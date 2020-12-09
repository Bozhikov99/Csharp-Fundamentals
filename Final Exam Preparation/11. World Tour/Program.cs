using System;
using System.Linq;
using System.Runtime.CompilerServices;

namespace _11._World_Tour
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string cmd = Console.ReadLine();
            while (cmd!="Travel")
            {
                string[] tokens = cmd.Split(':', StringSplitOptions.RemoveEmptyEntries);
                string command = tokens[0];
                switch (command)
                {
                    case "Add Stop":
                        int index = int.Parse(tokens[1]);
                        string newStop = tokens[2];
                        if (IsValidIndex(index, input))
                        {
                            input=input.Insert(index, newStop); 
                        }
                        break;

                    case "Remove Stop":
                        int start = int.Parse(tokens[1]);
                        int end = int.Parse(tokens[2]);
                        if (IsValidIndex(start, input)&&IsValidIndex(end, input))
                        {
                            input = input.Remove(start, end-start+1);
                        }
                        break;
                    case "Switch":
                        string oldString = tokens[1];
                        string newString = tokens[2];
                        if (input.Contains(oldString))
                        {
                            input = input.Replace(oldString, newString);
                        }
                        break;
                    
                    default:
                        break;
                }
                Console.WriteLine(input);
                cmd = Console.ReadLine();
            }
            Console.WriteLine($"Ready for world tour! Planned stops: {input}");
        }
        public static bool IsValidIndex(int index, string input)
        {
            if (index>=0&&index<input.Length)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

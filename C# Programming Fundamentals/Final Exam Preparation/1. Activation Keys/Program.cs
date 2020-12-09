using System;

namespace _1._Activation_Keys
{
    class Program
    {
        static void Main(string[] args)
        {
            string rawKey = Console.ReadLine();
            string cmd = Console.ReadLine();
            while (cmd != "Generate")
            {
                string[] commands = cmd.Split(">>>", StringSplitOptions.RemoveEmptyEntries);
                switch (commands[0])
                {
                    case "Contains":
                        string substring = commands[1];
                        if (rawKey.Contains(substring))
                        {
                            Console.WriteLine($"{rawKey} contains {substring}");
                        }
                        else
                        {
                            Console.WriteLine("Substring not found!");
                        }
                        break;
                    case "Flip":
                        string caseType = commands[1];
                        int start = int.Parse(commands[2]);
                        int stop = int.Parse(commands[3]);
                        string substring1 = rawKey.Substring(start, stop - start);
                        if (caseType.ToUpper()=="UPPER")
                        {
                            rawKey=rawKey.Replace(substring1, substring1.ToUpper());
                        }
                        else if (caseType.ToUpper()=="LOWER")
                        {
                            rawKey=rawKey.Replace(substring1, substring1.ToLower());
                        }
                        Console.WriteLine(rawKey);
                        break;
                    case "Slice":
                        int start1 = int.Parse(commands[1]);
                        int stop1 = int.Parse(commands[2]);
                        rawKey = rawKey.Remove(start1, stop1 - start1);
                        Console.WriteLine(rawKey);
                        break;
                    default:
                        break;
                }
                cmd = Console.ReadLine();
            }
            Console.WriteLine($"Your activation key is: {rawKey}");
        }
    }
}

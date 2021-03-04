using System;
using System.Threading.Tasks.Dataflow;

namespace _21._Password_Reset
{
    class Program
    {
        static void Main(string[] args)
        {
            string rawPassword = Console.ReadLine();
            string cmd = Console.ReadLine();
            while (cmd!="Done")
            {
                string[] tokens = cmd.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                switch (tokens[0])
                {
                    case "TakeOdd":
                        string newPassword = string.Empty;
                        for (int i = 0; i < rawPassword.Length; i++)
                        {
                            if (i%2!=0)
                            {
                                newPassword += rawPassword[i];
                            }
                        }
                        rawPassword = newPassword;
                        Console.WriteLine(rawPassword);
                        break;
                    case "Cut":
                        int index = int.Parse(tokens[1]);
                        int count = int.Parse(tokens[2]);
                        rawPassword=rawPassword.Remove(index, count);
                        Console.WriteLine(rawPassword);
                        break;
                    case "Substitute":
                        string old = tokens[1];
                        string substitute= tokens[2];
                        if (rawPassword.Contains(old))
                        {
                            rawPassword = rawPassword.Replace(old, substitute);
                            Console.WriteLine(rawPassword);
                        }
                        else
                        {
                            Console.WriteLine("Nothing to replace!");
                        }
                        break;
                    default:
                        break;
                }
                cmd = Console.ReadLine();
            }
            Console.WriteLine($"Your password is: {rawPassword}");
        }
    }
}

using System;

namespace _03._Extract_File
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] path = Console.ReadLine()
                .Split(@"\", StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine($"File name: {path[path.Length-2]}");
            Console.WriteLine($"File extension: {path[path.Length-1]}");
        }
    }
}

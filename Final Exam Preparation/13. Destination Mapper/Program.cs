using System;
using System.Text.RegularExpressions;

namespace _13._Destination_Mapper
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"(=|\/)(?<location>[A-Z][A-Za-z]{2,})\1";
            MatchCollection matches = Regex.Matches(input, pattern);
            int travelPoints = 0;
            Console.Write("Destinations:");
            for (int i = 0; i < matches.Count; i++)
            {
                if (i == matches.Count - 1)
                {
                    Console.Write($" {matches[i].Groups["location"]}");
                }
                else
                {
                    Console.Write($" {matches[i].Groups["location"]},");
                }
                travelPoints += matches[i].Groups["location"].Length;
            }
            Console.WriteLine();
            Console.WriteLine($"Travel Points: {travelPoints}");
        }
    }
}

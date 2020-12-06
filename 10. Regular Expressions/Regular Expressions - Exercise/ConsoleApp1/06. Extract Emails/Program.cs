using System;
using System.Text.RegularExpressions;

namespace _06._Extract_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"(^| )(([A-Za-z0-9]+)([._-][\w]+)*)@(([A-Za-z]+)([._-][A-Za-z]+)+)($|)";
            MatchCollection emails = Regex.Matches(input, pattern);
            foreach (Match e in emails)
            {
                Console.WriteLine(e.Value.Trim());
            }
        }
    }
}

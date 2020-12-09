using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _2._Rage_Quit
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToUpper();
            StringBuilder output = new StringBuilder();
            string uniqueSymbols = string.Empty;
            string pattern = @"[\D]+(?<repeats>\d+)";
            MatchCollection matches = Regex.Matches(input, pattern);
            foreach (Match str in matches)
            {
                int n = int.Parse(str.Groups["repeats"].Value);
                string printString = Regex.Match(str.Value, @"[\D]+").Value;
                if (n != 0)
                {
                    foreach (char c in printString)
                    {
                        if (!uniqueSymbols.Contains(c))
                        {
                            uniqueSymbols += c;
                        }
                    }
                }
                for (int i = 0; i < n; i++)
                {
                    output.Append(printString);
                }

            }
            Console.WriteLine($"Unique symbols used: {uniqueSymbols.Length}");
            Console.WriteLine(output);
        }
    }
}

using System;
using System.Text.RegularExpressions;

namespace _3._Post_Office
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split('|', StringSplitOptions.RemoveEmptyEntries);
            Match captLetters = Regex.Match(input[0], @"(#|\$|%|&|\*)[A-Z]+\1");
            if (captLetters.Captures.Count > 0)
            {
                string capitals = captLetters.Value[1..^1];
                foreach (char letter in capitals)
                {
                    int asciiValue = letter;
                    Match current = Regex.Match(input[1], $"(?<ascii>{asciiValue}+):(?<length>([0-1][0-9])|20)");
                    int length = int.Parse(current.Groups["length"].Value.TrimStart());
                    MatchCollection words = Regex.Matches(input[2], @"(\b(?<letter>[A-Z])[a-z\S]+)($|\b)");
                    string currentWord = string.Empty;
                    foreach (Match word in words)
                    {
                        if (word.Groups["letter"].Value == letter.ToString() && word.Value.Length == length + 1)
                        {
                            currentWord = word.Value;
                            break;
                        }
                    }
                    Console.WriteLine(currentWord);
                }
            }
        }
    }
}

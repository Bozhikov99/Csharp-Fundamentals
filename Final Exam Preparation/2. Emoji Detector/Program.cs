using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _2._Emoji_Detector
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string numPattern = @"\d";
            long treshold = 1;
            Regex.Matches(input, numPattern)
                .Select(m => m.Value)
                .Select(int.Parse)
                .ToList()
                .ForEach(m => treshold *= m);
            string emojiPattern = @"(:{2}|\*{2})[A-Z][a-z]{2,}\1";
            MatchCollection emojis = Regex.Matches(input, emojiPattern);
            List<string> coolEmojis = new List<string>();
            foreach (Match item in emojis)
            {
                long currentValue = item.Value
                    .Substring(2, item.Value.Length - 4)
                    .ToCharArray()
                    .Sum(c=>(int)c);
                if (currentValue>=treshold)
                {
                    coolEmojis.Add(item.Value);
                }
            }
            Console.WriteLine($"Cool threshold: {treshold}");
            Console.WriteLine($"{emojis.Count} emojis found in the text. The cool ones are:");
            foreach (string cool in coolEmojis)
            {
                Console.WriteLine(cool);
            }
        }
    }
}

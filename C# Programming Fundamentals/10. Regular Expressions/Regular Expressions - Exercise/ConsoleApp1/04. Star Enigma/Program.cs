using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _04._Star_Enigma
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> attackedPlanets = new List<string>();
            List<string> destroyedPlanets = new List<string>();
            string filter = "starSTAR";

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string pattern = @"([^\@\:\!\-\>]+)*@(?<planet>[A-Za-z]+)([^\@\:\!\-\>]+)*:([^\@\:\!\-\>]+)*(\d+)([^\@\:\!\-\>]+)*!([^\@\:\!\-\>]+)*(?<attackType>A|D)([^\@\:\!\-\>]+)*!([^\@\:\!\-\>]+)*->([^\@\:\!\-\>]+)*(\d+)";
                StringBuilder decryptedMessage = new StringBuilder();
                int letterCount = input.Where(c => filter.Contains(c)).ToArray().Length;
                //decrypt
                foreach (char c in input)
                {
                    char decryptedSymbol = (char)((int)c - letterCount);
                    decryptedMessage.Append(decryptedSymbol);
                }

                Match message = Regex.Match(decryptedMessage.ToString(), pattern);
                if (message.Success)
                {
                    if (message.Groups["attackType"].Value=="D")
                    {
                        destroyedPlanets.Add(message.Groups["planet"].Value);
                    }
                    else
                    {
                        attackedPlanets.Add(message.Groups["planet"].Value);
                    }
                }
            }
            Console.WriteLine($"Attacked planets: {attackedPlanets.Count}");
            foreach (var p in attackedPlanets.OrderBy(p=>p))
            {
                Console.WriteLine($"-> {p}");
            }
            Console.WriteLine($"Destroyed planets: {destroyedPlanets.Count}");
            foreach (var p in destroyedPlanets.OrderBy(p => p))
            {
                Console.WriteLine($"-> {p}");
            }

        }
    }
}

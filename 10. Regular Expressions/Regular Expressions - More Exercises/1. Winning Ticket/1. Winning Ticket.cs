using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Regular_Expressions___More_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tickets = Regex.Split(Console.ReadLine(), @"\s*,\s*");
            foreach (string ticket in tickets)
            {
                if (ticket.Length!=20)
                {
                    Console.WriteLine("invalid ticket");
                }
                else
                {
                    Console.Write($"ticket \"{ticket}\" - ");
                    string winningPattern = @"(@){6,}|(#){6,}|(\$){6,}|(\^){6,}";
                    Match leftMatch = Regex.Match(ticket.Substring(0, 10), winningPattern);
                    Match rightMatch = Regex.Match(ticket.Substring(10), winningPattern);

                    bool isGoodToGo = leftMatch.Success && rightMatch.Success &&
                        leftMatch.Value.First() == rightMatch.Value.First();

                    if (isGoodToGo)
                    {
                        string shorter = leftMatch.Value.Length > rightMatch.Value.Length ? rightMatch.Value : leftMatch.Value;
                        if (shorter.Length < 10)
                        {
                            Console.Write($"{shorter.Length}{shorter.First()}");
                        }
                        else 
                        {
                            Console.Write($"{shorter.Length}{shorter.First()} Jackpot!");
                        }
                    }
                    else
                    {
                        Console.Write("no match");
                    }
                    Console.WriteLine();
                }
            }

        }
    }
}

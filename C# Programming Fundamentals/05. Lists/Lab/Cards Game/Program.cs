using System;
using System.Collections.Generic;
using System.Linq;

namespace Cards_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstDeck = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            List<int> secondDeck = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            List<int> winningDeck = new List<int>();
            string winner = string.Empty;
            while (firstDeck.Count!= 0&&secondDeck.Count!=0)
            {
                if (firstDeck[0]>secondDeck[0])
                {
                    firstDeck.Add(firstDeck[0]);
                    firstDeck.Add(secondDeck[0]);
                    firstDeck.RemoveAt(0);
                    secondDeck.RemoveAt(0);
                }
                else if (firstDeck[0]<secondDeck[0])
                {
                    secondDeck.Add(secondDeck[0]);
                    secondDeck.Add(firstDeck[0]);
                    secondDeck.RemoveAt(0);
                    firstDeck.RemoveAt(0);
                }
                else 
                {
                    secondDeck.RemoveAt(0);
                    firstDeck.RemoveAt(0);
                }
                if (secondDeck.Count==0)
                {
                    winner = "First";
                    winningDeck = firstDeck;
                }
                else if (firstDeck.Count==0)
                {
                    winner = "Second";
                    winningDeck = secondDeck;
                }

                 
            }
            Console.WriteLine($"{winner} player wins! Sum: {winningDeck.Sum()}");
        }
    }
}

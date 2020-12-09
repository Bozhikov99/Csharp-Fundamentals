using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._P_rates
{
    class Program
    {
        static void Main(string[] args)
        {
            var towns = new Dictionary<string, Dictionary<string, int>>();
            string cmd = Console.ReadLine();
            while (cmd!="Sail")
            {
                string[] commands = cmd.Split("||", StringSplitOptions.RemoveEmptyEntries);
                string town = commands[0];
                int population = int.Parse(commands[1]);
                int gold = int.Parse(commands[2]);
                if (!towns.ContainsKey(town))
                {
                    towns[town] = new Dictionary<string, int>();
                    towns[town]["population"] = 0;
                    towns[town]["gold"] = 0;
                }
                towns[town]["population"] += population;
                towns[town]["gold"] += gold;
                cmd = Console.ReadLine();
            }
            cmd = Console.ReadLine();
            while (cmd!="End")
            {
                string[] tokens = cmd.Split("=>", StringSplitOptions.RemoveEmptyEntries);
                string command = tokens[0];
                string town = tokens[1];
                if (command=="Plunder")
                {
                    int people = int.Parse(tokens[2]);
                    int gold = int.Parse(tokens[3]);
                    towns[town]["population"] -= people;
                    towns[town]["gold"] -= gold;
                    Console.WriteLine($"{town} plundered! {gold} gold stolen, {people} citizens killed.");
                    if (towns[town]["gold"]<=0||towns[town]["population"]<=0)
                    {
                        Console.WriteLine($"{town} has been wiped off the map!");
                        towns.Remove(town);
                    }  
                }
                else
                {
                    int gold = int.Parse(tokens[2]);
                    if (gold >= 0)
                    {
                        towns[town]["gold"] += gold;
                        Console.WriteLine($"{gold} gold added to the city treasury. {town} now has {towns[town]["gold"]} gold.");
                    }
                    else
                    {
                        Console.WriteLine("Gold added cannot be a negative number!");
                    }
                }
                cmd = Console.ReadLine();
            }
            if (towns.Count==0)
            {
                Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
            }
            else
            {
                Console.WriteLine($"Ahoy, Captain! There are {towns.Count} wealthy settlements to go to:");
                foreach (var t in towns.OrderByDescending(t=>t.Value["gold"])
                    .ThenBy(t=>t.Key))
                {
                    Console.WriteLine($"{t.Key} -> Population: {t.Value["population"]} citizens, Gold: {t.Value["gold"]} kg");
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace _12._Plant_Discovery
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var plants = new Dictionary<string, Dictionary<string, double>>();
            for (int i = 0; i < n; i++)
            {
                string[] rarityInput = Console.ReadLine()
                    .Split("<->", StringSplitOptions.RemoveEmptyEntries);
                string plant = rarityInput[0];
                int rarity = int.Parse(rarityInput[1]);
                if (!plants.ContainsKey(plant))
                {
                    plants[plant] = new Dictionary<string, double>();
                    plants[plant]["rating"] = 0; 
                    plants[plant]["rate iterations"] = 0; 
                }
                plants[plant]["rarity"] = rarity;
            }
            string cmd = Console.ReadLine();
            while (cmd!="Exhibition")
            {
                string[] command = cmd.Split(new char[] { ':', '-', ' ' }, StringSplitOptions.RemoveEmptyEntries);
                switch (command[0])
                {
                    case "Rate":
                        string plant = command[1];
                        if (plants.ContainsKey(plant))
                        {
                            int rating = int.Parse(command[2]);
                            plants[plant]["rate iterations"]++;
                            plants[plant]["rating"] += rating;
                        }
                        else
                        {
                            Console.WriteLine("error");
                        }
                        //plants[plant]["rating"] /= plants[plant]["rate iterations"];
                        break;
                    case "Update":
                        //Update: {plant} - {new_rarity}
                        string plantUpd = command[1];
                        if (plants.ContainsKey(plantUpd))
                        {
                            int newRarity = int.Parse(command[2]);
                            plants[plantUpd]["rarity"] = newRarity;
                        }
                        else
                        {
                            Console.WriteLine("error");
                        }
                        break;
                    case "Reset":
                        //Reset: {plant} 
                        string plantRes = command[1];
                        if (plants.ContainsKey(plantRes))
                        {
                            plants[plantRes]["rating"] = 0;
                            plants[plantRes]["rate iterations"] = 0;
                        }
                        else
                        {
                            Console.WriteLine("error");
                        }
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
                cmd = Console.ReadLine();
            }
            foreach (var p in plants)
            {
                if (p.Value["rating"] != 0)
                {
                    p.Value["rating"] /= p.Value["rate iterations"];
                }
                
            }
            Console.WriteLine("Plants for the exhibition:");
            foreach (var p in plants.OrderByDescending(p=>p.Value["rarity"])
                .ThenByDescending(p=>p.Value["rating"]))
            {
                //{plant_name}; Rarity: {rarity}; Rating: {average_rating formatted to the 2nd digit}
                if (p.Value["rating"]!=0)
                {
                    Console.WriteLine($"- {p.Key}; Rarity: {p.Value["rarity"]}; Rating: {p.Value["rating"]:f2}");
                }
                else
                {
                    Console.WriteLine($"- {p.Key}; Rarity: {p.Value["rarity"]}; Rating: 0.00");
                }
            }
        }
    }
}

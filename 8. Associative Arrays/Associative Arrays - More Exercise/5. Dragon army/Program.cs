using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._Dragon_army
{
    class Program
    {
        static void Main(string[] args)
        {
            var types = new Dictionary<string, SortedDictionary<string, Dictionary<string, int>>>();
            var averageStats = new Dictionary<string, Dictionary<string, double>>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] cmd = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string type = cmd[0];
                string name = cmd[1];
                int dmg = cmd[2] == "null" ? dmg = 45 : int.Parse(cmd[2]);
                int hp = cmd[3] == "null" ? hp = 250 : int.Parse(cmd[3]); ;
                int armor = cmd[4] == "null" ? armor = 10 : int.Parse(cmd[4]);

                if (!types.ContainsKey(type))
                {
                    types[type] = new SortedDictionary<string, Dictionary<string, int>>();

                    averageStats[type] = new Dictionary<string, double>();
                    averageStats[type]["avDmg"] = 0;
                    averageStats[type]["avHp"] = 0;
                    averageStats[type]["avAr"] = 0;
                }
                if (!types[type].ContainsKey(name))
                {
                    types[type][name] = new Dictionary<string, int>();
                    averageStats[type]["avDmg"] += dmg;
                    averageStats[type]["avHp"] += hp;
                    averageStats[type]["avAr"] += armor;
                }
                else
                {
                    averageStats[type]["avDmg"] += dmg - types[type][name]["damage"];
                    averageStats[type]["avHp"] += hp- types[type][name]["health"];
                    averageStats[type]["avAr"] += armor- types[type][name]["armor"];
                }
                types[type][name]["damage"] = dmg;
                types[type][name]["health"] = hp;
                types[type][name]["armor"] = armor;


            }

            foreach (var t in types)
            {
                double averageDMG = averageStats[t.Key]["avDmg"] / t.Value.Count;
                double averageHP = averageStats[t.Key]["avHp"] / t.Value.Count;
                double averageArmor = averageStats[t.Key]["avAr"] / t.Value.Count;
                Console.WriteLine($"{t.Key}::({averageDMG:f2}/{averageHP:f2}/{averageArmor:f2})");
                foreach (var d in t.Value)
                {
                    int dmg = d.Value["damage"];
                    int hp = d.Value["health"];
                    int armor = d.Value["armor"];
                    Console.WriteLine($"-{d.Key} -> damage: {dmg}, health: {hp}, armor: {armor}");
                }
            }
        }
    }
}

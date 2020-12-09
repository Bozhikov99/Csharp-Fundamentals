using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _05._Nether_Realms
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] demons = Console.ReadLine()
                .Split(new[]{',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string Pattern = @"[-+]?[0-9]+\.?[0-9]*";
            List<Demon> demonList = new List<Demon>();
            foreach (string demon in demons)
            {
                string filter = "1234567890./+-*";
                int health = demon.Where(c => !filter.Contains(c)).Sum(c=>c);
                double dmg = 0;
                MatchCollection dmgMatches = Regex.Matches(demon, Pattern);
                foreach (Match m in dmgMatches)
                {
                    dmg += double.Parse(m.Value);
                }
                foreach (char c in demon)
                {
                    if (c=='*')
                    {
                        dmg *= 2;
                    }
                    else if (c=='/')
                    {
                        dmg /= 2;
                    }
                }
                Demon current = new Demon(demon, health, dmg);
                demonList.Add(current);
            }
            foreach (Demon d in demonList.OrderBy(d=>d.Name))
            {
                Console.WriteLine(d.ToString());
            }
        }
    }
    class Demon
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public double Damage { get; set; }
        public Demon(string name, int health, double dmg)
        {
            Name = name;
            Health = health;
            Damage = dmg;
        }
        public override string ToString()
        {
            return $"{Name} - {Health} health, {Damage:f2} damage";
        }
    }
}

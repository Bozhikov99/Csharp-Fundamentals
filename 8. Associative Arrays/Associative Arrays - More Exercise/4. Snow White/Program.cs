using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace _4._Snow_White
{
    class Program
    {
        static void Main(string[] args)
        {
            var dwarfs = new Dictionary<string, Dictionary<string, int>>();
            string input = Console.ReadLine();
            while (input!= "Once upon a time")
            {
                string[] cmd = input.Split(" <:> ");
                string name = cmd[0];
                string hatColor = cmd[1];
                int physics = int.Parse(cmd[2]);
                if (!dwarfs.ContainsKey(hatColor))
                {
                    dwarfs[hatColor] = new Dictionary<string, int>();
                    dwarfs[hatColor].Add(name, physics);
                }
                else if (dwarfs.ContainsKey(hatColor))
                {
                    if (dwarfs[hatColor].ContainsKey(name))
                    {
                        if (physics > dwarfs[hatColor][name])
                        {
                            dwarfs[hatColor][name] = physics;
                        }
                    }
                    else
                    {
                        dwarfs[hatColor].Add(name, physics);
                    }
                }
                
                input = Console.ReadLine();
            }
            Dictionary<string, int> sortedDwarfs = new Dictionary<string, int>();
            foreach (var hatColor in dwarfs.OrderByDescending(x => x.Value.Count()))
            {
                foreach (var dwarf in hatColor.Value)
                {
                    sortedDwarfs.Add($"({hatColor.Key}) {dwarf.Key} <-> ", dwarf.Value);
                }
            }
            foreach (var dwarf in sortedDwarfs.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"{dwarf.Key}{dwarf.Value}");
            }
                       
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text.RegularExpressions;
using System.Threading;

namespace _02._Race
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] contestants = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);
            Dictionary<string, int> distances = new Dictionary<string, int>();
            foreach (string c in contestants)
            {
                distances.Add(c, 0);
            }

            string cmd = Console.ReadLine();
            string namePattern = @"[\W\d]?";
            string kmPattern = @"[\WA-Za-z]";
            while (cmd!="end of race")
            {
                string name = Regex.Replace(cmd, namePattern, "");
                string km = Regex.Replace(cmd, kmPattern, "");
                if (distances.ContainsKey(name))
                {
                    foreach (char c in km)
                    {
                        distances[name] += int.Parse(c.ToString());
                    }
                }
                cmd = Console.ReadLine();
            }
            int counter = 1;
            foreach (var item in distances.OrderByDescending(d=>d.Value))
            {
                string position = counter == 1 ? "st" :counter==2?"nd":"rd";
                Console.WriteLine($"{counter++}{position} place: {item.Key}");
                if (counter==4)
                {
                    break;
                }
            }
        }
    }
}

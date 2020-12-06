using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Judge
{
    class Program
    {
        static void Main(string[] args)
        {
            var contests = new Dictionary<string, Dictionary<string, int>>();
            //contest, submission<name, score>)
            var userScore = new Dictionary<string, int>();
            string cmd = Console.ReadLine();
            while (cmd != "no more time")
            {
                string[] commands = cmd.Split(" -> ")
                    .ToArray();
                string username = commands[0];
                string contest = commands[1];
                int score = int.Parse(commands[2]);
                
                if (!userScore.ContainsKey(username))
                {
                    userScore[username] = 0;
                }
                if (!contests.ContainsKey(contest))
                {
                    contests[contest] = new Dictionary<string, int>();
                }

                if (!contests[contest].ContainsKey(username))
                {
                    contests[contest].Add(username, score);
                    userScore[username] += score;
                }
                else
                {
                    if (contests[contest][username] < score)
                    {
                        userScore[username] +=  score-contests[contest][username];
                        contests[contest][username] = score;
                    }
                    
                }

                cmd = Console.ReadLine();
            }
            foreach (var c in contests)
            {
                Console.WriteLine($"{c.Key}: {c.Value.Count} participants");
                int pos = 1;
                foreach (var u in c.Value.OrderByDescending(s=>s.Value).ThenBy(s=>s.Key))
                {
                    Console.WriteLine($"{pos}. {u.Key} <::> {u.Value}");
                    pos++;
                }
                //contest=> Name (key)
                //       => Submissions(value)
                //          => Username(key)
                //          => score(value)
            }
            Console.WriteLine("Individual standings:");
            int individualPosition = 1;
            foreach (var u in userScore.OrderByDescending(u=>u.Value).ThenBy(u=>u.Key))
            {
                Console.WriteLine($"{individualPosition}. {u.Key} -> {u.Value} ");
                individualPosition++;
            }
        }
    }
}

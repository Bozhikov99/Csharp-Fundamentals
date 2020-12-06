using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace _3._MOBA_Challenger
{
    class Program
    {
        static void Main(string[] args)
        {
            var playerPool = new Dictionary<string, Dictionary<string, int>>();
            string cmd = Console.ReadLine();
            while (cmd != "Season end")
            {

                if (cmd.Contains(" -> "))
                {
                    string[] command = cmd.Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
                    string player = command[0];
                    string position = command[1];
                    int skill = int.Parse(command[2]);
                    if (!playerPool.ContainsKey(player))
                    {
                        playerPool[player] = new Dictionary<string, int>();
                    }

                    if (!playerPool[player].ContainsKey(position))
                    {
                        playerPool[player].Add(position, skill);
                    }
                    else if (playerPool[player][position]<skill)
                    {
                        playerPool[player][position] = skill;
                    }
                    
                }

                else if (cmd.Contains(" vs "))
                {
                    string[] command = cmd.Split(" vs ", StringSplitOptions.RemoveEmptyEntries);
                    string firstPlayer = command[0];
                    string secondPlayer = command[1];
                    if (playerPool.ContainsKey(firstPlayer)&&playerPool.ContainsKey(secondPlayer))
                    {
                        bool canDuel = false;
                        foreach (var p in playerPool[firstPlayer])                      //Проверяваме позициите
                        {
                            foreach (var posit in playerPool[secondPlayer])
                            {
                                if (posit.Key==p.Key)
                                {
                                    canDuel = true;
                                    break;
                                }
                            }
                            if (canDuel == true)
                            {
                                break;
                            }
                        }
                        if (canDuel==true)
                        {
                            if (playerPool[firstPlayer].Values.Sum()> playerPool[secondPlayer].Values.Sum())
                            {
                                playerPool.Remove(secondPlayer);
                            }
                            else if (playerPool[firstPlayer].Values.Sum() < playerPool[secondPlayer].Values.Sum())
                            {
                                playerPool.Remove(firstPlayer);
                            }
                        }
                    }
                }
                cmd = Console.ReadLine();
            }
            foreach (var p in playerPool.OrderByDescending(p=>p.Value.Values.Sum())
                .ThenBy(p=>p.Key))
            {
                Console.WriteLine($"{p.Key}: {p.Value.Values.Sum()} skill");
                foreach (var pos in p.Value.OrderByDescending(p=>p.Value).ThenBy(p=>p.Key))
                {
                    Console.WriteLine($"- {pos.Key} <::> {pos.Value}");
                }
            }
        }
    }
}

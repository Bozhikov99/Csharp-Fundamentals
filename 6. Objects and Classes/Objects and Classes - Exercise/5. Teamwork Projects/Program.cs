using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace _5._Teamwork_Projects
{
    class Program
    {
        static void Main(string[] args)
        {
            int teams = int.Parse(Console.ReadLine());
            List<Team> teamList = new List<Team>();
            for (int i = 0; i < teams; i++)
            {
                string[] cmd = Console.ReadLine()
                    .Split("-", StringSplitOptions.RemoveEmptyEntries);

                bool isTeamNameTaken = teamList.Select(x=>x.TeamName)
                    .Contains(cmd[1]);

                bool isCreatorExisting = teamList.Select(x => x.Creator)
                    .Contains(cmd[0]);

                Team newTeam = new Team(cmd[0], cmd[1]);
                if (!isTeamNameTaken)
                {
                    if (!isCreatorExisting)
                    {
                        teamList.Add(newTeam);
                        Console.WriteLine($"Team {cmd[1]} has been created by {cmd[0]}!");
                    }
                    else
                    {
                        Console.WriteLine($"{cmd[0]} cannot create another team!");
                    }
                }
                else
                {
                    Console.WriteLine($"Team {cmd[1]} was already created!");
                }

                
            }

            //Joining 
            string memberInput = Console.ReadLine();

            while (memberInput!="end of assignment")
            {
                string[] cmd = memberInput.Split("->")
                    .ToArray();
                string newMember = cmd[0];
                string teamName = cmd[1];

                bool teamExists = teamList.Select(x => x.TeamName)
                    .Contains(cmd[1]);

                bool creatorExists = teamList.Select(x => x.Creator)
                    .Contains(newMember);

                bool memberExists = teamList.Select(x => x.Members)
                    .Any(x => x.Contains(newMember));

                if (!teamExists)
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                }
                else if (creatorExists||memberExists)
                {
                    Console.WriteLine($"Member {newMember} cannot join team {teamName}!");
                }
                else
                {
                    int teamIndex = teamList.FindIndex(x => x.TeamName == teamName);
                    teamList[teamIndex]
                        .Members
                        .Add(newMember);
                }
                memberInput = Console.ReadLine();
            }
            Team[] toDQ = teamList.OrderBy(x => x.TeamName)
                .Where(x => x.Members.Count == 0)
                .ToArray();
            Team[] participatingTeams = teamList.OrderByDescending(x => x.Members.Count)
                .ThenBy(x => x.TeamName)
                .Where(x=>x.Members.Count>0)
                .ToArray();
            StringBuilder print = new StringBuilder();
            foreach (Team x in participatingTeams)
            {
                print.AppendLine($"{x.TeamName}");
                print.AppendLine($"- {x.Creator}");
                foreach(var member in x.Members.OrderBy(x=>x))
                {
                    print.AppendLine($"-- {member}");
                }
            }
            print.AppendLine("Teams to disband:");
            foreach (Team x in toDQ)
            {
                print.AppendLine(x.TeamName);
            }
            Console.WriteLine(print.ToString());
        }
    }
    class Team
    {
        public string Creator { get; set; }
        public string TeamName { get; set; }
        public List<string> Members { get; set; }
        public Team(string creator, string teamname)
        {
            TeamName = teamname;
            Creator = creator;
            Members = new List<string>();
        }
    }
}
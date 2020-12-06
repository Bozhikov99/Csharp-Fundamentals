using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;

namespace Associative_Arrays___More_Exercise //01.Ranking
{
    class Program
    {
        static void Main(string[] args)
        {
            var exams = new Dictionary<string, string>();
            string cmd = Console.ReadLine();
            while (cmd!="end of contests")
            {
                string[] command = cmd.Split(":", StringSplitOptions.RemoveEmptyEntries);
                string contest = command[0];
                string contestPassword = command[1];
                exams[contest] = contestPassword;
                cmd = Console.ReadLine();
            }

            var students = new Dictionary<string, Dictionary<string, int>>();

            string submit = Console.ReadLine();
            while (submit != "end of submissions")
            {//C# Fundamentals=>fundPass=>Tanya=>350
                string[] command = submit.Split("=>", StringSplitOptions.RemoveEmptyEntries);
                string contest = command[0];
                string password = command[1];
                string name = command[2];
                int score = int.Parse(command[3]);
                bool isValidExam = exams.ContainsKey(contest) &&
                    exams[contest] == password;
                if (isValidExam)
                {
                    if (!students.ContainsKey(name))
                    {
                        students[name] = new Dictionary<string, int>();
                        students[name].Add(contest, score);
                    }
                    else 
                    {
                        if (!students[name].ContainsKey(contest))
                        {
                            students[name].Add(contest, score);
                        }
                        else
                        {
                            if (students[name][contest]<score)
                            {
                                students[name][contest] = score;
                            }   
                        }
                    }
                    
                }
                submit = Console.ReadLine();
            }
            string bestCandidate = students.OrderByDescending(s => s
            .Value
            .Values
            .Sum())
                .First()
                .Key;
            int totalScore = students.OrderByDescending(s => s
              .Value
              .Values
              .Sum())
                .First()
                .Value
                .Values
                .Sum();
            Console.WriteLine($"Best candidate is {bestCandidate} with total {totalScore} points.");
            foreach (var s in students.OrderBy(s=>s.Key))
            {
                Console.WriteLine($"{s.Key}");
                foreach (var c in s.Value.OrderByDescending(s=>s.Value))
                {
                    Console.WriteLine($"# {c.Key} -> {c.Value}");
                }
            }
        }
    }
}

using System;
using System.Linq;
using System.Net.Http.Headers;

namespace Shoot_for_the_win
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] targets = Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int targetShotCount = 0;

            string cmd = Console.ReadLine().ToUpper();
            while (cmd!="END")
            {

                int index = int.Parse(cmd);
                if (index >= 0 && index < targets.Length&& targets[index]!=-1)
                {
                    targetShotCount++;
                    int target = targets[index];
                    int shotValue = target;
                    targets[index] = -1;
                    for (int i = 0; i < targets.Length; i++)
                    {
                        if (i!=index)
                        {
                            if (targets[i] != -1&&shotValue >=targets[i])
                            {
                                targets[i] += shotValue;
                            }
                            else if (shotValue<targets[i]&&targets[i]!=-1)
                            {
                                targets[i] -= shotValue;
                            }
                        }
                    }
                }
                cmd = Console.ReadLine().ToUpper();
            }
            Console.WriteLine($"Shot targets: {targetShotCount} -> {string.Join(" ",targets)}");
        }
    }
}

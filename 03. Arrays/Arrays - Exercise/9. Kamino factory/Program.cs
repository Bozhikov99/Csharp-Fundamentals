using System;

namespace _9._Kamino_factory
{
    class Program
    {
        static void Main(string[] args)
        {
            int dnaLength = int.Parse(Console.ReadLine());

            string[] sequence = new string[dnaLength];
            sequence = Console.ReadLine()
                    .Split("!", StringSplitOptions.RemoveEmptyEntries);
            
            string cmd = string.Join("",sequence);
            string bestSequence = string.Empty;
            int bestStreak = 0;
            int bestSqOnes = 0;
            int bestBeginIndex = 0;
            int streakIndex = 0;
            int bestStreakIndex = 0;
            int count = 0;
            int currSqOnes = 0;
            int currStreak = 0;
            //reads the DNA sequences.
            while (cmd != "Clone them")
            {
                currSqOnes = 0;
                count = 0;
                currStreak = 0;
                //reads a single DNA sequence.
                for (int i = 0; i < sequence.Length; i++)
                {
                    //records the streak of ones and the count of them.
                    if (int.Parse(sequence[i]) == 1)
                    {
                        count++;
                        currSqOnes++;
                    }
                    else
                    {
                        if (count> currStreak)
                        {
                            currStreak = count;
                        }
                        count = 0;
                    }
                    
                }
                streakIndex++;
                if (count>currStreak)
                {
                    currStreak = count;
                }
                int beginIndex = cmd.IndexOf('1');
                //checks if the current sequence is the best one so far.
                if (currStreak >= bestStreak && beginIndex>bestBeginIndex||
                    (currStreak>=bestStreak&&beginIndex>=bestBeginIndex&&currSqOnes>bestSqOnes))
                {
                    bestStreak = currStreak;
                    bestSqOnes = currSqOnes;
                    bestBeginIndex = beginIndex;
                    bestStreakIndex = streakIndex;
                    bestSequence = string.Join(" ", sequence);
                }
                //reads sequence or ends the process of cloning
                sequence = Console.ReadLine()
                            .Split("!", StringSplitOptions.RemoveEmptyEntries);
                
                cmd = string.Join("", sequence);

            }
            Console.WriteLine($"Best DNA sample {bestStreakIndex} with sum: {bestSqOnes}.");
            Console.WriteLine($"{bestSequence}");
        }
    }
}

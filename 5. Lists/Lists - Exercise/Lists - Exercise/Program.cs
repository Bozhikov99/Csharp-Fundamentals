using System;
using System.Linq;

namespace Lists___Exercise      //car race
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] track = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();
            double leftTime = 0;
            double rightTime = 0;
            string winner = string.Empty;
            for (int i = 0; i <(track.Length-1)/2; i++)
            {
                leftTime += track[i];
                if (track[i]==0)
                {
                    leftTime *= 0.8;
                }
                rightTime += track[(track.Length - 1) - i];
                if ((track.Length - 1) - i == 0)
                {
                    rightTime *= 0.8;
                }
            }
            if (leftTime<rightTime)
            {
                winner = $"The winner is left with total time: {leftTime}";
            }
            else
            {
                winner = $"The winner is right with total time: {rightTime}";
            }
            Console.WriteLine(winner);
        }
    }
}

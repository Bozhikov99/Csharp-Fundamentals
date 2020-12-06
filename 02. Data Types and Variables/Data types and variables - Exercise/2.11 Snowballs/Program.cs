using System;
using System.Numerics;

namespace _2._11_Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            int snowballAmount = int.Parse(Console.ReadLine());
            BigInteger bestBall = 0;
            int bestBallSnow = 0;
            int bestBallTime = 0;
            int bestBallQuality = 0;
            for (int i = 0; i < snowballAmount; i++)
            {
                
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());

                int snowTime = snowballSnow / snowballTime;
                BigInteger snowballValue = BigInteger.Pow((snowTime), snowballQuality);
                if (snowballValue>bestBall)
                {
                    bestBall = snowballValue;
                    bestBallTime = snowballTime;
                    bestBallSnow = snowballSnow;
                    bestBallQuality = snowballQuality;

                }
            }
            Console.WriteLine($"{bestBallSnow} : {bestBallTime} = {bestBall} ({bestBallQuality})");
        }
    }
}

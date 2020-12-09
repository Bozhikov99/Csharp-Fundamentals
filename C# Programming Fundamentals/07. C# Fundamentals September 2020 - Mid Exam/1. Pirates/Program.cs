using System;

namespace Fundamentals_Mid_Exam_2020
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int dailyPlunder = int.Parse(Console.ReadLine());
            decimal target = decimal.Parse(Console.ReadLine());
            decimal totalPlunder = 0;
            for (int i = 1; i <= days; i++)
            {
                totalPlunder += dailyPlunder;
                if (i % 3 == 0)
                {
                    totalPlunder +=dailyPlunder*0.5M;
                }
                if (i%5==0)
                {
                    totalPlunder *= 0.70M;
                }
            }
            if (totalPlunder>=target)
            {
                Console.WriteLine($"Ahoy! {totalPlunder:f2} plunder gained.");
            }
            else
            {
                Console.WriteLine($"Collected only {(totalPlunder/(target/100)):f2}% of the plunder.");
            }
        }
    }
}

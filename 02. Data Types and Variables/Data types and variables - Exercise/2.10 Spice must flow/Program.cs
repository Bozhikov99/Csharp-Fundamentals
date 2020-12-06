using System;

namespace _2._10_Spice_must_flow
{
    class Program
    {
        static void Main(string[] args)
        {
            int sourceCapacity = int.Parse(Console.ReadLine());
            int days = 0;
            int totalAmount = 0;
            int dailyAmount = 0;
            while (sourceCapacity>=100)
            {
                dailyAmount = sourceCapacity;
                sourceCapacity -= 10;
                totalAmount += dailyAmount;
                dailyAmount = 0;
                if (totalAmount >= 26)
                {
                    totalAmount -= 26;
                }
               
                
                days++;
            }
            if (totalAmount >= 26)
            {
                totalAmount -= 26;
            }

            Console.WriteLine(days);
            Console.WriteLine(totalAmount);
        }
    }
}

using System;
using System.Linq;


namespace ValentineDay
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] neightborhood = Console.ReadLine()
                .Split("@")
                .Select(int.Parse)
                .ToArray();

            int jumpPositions = 0;
            string input = Console.ReadLine();

            while (input != "Love!")
            {

                string[] comands = input
                     .Split(" ");
                int jumpLenght = int.Parse(comands[1]);

                jumpPositions += jumpLenght;
                if (jumpPositions >= 0 && jumpPositions < neightborhood.Length)
                {
                    neightborhood[jumpPositions] -= 2;
                }
                else
                {
                    jumpPositions = 0;
                    neightborhood[jumpPositions] -= 2;
                }

                if (neightborhood[jumpPositions] == 0)//vvgreshka
                {
                    Console.WriteLine($"Place {jumpPositions} has Valentine's day.");
                }
                else if (neightborhood[jumpPositions] < 0)
                {
                    Console.WriteLine($"Place {jumpPositions} already had Valentine's day.");
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Cupid's last position was {jumpPositions}.");

            int faileCount = neightborhood.Count(x => x > 0);
            if (faileCount == 0)
            {
                Console.WriteLine("Mission was successful.");
            }
            else
            {
                Console.WriteLine($"Cupid has failed {faileCount} places.");
            }



        }
    }
}
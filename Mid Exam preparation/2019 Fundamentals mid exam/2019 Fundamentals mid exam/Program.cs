using System;

namespace _2019_Fundamentals_mid_exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int playerCount = int.Parse(Console.ReadLine());
            double energy = double.Parse(Console.ReadLine());
            double waterPerDay = double.Parse(Console.ReadLine());
            double foodPerDay = double.Parse(Console.ReadLine());


            double food = foodPerDay * playerCount * days;
            double water = waterPerDay * playerCount * days;
            
            string result = string.Empty;
            for (int i = 1; i <= days; i++)
            {

                bool haveEnoughEnergy = energy > 0;
                double energyLoss = double.Parse(Console.ReadLine());
                if (haveEnoughEnergy)
                {
                    energy -= energyLoss;
                    if (i % 2 == 0)
                    {
                        energy *= 1.05;
                        water *= 0.70;
                    }
                    if (i%3==0)
                    {
                        energy *= 1.1;
                        food -= food/playerCount;
                    }
                }
                else
                {
                    result = $"You will run out of energy. You will be left with {food:f2} food and {water:f2} water.";
                    break;
                }
            }
            if (energy>0)
            {
               result=$"You are ready for the quest. You will be left with - {energy:f2} energy!";
            }
            else
            {
                result = $"You will run out of energy. You will be left with {food:f2} food and {water:f2} water.";
            }
            Console.WriteLine(result);
        }
    }
}

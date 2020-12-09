using System;

namespace _0._9
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double priceLightsabers = double.Parse(Console.ReadLine());
            double priceRobes = double.Parse(Console.ReadLine());
            double priceBelts = double.Parse(Console.ReadLine());
            int freeBelts = 0;
            if (students > 5)
            {
                freeBelts = (students / 6);
            }
            double lightsabers = Math.Ceiling(1.1 * students);
            int robes = students;
            int belts = students - freeBelts;
            double totalPrice = lightsabers*priceLightsabers+belts*priceBelts+robes*priceRobes;

            if (totalPrice > budget)
            {
                Console.WriteLine($"Ivan Cho will need {(totalPrice - budget):f2}lv more.");
            }
            else
            {
                Console.WriteLine($"The money is enough - it would cost {totalPrice:f2}lv.");
            }
        }
    }
}

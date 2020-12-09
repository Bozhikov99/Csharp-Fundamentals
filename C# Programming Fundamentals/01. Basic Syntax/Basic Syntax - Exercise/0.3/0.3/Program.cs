using System;

namespace _0._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            string classa =Console.ReadLine();
            string day = Console.ReadLine();
            double price = 0;
            if (classa =="Students")
            {
                
                if (day=="Friday")
                {
                    price = 8.45 * people;
                }
                else if(day=="Saturday")
                {
                    price = 9.8 * people;
                }
                else if (day=="Sunday")
                {
                    price = 10.46 * people;
                }
                if (people >= 30)
                {
                    price *= 0.85;
                }
            }
            if (classa == "Business")
            {
                if (people >= 100)
                {
                    people -= 10;
                }
                if (day == "Friday")
                {
                    price = 10.90 * people;
                }
                else if (day == "Saturday")
                {
                    price = 15.60 * people;
                }
                else if (day == "Sunday")
                {
                    price = 16 * people;
                }
                
            }
            if (classa=="Regular")
            {
                if (day == "Friday")
                {
                    price = 15 * people;
                }
                else if (day == "Saturday")
                {
                    price = 20 * people;
                }
                else if (day == "Sunday")
                {
                    price = 22.5 * people;
                }
                if (people>=10 && people<=20)
                {
                    price *= 0.95;
                }
                
            }
            Console.WriteLine($"Total price: {price:F2}");
        }
    }
}

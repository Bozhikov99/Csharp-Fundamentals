using System;

namespace Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            //coffee 1.5, water 1.0, coke 1.4, snacks 2.00
            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            orderSum(quantity, product);
        }
        static void orderSum(int quantity, string product)
        {
            double sum = 0;
            switch (product)
            {
                case "water":
                    sum += quantity * 1;
                    break;
                case "coffee":
                    sum +=quantity * 1.5;
                    break;
                case "coke":
                    sum += quantity * 1.4;
                    break;
                case "snacks":
                    sum += quantity * 2;
                    break;
                default:
                    break;
            }
            Console.WriteLine($"{sum:f2}");
        }
    }
}

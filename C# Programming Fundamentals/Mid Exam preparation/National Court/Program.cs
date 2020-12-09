using System;

namespace _1._National_Court
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstCapacity = int.Parse(Console.ReadLine());
            int secCapacity = int.Parse(Console.ReadLine());
            int thirdCapacity = int.Parse(Console.ReadLine());
            int totalPeople = int.Parse(Console.ReadLine());
            int peoplePerHour = firstCapacity + secCapacity + thirdCapacity;
            int hours = 0;
            for (int i = 1; totalPeople > 0; i++)
            {
                hours = i;
                if (i % 4 != 0)
                {
                    totalPeople -= peoplePerHour;
                }
            }
            Console.WriteLine($"Time needed: {hours}h.");
        }
    }
}

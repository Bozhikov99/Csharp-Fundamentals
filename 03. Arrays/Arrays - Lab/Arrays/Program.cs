using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] week =
            {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };
            int input = int.Parse(Console.ReadLine());
            if (input<=week.Length&&input>0)
            {
                Console.WriteLine($"{week[input-1]}");
            }
            else
            {
                Console.WriteLine("Invalid day!");
            }

        }
    }
}

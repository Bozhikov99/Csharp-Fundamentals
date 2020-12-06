using System;

namespace _8._Town_Info
{
    class Program
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine();
            string pop = Console.ReadLine();
            string area = Console.ReadLine();
            Console.WriteLine($"Town {town} has population of {pop} and area {area} square km.");
        }
    }
}

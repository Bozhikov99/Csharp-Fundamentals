using System;

namespace _2._7._Water_overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int capacity = 255;
            int flows = int.Parse(Console.ReadLine());
            int litres = 0;
            for (int i = 1; i <=flows; i++)
            {
                int pour = int.Parse(Console.ReadLine());
                if (capacity<litres+pour)
                {
                    Console.WriteLine("Insufficient capacity!");
                }
                else
                {
                    litres += pour;
                }
            }
            Console.WriteLine(litres);
        }
    }
}

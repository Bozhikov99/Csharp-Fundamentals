using System;
using System.Linq;

namespace _7._Condense_array_to_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] main = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            string output = string.Empty;
            if (main.Length == 1)
            {
                output = $"{main[0]}";
            }
            while (main.Length>1)
            {
                int[] dense = new int[main.Length - 1];
                for (int i = 0; i <dense.Length ; i++)
                {
                     dense[i] = main[i] + main[i + 1];
                }
                main= dense;
                output = $"{main[0]}";
            }
            Console.WriteLine(output);
        }
    }
}

using System;
using System.Linq;

namespace _4._Reverse_array_of_strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine()
                .Split()
                .ToArray();
            Console.WriteLine(string.Join(" ", arr.Reverse()));
        }
    }
}

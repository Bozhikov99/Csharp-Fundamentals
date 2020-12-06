using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            if (input=="string")
            {
                string a = Console.ReadLine();
                string b = Console.ReadLine();
                Console.WriteLine(GetMax(a, b));
            }
            else if(input == "int")
            {
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine(GetMax(a, b));
            }
            else if (input == "char")
            {
                char a = char.Parse(Console.ReadLine());
                char b = char.Parse(Console.ReadLine());
                Console.WriteLine(GetMax(a, b));
            }

        }
        static string GetMax(string a, string b)
        {
            int max = a.CompareTo(b);
            if (max>=0)
            {
                return a;
            }
            else
            {
                return b;
            }

        }
        static int GetMax(int a, int b)
        {
            return Math.Max(a, b);
        }
        static char GetMax(char a, char b)
        {
            return (char)Math.Max(a, b);
        }
    }
}

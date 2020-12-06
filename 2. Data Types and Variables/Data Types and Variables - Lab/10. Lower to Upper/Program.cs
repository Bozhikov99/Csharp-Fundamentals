using System;

namespace _10._Lower_to_Upper
{
    class Program
    {
        static void Main(string[] args)
        {
            string letter = Console.ReadLine();
            string res = string.Empty;
            if (letter==letter.ToUpper())
            {
                res = "upper-case";
            }
            else
            {
                res = "lower-case";
            }
            Console.WriteLine(res);
        }
    }
}

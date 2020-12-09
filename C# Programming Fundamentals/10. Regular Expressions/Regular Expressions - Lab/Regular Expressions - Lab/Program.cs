using System;
using System.Text.RegularExpressions;

namespace Regular_Expressions___Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+";
            Regex rx = new Regex(pattern);
            string text = Console.ReadLine();
            var matches = rx.Matches(text);
            Console.WriteLine(string.Join(" ",matches));
        }
    }
}

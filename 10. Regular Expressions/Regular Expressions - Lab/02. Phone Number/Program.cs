using System;
using System.Text.RegularExpressions;

namespace _02._Phone_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string pattern = @"(?:[+][359]+)((\s)|-)([2])(\1)(\d{3})(\1)(\d{4})";
            var regex = new Regex(pattern);
            var matches = regex.Matches(text);
            Console.WriteLine(string.Join(", ",matches));
        }
    }
}

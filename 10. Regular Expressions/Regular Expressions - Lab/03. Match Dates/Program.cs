using System;
using System.Text.RegularExpressions;

namespace _03._Match_Dates
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern= @"(?<day>[0-3]+[0-9])((.)|([/])|(-))(?<month>[A-Z][a-z][a-z])\2(?<year>\d{4})";
            var regX = new Regex(pattern);
            var matches = regX.Matches(input);
            foreach (Match match in matches)
            {
                //Day: 13, Month: Jul, Year: 1928
                string day = match.Groups["day"].Value;
                string month = match.Groups["month"].Value;
                string year = match.Groups["year"].Value;
                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }
        }
    }
}

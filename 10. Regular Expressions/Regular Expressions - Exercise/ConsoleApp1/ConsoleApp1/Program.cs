using System;
using System.Text;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            string pattern = @">>(?<furniture>\w+)<<(?<price>\d+((.\d+)?))!(?<quantity>\d+)";
            Regex rx = new Regex(pattern);
            double sum = 0;
            string input = Console.ReadLine();
            while (input!="Purchase")
            {
                if (rx.IsMatch(input))
                {
                    sb.AppendLine(input);
                }
                input = Console.ReadLine();
            }
            var matches = rx.Matches(sb.ToString());
            Console.WriteLine("Bought furniture:");
            foreach (Match m in matches)
            {
                sum += double.Parse(m.Groups["price"].Value) * double.Parse(m.Groups["quantity"].Value);
                Console.WriteLine(m.Groups["furniture"].Value);
            }
            Console.WriteLine($"Total money spend: {sum:f2}");
        }
    }
}

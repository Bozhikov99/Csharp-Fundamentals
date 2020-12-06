using System;
using System.Text.RegularExpressions;

namespace _03._SoftUni_Bar_Income
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern= @"%(?<name>[A-Za-z]+)%([^.|$%])*<(?<product>\w+)>([^.|$%])*\|(?<quantity>\d+)\|([^.|$%])*?(?<price>\d+\.?\d*)\$";
            string input = Console.ReadLine();
            double sum = 0;
            while (input!="end of shift")
            {
                //George: Croissant - 20.60
                Match match = Regex.Match(input, pattern);
                if (match.Success)
                {
                    string name = match.Groups["name"].Value;
                    string prod = match.Groups["product"].Value;
                    int quantity = int.Parse(match.Groups["quantity"].Value);
                    double price = double.Parse(match.Groups["price"].Value);
                    Console.WriteLine($"{name}: {prod} - {(quantity*price):f2}");
                    sum += quantity*price;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"Total income: {sum:f2}");
        }
    }
}

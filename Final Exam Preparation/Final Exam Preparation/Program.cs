using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Final_Exam_Preparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            string pattern = @"^@#+(?<product>[A-Z][A-Za-z0-9]{4,}[A-Z])@#+$";
            for (int i = 0; i < lines; i++)
            {
                string input = Console.ReadLine();
                string productGroup = string.Empty;
                Match current = Regex.Match(input, pattern);
                if (current.Success)
                {
                    foreach (char c in current.Groups["product"].Value)
                    {
                        if (char.IsDigit(c))
                        {
                            productGroup += c;
                        }
                    }
                    if (productGroup==string.Empty)
                    {
                        productGroup = "00";
                       
                    }
                    Console.WriteLine($"Product group: {productGroup}");
                }
                else
                {
                    Console.WriteLine("Invalid barcode");
                }
            }
        }
    }
}

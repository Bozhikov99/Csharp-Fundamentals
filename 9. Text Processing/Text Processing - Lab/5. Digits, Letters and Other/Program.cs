using System;
using System.Text;

namespace _5._Digits__Letters_and_Other
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            StringBuilder nums = new StringBuilder();
            StringBuilder letters = new StringBuilder();
            StringBuilder symbols = new StringBuilder();
            foreach (char l in text)
            {
                if (char.IsLetterOrDigit(l))
                {
                    _ = char.IsDigit(l) ? nums.Append(l) : letters.Append(l);
                }
                else
                {
                    symbols.Append(l);
                }
            }
            Console.WriteLine(nums);
            Console.WriteLine(letters);
            Console.WriteLine(symbols);
        }
    }
}

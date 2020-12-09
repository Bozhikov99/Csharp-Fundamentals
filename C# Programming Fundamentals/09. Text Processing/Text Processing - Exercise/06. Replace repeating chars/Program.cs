using System;
using System.Linq;
using System.Text;

namespace _06._Replace_repeating_chars
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var sb = new StringBuilder();
            for (int i = 0; i < input.Length-1; i++)
            {
                if (input[i]!=input[i+1])
                {
                    sb.Append(input[i]);
                }
            }
            sb.Append(input[input.Length - 1]);
            Console.WriteLine(sb);
        }
    }
}

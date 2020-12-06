using System;
using System.Text;

namespace repeat_string
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int repeats = int.Parse(Console.ReadLine());
            Console.WriteLine(repeatString(input, repeats));
        }
        static string repeatString(string input,int repeats)
        {
            StringBuilder repeat=new StringBuilder();
            for (int i = 1; i <= repeats; i++)
            {
                repeat.Append(input);
            }
            return repeat.ToString();
        }
    }
}

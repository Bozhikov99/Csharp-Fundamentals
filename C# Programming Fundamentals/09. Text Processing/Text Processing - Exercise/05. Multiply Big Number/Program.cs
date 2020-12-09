using System;
using System.Linq;
using System.Text;

namespace _05._Multiply_Big_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string first = Console.ReadLine().TrimStart('0');
            short sec = short.Parse(Console.ReadLine());
            StringBuilder result = new StringBuilder();
            int left = 0;
            if (first.Length == 0||sec==0)
            {
                Console.WriteLine(0);
                return;
            }
            foreach (char c in first.Reverse())
            {
                int digit = int.Parse(c.ToString());
                int res = digit * sec + left;
                left = 0;
                if (res > 9)
                {
                    left = res / 10;
                    res %= 10;
                }
                result.Insert(0, res);
            }
            if (left != 0)
            {
                result.Insert(0, left);
            }
                Console.WriteLine(result);
        }
    }
}

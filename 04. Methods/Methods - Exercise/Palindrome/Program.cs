using System;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            while (input!="END")
            {
                int number = int.Parse(input);
                Console.WriteLine($"{IsPalindrome(number).ToString().ToLower()}");
                input = Console.ReadLine();
            }
        }
        static bool IsPalindrome(int number)
        {
            bool isTrue = false;
            int divider = 1;
            if (number<0)
            {
                return false;
            }
            while (number/divider>=10)
            {
                divider *= 10;
            }
            while (number!=0)
            {
                int l = number/divider;
                int k = number % 10;
                if (l!=k)
                {
                    return false;
                }
                number = (number % divider) / 10;
                divider /= 100;
            }

            return true;
        }
    }
}

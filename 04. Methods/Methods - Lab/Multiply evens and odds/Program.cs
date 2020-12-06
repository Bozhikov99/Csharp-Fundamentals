using System;
using System.Net.Http.Headers;

namespace Multiply_evens_and_odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = Math.Abs(int.Parse(Console.ReadLine()));
            Console.WriteLine(GetEvenSum(number)*GetOddSum(number));
        }
        static int GetEvenSum(int number)
        {
            int sum = 0;
            while (number > 0)
            {
                bool isEven = number % 2 == 0;
                if (isEven == true)
                {
                    sum += number % 10;
                }
                number /= 10;
            }
            return sum;
        }
        static int GetOddSum(int number)
        {
            int sum = 0;
            while (number>0)
            {
                bool isOdd = number % 2 != 0;
                if (isOdd==true)
                {
                    sum += number % 10;
                }
                number /= 10;
            }
            return sum;
        }
        
    }
}

using System;

namespace Multiplication_sign
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            Console.WriteLine(GetSign(num1, num2, num3));
        }

        static string GetSign(int num1, int num2, int num3)
        {
            int[] numbers = { num1, num2, num3 };
            
            bool isZero = num1 == 0 ||
                num2 == 0 ||
                num3 == 0;
            int minusCount = 0;
            if (isZero == true)
            {
                return "zero";   
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i]<0)
                {
                    minusCount++;
                }
            }
            if (minusCount%2==0)
            {
                return "positive";
                
            }
            else
            {
                return "negative";
            }
        }
    }
}

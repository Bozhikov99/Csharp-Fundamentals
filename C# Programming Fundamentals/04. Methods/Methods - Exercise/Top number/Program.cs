using System;

namespace Top_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            
            for (int i = 0; i <=number; i++)
            {
                bool isTop = IsDivisible(i) &&
                HasOddDigit(i);
                if (isTop == true)
                {
                    Console.WriteLine(i);
                }
            }
            
        }
        public static bool IsDivisible(int number)
        {
            int sum = 0;
            bool isTrue = false;
            while(number>0)
            {
                sum += number % 10;
                number /= 10;
            }
            if (sum%8==0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool HasOddDigit(int number)
        {
            bool isTrue = false;
            
            while(number>0)
            {
                if (number % 2 == 1)
                {
                    return true;
                }
                number /=10;
            }
            return isTrue;
        }
    }
}

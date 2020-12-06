using System;

namespace _02._Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strings = Console.ReadLine()
                .Split();
            Console.WriteLine(CharMultiply(strings[0], strings[1]));
        }
        public static int CharMultiply(string a, string b)
        {
            int sum = 0;
            if (a.Length!=b.Length)
            {
                string longerString = a.Length > b.Length ? a : b;
                string shorterString = a.Length > b.Length ? b : a;
                int end = shorterString.Length;
                for (int i = 0; i < shorterString.Length; i++)
                {
                    sum += (int)shorterString[i] * (int)longerString[i];
                }
                for (int i = end; i < longerString.Length; i++)
                {
                    sum += longerString[i];
                }
            }
            else
            {
                for (int i = 0; i < a.Length; i++)
                {
                    sum += a[i] * b[i];
                }
            }      
            return sum;
        }
    }
    
}

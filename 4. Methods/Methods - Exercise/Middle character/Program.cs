using System;

namespace Middle_character
{
    class Program
    {
        static void Main(string[] args)
        {
            string text=Console.ReadLine();
            if (text.Length%2==0)
            {
                Console.WriteLine(GetMiddleCharEven(text));
            }
            else
            {
                Console.WriteLine(GetMiddleCharOdd(text));
            }
        }
        public static string GetMiddleCharEven(string text)
        {
            
            int index = text.Length / 2;
            string middleChars = text.Substring(index-1,2);
            return middleChars;
        }
        public static string GetMiddleCharOdd(string text)
        {
            
            int index = text.Length / 2;
            string middleChars = text.Substring(index,1);
            return middleChars;
        }       
    }
}

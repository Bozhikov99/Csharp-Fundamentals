using System;

namespace Vowels_count
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Console.WriteLine(VowelsCount(input));
        }
        static int VowelsCount(string input)
        {
            char[] letters = input.ToCharArray();
            int vowels = 0;
            for (int i = 0; i < letters.Length; i++)
            {
                bool isVowel = letters[i] == 'a' ||
                    letters[i] == 'A' ||
                    letters[i] == 'e' ||
                    letters[i] == 'E' ||
                    letters[i] == 'u' ||
                    letters[i] == 'U' ||
                    letters[i] == 'i' ||
                    letters[i] == 'I' ||
                    letters[i] == 'O' ||
                    letters[i] == 'o';
                if (isVowel==true)
                {
                    vowels++;
                }
            }
            return vowels;
        }
    }
}

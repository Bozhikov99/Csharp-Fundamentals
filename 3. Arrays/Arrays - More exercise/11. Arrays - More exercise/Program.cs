using System;
using System.Collections.Generic;
using System.Linq;

namespace _11._Arrays___More_exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] arr = new string[n];
            int[] cryptedArr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i]=Console.ReadLine();
                int vowelSum = 0;
                int consonantSum = 0;
                int totalSum = 0;
                foreach (char letter in arr[i])
                {
                    int letterCode = (int)letter;
                    bool isVowel = letter == 'a' ||
                        letter == 'e' ||
                        letter == 'o' ||
                        letter == 'u' ||
                        letter == 'i'||
                        letter == 'A' ||
                        letter == 'E' ||
                        letter == 'O' ||
                        letter == 'U' ||
                        letter == 'I' ;
                    if (isVowel==true)
                    {
                        vowelSum += letterCode * arr[i].Length;
                    }
                    else
                    {
                        consonantSum += letterCode / arr[i].Length;
                    }
                }
                totalSum = vowelSum + consonantSum;
                cryptedArr[i] = totalSum;
            }
            Array.Sort(cryptedArr);
            foreach (int k in cryptedArr)
            {
                Console.WriteLine(k);
            }
        }
    }
}

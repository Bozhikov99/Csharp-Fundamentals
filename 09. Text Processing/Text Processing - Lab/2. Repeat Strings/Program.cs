﻿using System;

namespace _2._Repeat_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .Split();
            string result = string.Empty;
            foreach (string word in words)
            {
                int n = word.Length;
                for (int i = 0; i < n; i++)
                {
                    result += word;
                }
            }
            Console.WriteLine(result);
        }
    }
}

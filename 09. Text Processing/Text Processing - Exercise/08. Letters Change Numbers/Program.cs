using System;
using System.ComponentModel;

namespace _08._Letters_Change_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] field = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string alphabet = " ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            double sum = 0;
            //A12b s17G
            foreach (var item in field)
            {
                char firstLetter = item[0];
                int positionFirst = alphabet.IndexOf(char.ToUpper(firstLetter));
                char lastLetter = item[item.Length - 1];
                int positionSecond = alphabet.IndexOf(char.ToUpper(lastLetter));
                double number = double.Parse(item.Substring(1, item.Length - 2));
                if (firstLetter==char.ToUpper(firstLetter))
                {
                    number /= positionFirst;
                }
                else
                {
                    number *= positionFirst;
                }

                if (lastLetter==char.ToUpper(lastLetter))
                {
                    number -= positionSecond;
                }
                else
                {
                    number += positionSecond;
                }
                sum += number;
            }
            Console.WriteLine($"{sum:f2}");
        }
    }
}

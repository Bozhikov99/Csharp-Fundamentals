using System;

namespace _2._2 //Sum Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int inputValue = int.Parse(input);
            int sum = 0;
            for (int i = 0; i < input.Length; i++)
            {    
                int currentNum = inputValue % 10;
                inputValue /= 10;
                sum += currentNum;
            }
            Console.WriteLine(sum);
        }
    }
}

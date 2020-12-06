using System;

namespace _2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfChars = int.Parse(Console.ReadLine());
            
            int sum = 0;
            for (int i = 1; i <= numberOfChars; i++)
            {
                char symbol = char.Parse(Console.ReadLine());
                int currentChar = (int)symbol;
                sum += currentChar;
                
            }
            Console.WriteLine($"The sum equals: {sum}");
        } 
    }
}

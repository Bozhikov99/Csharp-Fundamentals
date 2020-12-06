using System;
using System.Collections.Generic;
using System.Linq;

namespace Messaging
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            
            string message = Console.ReadLine();
            string result = string.Empty;
            
            for (int i = 0; i < numbers.Count; i++)
            {
                int charIndex = 0;
                int num = numbers[i];
                while (num>0)
                {
                    charIndex += num % 10;
                    num /= 10;
                }
                for (int k = 0; k <message.Length; k++)
                {
                    if (k == charIndex)
                    {
                        result += message[k];
                        message=message.Remove(k, 1);
                        break;
                    }
                    if (k==message.Length-1&&charIndex!=k)
                    {
                        charIndex -= message.Length;
                        k = 0;
                    }
                }
            }
            Console.WriteLine(result);
        }
    }
}

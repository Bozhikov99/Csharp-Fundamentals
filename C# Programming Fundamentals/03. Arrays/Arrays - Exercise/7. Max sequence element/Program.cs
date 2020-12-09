using System;
using System.Linq;

namespace _7._Max_sequence_element
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine()
                .Split();
            int bestLength = 0;
            int bestIndex = 0;
            for (int i = 0; i < array.Length; i++)
            {
                string currentElement = array[i];
                int currentCounter = 1;
                for (int j = i+1; j < array.Length; j++)
                {
                    if (currentElement==array[j])
                    {
                        currentCounter += 1;
                    }
                    else
                    {
                        break;
                    }
                }
                if (currentCounter> bestLength)
                {
                    bestLength = currentCounter;
                    bestIndex = i;
                }
                else
                {
                    currentCounter = 0;
                }
            }
            for (int i = 0; i < bestLength; i++)
            {
                Console.Write($"{array[bestIndex]} ");
            }
        }
    }
}

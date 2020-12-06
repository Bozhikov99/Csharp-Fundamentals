using System;

namespace _2._6
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfTriples = int.Parse(Console.ReadLine());
            
            for (int i = 0; i <=numberOfTriples-1; i++)
            {
                
                
                for (int k = 0; k <= numberOfTriples-1; k++)
                {

                    for (int j = 0; j <= numberOfTriples - 1; j++)
                    {
                        char first = (char)(97 + i);
                        char second = (char)(97 + k);
                        char third = (char)(97 + j);
                        Console.WriteLine($"{first}{second}{third}");

                    }   
                }
            }
        }
    }
}

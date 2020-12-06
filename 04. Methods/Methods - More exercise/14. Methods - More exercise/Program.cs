using System;

namespace _14._Methods___More_exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            if (input=="int")
            {
                int integer = int.Parse(Console.ReadLine());
                DataType(integer);
            }
            else if (input == "real")
            {
                double drob = double.Parse(Console.ReadLine());
                DataType(drob);
            }
            else if (input == "string")
            {
                string txt = Console.ReadLine();
                DataType(txt);
            }
        }
        static void DataType(int input)
        {
            input *= 2;
            Console.WriteLine(input);
        }
        static void DataType(double input)
        {
            input *= 1.5;
            Console.WriteLine($"{input:f2}");
        }
        static void DataType(string input)
        {
            Console.WriteLine($"${input}$");
        }
    }

}

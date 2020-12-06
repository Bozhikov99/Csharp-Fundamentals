using System;
using System.Net.Http.Headers;

namespace Add_and_Subtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());
            Console.WriteLine(Subtract(Sum(first, second),third));
        }
        public static int Sum(int first, int second)
        {
            int sum = first + second;
            return sum;
        }
        public static int Subtract(int sum, int third)
        {
            int result = sum - third;
            return result;
        }
    }
}

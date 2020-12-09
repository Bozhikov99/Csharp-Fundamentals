using System;
using System.Collections.Generic;

namespace List_of_Products
{
    class Program
    {
        static void Main(string[] args)
        {
            int products = int.Parse(Console.ReadLine());
            List<string> productList = new List<string>();
            for (int i = 0; i < products; i++)
            {
                productList.Add(Console.ReadLine());
            }
            productList.Sort();
            for (int i = 0; i < products; i++)
            {
                Console.WriteLine($"{i + 1}.{productList[i]}");
            }
        }
    }
}

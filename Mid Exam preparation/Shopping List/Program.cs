using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Shopping_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> prodList = Console.ReadLine()
                .Split("!", StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            string cmd = Console.ReadLine();
            while (cmd!="Go Shopping!")
            {
                string[] command = cmd
                    .Split();
                string type = command[0];
                string product1 = command[1];
                
                switch (type)
                {
                    case "Urgent":
                        if (!prodList.Contains(product1))
                        {
                            prodList.Insert(0, product1);
                        }
                        break;
                    case "Unnecessary":
                        if (prodList.Contains(product1))
                        {
                            prodList.Remove(product1);
                        }
                        break;
                    case "Correct":
                        if (prodList.Contains(product1))
                        {
                            string product2 = command[2];
                            int index = prodList.IndexOf(product1);
                            prodList.Remove(product1);
                            prodList.Insert(index, product2);
                        }
                        break;
                    case "Rearrange":
                        if (prodList.Contains(product1))
                        {
                            prodList.Remove(product1);
                            prodList.Add(product1);
                        }
                        break;
                }
                cmd = Console.ReadLine();
            }
            Console.WriteLine(string.Join(", ", prodList));
        }
    }
}

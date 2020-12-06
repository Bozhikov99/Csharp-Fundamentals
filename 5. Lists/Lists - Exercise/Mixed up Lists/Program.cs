using System;
using System.Collections.Generic;
using System.Linq;

namespace Mixed_up_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstList = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<int> secondList= Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<int> numbers = new List<int>();
            if (secondList.Count>firstList.Count)
            {
                secondList.Reverse();
                List<int> save = secondList;
                secondList = firstList;
                firstList = save;
            }
            for (int i = 0; i < secondList.Count; i++)
            {
                numbers.Add(firstList[i]);
                numbers.Add(secondList[(secondList.Count-1)-i]);
            }
            
            int min = firstList[firstList.Count - 2] < firstList[firstList.Count - 1] ? firstList[firstList.Count - 2] : firstList[firstList.Count - 1];
            int max = firstList[firstList.Count - 2] > firstList[firstList.Count - 1] ? firstList[firstList.Count - 2] : firstList[firstList.Count - 1];
            numbers.Sort();
            foreach (int x in numbers)
            {
                if (x>min&&x<max)
                {
                    Console.Write($"{x} ");
                }
            }
        }
    }
}

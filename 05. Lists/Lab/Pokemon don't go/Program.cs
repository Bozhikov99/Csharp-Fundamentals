using System;
using System.Collections.Generic;
using System.Linq;

namespace Pokemon_don_t_go
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> distances = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            int sum = 0;
            while (distances.Count != 0)
            {
                int index = int.Parse(Console.ReadLine());
                int value;
                if (index < 0)
                {
                    index = 0;
                    value = distances[index];
                    sum += value;
                    distances.RemoveAt(0);
                    distances.Insert(0, distances[distances.Count - 1]);
                }
                else if (index > distances.Count - 1)
                {
                    index = distances.Count - 1;
                    value = distances[index];
                    sum += value;
                    distances.RemoveAt(distances.Count - 1);
                    distances.Add(distances[0]);
                }
                else
                {
                    value = distances[index];
                    sum += value;
                    distances.RemoveAt(index);
                }
                for (int i = 0; i < distances.Count; i++)
                {
                    if (distances[i] <= value)
                    {
                        distances[i] += value;
                    }
                    else
                    {
                        distances[i] -= value;
                    }
                }
            }
            Console.WriteLine(sum);
        }
    }
}

using System;
using System.Linq;

namespace _3._Angry_Pet
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] items = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int entryPoint = int.Parse(Console.ReadLine());
            string itemType = Console.ReadLine().ToLower();
            string itemSign = Console.ReadLine().ToLower();

            int leftSum = 0;
            int rightSum = 0;
            string side = string.Empty;
            int biggerSum = 0;
            if (itemType == "cheap")
            {
                if (itemSign=="positive")
                {
                    for (int i = 0; i < entryPoint; i++)
                    {
                        if (items[i] < items[entryPoint]&&items[i]>0)
                        {
                            leftSum += items[i];
                        }
                    }
                    for (int i = entryPoint + 1; i < items.Length; i++)
                    {
                        if (items[i] < items[entryPoint]&&items[i]>0)
                        {
                            rightSum += items[i];
                        }
                    }
                }
                else if (itemSign=="negative")
                {
                    for (int i = 0; i < entryPoint; i++)
                    {
                        if (items[i] < items[entryPoint] && items[i] < 0)
                        {
                            leftSum += items[i];
                        }
                    }
                    for (int i = entryPoint + 1; i < items.Length; i++)
                    {
                        if (items[i] < items[entryPoint] && items[i] < 0)
                        {
                            rightSum += items[i];
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < entryPoint; i++)
                    {
                        if (items[i]<items[entryPoint])
                        {
                            leftSum += items[i];
                        }
                    }
                    for (int i = entryPoint+1; i < items.Length; i++)
                    {
                        if (items[i]<items[entryPoint])
                        {
                            rightSum += items[i];
                        }
                    }
                }
            }
            else if (itemType=="expensive")
            {
                if (itemSign == "positive")
                {
                    for (int i = 0; i < entryPoint; i++)
                    {
                        if (items[i] >= items[entryPoint] && items[i] > 0)
                        {
                            leftSum += items[i];
                        }
                    }
                    for (int i = entryPoint + 1; i < items.Length; i++)
                    {
                        if (items[i] >= items[entryPoint] && items[i] > 0)
                        {
                            rightSum += items[i];
                        }
                    }
                }
                else if (itemSign == "negative")
                {
                    for (int i = 0; i < entryPoint; i++)
                    {
                        if (items[i] >= items[entryPoint] && items[i] < 0)
                        {
                            leftSum += items[i];
                        }
                    }
                    for (int i = entryPoint + 1; i < items.Length; i++)
                    {
                        if (items[i] >= items[entryPoint] && items[i] < 0)
                        {
                            rightSum += items[i];
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < entryPoint; i++)
                    {
                        if (items[i] >= items[entryPoint])
                        {
                            leftSum += items[i];
                        }
                    }
                    for (int i = entryPoint + 1; i < items.Length; i++)
                    {
                        if (items[i] >= items[entryPoint])
                        {
                            rightSum += items[i];
                        }
                    }
                }
            }
            if (leftSum>=rightSum)
            {
                side = "Left";
                biggerSum = leftSum;
            }
            else
            {
                side = "Right";
                biggerSum = rightSum;
            }
            Console.WriteLine($"{side} - {biggerSum}");
        }
    }
}

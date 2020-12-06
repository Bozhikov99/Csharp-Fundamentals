using System;
using System.Collections.Generic;

namespace TakeSkip_Rope
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<char> nonNumList = new List<char>();
            List<char> NumList = new List<char>();
            foreach (char x in input)
            {
                if (char.IsDigit(x))
                {
                    NumList.Add(x);
                }
                else
                {
                    nonNumList.Add(x);
                }
            }
            List<char> takeList = new List<char>();
            List<char> skipList = new List<char>();
            List<char> result = new List<char>();
            for (int i = 0; i < NumList.Count; i++)
            {
                if (i%2!=0)
                {
                    skipList.Add(NumList[i]);
                }
                else
                {
                    takeList.Add(NumList[i]);
                }
            }
            int index = 0;
            for (int i = 0; i < takeList.Count; i++)
            {
                int take = takeList[i]-'0';
                int skip = skipList[i] - '0';
                for (int j = index; j <index+take; j++)
                {
                    if (j==nonNumList.Count)
                    {
                        break;
                    }
                    result.Add(nonNumList[j]);
                }
                index += take+skip;
            }
            Console.WriteLine(string.Join("",result));
        }
    }
}

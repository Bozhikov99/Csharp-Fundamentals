using System;
using System.Linq;

namespace _03._Hidden_Treasure
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] key = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            string cmd = Console.ReadLine();
            while (cmd != "find")
            {
                int keyIndex = 0;
                for (int i = 0; i < cmd.Length; i++)
                {
                    int currentInt = (int)cmd[i] - key[keyIndex];
                    cmd = cmd.Remove(i, 1);
                    cmd = cmd.Insert(i, ((char)currentInt).ToString());
                    keyIndex++;
                    if (keyIndex == key.Length)
                    {
                        keyIndex = 0;
                    }
                }
                int start = cmd.IndexOf('&');
                int end = cmd.LastIndexOf('&');
                string treasure = cmd.Substring(start + 1, end - start-1);
                int cStart = cmd.IndexOf('<');
                int cEnd = cmd.IndexOf('>');
                string coordinates = cmd.Substring(cStart+1, cEnd - cStart - 1);
                Console.WriteLine($"Found {treasure} at {coordinates}");
                cmd = Console.ReadLine();
            }            
        }
    }
}

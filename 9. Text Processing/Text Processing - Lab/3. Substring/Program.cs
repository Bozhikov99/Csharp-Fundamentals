using System;

namespace _3._Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string substring = Console.ReadLine();
            string text = Console.ReadLine();
            while (text.Contains(substring))
            {
                
                text=text.Remove(text.IndexOf(substring), substring.Length);
            }
            Console.WriteLine(text);
        }
    }
}

using System;

namespace _4._Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] delimeters = { ' ', ',' };
            string[] badWords = Console.ReadLine()
                .Split(delimeters, StringSplitOptions.RemoveEmptyEntries);
            string text = Console.ReadLine();
            foreach (string badword in badWords)
            {
                text=text.Replace(badword, new string('*', badword.Length));
            }
            Console.WriteLine(text);
        }
    }
}

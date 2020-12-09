using System;

namespace Text_Processing___Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] usernames = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);
            foreach (string u in usernames)
            {
                bool isValid = true;
                if (u.Length < 3 || u.Length > 16)
                {
                    isValid = false;
                }
                else
                {
                    foreach (char c in u)
                    {
                        if (!(char.IsLetterOrDigit(c) || c == '_' || c == '-'))
                        {
                            isValid = false;
                            break;
                        }
                    }
                    if (isValid)
                    {
                        Console.WriteLine(u);
                    }
                }
                
            }
        }
    }
}

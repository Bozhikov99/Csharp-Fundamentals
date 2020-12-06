using System;

namespace _07._String_Explosions
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string result = string.Empty;
            int explosionPower = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i]=='>')
                {
                    explosionPower += int.Parse(input[i + 1].ToString());
                    continue;
                }
                if (explosionPower>0)
                {
                    input= input.Remove(i, 1);
                    i--;
                    explosionPower--;
                }
            }
            Console.WriteLine(input);
        }
    }
}

using System;
using System.Linq;

namespace Text_Processing___Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            string cmd = Console.ReadLine();
            while (cmd != "end")
            {
                Console.WriteLine($"{cmd} = {string.Join("",cmd.ToCharArray().Reverse())}"); 
                cmd = Console.ReadLine();
            }
        }
    }
}

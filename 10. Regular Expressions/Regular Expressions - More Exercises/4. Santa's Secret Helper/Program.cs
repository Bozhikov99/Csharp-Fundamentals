using System;
using System.Text;
using System.Text.RegularExpressions;

namespace _4._Santa_s_Secret_Helper
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            string cmd = Console.ReadLine();
            while (cmd!="end")
            {
                StringBuilder decrypted = new StringBuilder();
                foreach (char c in cmd)
                {
                    decrypted.Append((char)(c-key));
                }
                string pattern = @"@(?<name>[A-Za-z]+)([^@\:\-\>\!])*!(?<behavior>N|G)!";
                Match child = Regex.Match(decrypted.ToString(), pattern);
                if (child.Success)
                {
                    if (child.Groups["behavior"].Value=="G")
                    {
                        Console.WriteLine(child.Groups["name"].Value);
                    }
                }
                cmd = Console.ReadLine();
            }

        }
    }
}

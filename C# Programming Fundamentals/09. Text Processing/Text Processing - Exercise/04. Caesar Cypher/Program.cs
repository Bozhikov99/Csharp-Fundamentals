using System;
using System.Text;

namespace _04._Caesar_Cypher
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();
            StringBuilder encryptedMessage = new StringBuilder();
            foreach (char c in message)
            {
                encryptedMessage.Append((char)(c + 3));
            }
            Console.WriteLine(encryptedMessage);
        }
    }
}

using System;

namespace _2._5_Decrypting
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            string[] decryptedMessage = new string[n];
            
                
                for (int k = 0; k < n; k++)
                {
                    char symbol = char.Parse(Console.ReadLine());
                    char decrypted = (char)((int)symbol + key);
                    decryptedMessage[k]+= decrypted;
                }
                
            
            for (int a = 0; a < n; a++)
            {
                Console.Write(decryptedMessage[a]);
            }


        }
    }
}

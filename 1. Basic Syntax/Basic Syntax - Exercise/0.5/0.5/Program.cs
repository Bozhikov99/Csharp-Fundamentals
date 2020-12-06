using System;

namespace _0._5
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = string.Empty;

            for (int i = username.Length - 1; i >= 0; i--)
            {
                password += username[i];
            }
            int tries = 0;
            while (tries<3)
            {

                string Login = Console.ReadLine();
                if (Login == password)
                {
                    Console.WriteLine($"User {username} logged in.");
                    break;
                }
                else
                {
                    Console.WriteLine("Incorrect password. Try again.");
                }
                tries++;
            }
            if (tries == 3)
            {
                Console.WriteLine($"User {username} blocked!");
            }
        }
    }
}

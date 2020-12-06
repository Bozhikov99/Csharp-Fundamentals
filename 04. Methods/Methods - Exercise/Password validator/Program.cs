using System;
using System.Net.Http.Headers;

namespace Password_validator
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            bool isValid = PasswordLength(password) &&
                Format(password) &&
                HasTwoDigits(password);
            if (isValid)
            {
                Console.WriteLine("Password is valid");
            }
            else
            {
                if (!PasswordLength(password))
                {
                    Console.WriteLine("Password must be between 6 and 10 characters");
                }
                if (!Format(password))
                {
                    Console.WriteLine("Password must consist only of letters and digits");
                }
                if (!HasTwoDigits(password))
                {
                    Console.WriteLine("Password must have at least 2 digits");
                }
                
            }
        }
        public static bool PasswordLength(string password)
        {
            bool isTrue = true;
            if (password.Length<6||password.Length>10)
            {
                isTrue = false;
            }
            return isTrue;
        }
        public static bool Format(string password)
        {
            bool isTrue = true;
            foreach (char x in password)
            {
                if (!char.IsLetterOrDigit(x))
                {
                    isTrue = false;
                }
            }
            return isTrue;
        }
        public static bool HasTwoDigits(string password)
        {
            bool isTrue = false;
            int digitCount = 0;
            foreach (char x in password) 
            {
                if (char.IsDigit(x))
                {
                    digitCount++;
                }
            }
            if (digitCount >= 2)
            {
                isTrue = true;
            }
            return isTrue;
        }
    }
}

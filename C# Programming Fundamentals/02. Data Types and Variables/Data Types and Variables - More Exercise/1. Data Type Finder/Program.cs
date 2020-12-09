using System;

namespace _1._Data_Type_Finder
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            while (input != "END")
            {
                string result = string.Empty;
                bool isInt= int.TryParse(input, out int integer);
                bool isDouble= double.TryParse(input, out double floating);
                bool isBool = bool.TryParse(input, out bool boolean);
                bool isChar= char.TryParse(input, out char character);
                
                if (isInt==true)
                {
                    result = $"{input} is integer type";
                }
                else if (isDouble == true)
                {
                    result = $"{input} is floating point type";
                }
                else if (isBool == true)
                {
                    result = $"{input} is boolean type";
                }
                else if (isChar == true)
                {
                    result = $"{input} is character type";
                }
                else 
                {
                    result = $"{input} is string type";
                }
                Console.WriteLine(result);
                input = Console.ReadLine();
            }
        }
    }
}

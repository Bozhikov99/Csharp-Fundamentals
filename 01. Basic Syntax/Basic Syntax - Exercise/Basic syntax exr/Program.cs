﻿using System;

namespace Basic_syntax_exr
{
    class Division
    {
        static void Main(string[] args)
        {
            int delimo = int.Parse(Console.ReadLine());
            string output = string.Empty;
            if (delimo%10==0)
            {
                output = "The number is divisible by 10";
            }
            else if ( delimo%7==0)
            {
                output = "The number is divisible by 7";
            }
            else if (delimo %6 == 0)
            {
                output = "The number is divisible by 6";
            }
            else if (delimo % 3 == 0)
            {
                output = "The number is divisible by 3";
            }
            else if (delimo % 2 == 0)
            {
                output = "The number is divisible by 2";
            }
            else
            {
                output = "Not divisible";  
            }
            Console.WriteLine(output);
        }
    }

}

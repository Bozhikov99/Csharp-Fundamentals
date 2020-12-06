using System;
using System.Diagnostics.CodeAnalysis;

namespace _0._7
{
    class Program
    {
        static void Main(string[] args)
        {
            string cmd = Console.ReadLine();
            double sum = 0;
            while (cmd != "Start")
            {
                double insertedCoin = Convert.ToDouble(cmd);
                bool Valid;
                if (insertedCoin == 0.1 ||
                    insertedCoin == 0.2 ||
                    insertedCoin == 0.5 ||
                    insertedCoin == 1 ||
                    insertedCoin == 2)
                {
                    Valid = true;
                }
                else
                {
                    Console.WriteLine("Cannot accept money");
                    Valid = false;
                }
                if (Valid)
                {
                    sum += insertedCoin;
                }
                cmd = Console.ReadLine();
            }
        }
    }
}

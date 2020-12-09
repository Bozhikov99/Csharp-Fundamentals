using System;

namespace _2._9_Poke_Mon
{
    class Program
    {
        static void Main(string[] args)
        {
            int pokePowerN = int.Parse(Console.ReadLine());
            int distanceM = int.Parse(Console.ReadLine());
            int exhaustionFactorN = int.Parse(Console.ReadLine());
            double halfPower = pokePowerN * 0.5;
            int pokes = 0;
            while (pokePowerN >= distanceM)
            {
                pokes++;
                pokePowerN -= distanceM;
                
                if (pokePowerN == halfPower && exhaustionFactorN != 0 )
                {
                    pokePowerN /= exhaustionFactorN;
                }
                
            }
            Console.WriteLine(pokePowerN);
            Console.WriteLine(pokes);
        }
    }
}

using System;

namespace _2._8_Beer_Kegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int kegs = int.Parse(Console.ReadLine());
            string kegModel = string.Empty;
            double radius = 0;
            int height = 0;
            string output = string.Empty;
            double volume = 0;
            for (int i = 1; i <=kegs; i++)
            {
                kegModel = Console.ReadLine();
                radius = double.Parse(Console.ReadLine());
                height = int.Parse(Console.ReadLine());
                double C = Math.PI * Math.Pow(radius,2);
                double currentVolume = C * height;

                if (currentVolume>=volume)
                {
                    output = kegModel;
                    volume = currentVolume;
                }
            }
            Console.WriteLine(output);
        }
    }
}

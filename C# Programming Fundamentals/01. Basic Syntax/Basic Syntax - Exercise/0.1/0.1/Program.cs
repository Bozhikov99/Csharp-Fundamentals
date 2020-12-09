using System;

namespace _0._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            string person = string.Empty;
            if (age <= 2 && age >= 0)
            {
                person = "baby";
            }
            else if (age<=13&&age>=3)

            {
                person = "child";
            }
            else if (age<=19&&age>=14)
            {
                person = "teenager";
            }
            else if (age>=20&&age<=65)
            {
                person = "adult";

            }
            else if (age>=66)
            {
                person = "elder";
            }
            Console.WriteLine(person);
        }
    }
}

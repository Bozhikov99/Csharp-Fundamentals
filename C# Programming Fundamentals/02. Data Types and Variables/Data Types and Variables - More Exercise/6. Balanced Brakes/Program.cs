using System;

namespace _6._Balanced_Brakes
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            bool open = false;
            bool isBalanced = true;

            int bracksOpen = 0;
            int closeBracks= 0;
            for (int i = 0; i < lines; i++)
            {
                string input = Console.ReadLine();
                if (input == "(")
                {
                    if (open==false)
                    {
                        open = true;
                    }
                    else
                    {
                        isBalanced = false;
                    }
                }
                else if (input == ")")
                {
                    
                    if (open == true)
                    {     
                        open = false;
                    }
                    else
                    {
                        isBalanced = false;
                    }
                }
            }
            string result;
            if (isBalanced&&!open)
            {
                result = "BALANCED";
            }
            else
            {
                result = "UNBALANCED";
            }
            Console.WriteLine(result);
        }
    }
}

using System;

namespace NxN_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int matrix = int.Parse(Console.ReadLine());
            SqareMatrix(matrix);
        }
        public static void SqareMatrix(int matrix)
        {
            for (int i = 0; i <matrix; i++)
            {
                for (int k = 0; k < matrix; k++)
                {
                    Console.Write($"{matrix} ");
                }
                Console.WriteLine();
            }
        }
    }
}

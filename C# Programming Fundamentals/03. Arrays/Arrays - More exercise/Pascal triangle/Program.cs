using System;
using System.Net.Http.Headers;

namespace Pascal_triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberofArrays = int.Parse(Console.ReadLine());
            int[] oldRow = new int[1];
            int leftnum = 0;
            int rightnum = 0;
            for (int i = 1; i <= numberofArrays; i++)
            {
                int[] newRow = new int[i];
                if (i == 1)
                {
                    newRow[0] = 1;
                    Console.WriteLine("1");
                    oldRow = newRow;
                }
                else if (i == 2)
                {
                    newRow[0] = 1;
                    newRow[1] = 1;
                    Console.WriteLine("1 1");
                    oldRow = newRow;
                }
                else if (i > 2)
                {
                    for (int k = 0; k < oldRow.Length; k++) 
                    {
                        bool leftIsBlank = k == 0;
                        bool rightIsBlank = k == oldRow.Length - 1;
                        if (leftIsBlank == true && rightIsBlank == true)
                        {
                            newRow[k] = 1;
                            leftnum = 0;
                            rightnum = 0;
                        }
                        else if (leftIsBlank == true && rightIsBlank == false)
                        {
                            leftnum = 0;
                            rightnum = oldRow[k];
                            newRow[k] = rightnum;
                        }

                        else if (rightIsBlank == true && leftIsBlank == false)
                        {
                            rightnum = oldRow[k];
                            leftnum = oldRow[k-1];
                            newRow[k] = leftnum+rightnum;
                            newRow[k+1]= rightnum;
                        }
                        else
                        {
                            leftnum = oldRow[k - 1];

                            rightnum = oldRow[k];

                            newRow[k] = leftnum + rightnum;
                        }              
                    }
                    oldRow = newRow;
                    Console.WriteLine(string.Join(" ", newRow));
                }
            }
        }
    }
}

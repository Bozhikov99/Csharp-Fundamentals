using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Array_Manipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            int[] array = Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            string cmd = Console.ReadLine()
                .ToLower();

            //manipulations
            while (cmd!="end")
            {
                string command = cmd.Split()[0];
                switch (command)
                {
                    case "exchange":
                        int index =int.Parse(cmd.Split()[1]);
                        if (index>=0&&index<array.Length)
                        {
                            array = Exchange(array, index);
                        }
                        else
                        {
                            Console.WriteLine("Invalid index");
                        }
                        break;
                    case "max":
                        if (cmd.Split()[1]=="odd")
                        {                         
                            GetMaxOdd(array);
                        }
                        else
                        {
                            GetMaxEven(array);
                        }
                        break;
                    case "min":
                        if (cmd.Split()[1]=="odd")
                        {
                            GetMinOdd(array);
                        }
                        else
                        {
                            GetMinEven(array);
                        }
                        break;
                    case "first":
                        int last = int.Parse(cmd.Split()[1]);
                        if (cmd.Split()[2]=="odd")
                        {
                            GetFirstOdd(array, last);
                        }
                        else
                        {
                            GetFirstEven(array, last);
                        }
                        break;
                    case "last":
                        int first = int.Parse(cmd.Split()[1]);
                        if (cmd.Split()[2]=="odd")
                        {
                            GetLastOdd(array, first);
                        }
                        else
                        {
                            GetLastEven(array, first);
                        }
                        break;
                }
                cmd = Console.ReadLine()
                    .ToLower();
            }
            Console.WriteLine($"[{string.Join(", ",array)}]");
        }
        public static int[] Exchange(int[] array, int index)
        {
            int[] result=new int[array.Length];
            int resIndex = 0;
            for (int i = index+1; i <array.Length; i++)
            {
                result[resIndex] = array[i];
                resIndex++;
            }
            for (int i = 0; i <=index; i++)
            {
                result[resIndex] = array[i];
                resIndex++;
            }
            return result;
        }
        public static void GetMaxOdd(int[] array)
        {
            int result = 0;
            int[] arr = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i]%2!=0)
                {
                    arr[i] = array[i];
                }
            }
            arr=arr.Where(x=>x!=0)
                .ToArray();
            if (arr.Length != 0)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] == arr.Max())
                    {
                        result = i;
                        break;
                    }
                }
                Console.WriteLine(result);
            }
            
            else
            {
                Console.WriteLine("No matches");
            }
        }
        public static void GetMaxEven(int[] array)
        {
            int result = 0;
            int[] arr = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i]%2==0)
                {
                    arr[i] = array[i];
                }
            }
            arr=arr.Where(x=>x!=0)
                .ToArray();
            if (arr.Length != 0)
            {

                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] == arr.Max())
                    {
                        result = i;
                        break;
                    }
                }
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("No matches");
            }
        }
        public static void GetMinOdd(int[] array)
        {
            int result = 0;
            int[] arr = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    arr[i] = array[i];
                }
            }
            arr = arr.Where(x => x != 0)
                .ToArray();
            if (arr.Length != 0)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] == arr.Min())
                    {
                        result = i;
                        break;
                    }
                }
                Console.WriteLine(result);
            }

            else
            {
                Console.WriteLine("No matches");
            }
        }
        public static void GetMinEven(int[] array)
        {
            int result = 0;
            int[] arr = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    arr[i] = array[i];
                }
            }
            arr = arr.Where(x => x != 0)
                .ToArray();
            if (arr.Length != 0)
            {

                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] == arr.Min())
                    {
                        result = i;
                        break;
                    }
                }
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("No matches");
            }
        }
        public static void GetFirstOdd(int[] array, int last)
        {
            if (last > array.Length)
            {
                Console.WriteLine("Invalid count");
            }
            else
            {
                int[] result = new int[last];
                int index = 0;
                for (int i = 0; i < last; i++)
                {
                    if (array[i] % 2 != 0)
                    {
                        result[index] = array[i];
                        index++;
                    }
                }
                result = result.Where(x => x != 0)
                    .ToArray();
                if (index == 0)
                {
                    Console.WriteLine("[]");
                }
                
                else
                {
                    Console.WriteLine($"[{string.Join(", ", result)}]");
                }
            }
        }
        public static void GetFirstEven(int[] array, int last)
        {
            if (last > array.Length)
            {
                Console.WriteLine("Invalid count");
            }
            else
            {
                int[] result = new int[last];
                int index = 0;
                for (int i = 0; i < last; i++)
                {
                    if (array[i] % 2 == 0)
                    {
                        result[index] = array[i];
                        index++;
                    }
                }
                result = result.Where(x => x != 0)
                    .ToArray();
                if (index == 0)
                {
                    Console.WriteLine("[]");
                }
                
                else
                {
                    Console.WriteLine($"[{string.Join(", ", result)}]");
                }
            }
        }
        public static void GetLastOdd(int[] array, int first)
        {
            if (first > array.Length)
            {
                Console.WriteLine("Invalid count");
            }
            else
            {
                int[] result = array.Where(x => x != 0)
                    .Where(x => x % 2 != 0)
                    .ToArray();
                if (first>=result.Length)
                {
                    first = 0;
                }
                Console.Write("[");
                for (int i = first; i < result.Length; i++)
                {
                    if (i<result.Length-1)
                    {
                        Console.Write($"{result[i]}, ");
                    }
                    else
                    {
                        Console.Write($"{result[i]}");
                    }
                }
                Console.Write("]");
                Console.WriteLine();
            }
        }
        public static void GetLastEven(int[] array, int first)
        {
            if (first > array.Length)
            {
                Console.WriteLine("Invalid count");
            }
            else
            {
                int[] result = array.Where(x => x != 0)
                    .Where(x => x % 2 == 0)
                    .ToArray();
                if (first>=result.Length)
                {
                    first = 0;
                }
                Console.Write("[");
                for (int i = first; i < result.Length; i++)
                {
                    if (i<result.Length-1)
                    {
                        Console.Write($"{result[i]}, ");
                    }
                    else
                    {
                        Console.Write($"{result[i]}");
                    }
                }
                Console.Write("]");
                Console.WriteLine();
            }
        }

    }
}

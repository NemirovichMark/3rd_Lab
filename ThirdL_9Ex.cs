using System;
using System.Reflection;

namespace _3rd_Lab
{
    class ThirdL_9Ex
    {
        static void Main(string[] args)
        {
            try
            {
                int size, maxJ = 0, maxK = 0;
                Console.Write("Introduce the size of the matriz: ");
                if (!int.TryParse(Console.ReadLine(), out size))
                    return;
                double[] x = new double[size];
                for (int i = 0; i < size; i++)
                {
                    Console.Write($"Enter the {i + 1} element of the array: ");
                    if (!double.TryParse(Console.ReadLine(), out x[i])) return;
                }
                int k = 0, j = 0;
                for (int i = 0; i < size - 1; i += 1)
                {
                    if (x[i] < x[i + 1])
                    {
                        k++;
                        j = 0;
                        if (k > maxK) maxK = k;
                    }
                    else if (x[i] > x[i + 1])
                    {
                        j++;
                        k = 0;
                        if (j > maxJ) maxJ = j;
                    }
                    else
                    {
                        j = 0;
                        k = 0;
                    }
                }
                if (maxK > maxJ)
                {
                    Console.WriteLine($"Max legnth by increasing is {maxK}");
                }
                else
                {
                    Console.WriteLine($"Max legnth by decreasing is {maxJ}");
                }
            }
            catch
            {
                Console.WriteLine("Wrong input error");
            }
        }
    }
}
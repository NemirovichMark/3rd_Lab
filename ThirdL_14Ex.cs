using System;
using System.Reflection;

namespace _3rd_Lab
{
    class ThirdL_14Ex
    {
        static void Main(string[] args)
        {
            try
            {
                int size;
                Console.Write("Introduce the size of the matriz: ");
                if (!int.TryParse(Console.ReadLine(), out size))
                    return;
                double[] x = new double[size];
                for (int i = 0; i < size; i++)
                {
                    Console.Write($"Enter the {i + 1} element of the array: ");
                    if (!double.TryParse(Console.ReadLine(), out x[i])) return;
                }
                double[] y = new double[size];
                for (int i = 0; i < size; i += 1)
                {
                    y[i] = x[size - 1 - i];
                }
                Console.WriteLine(String.Join(" ", y));
            }
            catch
            {
                Console.WriteLine("Wrong input error");
            }
        }
    }
}
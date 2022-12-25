using System;
using System.Reflection;

namespace _3rd_Lab
{
    class ThirdL_5Ex
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
                int k = 0;
                double[] y = new double[x.Length / 2];
                for (int i = 0; i < x.Length; i++)
                {
                    if (i % 2 == 0)
                    {
                        y[k] = x[i];
                        k++;
                    }
                }
                Array.Sort(y);
                for (int i = 0; i < y.Length; i++) x[i * 2] = y[i];
                foreach (int element in x) Console.Write($"{element} ");
            }
            catch
            {
                Console.WriteLine("Wrong input error");
            }
        }
    }
}
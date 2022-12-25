using System;
using System.Reflection;

namespace _3rd_Lab
{
    class ThirdL_8Ex
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
                int sizeY = 0;
                foreach (int element in x)
                {
                    if (element < 0) sizeY++;
                }
                double[] y = new double[sizeY];
                int index = 0;
                for (int i = 0; i < size; i++)
                {
                    if (x[i] < 0)
                    {
                        y[index] = x[i];
                        index++;
                    }
                }
                Array.Sort(y);
                index = 0;
                for (int i = 0; i < size; i++)
                {
                    if (x[i] < 0)
                    {
                        x[i] = y[index];
                        index++;
                    }
                }
                foreach (int element in x) Console.Write($"{element} ");
            }
            catch
            {
                Console.WriteLine("Wrong input error");
            }
        }
    }
}
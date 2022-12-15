using System;
using System.Reflection;

namespace _3rd_Lab
{
    class ThirdL_1Ex
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
                int index = 0;
                double MaxElement = x[0];
                foreach (int element in x)
                {
                    if (element > MaxElement)
                    {
                        MaxElement = element;
                    }
                    index++;
                }
                int sizeY = 0;
                foreach (int element in x)
                {
                    if (MaxElement == element) sizeY++;
                }
                double[] y = new double[sizeY];
                index = 0;
                for (int i = 0; i < size; i++)
                {
                    if (x[i] == MaxElement)
                    {
                        y[index] = i;
                        index++;
                    }
                }
                foreach (int element in y) Console.WriteLine($"{element} ");
            }
            catch
            {
                Console.WriteLine("Wrong input error");
            }
        }
    }
}

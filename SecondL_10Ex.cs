using System;
using System.Reflection;

namespace _3rd_Lab
{
    class SecondL_10Ex
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
                double MinElement = x[0];
                foreach (int element in x)
                {
                    if (element < MinElement && element > 0)
                    {
                        MinElement = element;
                    }
                }

                x = x.Where(val => val != MinElement).ToArray();
                foreach (int element in x) Console.Write($"{element} ");
            }
            catch
            {
                Console.WriteLine("Wrong input error");
            }
        }
    }
}
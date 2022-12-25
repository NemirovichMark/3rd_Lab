using System;
using System.Reflection;

namespace _3rd_Lab
{
    class SecondL_11Ex
    {
        static void Main(string[] args)
        {
            try
            {
                int size, P;
                Console.Write("Introduce the value of P: ");
                if (!int.TryParse(Console.ReadLine(), out P))
                    return;
                Console.Write("Introduce the size of the matriz: ");
                if (!int.TryParse(Console.ReadLine(), out size))
                    return;
                double[] x = new double[size];
                for (int i = 0; i < size; i++)
                {
                    Console.Write($"Enter the {i + 1} element of the array: ");
                    if (!double.TryParse(Console.ReadLine(), out x[i])) return;
                }
                double LastPositiveElement = x[0];
                foreach (int element in x)
                {
                    if (element > 0)
                    {
                        LastPositiveElement = element;
                    }
                }
                Console.WriteLine(P);
                double[] y = new double[size + 1];
                int indexOfY = 0;
                foreach (int element in x)
                {
                    y[indexOfY++] = element;
                    if (element == LastPositiveElement) y[indexOfY++] = P;
                }
                foreach (int element in y) Console.Write($"{element} ");
            }
            catch
            {
                Console.WriteLine("Wrong input error");
            }
        }
    }
}
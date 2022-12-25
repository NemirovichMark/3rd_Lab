using System;
using System.Reflection;

namespace _3rd_Lab
{
    class ThirdL_13Ex
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
                int flag = 0;
                int index0fY = 0;
                for (int i = 0; i < size; i++)
                {
                    flag = 1;
                    for (int j = 0; j < size; j++)
                    {
                        if (x[i] == x[j] && i != j) flag = 0;
                    }
                    index0fY += flag;
                }
                double[] y = new double[index0fY];
                index0fY = 0;
                for (int i = 0; i < size; i++)
                {
                    flag = 1;
                    for (int j = 0; j < size; j++)
                    {
                        if (x[i] == x[j] && i != j) flag = 0;
                    }
                    if (flag == 1)
                    {
                        y[index0fY] = x[i];
                        index0fY++;
                    }
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
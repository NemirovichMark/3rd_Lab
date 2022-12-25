using System;
using System.Reflection;

namespace _3rd_Lab
{
    class AddL_15Ex
    {
        static void Main(string[] args)
        {
            try
            {
                int size;
                Console.Write("Introduce the size of the matriz X: ");
                if (!int.TryParse(Console.ReadLine(), out size))
                    return;
                double[] x = new double[size];
                for (int i = 0; i < size; i++)
                {
                    Console.Write($"Enter the {i + 1} element of the array: ");
                    if (!double.TryParse(Console.ReadLine(), out x[i])) return;
                }
                int z = 0, k = 0;
                string[] g = Console.ReadLine().Split();
                if (g.Length == 1)
                {
                    if (int.TryParse(g[0], out k))
                    {
                        z = k;
                    }
                    else
                    {
                        Console.WriteLine("wrong data");
                    }
                }
                double[] y = new double[x.Length];
                for (int i = 0; i < x.Length; i += 1)
                {
                    if (i + z < x.Length)
                    {
                        y[i + z] = x[i];
                    }
                    else
                    {
                        y[i + z - x.Length] = x[i];
                    }
                }
                Console.Write(String.Join(" ", y));
            }
            catch
            {
                Console.WriteLine("Wrong input error");
            }
        }
    }
}
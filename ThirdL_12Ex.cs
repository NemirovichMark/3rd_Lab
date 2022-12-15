using System;
using System.Reflection;

namespace _3rd_Lab
{
    class ThirdL_12Ex
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Introduce the 12 elements of the array X");
                int size = 12;
                double[] x = new double[size];
                for (int i = 0; i < size; i++)
                {
                    Console.Write($"Enter the {i + 1} element of the array: ");
                    if (!double.TryParse(Console.ReadLine(), out x[i])) return;
                }
                foreach (int element in x)
                {
                    if (element < 0) x = x.Where(e => e != element).ToArray();
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
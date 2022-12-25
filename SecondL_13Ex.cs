using System;
using System.Reflection;

namespace _3rd_Lab
{
    class SecondL_13Ex
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
                double MaxElementEven = x[0];
                int MaxElementIndex = 0;
                foreach (int element in x)
                {
                    if (element > MaxElementEven && (element % 2 == 0))
                    {
                        MaxElementEven = element;
                        MaxElementIndex = index;
                    }
                    index++;
                }
                x[MaxElementIndex] = MaxElementIndex;
                foreach (int element in x) Console.Write($"{element} ");
            }
            catch
            {
                Console.WriteLine("Wrong input error");
            }
        }
    }
}
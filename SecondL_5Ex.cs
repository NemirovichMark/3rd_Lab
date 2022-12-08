using System;
using System.Reflection;

namespace _3rd_Lab
{
    class SecondL_10Ex
    {
        static void Main(string[] args)
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
            double MaxElement = x[0];
            double MinElement = x[0];
            int MaxElementIndex = 0 , MinElementIndex = 0;
            int index = 0;
            foreach (int element in x) {
                if (element > MaxElement) {
                    MaxElement = element;
                    MaxElementIndex = index;
                }
                if (element < MinElement) {
                    MinElement = element;
                    MinElementIndex = index;
                }
                index++;
            }
            double[] y = new double[];
            Console.WriteLine($"{MaxElement}, {MaxElementIndex}");
            Console.WriteLine($"{MinElement}, {MinElementIndex}");
            //double[] y = new double[size];
        }
    }
}

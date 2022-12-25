using System;

namespace _3rd_Lab
{
    class firstL_11Ex
    {
        static void Main(string[] args)
        {
            int size = 10;
            int counter = 0;
            double[] x = new double[size];
            double[] y = new double[counter];
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Enter the {i + 1} element of the array: ");
                if (!double.TryParse(Console.ReadLine(), out x[i])) return;
                if (x[i] > 0)
                {
                    Array.Resize(ref y, ++counter);
                    y[counter - 1] = x[i];
                }
            }
            Console.Write("Your array: ");
            foreach (int element in x)
            {
                Console.Write($"{element}");
            }
            Console.Write("\n");
            foreach (int element in y)
            {
                Console.Write($"{element} ");
            }
        }
    }
}
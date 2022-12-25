using System;
using System.IO;

namespace _3rd_Lab
{
    class firstL_6Ex
    {
        static void Main(string[] args)
        {
            int size = 5;
            double[] x = new double[size];
            double L = 0;

            for (int i = 0; i < size; i++)
            {
                Console.Write("Enter the coordinates of your vector: ");
                if (!double.TryParse(Console.ReadLine(), out x[i]))
                    return;
            }

            Console.Write("\nSize of the vector with coordinates: ");
            for (int i = 0; i < size; i++)
            {
                L += x[i] * x[i];
                Console.Write($"{x[i]}");
                if (i < 4)
                    Console.Write(", ");
            }
            L = Math.Sqrt(L);
            Console.Write($" equals L={L}");
        }
}
}

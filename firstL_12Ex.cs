using System;

namespace _3rd_Lab
{
    class firstL_12Ex
    {
        static void Main(string[] args)
        {
            int size = 8;
            int counter = 0;
            bool flag = false;
            double[] x = new double[size];
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Enter the {i + 1} element of the array: ");
                if (!double.TryParse(Console.ReadLine(), out x[i])) return;
                if (x[i] < 0)
                {
                    counter = i;
                    flag = true;
                }
                else
                {
                    flag = false;
                }

            }
            if (flag)
            {
                Console.Write($"\nThe last negative element is located at the position number {counter + 1} of the array and equals {x[counter]}");
            }
            else
            {
                Console.Write("There are not negative elements in the array");
            }
        }
    }
}
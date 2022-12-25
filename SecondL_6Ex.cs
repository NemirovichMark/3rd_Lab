using System;
using System.Reflection;

namespace _3rd_Lab
{
    class SecondL_6Ex
    {
        static void Main(string[] args)
        {
            try
            {
                int size;
                Console.Write("Introduce the size of the matriz: ");
                if (!int.TryParse(Console.ReadLine(), out size))
                    return;
                double[] array = new double[size];
                for (int i = 0; i < size; i++)
                {
                    Console.Write($"Enter the {i + 1} element of the array: ");
                    if (!double.TryParse(Console.ReadLine(), out array[i])) return;
                }
                double P = 0; //average
                foreach (double element in array)
                {
                    P += element;
                }
                P /= array.Length;
                Console.WriteLine($"The average is: {P}");
                double[] array2 = new double[size + 1];
                int counter = 0;
                bool key = true;
                for (int i = 0; i < size; i++)
                {
                    array2[counter++] = array[i];
                    if (P >= array[i] && key == true)
                    {
                        array2[counter++] = P;
                        key = false;
                    }
                }
                foreach (double element in array2) Console.Write(element + " ");
            }
            catch
            {
                Console.WriteLine("Wrong input error");
            }
        }
    }
}
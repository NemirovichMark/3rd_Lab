using System;
using System.Reflection;

namespace _3rd_Lab
{
    class SecondL_15Ex
    {
        static void Main(string[] args)
        {
            try
            {
                int sizeA, sizeB, k;
                Console.Write("Introduce the size of the matriz A: ");
                if (!int.TryParse(Console.ReadLine(), out sizeA))
                    return;
                double[] a = new double[sizeA];
                for (int i = 0; i < sizeA; i++)
                {
                    Console.Write($"Enter the {i + 1} element of the array: ");
                    if (!double.TryParse(Console.ReadLine(), out a[i])) return;
                }
                Console.Write("Introduce the size of the matriz B: ");
                if (!int.TryParse(Console.ReadLine(), out sizeB)) return;
                double[] b = new double[sizeB];
                for (int i = 0; i < sizeB; i++)
                {
                    Console.Write($"Enter the {i + 1} element of the array: ");
                    if (!double.TryParse(Console.ReadLine(), out b[i])) return;
                }
                Console.Write("Introduce the value of K: ");
                while (true)
                {
                    Console.Write("Introduce the value of k: ");
                    if (!int.TryParse(Console.ReadLine(), out k))
                    {
                        Console.WriteLine("The value of nStudents is wrong");
                        continue;
                    }
                    if (k < 0 || k > sizeA)
                    {
                        Console.WriteLine("the value of k has to be smaller than the size of the array A and also bigger than 0");
                        continue;
                    }
                    break;
                }
                Console.Write("A : ");
                foreach (int element in a) Console.Write($"{element} ");
                Console.WriteLine(" ");
                Console.Write("B : ");
                foreach (int element in b) Console.Write($"{element} ");
                Console.WriteLine(" ");
                Console.WriteLine($"k : {k}");
                //Array.Resize(ref a, a.Length + b.Length);
                double[] x = new double[a.Length + b.Length];
                int indexOfX = 0;
                for (int i = 0; i < k; i++)
                {
                    x[indexOfX] = a[i];
                    indexOfX++;
                }
                for (int i = 0; i < b.Length; i++)
                {
                    x[indexOfX] = b[i];
                    indexOfX++;
                }
                for (int i = k; i < a.Length; i++)
                {
                    x[indexOfX] = a[i];
                    indexOfX++;
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
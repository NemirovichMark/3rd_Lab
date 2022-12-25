using System;

namespace _3rd_Lab
{
    class firstL_10Ex
    {
        static void Main(string[] args)
        {
            int size = 10;
            double[] x = new double[size];
            double[] y = new double[size];
            double L = 0;
            double p = 0, q = 0;
            Console.Write("Enter the value of P: ");
            if (!double.TryParse(Console.ReadLine(), out p))
                return;
            Console.Write("Enter the value of Q: ");
            if (!double.TryParse(Console.ReadLine(), out q))
                return;
            int counter = 0;
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Enter the {i + 1} element of the array: ");
                if (!double.TryParse(Console.ReadLine(), out x[i])) return;
                if (x[i] > p && x[i] < q)
                {
                    L++;
                    y[counter++] = x[i];
                }
            }
            Console.Write($" L = {L}: ");
            for (int i = 0; i < L; i++)
            {
                Console.Write($"{y[i]} ");
            }
        }
}
}

using System;
using System.Reflection;

namespace _3rd_Lab
{
    class ThirdL_1Ex
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
                int index = -1;
                double [] y = new double[size];
                double MaxElement = x[0];
                for(int i = 0; i < size; i++){
                    if(x[i] > MaxElement){
                        MaxElement = x[i];
                        y[0] = i;
                        index = 0;
                    }else if(x[i] == MaxElement ){
                        index++;
                        y[index] = i;
                    }
                }
                for(int i = 0; i <= index; i++){
                    Console.WriteLine($"{y[i]}");
                } 
            }
            catch
            {
                Console.WriteLine("Wrong input error");
            }
        }
    }
}
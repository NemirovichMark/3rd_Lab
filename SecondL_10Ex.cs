using System;
using System.Reflection;

namespace _3rd_Lab
{
    class SecondL_10Ex
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
                double MinElement = 0;
                int indexMinElement = 0;
                double [] y = new double[size - 1];
                for(int i = 0; i < size; i++){
                    if (x[i] < MinElement && x[i] > 0)
                    {
                        MinElement = x[i];
                        indexMinElement = i;
                    }
                }
                if(x[indexMinElement] > 0){
                    for(int i = indexMinElement + 1; i < size; i++){    
                        x[ i - 1] = x[i]; 
                    }
                for(int i = 0; i < size - 1; i++) Console.WriteLine(x[i]);
                }else{
                    Console.WriteLine("There are not positive elements in the array");
                }
            }
            catch
            {
                Console.WriteLine("Wrong input error");
            }
        }
    }
}

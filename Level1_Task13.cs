using System;
class HelloWorld
{
  static void Main ()
  {
    int size = 10;
    double[] x = new double[size];
    double[] y = new double[size/2];
    double[] z = new double[size/2];
    for (int i = 0; i < size; i+=2){
  Console.Write($"Enter the {i+1} element of the array: ");
  if (!double.TryParse (Console.ReadLine (), out x[i])) return;
  Console.Write($"Enter the {i+2} element of the array: ");
  if (!double.TryParse (Console.ReadLine (), out x[i+1])) return;
        y[i/2]=x[i];
        z[i/2]=x[i+1];
    }
    Console.Write("Your array:");
    foreach(int element in x){
        Console.Write($" {element}");
    }
    Console.Write("\n");
    Console.Write("Array of even indexes:");
    foreach(int element in y){
        Console.Write($" {element}");
    }
    Console.Write("\n");
    Console.Write("Array of odd indexes:");
    foreach(int element in z){
        Console.Write($" {element}");
    }
    
  }
}

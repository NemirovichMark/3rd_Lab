using System;
class HelloWorld
{
  static void Main ()
  {
    int size = 8;
    int counter = 0; 
    double[] x = new double[size];
    for (int i = 0; i < size; i++){
  Console.Write($"Enter the {i+1} element of the array: ");
  if (!double.TryParse (Console.ReadLine (), out x[i])) return;
        if (x[i] < 0 )
            counter = i;
    }
    Console.Write("Your array: \n");
    foreach(int element in x){
        Console.WriteLine($"{element}");
    }
    Console.Write($"\nThe last negative element is located at the position number {counter+1} of the array and equals {x[counter]}");
    
  }
}

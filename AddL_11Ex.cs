using System;
class AddL_11Ex {
  static void Main() {
            const int indexA = 10;
            bool flag = false; 
            double[] a = new double[indexA] { 1,2,3,4,5,6,7,8,9,10 };
            double x;
            Console.Write("Introduce the element that you want to find in the array: ");
            double.TryParse(Console.ReadLine(), out x);
            Console.Write("array: ");
            foreach(int element in a) Console.Write($"{element} ");
            Console.WriteLine();
            foreach(int element in a) if( element == x) flag = true; 
            if(flag){
                Console.WriteLine("The element that you introduced is in the array");
            }else{
                Console.WriteLine("The element that you introduced is not in the array");
            }
  }
}
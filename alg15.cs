using System;
using System.Linq;
using System.Collections.Generic;
class HelloWorld {
    static void Main() {
        try{
            Console.Write("Write the array: ");
            double[] a=Console.ReadLine().Split().Select(t => double.Parse(t)).ToArray();
            Console.Write("Enter the step: ");
            int k = int.Parse(Console.ReadLine());
            double tmp;
            for(int i=0; i<k; i++){
                tmp = a[a.Length-1];
                for(int j=a.Length-1; j>0; j--) a[j]=a[j-1];
                a[0]=tmp;
            }
            Console.Write("Answer array:");
            foreach(var i in a) Console.Write($" {i}");
        }
        catch{}
    }
}

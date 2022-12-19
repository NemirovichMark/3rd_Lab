using System;
using System.Linq;
using System.Collections.Generic;
class HelloWorld {
    static void Main() {
        try{
            Console.Write("Write the array: ");
            double[] a=Console.ReadLine().Split().Select(t => double.Parse(t)).ToArray();
            for(int i=0; i<a.Length/2; i++)
                a[i] = a[i] + a[a.Length-i-1] - (a[a.Length-i-1]=a[i]);
            Console.Write("Answer array:");
            foreach(var i in a) Console.Write($" {i}");
        }
        catch{}
    }
}

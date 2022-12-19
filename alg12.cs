using System;
using System.Linq;
using System.Collections.Generic;
class HelloWorld {
    static void Main() {
        try{
            Console.Write("Write the first array: ");
            double[] a=Console.ReadLine().Split().Select(t => double.Parse(t)).ToArray();
            Console.Write("Write the second array: ");
            double[] b=Console.ReadLine().Split().Select(t => double.Parse(t)).ToArray();
            if(a.Length<b.Length) Array.Resize(ref b,a.Length);
            else Array.Resize(ref a,b.Length);
            double[] c = new double[a.Length*2];
            for(int i=0; i<a.Length; i++){
                c[i*2]=a[i];
                c[i*2+1]=b[i];
            }
            Console.Write("Answer array:");
            foreach(var i in c) Console.Write($" {i}");
        }
        catch{}
    }
}

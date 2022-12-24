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
            double[] c = new double[a.Length+b.Length];
            int p=0,q=0;
            for(int i=0; i<c.Length; i++){
                c[i]=(a[p]>b[q])?a[p++]:b[q++];
                if(p==a.Length){
                    for(int j=i+1; j<c.Length; j++) c[j]=b[q++];
                    break;
                }
                else if(q==b.Length){
                    for(int j=i+1; j<c.Length; j++) c[j]=a[p++];
                    break;
                }
            }
            Console.Write("Answer array:");
            foreach(var i in c) Console.Write($" {i}");
        }
        catch{}
    }
}

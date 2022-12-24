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
            int len=a.Length;
            if(a.Length>b.Length) len=b.Length;
            double[] c = new double[a.Length+b.Length];
            for(int i=0; i<len; i++){
                c[i*2]=a[i];
                c[i*2+1]=b[i];
            }
            int counter=len*2;
            if(len==a.Length)
                for(int i=len; i<b.Length; i++)
                    c[counter++]=b[i];
            else
                for(int i=len; i<a.Length; i++)
                    c[counter++]=a[i];
            Console.Write("Answer array:");
            foreach(var i in c) Console.Write($" {i}");
        }
        catch{}
    }
}

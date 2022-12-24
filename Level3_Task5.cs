using System;
using System.Linq;

public class HelloWorld
{
    static Random rand = new Random();
    static void Qsort(int l, int r, double[] a){
        if((r-l)/2<=1) return;
        double pivot = a[l+rand.Next()%((r-l)/2)*2];
        int m=l;
        for(int i=l; i<r&&m<r; i+=2)
            if(a[i]<pivot){
                a[i]=a[i]+a[m]-(a[m]=a[i]);
                m+=2;
            }
        int p=l,q=l;
        for(;p<a.Length&&a[p]<pivot;p+=2);
        for(;q<a.Length&&a[q]<=pivot;q+=2);
        Qsort(l,p,a);
        Qsort(q,r,a);
    }
    public static void Main(string[] args)
    {
        try{
            Console.Write("Write your array in a row: ");
            var a = Console.ReadLine().Split(' ').Select(n => double.Parse(n)).ToArray();
            Qsort(0,a.Length,a);
            foreach(var i in a) Console.Write($"{i} ");
        }
        catch{
            
        }
    }
}

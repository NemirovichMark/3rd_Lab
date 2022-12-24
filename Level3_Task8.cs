using System;
using System.Linq;

public class HelloWorld
{
    static Random rand = new Random();
    static void Qsort(int l, int r, double[] a){
        if((r-l)<=1) return;
        double pivot = a[l+rand.Next()%(r-l)];
        int m=l;
        for(int i=l; i<r; i++)
            if(a[i]<pivot)
                a[i]=a[i]+a[m]-(a[m++]=a[i]);
        int p=l,q=l;
        for(;a[p]<pivot;p++);
        for(;q<a.Length&&a[q]<=pivot;q++);
        Qsort(l,p,a);
        Qsort(q,r,a);
    }
    public static void Main(string[] args)
    {
        try{
            Console.Write("Write your array in a row: ");
            var a = Console.ReadLine().Split(' ').Select(n => double.Parse(n)).ToArray();
            double[] b = new double[a.Count(n => n<0)];
            int m=0;
            foreach(double i in a)
                if(i<0)
                    b[m++]=-i;
            Qsort(0,b.Length,b);
            m=0;
            for(int i=0; i<a.Length; i++)
                if(a[i]<0)
                    a[i]=-b[m++];
            foreach(var i in a) Console.Write($"{i} ");
        }
        catch{
            
        }
    }
}

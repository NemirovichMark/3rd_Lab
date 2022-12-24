using System;
using System.Linq;
using System.Collections.Generic;
class HelloWorld {
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
    static int BinSearch(int l, int r, double[] a, double el){
        if(l>r) return -1;
        int mid=(l+r)/2;
        if(el==a[mid]) return mid;
        if(el>a[mid]) return BinSearch(mid+1,r,a,el);
        else return BinSearch(l,mid-1,a,el);
    }
    static void Main() {
        try{
            double el;
            Console.Write("Write your array in a row: ");
            double[] a=Console.ReadLine().Split().Select(t => double.Parse(t)).ToArray();
            Qsort(0,a.Length,a);
            Console.Write("Enter element you want to find: ");
            el=double.Parse(Console.ReadLine());
            Console.Write($"Index of this element is: {BinSearch(0,a.Length-1,a,el)} ('-1' means that element is not found)");
        }
        catch{}
    }
}

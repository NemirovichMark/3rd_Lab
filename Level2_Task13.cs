using System;
using System.Linq;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        try{
            Console.Write("Enter your array in a row: ");
            double[] a=Console.ReadLine().Split().Select(n => double.Parse(n)).ToArray();
            int index=0;
            for(int i=0; i<a.Length; i+=2)
                if(a[i]>a[index]) index=i;
            a[index]=index;
            Console.Write("This is the answer array:");
            foreach(var i in a)
                Console.Write($" {i}");
        }
        catch{}
    }
}

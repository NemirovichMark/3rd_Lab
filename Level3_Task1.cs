using System;
using System.Linq;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        try{
            Console.Write("Enter the array in a row: ");
            double[] a=Console.ReadLine().Split().Select(n => double.Parse(n)).ToArray();
            int[] b = new int[a.Length];
            int index=0;
            for(int i=1; i<a.Length; i++)
                if(a[i]>a[index]) index=i;
            int c=0;
            for(int i=0; i<a.Length; i++)
                if(a[i]==a[index])
                    b[c++]=i;
            Array.Resize(ref b, c);
            Console.Write("This is the answer array:");
            foreach(var i in b)
                Console.Write($" {i}");
        }
        catch{}
    }
}

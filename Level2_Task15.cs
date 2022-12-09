using System;
using System.Linq;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        try{
            Console.Write("Enter the array A in a row: ");
            double[] a=Console.ReadLine().Split().Select(n => double.Parse(n)).ToArray();
            Console.Write("Enter the array B in a row: ");
            double[] b=Console.ReadLine().Split().Select(n => double.Parse(n)).ToArray();
            Array.Resize(ref a, a.Length+b.Length);
            Console.Write("Enter k: ");
            int k=int.Parse(Console.ReadLine());
            for(int i=a.Length-1; i>=k+b.Length+1; i--)
                a[i]=a[i-b.Length];
            int c=0;
            for(int i=k+1; i<=k+b.Length; i++)
                a[i]=b[c++];
            Console.Write("This is the answer array:");
            foreach(var i in a)
                Console.Write($" {i}");
        }
        catch{}
    }
}

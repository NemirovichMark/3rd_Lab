using System;
using System.Linq;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        try{
            Console.Write("Enter your array in a row: ");
            double[] a=Console.ReadLine().Split().Select(n => double.Parse(n)).ToArray();
            Console.Write("This is your array:");
            foreach(var i in a)
                Console.Write($" {i}");
            Array.Resize(ref a, a.Length+1);
            Console.Write("\nEnter P: ");
            double P = double.Parse(Console.ReadLine());
            int index=-1;
            for(int i=0; i<a.Length-1; i++)
                if(a[i]>0) index=i;
            for(int i=a.Length-1; i>index+1; i--)
                a[i]=a[i-1];
            a[index+1]=P;
            Console.Write("This is the answer array:");
            foreach(var i in a)
                Console.Write($" {i}");
        }
        catch{}
    }
}

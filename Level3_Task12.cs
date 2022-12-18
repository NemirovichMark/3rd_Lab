using System;
using System.Linq;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        try{
            Console.Write("Write the array in a row: ");
            double[] a=Console.ReadLine().Split().Select(t => double.Parse(t)).ToArray();
            int m=0;
            for(int i=0; i<a.Length; i++)
                if(a[i]>=0)
                    a[m++]=a[i];
            Array.Resize(ref a, a.Length-m);
            Console.Write("The answer array:");
            foreach(var i in a)
                Console.Write($" {i}");
        }
        catch{}
    }
}

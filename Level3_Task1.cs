using System;
using System.Linq;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        try{
            Console.Write("Write the array in a row: ");
            double[] a=Console.ReadLine().Split().Select(n => double.Parse(n)).ToArray();
            int[] b = new int[1]{0};
            for(int i=1; i<a.Length; i++){
                if(a[i]==a[b[0]]){
                    Array.Resize(ref b, b.Length+1);
                    b[b.Length-1]=i;
                }
                else if(a[i]>a[b[0]]){
                    Array.Resize(ref b, 1);
                    b[b.Length-1]=i;
                }
            }
            Console.Write($"Max element: {a[b[0]]}\nThis is the array made of indexes of the max elements:");
            foreach(var i in b)
                Console.Write($" {i}");
        }
        catch{}
    }
}

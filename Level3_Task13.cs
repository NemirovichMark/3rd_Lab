using System;
using System.Linq;
using System.Collections.Generic;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        try{
            Console.Write("Write the array in a row: ");
            List<double> a=Console.ReadLine().Split().Select(t => double.Parse(t)).ToList();
            for(int i=0; i<a.Count; i++){
                for(int j=i+1; j<a.Count; j++)
                    if(a[j]==a[i])
                        a.RemoveAt(j--);
            }
            Console.Write("Answer array:");
            foreach(var i in a)
                Console.Write($" {i}");
        }
        catch{}
    }
}

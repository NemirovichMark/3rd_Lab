using System;
using System.Linq;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        try{
            Console.Write("Enter an array in a row: ");
            var a = Console.ReadLine().Split(' ').Select(n => double.Parse(n)).ToArray();
            double[] b = new double[a.Length-1];
            int mn=0;
            for(int i=1; i<a.Length; i++){
                if(a[i]<a[mn]) mn=i;
            }
            Console.WriteLine($"Minimal element: {mn}");
            int c=0;
            for(int i=0; i<a.Length;i++){
                if(i==mn)
                    continue;
                b[c++]=a[i];
            }
            Console.WriteLine("This is the answer array: ");
            foreach(var i in b)
                Console.Write("{0} ",i);
        }
        catch{
            Console.WriteLine("Wrong input error");
        }
        
    }
}

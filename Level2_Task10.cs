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
            int mn=-1;
            for(int i=0; i<a.Length&&a[i]<=0;i++) mn=i;
            mn++;
            if(mn==a.Length){
                Console.Write("There are no positive elements");
                return;
            }
            for(int i=mn+1; i<a.Length; i++){
                if(a[i]<a[mn] && a[i]>0) mn=i;
            }
            Console.WriteLine($"Minimal element: a[{mn}]");
            int c=0;
            for(int i=0; i<a.Length;i++){
                if(i==mn)
                    continue;
                b[c++]=a[i];
            }
            Console.WriteLine("This is the answer array: ");
            foreach(var i in b)
                Console.Write(" {0}",i);
        }
        catch{
            Console.WriteLine("Wrong input error");
        }
        
    }
}

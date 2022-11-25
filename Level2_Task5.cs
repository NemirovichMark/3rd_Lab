using System;
using System.Linq;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        try{
            Console.Write("Enter an array in a row: ");
            var a = Console.ReadLine().Split(' ').Select(n => double.Parse(n)).ToArray();
            double[] b = new double[0];
            int mx=0,mn=0;
            for(int i=1; i<a.Length; i++){
                if(a[i]>a[mx]) mx=i;
                if(a[i]<a[mn]) mn=i;
            }
            Console.WriteLine($"Minimal element: {a[mn]}\nMaximal element: {a[mx]}");
            if(mn>mx) (mn,mx)=(mx,mn);
            for(int i=mn+1; i<mx;i++){
                if(a[i]<0){
                    Array.Resize(ref b,b.Length+1);
                    b[b.Length-1]=a[i];
                }
            }
            Console.Write("This is the answer array: ");
            foreach(var i in b)
                Console.Write("{0} ",i);
        }
        catch{
            Console.WriteLine("Wrong input error");
        }
        
    }
}

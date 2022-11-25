using System;
using System.Linq;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        try{
            Console.Write("Enter an array in a row: ");
            var a = Console.ReadLine().Split(' ').Select(n => double.Parse(n)).ToArray();
            int mx=0,mn=0;
            for(int i=1; i<a.Length; i++){
                if(a[i]>a[mx]) mx=i;
                if(a[i]<a[mn]) mn=i;
            }
            Console.WriteLine($"Minimal element: {a[mn]}\nMaximal element: {a[mx]}");
            if(mn>mx) (mn,mx)=(mx,mn);
            double average=0;
            for(int i=mn+1; i<mx;i++){
                average+=a[i];
            }
            average/=(mx-mn-1);
            Console.Write($"This is the average value between max and min elements: {average}");
        }
        catch{
            Console.WriteLine("Wrong input error");
        }
        
    }
}

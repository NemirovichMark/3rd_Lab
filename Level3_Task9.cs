using System;
using System.Linq;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        try{
            Console.Write("Write the array in a row: ");
            double[] a=Console.ReadLine().Split().Select(t => double.Parse(t)).ToArray();
            int mx=1,mn=1,x=1,n=1;
            for(int i=1; i<a.Length; i++){
                if(a[i]>a[i-1]){
                    mn=(n>mn)?n:mn;
                    n=1;
                    x++;
                }
                else if(a[i]<a[i-1]){
                    mx=(x>mx)?x:mx;
                    x=1;
                    n++;
                }
                else{
                    mx=(x>mx)?x:mx;
                    mn=(n>mn)?n:mn;
                    x=1;
                    n=1;
                }
            }
            Console.Write($"Length of the longest sorted sequence is: {(mn>mx)?mn:mx}");
        }
        catch{}
    }
}

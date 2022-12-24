using System;
using System.Linq;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        try{
            Console.Write("Enter an array in a row: ");
            var a = Console.ReadLine().Split(' ').Select(n => double.Parse(n)).ToArray();
            double average=0;
            foreach(var i in a)
                average+=i;
            average/=a.Length;
            int precise=0;
            for(int i=1; i<a.Length; i++){
                if(Math.Abs(average-a[precise])>Math.Abs(average-a[i]))
                    precise = i;
            }
            Console.WriteLine($"The average value is: {average}");
            int counter=0;
            Array.Resize(ref a, a.Length+1);
            for(int i=a.Length-1; i>precise+1; i--)
                a[i]=a[i-1];
            a[precise+1]=average;
            Console.Write("There is the answer array: ");
            foreach(var i in a)
                Console.Write("{0} ",i);
        }
        catch{
            Console.WriteLine("Wrong input error");
        }
    }
}

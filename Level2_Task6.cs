using System;
using System.Linq;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        try{
            Console.Write("Enter an array in a row: ");
            var a = Console.ReadLine().Split(' ').Select(n => double.Parse(n)).ToArray();
            double[] b = new double[a.Length+1];
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
            for(int i=0; i<a.Length; i++){
                b[counter++]=a[i];
                if(i==precise)
                    b[counter++]=average;
            }
            Console.Write("There is the answer array: ");
            foreach(var i in b)
                Console.Write("{0} ",i);
        }
        catch{
            Console.WriteLine("Wrong input error");
        }
    }
}

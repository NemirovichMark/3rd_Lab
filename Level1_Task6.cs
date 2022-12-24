using System;
using System.Linq;
class HelloWorld {
    static void Main() {
        try{
            Console.Write("Enter coordinates of your vector in a row: ");
            double[] a=Console.ReadLine().Split().Select(t => double.Parse(t)).ToArray();
            double sum=0;
            foreach(var i in a) sum+=i*i;
            sum=Math.Sqrt(sum);
            Console.Write("The length of the vector: {0}",sum);
        }
        catch{
            Console.WriteLine("An error occured");
        }
    }
}

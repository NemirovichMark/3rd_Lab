 #region lvl2Task6
            double minimum = 1000000000000;
            double value = 0;
            int x = 0;
            Console.WriteLine("Enter count of array values");
            int n = Convert.ToInt32(Console.ReadLine());
            double[] array = new double[n];
            Console.WriteLine("Enter array values");
            for (int i = 0; i<n;i++)
            {
                array[i] = Convert.ToDouble(Console.ReadLine());
            }
            Console.WriteLine("Enter P number");
            double P = Convert.ToDouble(Console.ReadLine());
            double mid = array.Sum() / n;
            for (int i = 0; i < n; i++)
            {
                value = Math.Abs(array[i] - mid);
                if (value < minimum)
                {
                    minimum = value;
                    x = Array.IndexOf(array,array[i]);
                }
            }
            for (int i = n-2; i >= x +1;i--)
            {
                array[i + 1] = array[i];
                array[x + 1] = P;
            }
            Console.WriteLine(String.Join(" ",array));
            #endregion
            
#region lvl1Task10
double[] array = new double[10];
int count = 0;
Console.WriteLine("Enter Q and P values (P>Q)");
double Q = Convert.ToDouble(Console.ReadLine());
double P = Convert.ToDouble(Console.ReadLine());
if (P > Q)
{
    Console.WriteLine("Enter array values:");
    for (int i = 0; i < 10; i++)
    {
        array[i] = Convert.ToDouble(Console.ReadLine());
        if (Q < array[i] && array[i] < P)
        {
            count++;
        }
    }
    Console.WriteLine($"{count} elements of array stand between P and Q");
}
else
{
    Console.WriteLine("Error");
}
#endregion

#region lvl1Task11
double[] array = new double[10];
int count = 0;
Console.WriteLine("Enter array values");
for (int i = 0; i < 10; i++)
{
    array[i] = Convert.ToDouble(Console.ReadLine());
    if (array[i] > 0) count++;
}
double[] array_positive = new double[count];
for (int i = 0; i < 10; i++)
{
    if (array[i] > 0)
    {
        array_positive[count-1] = array[i];
        count--;
    }
}
Console.WriteLine(string.Join("", array_positive));
#endregion
            
             #region lvl3Task13
            Console.WriteLine("Enter count values");
            int n = Convert.ToInt32(Console.ReadLine());
            double[] array = new double[n];
            for (int i=0;i<n;i++)
            {
                array[i] = Convert.ToDouble(Console.ReadLine());
            }
            string value = "";
            for (int i=0;i<n;i++)
            {
                if (value.Contains(Convert.ToString(array[i])))
                {
                    continue;
                }
                else
                {
                    value += Convert.ToString(array[i]);
                }
            }
            Console.WriteLine(value);


            #endregion

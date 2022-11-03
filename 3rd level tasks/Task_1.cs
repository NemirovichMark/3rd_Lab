#region Task 3.1
 
Console.WriteLine("solution for task 3.1"); 

int n;
do
{
    Console.Write("enter n: ");
}
while (!int.TryParse(Console.ReadLine(), out n));

List<int> A = new List<int>();
List<int> B = new List<int>();

int temp;
for (int i = 0; i < n; i++) 
{ 
    do 
    { 
        Console.Write($"enter the {i+1} value of array A: "); 
    } 
    while (!int.TryParse(Console.ReadLine(), out temp)); 
    A.Add(temp);
}

int c = 0;
int max = A.Max();
for (int i = 0; i < n; i++)
{
    if (A[i] == max)
    {
        B.Add(i);
        c++;
    }
}

Console.Write("B = ");
for (int i = 0; i < c; i++)
{
    Console.Write($"{B[i]} ");
}

#endregion

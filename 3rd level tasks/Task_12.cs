#region Task 3.12
 
Console.WriteLine("solution for task 3.12"); 

int n;
do
{
    Console.Write("enter n: ");
}
while (!int.TryParse(Console.ReadLine(), out n));

List<int> A = new List<int>();

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

for (int i = 0; i < n; i++)
{
    if (A[i] < 0)
    {
        A.Remove(A[i]);
        n--;
        i--;
    }
}

Console.Write("\nA = ");
for (int i = 0; i < n; i++)
{
    Console.Write($"{A[i]} ");
}

#endregion

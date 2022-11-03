#region algorithm 14

int n;
do
{
    Console.Write("enter n: ");
}
while (!int.TryParse(Console.ReadLine(), out n));

int [] A = new int [n];
for (int i = 0; i < n; i++) 
{ 
    do 
    { 
        Console.Write($"enter the {i+1} value of array A: "); 
    } 
    while (!int.TryParse(Console.ReadLine(), out A[i]));
}

Console.Write("\nthe old array: ");
foreach (int x in A) Console.Write($"{x} ");

int f;
for (int i = 0; i < n / 2; i++)
{
    f = A[i];
    A[i] = A[n - 1 - i];
    A[n - 1 - i] = f;
}

Console.Write("\nthe new array: ");
foreach (int x in A) Console.Write($"{x} ");

#endregion

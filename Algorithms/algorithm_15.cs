#region algorithm 15

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

int m;
do
{
    Console.Write("enter the number of positions to shift: ");
}
while (!int.TryParse(Console.ReadLine(), out m));

Console.Write("\nthe old array: ");
foreach (int x in A) Console.Write($"{x} ");

int f;
for (int i = 0; i < m; i++)
{
    f = A[n - 1];
    for (int j = n - 1; j > 0; j--)
    {
        A[j] = A[j - 1];
    }
    A[0] = f;
}

Console.Write("\nthe new array: ");
foreach (int x in A) Console.Write($"{x} ");

#endregion

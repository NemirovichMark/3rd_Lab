#region Task 2.13
 
Console.WriteLine("solution for task 2.13"); 
 
int n;
do
{
    do
    {
        Console.Write("specify the length of the array: ");
    }
    while (!int.TryParse(Console.ReadLine(), out n));
}
while (n < 1);
  
int [] A = new int [n + 1];  
 
// input vector values 
for (int i = 0; i < n; i++) 
{ 
    do 
    { 
        Console.Write($"enter the {i+1} value of array A: "); 
    } 
    while (!int.TryParse(Console.ReadLine(), out A[i])); 
} 
 
Console.Write($"\nold vector: "); 
for (int i = 0; i < n; i++) 
{ 
    Console.Write($"{A[i]} "); 
} 
 
int max = A[0];
int maxi = 0;
for (int i = 0; i < n; i += 2)
{
    if (A[i] > max)
    {
        max = A[i];
        maxi = i;
    }
}

A[maxi] = maxi;

Console.Write($"\nnew vector: "); 
for (int i = 0; i < n; i++) 
{ 
    Console.Write($"{A[i]} "); 
}
 
#endregion

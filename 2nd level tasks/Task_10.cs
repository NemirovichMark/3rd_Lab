#region Task 2.10 
 
Console.WriteLine("solution for task 2.10"); 
 
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
 
int [] A = new int [n];  
 
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
 
int min = A[0]; 
int mini = 0; 
for (int i = 0; i < n; i++) 
{ 
    if ((A[i] > 0) && (A[i] < min)) 
    { 
        min = A[i]; 
        mini = i; 
    } 
} 
 
for (int i = mini; i < n - 1; i++) 
{ 
    A[i] = A[i + 1]; 
} 
 
Console.Write($"\nnew vector: "); 
for (int i = 0; i < n - 1; i++) 
{ 
    Console.Write($"{A[i]} "); 
} 
 
#endregion

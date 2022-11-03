#region Task 2.11 
 
Console.WriteLine("solution for task 2.11"); 
 
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
 
int p; 
do 
{ 
    Console.Write("enter P: "); 
} 
while (!int.TryParse(Console.ReadLine(), out p)); 
 
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
 
int positive_i = 0; 
for (int i = 0; i < n; i++) 
{ 
    if (A[i] > 0) 
    { 
        positive_i = i; 
    } 
} 
 
for (int i = n; i > positive_i; i--) 
{ 
    A[i] = A[i - 1]; 
} 
 
A[positive_i + 1] = p; 
 
Console.Write($"\nnew vector: "); 
for (int i = 0; i < n + 1; i++) 
{ 
    Console.Write($"{A[i]} "); 
} 
 
#endregion

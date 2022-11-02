#region Task 2.9 
 
Console.WriteLine("solution for task 2.9"); 
 
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
 
int min = A[0], max = A[0]; 
int mini = 0, maxi = 0; 
 
for (int i = 0; i < n; i++) 
{ 
    if (A[i] < min) 
    { 
        min = A[i]; 
        mini = i; 
    } 
 
    else if (A[i] > max) 
    { 
        max = A[i]; 
        maxi = i; 
    } 
} 
 
int sum = 0, count = 0; 
if (mini < maxi) 
{ 
    for (int i = mini + 1; i < maxi; i++) 
    { 
        sum += A[i]; 
        count++; 
    } 
} 
 
else if (maxi < mini) 
{ 
    for (int i = maxi + 1; i < mini; i++) 
    { 
        sum += A[i]; 
        count++; 
    } 
} 
 
if (count > 0) 
{ 
    Console.WriteLine($"answer for task 2.9: {sum / (count * 1.0)}"); 
} 
else 
{ 
    Console.WriteLine($"answer for task 2.9: 0"); 
} 
 
#endregion

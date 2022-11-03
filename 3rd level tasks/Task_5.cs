#region Task 3.5
 
Console.WriteLine("solution for task 3.5"); 

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

for (int i = 0; i < n; i += 2)
{
    B.Add(A[i]);
}

B.Sort();

int k = 0;
for (int i = 0; i < n; i += 2)
{
    A[i] = B[k];
    k++;
}

Console.Write("A = ");
for (int i = 0; i < n; i++)
{
    Console.Write($"{A[i]} ");
}

#endregion

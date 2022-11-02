#region Task 3.8
 
Console.WriteLine("solution for task 3.8"); 

int n;
do
{
    Console.Write("enter n: ");
}
while (!int.TryParse(Console.ReadLine(), out n));

List<int> A = new List<int>();
List<int> B = new List<int>();
List<int> C = new List<int>();

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
        B.Add(A[i]);
        C.Add(i);
    }
}

B.Sort();
B.Reverse();

int k = 0;
for (int i = 0; i < n; i++)
{
    if (C.Contains(i))
    {
        A[i] = B[k];
        k++;
    }
}

Console.Write("\nA = ");
for (int i = 0; i < n; i++)
{
    Console.Write($"{A[i]} ");
}

#endregion

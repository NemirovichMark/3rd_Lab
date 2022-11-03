#region Task 3.13
 
Console.WriteLine("solution for task 3.13"); 

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

A = A.Distinct().ToList();

Console.Write("\nA = ");
for (int i = 0; i < A.Count(); i++)
{
    Console.Write($"{A[i]} ");
}

#endregion

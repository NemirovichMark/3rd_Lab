#region Task 2.15
 
Console.WriteLine("solution for task 2.15"); 

int n;
do
{
    Console.Write("enter n: ");
}
while (!int.TryParse(Console.ReadLine(), out n));

int m;
do
{
    Console.Write("enter m: ");
}
while (!int.TryParse(Console.ReadLine(), out m));

int k;
do
{
    Console.Write("enter k: ");
}
while (!int.TryParse(Console.ReadLine(), out k));

List<int> A = new List<int>(n);
List<int> B = new List<int>(m);

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

for (int i = 0; i < m; i++) 
{ 
    do 
    { 
        Console.Write($"enter the {i+1} value of array B: "); 
    } 
    while (!int.TryParse(Console.ReadLine(), out temp));
    B.Add(temp);
} 

A.InsertRange(k, B);

Console.Write($"\nnew array: "); 
for (int i = 0; i < n; i++) 
{ 
    Console.Write($"{A[i]} "); 
}

#endregion

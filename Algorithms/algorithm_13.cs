#region algorithm 13

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


int [] A = new int [n];
for (int i = 0; i < n; i++) 
{ 
    do 
    { 
        Console.Write($"enter the {i+1} value of array A: "); 
    } 
    while (!int.TryParse(Console.ReadLine(), out A[i]));
}

int [] B = new int [m];
for (int i = 0; i < m; i++) 
{ 
    do 
    { 
        Console.Write($"enter the {i+1} value of array B: "); 
    } 
    while (!int.TryParse(Console.ReadLine(), out B[i]));
}

List<int> C = new List<int>();

int a = 0, b = 0;
while (a < n || b < m)
{
    if (a == n) { C.Add(B[b]); b++; continue; }
    if (b == m) { C.Add(A[a]); a++; continue; }
    if (A[a] >= B[b]) { C.Add(A[a]); a++; }
    else { C.Add(B[b]); b++; }
}


Console.Write("The new array: ");
foreach (int x in C) Console.Write($"{x} ");

#endregion

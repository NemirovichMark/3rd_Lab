#region algorithm 12

int n;
do
{
    Console.Write("enter n: ");
}
while (!int.TryParse(Console.ReadLine(), out n));

int[] A = new int[n];
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
    Console.Write("enter m: ");
}
while (!int.TryParse(Console.ReadLine(), out m));

int[] B = new int[m];
for (int i = 0; i < m; i++) 
{ 
    do 
    { 
        Console.Write($"enter the {i+1} value of array B: "); 
    } 
    while (!int.TryParse(Console.ReadLine(), out B[i]));
}

Console.Write("\nA = ");
foreach (int x in A) Console.Write($"{x} ");

Console.Write("\nB = ");
foreach (int x in B) Console.Write($"{x} ");

int difference = Math.Abs(n - m);
if (n > m) n = m;
else m = n;

int [] C = new int[2 * n + difference];

int k = 0;
int l = 0;
for (int i = 0; i < 2 * n; i += 2)
{
    C[i] = A[k];
    C[i + 1] = B[k];
    k++;
    l += 2;
}

if (difference > 0)
{
    if (A.Count() > B.Count())
    {
        for (int i = n; i < n + difference; i++)
        {
            C[l] = A[i];
            l++;
        }
    }

    else
    {
        for (int i = n; i < n + difference; i++)
        {
            C[l] = B[i];
            l++;
        }
    }
}

Console.Write("\nC = ");
foreach (int x in C) Console.Write($"{x} ");

#endregion

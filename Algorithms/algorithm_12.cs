#region algorithm 12

int[] A = new int[5];
for (int i = 0; i < 5; i++) 
{ 
    do 
    { 
        Console.Write($"enter the {i+1} value of array A: "); 
    } 
    while (!int.TryParse(Console.ReadLine(), out A[i]));
}


int[] B = new int[5];
for (int i = 0; i < 5; i++) 
{ 
    do 
    { 
        Console.Write($"enter the {i+1} value of array B: "); 
    } 
    while (!int.TryParse(Console.ReadLine(), out B[i]));
}

int [] C = new int[10];

int k = 0;
for (int i = 0; i < 10; i += 2)
{
    C[i] = A[k];
    k++;
}

k = 0;
for (int i = 1; i < 10; i += 2)
{
    C[i] = B[k];
    k++;
}

foreach (int x in C) Console.Write($"{x} ");

#endregion

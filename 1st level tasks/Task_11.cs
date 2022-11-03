#region Task 1.11

int [] A = new int[10];
int [] B = new int[10];
// because the length of B cannot exceed the length of A

Console.WriteLine("solution for task 1.11:");

// input vector values
for (int i = 0; i < 10; i++)
{
    do
    {
        Console.Write($"enter the {i+1} value of the vector A: ");
    }
    while (!int.TryParse(Console.ReadLine(), out A[i]));
}

int count = 0;
for (int i = 0; i < 10; i++)
{
    if (A[i] > 0)
    {
        B[count] = A[i];
        count++;
    }
}

Console.Write("answer for task 1.11:" + 
    $"\nB = ");

for (int i = 0; i < count; i++)
{
    Console.Write($"{B[i]} ");
}

#endregion

#region Task 1.6

int [] A = new int[5];

Console.WriteLine("solution for task 1.6:");

// input vector values
for (int i = 0; i < 5; i++)
{
    do
    {
        Console.Write($"enter the {i+1} value of the vector A: ");
    }
    while (!int.TryParse(Console.ReadLine(), out A[i]));
}

int L = 0;
for (int i = 0; i < 5; i++)
{
    L += A[i] * A[i];
}

Console.WriteLine($"answer for task 1.6: L = {Math.Sqrt(L):f3}");

#endregion

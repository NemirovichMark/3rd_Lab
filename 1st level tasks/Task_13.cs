#region Task 1.13

int [] A = new int[10];
int [] even = new int[5];
int [] odd = new int[5];

Console.WriteLine("solution for task 1.13:");

// input vector values
for (int i = 0; i < 10; i++)
{
    do
    {
        Console.Write($"enter the {i+1} value of array A: ");
    }
    while (!int.TryParse(Console.ReadLine(), out A[i]));
}

int count = 0;
for (int i = 0; i < 10; i += 2)
{
    even[count] = A[i];
    odd[count] = A[i + 1];
    count++;
}

Console.WriteLine($"\nanswer for task 1.13:");

Console.Write("even array: ");
for (int i = 0; i < 5; i++)
{
    Console.Write($"{even[i]} ");
}

Console.Write("\nodd array: ");
for (int i = 0; i < 5; i++)
{
    Console.Write($"{odd[i]} ");
}

#endregion

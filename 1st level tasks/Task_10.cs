#region Task 1.10

int [] A = new int[10];

Console.WriteLine("solution for task 1.10:");

// input vector values
for (int i = 0; i < 10; i++)
{
    do
    {
        Console.Write($"enter the {i+1} value of the vector A: ");
    }
    while (!int.TryParse(Console.ReadLine(), out A[i]));
}

int p, q;
do {
    do
    {
        Console.Write("enter a value for P: ");
    }
    while (!int.TryParse(Console.ReadLine(), out p));

    do
    {
        Console.Write("enter a value for Q: ");
    }
    while (!int.TryParse(Console.ReadLine(), out q));
}
while (p > q);

int count = 0;
for (int i = 0; i < 10; i++)
{
    if (p < A[i] && A[i] < q) count++;
}

Console.WriteLine($"\nanswer for task 1.10: {count}");

#endregion

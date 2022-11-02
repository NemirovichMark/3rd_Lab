#region Task 1.12

int [] A = new int[8];

Console.WriteLine("solution for task 1.12:");

// input vector values
for (int i = 0; i < 8; i++)
{
    do
    {
        Console.Write($"enter the {i+1} value of the vector A: ");
    }
    while (!int.TryParse(Console.ReadLine(), out A[i]));
}

bool flag = false;
for (int i = 7; i >= 0; i--)
{
    if (A[i] < 0)
    {
        Console.WriteLine("\nanswer for task 1.12:\n" + 
            $"Last negative number: {A[i]}\n" + 
            $"Number of the last negative number: {i+1}");
        flag = true;
        break;
    }
}

if (!flag)
{
    Console.WriteLine("\nanswer for task 1.12: no negative numbers");
}

#endregion

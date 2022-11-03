#region Task 2.6

Console.WriteLine("solution for task 2.6:");

int n;
do
{
    do
    {
        Console.Write("specify the length of the array: ");
    }
    while (!int.TryParse(Console.ReadLine(), out n));
}
while (n < 1);

int [] A = new int[n + 1];

// input vector values
for (int i = 0; i < n; i++)
{
    do
    {
        Console.Write($"enter the {i+1} value of array A: ");
    }
    while (!int.TryParse(Console.ReadLine(), out A[i]));
}

int p;
do
{
    Console.Write("enter the number \"P\": ");
}
while (!int.TryParse(Console.ReadLine(), out p));

Console.Write($"\nold vector: "); 
for (int i = 0; i < n; i++) 
{ 
    Console.Write($"{A[i]} "); 
} 

int sum = 0;
for (int i = 0; i < n; i++)
{
    sum += A[i];
}

double average = sum / (n * 1.0);

double difference = Math.Abs(A[0] - average);
int index = 0;
for (int i = 0; i < n; i++)
{
    if (Math.Abs(A[i] - average) < difference)
    {
        difference = Math.Abs(A[i] - average);
        index = i;
    }
}

for (int i = n; i > index; i--)
{
    A[i] = A[i - 1];
}

A[index + 1] = p;

Console.Write($"\nnew vector: "); 
for (int i = 0; i < n + 1; i++) 
{ 
    Console.Write($"{A[i]} "); 
} 

#endregion

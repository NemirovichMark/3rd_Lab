#region Task 3.9
 
Console.WriteLine("solution for task 3.9"); 

int n;
do
{
    Console.Write("enter n: ");
}
while (!int.TryParse(Console.ReadLine(), out n));

List<int> A = new List<int>();

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

int max = 0;
int k = 1;
for (int i = 0; i < n - 1; i++)
{
    if (A[i] >= A[i + 1])
    {
        k++;
    }
    else
    {
        if (k > max)
        {
            max = k;
            k = 1;
        }
        k = 1;
    }
}

if (k > max) max = k;

k = 1;
for (int i = 0; i < n - 1; i++)
{
    if (A[i] <= A[i + 1])
    {
        k++;
    }
    else
    {
        if (k > max)
        {
            max = k;
            k = 1;
        }
        k = 1;
    }
}

if (k > max) max = k;

Console.WriteLine(max);

#endregion

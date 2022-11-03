#region Task 2.5

Console.WriteLine("solution for task 2.5:");

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


int [] A = new int[n];
int [] X = new int[n];

// input vector values
for (int i = 0; i < n; i++)
{
    do
    {
        Console.Write($"enter the {i+1} value of array A: ");
    }
    while (!int.TryParse(Console.ReadLine(), out A[i]));
}

int max = A[0];
int maxi = 0;
int min= A[0];
int mini = 0;


for (int i = 0; i < n; i++)
{
    if (A[i] > max)
    {
        max = A[i];
        maxi = i;
    }

    if (A[i] < min)
    {
        min = A[i];
        mini = i;
    }
}

int start = 0, end = 0;
bool flag = true;
if (maxi > mini)
{
    start = mini;
    end = maxi;
}
else if (mini > maxi)
{
    start = maxi;
    end = mini;
}
else
{
    flag = false;
}

int count = 0;
if (flag)
{
    for (int i = start + 1; i < end; i++){
        if (A[i] < 0)
        {
            X[count] = A[i];
            count++;
        }
    }
}

if (count == 0)
{
    Console.WriteLine($"\nanswer for task 2.5: no negative numbers");
}
else
{
    Console.Write($"\nanswer for task 2.5: ");
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{X[i]} ");
    }
}

#endregion

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

int up = 1;
int down = 1;

int maxup = 0;
int maxdown = 0;
for (int i = 0; i < n - 1; i++)
{
    if (A[i] >= A[i + 1])
    {
        up++;
    }
    else
    {
        if (up > maxup)
        {
            maxup = up;
        }
        up = 1;
    }

    if (A[i] <= A[i + 1])
    {
        down++;
    }
    else
    {
        if (down > maxdown)
        {
            maxdown = down;
        }
        down = 1;
    }
}

if (up > maxup) maxup = up;
if (down > maxdown) maxdown = down;

Console.WriteLine(Math.Max(maxup, maxdown));

#endregion

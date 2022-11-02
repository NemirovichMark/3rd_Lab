#region algorithm 11

int n;
do
{
    Console.Write("enter the length of the array: ");
}
while (!int.TryParse(Console.ReadLine(), out n));


int[] A = new int[n];
for (int i = 0; i < n; i++) 
{ 
    do 
    { 
        Console.Write($"enter the {i+1} value of array A: "); 
    } 
    while (!int.TryParse(Console.ReadLine(), out A[i]));
}

Array.Sort(A);

Console.Write("\nA = ");
for (int i = 0; i < n; i++)
{
    Console.Write($"{A[i]} ");
}


int left = 0;
int right = n - 1;
int index = 0;

int q;
do
{
    Console.Write("\nenter the desired number: ");
}
while (!int.TryParse(Console.ReadLine(), out q));

int res = -1;

while (left <= right)
{
    index = (right + left) / 2;

    if (A[index] == q)
    {
        res = index;
        break;
    }

    if (A[index] < q)
    {
        left = index + 1;
    }
    
    else
    {
        right = index - 1;
    }
}

if (res != -1)
{
    Console.WriteLine($"desired number: {q}\ndesired number index: {res}");

}
else
{
    Console.WriteLine("There is no such element in the array");
}

#endregion

using System;
using System.Reflection.Emit;

namespace _3rd_Lab
{
    class Theory
    {
        static void Main(string[] args)
        {
#region Level 1
#region task 6
double[] a = new double[5];
double L = 0;
for (int i = 0; i < 5; i++)
{
    double d = 0;
    Console.Write($"Enter the value of element of array {i}:\t");
    double.TryParse(Console.ReadLine(), out d);
    a[i] = d;
    L += a[i] * a[i];
}
L = Math.Sqrt(L);
Console.WriteLine($"The length of the vector is {L}");
#endregion
#region Task 10
double[] a2 = new double[] { 2, 4, 6, -423, 1, 2, 33, 12, -12, 115 };
double P;
double Q;
double m = 0;
Console.Write("Enter the P value ");
double.TryParse(Console.ReadLine(), out P);
Console.Write("Enter the Q value ");
double.TryParse(Console.ReadLine(), out Q);
if (P < Q && P != Q)
{
    for (int i = 0; i < a2.Length; i++)
    {
        a2[i] = i;
        if ((a2[i]<Q) && (a2[i]>P))
        {
            m += 1;
        }
    }
}else
    Console.WriteLine("Q must be higher then P ");
Console.WriteLine(m);
#endregion
#region Task 11
int[] a11 = new [] { 1, 4, -12, 11, -213, 112, 9, 55, -155, 2 };
int[] a111 = new  int [10];
int k = 0;
foreach(int i in a11)
{
    if (i > 0)
    {
        a111 [k] = i;
        k++;
    }
}
for(int i = 0; i < k; i++)
{
    Console.Write(a111 [i]);
Console.WriteLine();
}
#endregion
#region Task 12
        double[] a4 = new double[] { 12, 7, 3, -2, 78, 66, -8, 15 };
        double last = 0;
        double numlast = 0;
        for (int i = 0; i < a4.Length; i++)
        {
            if (a4[i] < 0)
            {
                last = a4[i];
                numlast = i;
            }
        }
        Console.WriteLine($"Last value: {last} \n Number: {numlast}");
        #endregion
#region Task 13
double[] a5 = new double[] { 2, 4, 6, 8, 10, 11, 13, 15, 17, 19 };
double[] j5 = new double[5];
double[] y5 = new double[5];
int w = 0;
int p = 0;
 for (int i = 0; i < a5.Length; i++)
            {
                if (i % 2 == 0)
                    {
                        j5[w] = a5[i];
                         w += 1;
                    }
                else
                {  y5[p] = a5[i];
                p += 1;

                }
            }
 for (int i = 0; i < w; i++)
            {
                 Console.Write($"{j5[i]}\t");
            Console.WriteLine();
            }
for (int i = 0; i < p; i++)
            {
                     Console.Write($"{y5[i]}\t");
            Console.WriteLine();
            }
#endregion
#endregion
#region Level 2
#region Task 5

      Console.WriteLine("Enter the amount of members of array ");
int d;
int.TryParse(Console.ReadLine(), out d);
int[] array = new int[d];
for (int i = 0; i < d; i++)
{
    Console.WriteLine($"Enter the  {i}  memeber ");
    int t;
    int.TryParse(Console.ReadLine(), out t);
    array[i] = t;
}
int indexxmin = 0, indexmax = 0, min = 0, max = 0, k = 0, c = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] < 0)
    {
        k++;
    }

    if (array[i] < min)
    {

        min = array[i];
        indexxmin = i;
    }
    if (array[i] > max)
    {
        max = array[i];
        indexmax = i;
    }
}
int[] newarray = new int[k - 1];
for (int i = indexxmin + 1; i < indexmax; i++)
{
    if (array[i] < 0)
    {
        newarray[c] = array[i];
        c++;
    }
}
foreach (int i in newarray)
{
    Console.Write(i + " ");
}
#endregion
#region Task 6
int n, P = 32;
double sr_znach = 0;
double currentDistance = 0;
double min = 0;
int min_i = 0;
Random random = new Random();
Console.Write("Enter an array length: ");
if (!int.TryParse(Console.ReadLine(), out n))
{
    Console.WriteLine("Value has an incorrect format!");
    return;
}
else if (n <= 0)
{
    Console.WriteLine("Array length must be greater than zero!");
    return;
}

int[] numbers = new int[n];
Console.Write("Initial array:\t");
for (int i = 0; i < n; i++)
{
    numbers[i] = random.Next(-10, 11);
    Console.Write($"{numbers[i]} ");
}
Console.WriteLine($"\nP: {P}");
foreach (int  number in numbers)
    sr_znach += number;
sr_znach /= n;
Console.WriteLine($"Average value: {Math.Round(sr_znach, 3)}");
min = Math.Abs(sr_znach - numbers[0]);
min_i = 0;
for (int i = 1; i < n; i++)
{
    currentDistance = Math.Abs(sr_znach - numbers[i]);
    if (currentDistance < min)
    {
        min = currentDistance;
        min_i = i;
    }
}
if (min_i == n - 1) 
                umbers[0] = P;
            else
                numbers[min_i + 1] = P;
Console.Write("Result array:\t");
foreach (var number in numbers)  
                Console.Write($"{number} "); 
Console.WriteLine();
#endregion
#region Task 9
Console.WriteLine("Enter the amount of members of array ");
int d29;
int.TryParse(Console.ReadLine(), out d29);
int[] array29 = new int[d29];
for (int i = 0; i < d29; i++)
{
    Console.WriteLine($"Enter the  {i}  memeber ");
    int t29;
    int.TryParse(Console.ReadLine(), out t29);
    array29[i] = t29;
}
int mm8max = array29[0];
int mm8min = array29[0];
int indexmm8max = 0;
int indexmm8min = 0;
for (int i = 0; i < array29.Length; i++)
{
    if (array29[i] > mm8max)
    {
        mm8max = array29[i];
        indexmm8max = i;
    }
    if (array29[i] < mm8min)
    {
        mm8min = array29[i];
        indexmm8max = i;
    }
}
double sr8 = 0;
int k8 = 0;
for (int i = indexmm8min + 1; i < indexmm8max; i++)
{
    sr8 += array29[i];
    k8 += 1;
}
sr8 /= k8;
Console.WriteLine(sr8);
#endregion
#region Task 10
Console.WriteLine("Enter the amount of members of array ");
int d210;
int.TryParse(Console.ReadLine(), out d210);
int[] array210 = new int[d210];
for (int i = 0; i < d210; i++)
{
    Console.WriteLine($"Enter the  {i}  memeber ");
    int t210;
    int.TryParse(Console.ReadLine(), out t210);
    array210[i] = t210;
}
int indexmm9= 0;
int minmm9 = 10000;
for (int i = 0; i < array210.Length; i++)
{
    if (array29[i] > 0)
    {
        if (array29[i] < minmm9)
        {
            minmm9 = array29[i];
            indexmm9 = i;
        }
    }

}
int n210 = array210.Length - 1;
for (int i = indexmm9; i < n210; i++)
{
    array210[i] = array210[i + 1];
}
for (int i = 0; i < n9 ; i++)
{
    Console.Write(array210[i]);
    Console.Write(" ");
}
#endregion
#region Task 11
Console.WriteLine("Enter the amount of members of array ");
int d211, p211;
int.TryParse(Console.ReadLine(), out d211);
Console.WriteLine("eneter the value of P");
int.TryParse(Console.ReadLine(), out p211);
int[] array211 = new int[d211];
for (int i = 0; i < d211 - 1; i++)
{
    Console.WriteLine($"Enter the  {i}  memeber ");
    int t211;
    int.TryParse(Console.ReadLine(), out t211);
    array211[i] = t211;
}
int indexnx = 0;
int maxnx = 0;
for (int i = 0; i < array211.Length; i++)
{

    if (array211[i] > 0 & array211[i] > maxnx)
    {
        maxnx = array211[i];
        indexnx = i;
    }
}
for (int i = d211 - 2; i >= indexnx + 1; i--)
{
    array211[i + 1] = array211[i];

}
array211[indexnx + 1] = p211;
foreach (int i in array211)
{
    Console.Write(i);
    Console.Write(" ");
}
#endregion
#region Task 13
Console.WriteLine("Enter the amount of members of array ");
int d213;
int.TryParse(Console.ReadLine(), out d213);
int[] array213 = new int[d213];
for (int i = 0; i < d213; i++)
{
    Console.WriteLine($"Enter the  {i}  memeber ");
    int t213;
    int.TryParse(Console.ReadLine(), out t213);
    array213[i] = t213;
}
int maxmm10 = 0;
int indexmm10 = 0;
for (int i = 0; i < d213; i++)
{
    if (i / 2 != 0)
    {
        if (array213[i] > maxmm10)
        {
            maxmm10 = array213[i];
            indexmm10 = i;
        }
    }
}
for (int i = indexmm10; i < d213; i++)
{
    array213[i] = i;
    break;
}
foreach (int i in array213)
{
    Console.Write(i);
    Console.Write(" ");
}
#endregion 
#region task 15
ble[] array215 = new double[12] { -12, 7, -4, -2, 8, 29, -11, -10 ,51,22,74,81};
double[] array2152 = new double[5] { 2, -4, 9,11,-17 };
double[] array2153 = new double[array215.Length + array2152.Length];
int q = 0,t,jj,kk;
Console.WriteLine("Enter the k value ");
int.TryParse(Console.ReadLine(), out t);
if ( t >= 0)
{
    for (int i = 0; i < t + 1; i++)
    {
        array2153[i] = array215[i];
        Console.WriteLine(array2153[i]);
    }
    for (jj = t + 1; jj < t + 1 + array2152.Length; jj++)
    {
        array2153[jj] = array2152[q];
        Console.WriteLine(array2153[jj]);
        q++;
    }
    q = t + 1;
    for ( kk = t + 1 + array2152.Length; kk < array2153.Length; kk++)
    {
        array2153[kk] = array215[q];
        Console.WriteLine(array2153[kk]);
        q++;
    }
}
#endregion
#endregion
#region Level 3
#region Task 1
Console.WriteLine("Enter the amount of members of array ");
int d31, j31 = 0;
int.TryParse(Console.ReadLine(), out d31);
int[] array31 = new int[d31];
for (int i = 0; i < d31; i++)
{
    Console.WriteLine($"Enter the  {i}  memeber ");
    int t31;
    int.TryParse(Console.ReadLine(), out t31);
    array31[i] = t31;
}
int amax = array31[0];
int[] array312 = new int[d31];
for (int i = 1; i < d31; i++)
{
    if (array31[i] == amax)
    {
        array312[j31] = i;
        j31++;

    }
    if (array31[i] > amax)
    {
        j31 = 0;
        amax = array31[i];
        array312[j31] = i;
        j31++;
    }

}
for (int i = 0; i < j31; i++)
{
    Console.WriteLine(array312[i]);
}
#endregion
#region Task 5
Console.WriteLine("Enter the amount of members of array ");
int d35;
int.TryParse(Console.ReadLine(), out d35);
int[] array35 = new int[d35];
for (int i = 0; i < d35; i++)
{
    Console.WriteLine($"Enter the  {i}  memeber ");
    int t35;
    int.TryParse(Console.ReadLine(), out t35);
    array35[i] = t35;
}
for (int i = 0; i < d35; i++)
{
    int amin = array35[i], imin = i;
    for (int j = i+2; j < d35; j += 2)
    {
        if(array35[j] < amin)
        {
            amin = array35[j];
            imin = j;
        }
    }
    array35[imin] = array35[i];
    array35[i] = amin;
}
for (int i = 0; i < d35; i++)
{
    Console.Write(array35[i]+ " ");
}
#endregion
#region Task 8
Console.WriteLine("Enter the amount of members of array ");
int d38,amax38,imax38;
int.TryParse(Console.ReadLine(), out d38);
int[] array38 = new int[d38];
for (int i = 0; i < d38; i++)
{
    Console.WriteLine($"Enter the  {i}  memeber ");
    int t38;
    int.TryParse(Console.ReadLine(), out t38);
    array38[i] = t38;
}
for(int i = 0; i < d38-1; i++)
{
    if (array38[i] < 0)
    {
        amax38 = array38[i];
        imax38 = i;
        for (int j = i + 1; j < d38; j++)
        {
            if (array38[j] < 0)
            {
                if (array38[j] > amax38)
                {
                    amax38 = array38[j];
                    imax38 = j;
                }
            }
        }
        array38[imax38]= array38[i];
        array38[i] = amax38;
    }
}
for(int i=0; i < d38; i++)
{
    Console.Write(array38[i]+" ");
}
#endregion
#region Task 9
Console.WriteLine("Enter the amount of members of array ");
int d39,g39=0,l39=0,amax=0;
int.TryParse(Console.ReadLine(), out d39);
int[] array39 = new int[d39];
for (int i = 0; i < d39; i++)
{
    Console.WriteLine($"Enter the  {i}  memeber ");
    int t39;
    int.TryParse(Console.ReadLine(), out t39);
    array39[i] = t39;
}
for (int i = 0; i < d39-1; i++)
{
    if (g39 > amax)
    {
        amax = g39;
    }
    if (l39 > amax)
    {
        amax=l39;
    }
    if (array39[i] > array39[i + 1])
    {
        l39++;
    }
    else
    {
        l39=0;
    }
    if(array39[i] < array39[i + 1])
    {
        g39++;
    }
    else
    {
        g39=0;
    }
}
Console.WriteLine($" Length {amax + 1}");

#endregion
#region Task 12
Console.WriteLine("Enter the amount of members of array ");
int d312;
int.TryParse(Console.ReadLine(), out d312);
int[] array312 = new int[d312];
for (int i = 0; i < d312; i++)
{
    Console.WriteLine($"Enter the  {i}  memeber ");
    int t312;
    int.TryParse(Console.ReadLine(), out t312);
    array312[i] = t312;
}
for(int i = 0; i < d312; i++)
{
    if(array312[i] < 0)
    {
        for (int j = i;  j < d312-1; j++)
        {
            array312[j] = array312[j+1];
        }
        d312--;
        i--;
    }
}
for (int j = 0; j < d312; j++)
{
    Console.Write(array312[j]+" ");
}
#endregion
#region Task 13
onsole.WriteLine("Enter the amount of members of array ");
int d313,r313;
int.TryParse(Console.ReadLine(), out d313);
int[] array313 = new int[d313];
for (int i = 0; i < d313; i++)
{
    Console.WriteLine($"Enter the  {i}  memeber ");
    int t313;
    int.TryParse(Console.ReadLine(), out t313);
    array313[i] = t313;
}
for(int i = 0; i < d313-1; i++)
{
    r313=array313[i];
    for(int j = i+1; j < d313; j++)
    {
        if(array313[j] == r313)
        {
            array313[i] = 0;
            array313[j] = 0;
        }    
    }
}
for(int i = 0; i < d313; i++)
{
    Console.Write(array313[i] + " ");
}
#endregion
#endregion
#region Algoritms
#region 11
int n;
Console.Write("Enter length of array (n): ");
if (int.TryParse(Console.ReadLine(), out n))
{
    int[] a = new int[n];
    Console.WriteLine("Enter elements of array: ");
    for (int j = 0; j < n; j++)
    {
        int.TryParse(Console.ReadLine(), out a[j]);
    }

    for (int j = 0; j < n - 1; j++)
    {
        int min_a = a[j];
        int min_i = j;

        for (int q = j + 1; q < n; q++)
        {
            if (min_a > a[q])
            {
                min_a = a[q];
                min_i = q;
            }
        }

        a[min_i] = a[j];
        a[j] = min_a;
    }

    int x = 0;
    Console.Write("Enter X: ");
    int.TryParse(Console.ReadLine(), out x);

    int i, i1, i2;
    i1 = 0;
    i2 = n - 1;

    while (true)
    {
        i = (i1 + i2) / 2;

        if (i2 < i1)
        {
            Console.WriteLine("Array doesn't contain X");
            break;
        }

        if (x == a[i])
        {
            Console.WriteLine($"Answer: element rqual Х is its number - {i}");
            break;
        }

        else if (x < a[i])
        {
            i2 = i - 1;
            continue;
        }

        else if (x > a[i])
        {
            i1 = i + 1;
            continue;
        }
    }
}
#endregion
#region 12
int n, m;
Console.Write("Enter length array A");
int.TryParse(Console.ReadLine(), out n);

Console.Write("Enter length array B");
int.TryParse(Console.ReadLine(), out m);

if (n == m)
{
    int[] a = new int[n];
    int[] b = new int[m];

    Console.WriteLine("Enter elements of array A");
    for (int i = 0; i < n; i++)
    {
        int.TryParse(Console.ReadLine(), out a[i]);
    }

    Console.WriteLine("Enter elements of array B");
    for (int i = 0; i < m; i++)
    {
        int.TryParse(Console.ReadLine(), out b[i]);
    }

    int[] c = new int[2 * n];

    int a_i = 0;
    int b_i = 0;

    for (int i = 0; i < 2 * n; i++)
    {
        if (i % 2 == 0)
        {
            c[i] = a[a_i];
            a_i++;
        }
        else
        {
            c[i] = b[b_i];
            b_i++;
        }
    }

    Console.WriteLine("Final array C");
    for (int i = 0; i < 2 * n; i++)
    {
        Console.WriteLine(c[i]);
    }
}

if (n < m)
{
    int[] a = new int[n];
    int[] b = new int[m];

    Console.WriteLine("Enter elements of array A");
    for (int i = 0; i < n; i++)
    {
        int.TryParse(Console.ReadLine(), out a[i]);
    }

    Console.WriteLine("Enter elements of array B");
    for (int i = 0; i < m; i++)
    {
        int.TryParse(Console.ReadLine(), out b[i]);
    }

    int[] c = new int[n + m];

    int a_i = 0;
    int b_i = 0;

    for (int i = 0; i < 2 * n; i++)
    {
        if (i % 2 == 0)
        {
            c[i] = a[a_i];
            a_i++;
        }
        else
        {
            c[i] = b[b_i];
            b_i++;
        }
    }

    b_i = n;
    for (int i = 2 * n; i < n + m; i++)
    {
        c[i] = b[b_i];
        b_i++;

    }

    Console.WriteLine("Final array C");
    for (int i = 0; i < n + m; i++)
    {
        Console.WriteLine(c[i]);
    }
}
else
{
    int[] a = new int[n];
    int[] b = new int[m];

    Console.WriteLine("Enter elements of array A");
    for (int i = 0; i < n; i++)
    {
        int.TryParse(Console.ReadLine(), out a[i]);
    }

    Console.WriteLine("Enter elements of array B");
    for (int i = 0; i < m; i++)
    {
        int.TryParse(Console.ReadLine(), out b[i]);
    }

    int[] c = new int[n + m];

    int a_i = 0;
    int b_i = 0;

    for (int i = 0; i < 2 * m; i++)
    {
        if (i % 2 == 0)
        {
            c[i] = a[a_i];
            a_i++;
        }
        else
        {
            c[i] = b[b_i];
            b_i++;
        }
    }

    a_i = m;
    for (int i = 2 * m; i < n + m; i++)
    {
        c[i] = a[a_i];
        a_i++;

    }

    Console.WriteLine("Final array C");
    for (int i = 0; i < n + m; i++)
    {
        Console.WriteLine(c[i]);
    }
}
#endregion
#region 13
int n, m;
Console.Write("Enter length of array A: ");
int.TryParse(Console.ReadLine(), out n);
Console.Write("Enter length of array B: ");
int.TryParse(Console.ReadLine(), out m);
int[] a = new int[n];
int[] b = new int[m];
int[] c = new int[n + m];
Console.WriteLine("Enter elements of array A: ");
for (int i = 0; i < n; i++)
{
    int.TryParse(Console.ReadLine(), out a[i]);
}
Console.WriteLine("Enter elements of array B: ");
for (int i = 0; i < m; i++)
{
    int.TryParse(Console.ReadLine(), out b[i]);
}
for (int i = 0; i < n - 1; i++)
{
    int max_a = a[i];
    int max_i = i;
    for (int j = i + 1; j < n; j++)
    {
        if (a[j] > max_a)
        {
            max_a = a[j];
            max_i = j;
        }
    }
    a[max_i] = a[i];
    a[i] = max_a;
}
for (int i = 0; i < m - 1; i++)
{
    int max_a = b[i];
    int max_i = i;
    for (int j = i + 1; j < m; j++)
    {
        if (b[j] > max_a)
        {
            max_a = b[j];
            max_i = j;
        }
    }
    b[max_i] = b[i];
    b[i] = max_a;
}
int a_i = 0, b_i = 0, c_i = 0;
bool flag = true;
while (flag)
{
    while (a[a_i] >= b[b_i])
    {
        c[c_i] = a[a_i];
        a_i++;
        c_i++;

        if (a_i >= n)
        {
            flag = false;
            break;
        }
    }
    if (flag == false)
        break;
    while (a[a_i] < b[b_i])
    {
        c[c_i] = b[b_i];
        b_i++;
        c_i++;

        if (b_i >= m)
        {
            flag = false;
            break;
        }
    }
    if (flag == false)
        break;
}
if (b_i <= m)
{
    for (; b_i < m; b_i++)
    {
        c[c_i] = b[b_i];
        c_i++;
    }
}
if (a_i <= n)
{
    for (; a_i < n; a_i++)
    {
        c[c_i] = a[a_i];
        c_i++;
    }
}
Console.WriteLine("Final array: ");
for (int i = 0; i < n + m; i++)
{
    Console.WriteLine(c[i]);
}
#endregion
#region 14
int n;
Console.Write("Enter length of array A: ");
int.TryParse(Console.ReadLine(), out n);
int[] a = new int[n];
int savenum = 0;
Console.WriteLine("Enetr elements of array A: ");
for (int i = 0; i < n; i++)
{
    int.TryParse(Console.ReadLine(), out a[i]);
}
for (int i = 0; i < n / 2; i++)
{
    savenum = a[i];
    a[i] = a[n - (i + 1)];
    a[n - (i + 1)] = savenum;
}
Console.WriteLine("Final array: ");
for (int i = 0; i < n; i++)
{
    Console.WriteLine(a[i]);
}
#endregion
#region 15
int n, m;
Console.Write("Enter length of array: ");
int.TryParse(Console.ReadLine(), out n);
int[] a = new int[n];
Console.WriteLine("Enter elements of array: ");
for (int i = 0; i < n; i++)
{
    int.TryParse(Console.ReadLine(), out a[i]);
}
Console.Write("Enter, how much to shift right (m): ");
int.TryParse(Console.ReadLine(), out m);
int savenum = 0;
for (int i = 0; i < m; i++)
{
    savenum = a[n - 1];
    for (int j = n - 2; j >= 0; j--)
    {
        a[j + 1] = a[j];
    }
    a[0] = savenum;
}
Console.WriteLine("Final array: ");
for (int i = 0; i < n; i++)
{
    Console.WriteLine(a[i]);
}
#endregion
#endregion





            
            

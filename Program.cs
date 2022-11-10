using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Transactions;

#region lvl1

#region ex6
try
{
    double[] arr = new double[5];
    for (int i = 0; i < 5; i++)
    {
        Console.WriteLine($"enter x{i + 1}");
        arr[i] = double.Parse(Console.ReadLine());
    }

    Console.WriteLine("L = {0:f2}", Math.Sqrt(arr.Sum()));
}
catch(Exception)
{
    Console.WriteLine("Error"); 
}
#endregion

#region ex10

try
{
    double[] arr1 = new double[10];
    Console.WriteLine("enter P and Q");
    double p = double.Parse(Console.ReadLine());
    double q = double.Parse(Console.ReadLine());
    int k = 0;
    for (int i = 0; i < arr1.Length; i++)
    {
        Console.WriteLine($"enter {i + 1} number");
        arr1[i] = double.Parse(Console.ReadLine());
    }

    for (int i = 0; i < arr1.Length; i++)
    {
        if (p < q && arr1[i] > p && arr1[i] < q)
        {
            k += 1;
        }
        
        if (p > q && arr1[i] < p && arr1[i] > q)
        {
            k += 1;
        }
    }
    Console.WriteLine(k);

}
catch(Exception)
{
    Console.WriteLine("Error");
}
#endregion

#region ex11
try
{
    Console.WriteLine("enter length of 1st array");
    int n = int.Parse(Console.ReadLine());
    double[] array = new double[n];
    for (int i = 0; i < n; i++)
    {
        Console.WriteLine($"enter {i + 1} nuber");
        array[i] = double.Parse(Console.ReadLine());
    }
    double[] result = array.Where(i => i > 0).ToArray();
    for (int i = 0; i < result.Length; i++)
    {
        Console.Write(result[i]);
    }
    
}
catch(Exception)
{
    Console.WriteLine("Error");
}
#endregion

#region ex12

try
{
    double[] myarray = new double[8];
    for (int i = 0; i < 8; i++)
    {
        Console.WriteLine($"enter {i + 1} nuber");
        myarray[i] = double.Parse(Console.ReadLine());
    }
    if (Array.FindLast(myarray, i => i < 0) != 0)
        Console.WriteLine(Array.FindLast(myarray, i => i < 0));
    else
        Console.WriteLine("no negative numbers");
}
catch(Exception)
{
    Console.WriteLine("Error");
}

#endregion

#region ex13

try
{
    double[] arr2 = new double[10];
    double[] ch = new double[5];
    double[] nch = new double[5];
    int n1 = 0;
    int n2 = 0;
    for (int i = 0; i < arr2.Length; i++)
    {
        Console.WriteLine($"enter {i + 1} nuber");
        arr2[i] = double.Parse(Console.ReadLine());
    }
    for (int i = 0; i < arr2.Length; i++)
    {
        if (i % 2 == 0)
        {
            ch[n1] = arr2[i];
            n1++;
        }
        else
        {
            nch[n2] = arr2[i];
            n2++;
        }
    }
    Console.WriteLine("array = {0}, even = {1}, not even = {2}", string.Join(", ", arr2), string.Join(", ", ch), string.Join(", ", nch));
    
}
catch(Exception)
{
    Console.WriteLine("Error");
}
#endregion


#endregion

#region lvl2

#region ex5

try
{
    Console.WriteLine("enter the length of the array");
    int n = int.Parse(Console.ReadLine());
    double[] arr2 = new double[n];
    for (int i = 0; i < n; i++)
    {
        Console.Write($"enter {i + 1} element ");
        arr2[i] = double.Parse(Console.ReadLine());
    }
    double mn = arr2.Min();
    double mx = arr2.Max();
    int f1 = Array.FindIndex(arr2, i => i == mn);
    int f2 = Array.FindIndex(arr2, i => i == mx);
    double[] arr22 = new double[n];
    if (f2 > f1)
    {
        Array.Copy(arr2, f1 + 1, arr22, 0, f2 - f1 - 1);
        Console.WriteLine(string.Join(", ", arr22.Where(i => i < 0)));
    }
    if (f2 < f1)
    {
        Array.Copy(arr2, f2 + 1, arr22, 0, f1 - f2 - 1);
        Console.WriteLine(string.Join(", ", arr22.Where(i => i < 0)));
    }
}
catch(Exception)
{
    Console.WriteLine("Error");
}
#endregion

#region ex6

try
{
    Console.WriteLine("enter the length of the array");
    int n = int.Parse(Console.ReadLine());
    double[] arr6 = new double[n];
    double[] arr66 = new double[n + 1];
    for (int i = 0; i < n; i++)
    {
        Console.Write($"enter {i + 1} element ");
        arr6[i] = double.Parse(Console.ReadLine());
    }
    Console.Write("enter P ");
    double P = double.Parse(Console.ReadLine());
    double sr = arr6.Sum() / arr6.Length;
    double k6 = 10000000000;
    int k66 = 0;
    for (int i = 0; i < n; i++)
    {
        
        if (Math.Abs(arr6[i] - sr) < Math.Abs(k6))
        {
            k6 = arr6[i] - sr;
            k66 = i;
        }
    }
    Array.Copy(arr6, 0, arr66, 0, k66 + 1);
    arr66[k66 + 1] = P;
    Array.Copy(arr6, k66 + 1, arr66, k66 + 2, arr6.Length - k66 - 1);
    Console.WriteLine(string.Join(", ", arr66));

}
catch(Exception)
{
    Console.WriteLine("Error");
}

#endregion

#region ex9
try
{
    Console.WriteLine("enter the length of the array");
    int n = int.Parse(Console.ReadLine());
    double[] arr9 = new double[n];
    for (int i = 0; i < n; i++)
    {
        Console.Write($"enter {i + 1} element ");
        arr9[i] = double.Parse(Console.ReadLine());
    }
    double mn = arr9.Min();
    double mx = arr9.Max();
    int f1 = Array.FindIndex(arr9, i => i == mn);
    int f2 = Array.FindIndex(arr9, i => i == mx);
    double[] arr99 = new double[n];
    if (f2 > f1)
    {
        Array.Resize(ref arr99, f2 - f1 - 1);
        Array.Copy(arr9, f1 + 1, arr99, 0, f2 - f1 - 1);
        Console.WriteLine(String.Join(", ", arr99));
        Console.WriteLine(arr99.Sum() / arr99.Length);
    }
    if (f2 < f1)
    {
        Array.Resize(ref arr99, f1 - f2 - 1);
        Array.Copy(arr9, f2 + 1, arr99, 0, f1 - f2 - 1);
        Console.WriteLine(String.Join(", ", arr99));
        Console.WriteLine(arr99.Sum() / arr99.Length);
    }
}
catch(Exception)
{
    Console.WriteLine("Error");
}
#endregion

#region ex10
try
{
    Console.WriteLine("enter the length of the array");
    int n = int.Parse(Console.ReadLine());
    double[] arr10 = new double[n];
    double[] arr1010 = new double[n - 1];
    for (int i = 0; i < n; i++)
    {
        Console.Write($"enter {i + 1} element ");
        arr10[i] = double.Parse(Console.ReadLine());
    }
    double k10 = arr10.Where(i => i > 0).Min();
    int k1010 = Array.FindIndex(arr10, i => i == k10);

    Array.Copy(arr10, 0, arr1010, 0, k1010);
    Array.Copy(arr10, k1010 + 1, arr1010, k1010, arr1010.Length - k1010);
    Console.WriteLine(string.Join(", ", arr1010));

}
catch (Exception)
{
    Console.WriteLine("Error");
}
#endregion


#region ex11

try
{
    Console.WriteLine("enter the length of the array");
    int n = int.Parse(Console.ReadLine());
    double[] arr11 = new double[n];
    double[] arr1111 = new double[n + 1];
    for (int i = 0; i < n; i++)
    {
        Console.Write($"enter {i + 1} element ");
        arr11[i] = double.Parse(Console.ReadLine());
    }
    Console.Write("enter P ");
    double P = double.Parse(Console.ReadLine());
    int k1111 = Array.FindLastIndex(arr11, i => i > 0);
    
    Array.Copy(arr11, 0, arr1111, 0, k1111 + 1);
    arr1111[k1111 + 1] = P;
    Array.Copy(arr11, k1111 + 1, arr1111, k1111 + 2, arr11.Length - k1111 - 1);
    Console.WriteLine(string.Join(", ", arr1111));

}
catch (Exception)
{
    Console.WriteLine("Error");
}

#endregion

#region ex13

try
{
    Console.WriteLine("enter the length of the array");
    int n = int.Parse(Console.ReadLine());
    double[] arr13 = new double[n];
    int k13 = 0;
    for (int i = 0; i < n; i++)
    {
        Console.Write($"enter {i + 1} element ");
        arr13[i] = double.Parse(Console.ReadLine());
    }
    if (arr13.Length > 2)
    {
        for (int i = 0; i < n - 2; i += 2)
        {
            if (arr13[i] < arr13[i + 2])
                k13 = i + 2;
        }
    }
    else
    {
        arr13[k13] = k13;
    }

    arr13[k13] = k13;
    Console.WriteLine(string.Join(", ", arr13)); 
}
catch (Exception)
{
    Console.WriteLine("Error");
}

#endregion

#region

try
{
    Console.WriteLine("enter the length of the 1st array");
    int n = int.Parse(Console.ReadLine());
    
    Console.WriteLine("enter the length of the 2nd array");
    int m = int.Parse(Console.ReadLine());

    double[] A = new double[n];
    double[] B = new double[m];
    double[] AB = new double[n + m];
    for (int i = 0; i < n; i++)
    {
        Console.Write($"enter {i + 1} element of 1st array");
        A[i] = double.Parse(Console.ReadLine());
    }
    for (int i = 0; i < m; i++)
    {
        Console.Write($"enter {i + 1} element of 2nd array");
        B[i] = double.Parse(Console.ReadLine());
    }

    Console.WriteLine("enter k");
    int k = int.Parse(Console.ReadLine());

    Array.Copy(A, 0, AB, 0, k + 1);
    Array.Copy(B, 0, AB, k + 1, B.Length);
    Array.Copy(A, k + 1, AB, k + B.Length + 1, A.Length - k - 1);
    Console.WriteLine(string.Join(", ", AB));


}
catch(Exception)
{
    Console.WriteLine("Error");
}
#endregion

#endregion

#region lvl3

#region ex1
try
{
    Console.WriteLine("enter the length of the array");
    int n = int.Parse(Console.ReadLine());
    double[] arr1 = new double[n];
    for (int i = 0; i < n; i++)
    {
        Console.Write($"enter {i + 1} element ");
        arr1[i] = double.Parse(Console.ReadLine());
    }
    double mx1 = arr1.Max();
    double[] mx11 = Array.FindAll(arr1, i => i == mx1);
    for (int i = 0; i < arr1.Length; i++)
    {
        if (mx1 == arr1[i])
        {
            mx11[i] = i;
        }
    }
    Console.WriteLine(string.Join(", ", mx11));
}
catch(Exception)
{
    Console.WriteLine("Error");
}

#endregion

#region ex5
try
{
    Console.WriteLine("enter the length of the array");
    int n = int.Parse(Console.ReadLine());
    double[] arr5 = new double[n];
    int k5 = 0;
    int k55 = 0;
    double[] arr55 = new double[n];
    for (int i = 0; i < n; i++)
    {
        Console.Write($"enter {i + 1} element ");
        arr5[i] = double.Parse(Console.ReadLine());
    }
    if (n % 2 == 0)
    {
        Array.Resize(ref arr55, n / 2);
        for (int i = 0; i < n; i += 2)
        {
            arr55[k55] = arr5[i];
            k55++;
        }
        
    }
    else
    {
        Array.Resize(ref arr55, n / 2 + 1);
        for (int i = 0; i < n; i += 2)
        {
            arr55[k55] = arr5[i];
            k55++;
        }
    }

    Array.Sort(arr55);
    
    
    for (int i = 0; i < n; i += 2)
    {
        arr5[i] = arr55[k5];
        k5++;
    }
    Console.WriteLine(string.Join(", ", arr5));
}
catch(Exception)
{
    Console.WriteLine("Error");
}
#endregion

#region ex8

try
{
    Console.WriteLine("enter the length of the array");
    int n = int.Parse(Console.ReadLine());
    double[] arr8 = new double[n];
    int k8 = 0;
    for (int i = 0; i < n; i++)
    {
        Console.Write($"enter {i + 1} element ");
        arr8[i] = double.Parse(Console.ReadLine());
    }
    double[] arr88 = arr8.Where(i => i < 0).ToArray();
    Array.Sort(arr88);
    Array.Reverse(arr88);
    for (int i = 0; i < n; i++)
    {
        if (arr8[i] < 0)
        {
            arr8[i] = arr88[k8];
            k8++;
        }
    }
    Console.WriteLine(string.Join(", ", arr8));
}
catch(Exception)
{
    Console.WriteLine("Error");
}

#endregion


#region ex9

try
{
    Console.WriteLine("enter the length of the array");
    int n = int.Parse(Console.ReadLine());
    double[] arr9 = new double[n];
    int k9 = 1;
    int k99 = 1;
    int mx = 0;
    for (int i = 0; i < n; i++)
    {
        Console.Write($"enter {i + 1} element ");
        arr9[i] = double.Parse(Console.ReadLine());
    }
    for (int i = 0; i < n - 1; i++)
    {
        if (arr9[i] + 1 == arr9[i + 1])
        {
            k9 += 1;
        }
        else
        {
            if (k9 > mx)
                mx = k9;
            k9 = 1;
        }
    }
    for (int i = 0; i < n - 1; i++)
    {
        if (arr9[i] == arr9[i + 1] + 1)
        {
            k99 += 1;
        }
        else
        {
            if (k99 > mx)
                mx = k99;
            k99 = 1;
        }
    }
    Console.WriteLine(mx);
}
catch(Exception)
{
    Console.WriteLine("Error");
}
#endregion


#region ex12

try
{
    int n = 12;
    double[] arr12 = new double[n];
    for (int i = 0; i < n; i++)
    {
        Console.Write($"enter {i + 1} element ");
        arr12[i] = double.Parse(Console.ReadLine());
    }
    double[] result = arr12.Where(i => i > 0).ToArray();
    Console.WriteLine(string.Join(", ", result));
}
catch(Exception)
{
    Console.WriteLine("Error");
}
#endregion


#region ex13

try
{
    Console.WriteLine("enter the length of the array");
    int n = int.Parse(Console.ReadLine());
    double[] arr13 = new double[n];
    for (int i = 0; i < n; i++)
    {
        Console.Write($"enter {i + 1} element ");
        arr13[i] = double.Parse(Console.ReadLine());
    }

    Console.WriteLine(string.Join(", ", arr13.Distinct().ToArray()));
}
catch(Exception)
{
    Console.WriteLine("Error");
}
#endregion

#endregion

#region theory

#region ex11
try
{

    Console.WriteLine("enter the length of the array");
    int n = int.Parse(Console.ReadLine());
    double[] a = new double[n];
    Console.WriteLine("enter x");
    double x = double.Parse(Console.ReadLine());
    for (int i = 0; i < n; i++)
    {
        Console.Write($"enter {i + 1} element ");
        a[i] = double.Parse(Console.ReadLine());
    }
    Array.Sort(a);
    int result = Array.FindIndex(a, i => i == x);
    if (result == -1)
        Console.WriteLine("No element");
    else
        Console.WriteLine(result);
}
catch(Exception)
{
    Console.WriteLine("Error");
}


#endregion

#region ex12
try
{
    Console.WriteLine("enter the length of the 1st array");
    int n = int.Parse(Console.ReadLine());

    Console.WriteLine("enter the length of the 2nd array");
    int m = int.Parse(Console.ReadLine());

    double[] A = new double[n];
    double[] B = new double[m];
    double[] AB = new double[n + m];
    int k = 0;
    for (int i = 0; i < n; i++)
    {
        Console.Write($"enter {i + 1} element of 1st array");
        A[i] = double.Parse(Console.ReadLine());
    }
    for (int i = 0; i < m; i++)
    {
        Console.Write($"enter {i + 1} element of 2nd array");
        B[i] = double.Parse(Console.ReadLine());
    }
    if (n == m)
    {
        for (int i = 0; i < AB.Length - 1; i += 2)
        {
            AB[i] = A[k];
            AB[i + 1] = B[k];
            k++;
            
        }
        Console.WriteLine(String.Join(", ", AB));
    }
    if (n < m)
    {
        Array.Resize(ref A, n);
        Array.Resize(ref AB, n * 2);
        for (int i = 0; i < AB.Length - 1; i += 2)
        {
            AB[i] = A[k];
            AB[i + 1] = B[k];
            k++;
        }
        Console.WriteLine(String.Join(", ", AB));
    }
    if (n > m)
    {
        Array.Resize(ref B, m);
        Array.Resize(ref AB, m * 2);
        for (int i = 0; i < AB.Length - 1; i += 2)
        {
            AB[i] = A[k];
            AB[i + 1] = B[k];
            k++;
        }
        Console.WriteLine(String.Join(", ", AB));
    }

}
catch(Exception)
{
    Console.WriteLine("Error");
}
#endregion

#region ex13
try
{
    Console.WriteLine("enter the length of the 1st array");
    int n = int.Parse(Console.ReadLine());

    Console.WriteLine("enter the length of the 2nd array");
    int m = int.Parse(Console.ReadLine());

    double[] A = new double[n];
    double[] B = new double[m];
    double[] AB = new double[n + m];
    int k = 0;
    for (int i = 0; i < n; i++)
    {
        Console.Write($"enter {i + 1} element of 1st array");
        A[i] = double.Parse(Console.ReadLine());
    }
    for (int i = 0; i < m; i++)
    {
        Console.Write($"enter {i + 1} element of 2nd array");
        B[i] = double.Parse(Console.ReadLine());
    }
    Array.Copy(A, 0, AB, 0, n);
    Array.Copy(B, 0, AB, n, m);
    Array.Sort(AB);
    Array.Reverse(AB);
    Console.WriteLine(string.Join(", ", AB));
}
catch(Exception)
{
    Console.WriteLine("Error");
}
#endregion

#region ex14
try
{
    Console.WriteLine("enter the length of the array");
    int n = int.Parse(Console.ReadLine());
    double[] a = new double[n];
    for (int i = 0; i < n; i++)
    {
        Console.Write($"enter {i + 1} element ");
        a[i] = double.Parse(Console.ReadLine());
    }
    Array.Sort(a);
    Array.Reverse(a);
    double a1 = a[n / 2 + 1];
    double b1 = a[n / 2];
    a[n / 2] = a1;
    a[n / 2 + 1] = b1;
    Console.WriteLine(string.Join(", ", a));

}
catch(Exception)
{
    Console.WriteLine("Error");
}
#endregion


#region ex15
try
{
    Console.WriteLine("enter the length of the array");
    int n = int.Parse(Console.ReadLine());
    double[] a = new double[n];
    double[] b = new double[n];
    Console.WriteLine("enter m");
    int m = int.Parse(Console.ReadLine());
    for (int i = 0; i < n; i++)
    {
        Console.Write($"enter {i + 1} element ");
        a[i] = double.Parse(Console.ReadLine());
    }
    Array.Copy(a, 0, b, m, n - m);
    Array.Copy(a, m + 1, b, 0, m);
    Console.WriteLine(string.Join(", ", b));
}
catch(Exception)
{
    Console.WriteLine("Error");
}
#endregion

#endregion
using System;
using System.Diagnostics.Metrics;
// Nizamiev, Laboratorka N3
namespace Lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            ////LVL 1, TSK 6
            //double[] a = new double[] { 1, 2, 3, 4, 5 };
            //double s = 0, l = 0;
            //for (int i = 0; i < a.Length; i++)
            //{
            //    if (i < a.Length)
            //    {
            //        s += Math.Pow(a[i], 2);
            //    }
            //    l = Math.Sqrt(s);
            //}
            //Console.WriteLine(l);



            ////LVL 1, TSK 10
            //double[] a = new double[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //double p = 4, q = 7, x = 0;
            //for (int i = 0; i < a.Length; i++)
            //{
            //    if (a[i] < q & a[i] > p)
            //    {
            //        x++;
            //    }
            //}
            //Console.WriteLine(x);


            ////LVL 1, TSK 11
            //double[] a = new double[] { 1, -2, 3, -4, 5, -6, 7, -8, 9, -10 };
            //double[] b = new double[10];
            //for (int i = 0; i < a.Length; i++)
            //{
            //    if (a[i] > 0)
            //    {
            //        b[i] = a[i];
            //        Console.WriteLine(b[i]);
            //    }
            //}


            ////LVL 1, TSK 12
            //double[] a = new double[] { 1, -2, 3, -4, 5, -6, 7, -8, 9, 10 };
            //for (int i = 9; i > 0; i--)
            //{
            //    if (a[i] < 0)
            //    {
            //        Console.WriteLine($"Amount: {a[i]}; Number = {i}");
            //        break;
            //    }
            //}


            ////LVL 1, TSK 13
            //double[] a = new double[] { 1, -2, 3, -4, 5, -6, 7, -8, 9, 10 };
            //double[] b = new double[10];
            //double[] c = new double[10];
            //for (int i = 0; i < a.Length; i++)
            //{
            //    if ((i + 1) % 2 == 0)
            //    {
            //        b[i] = a[i];
            //        Console.WriteLine($"first massive with count: {b[i]}");
            //    }
            //    else
            //    {
            //        c[i] = a[i];
            //        Console.WriteLine($"second massive with uncount: {c[i]}");
            //    }
            //}


            /////////////////LVL2///////////////////////////////


            ////LVL 2, TSK 5

            //double[] a = new double[] { -1, -2, -10, -3, -4, -5, 3, -7, 8, -9 };
            //double[] b = new double[10];
            //double max = 0, min = 10000;
            //int nummin = 0, numplus = 0;
            //for (int i = 0; i < a.Length; i++)
            //{
            //    if (max < a[i])
            //    {
            //        max = a[i];
            //        numplus = i;
            //    }
            //}
            //for (int i = 0; i < a.Length; i++)
            //{
            //    if (min > a[i])
            //    {
            //        min = a[i];
            //        nummin = i;
            //    }
            //}
            //for (int i = nummin + 1; i < numplus; i++)
            //{
            //    if (a[i] < 0)
            //    {
            //        b[i] = a[i];
            //        Console.WriteLine(b[i]);
            //    }
            //}


            ////LVL 2, TSK 6

            //double[] a = new double[] { 2.5, 3, 4, 5, 6, 7, 8, 1, 9, 10, -1 }; 
            //double[] b = new double[11];
            //double p = 1000;
            //double sum = 0, mid = 0, min = 10000;
            //int nummin = 0;
            //for (int i = 0; i < a.Length; i++)
            //{
            //    sum += a[i];
            //    mid = sum / a.Length;
            //}
            //for (int i = 0; i < a.Length; i++)
            //{
            //    if (min > Math.Abs(a[i] - mid))
            //    {
            //        min = Math.Abs(a[i] - mid);
            //        nummin = i;
            //    }
            //}
            //for (int i = a.Length - 1; i > nummin + 1; i--)
            //{
            //    a[i] = a[i - 1];
            //}
            //a[nummin + 1] = p;
            //for (int i = 0; i < a.Length; i++)
            //{
            //    Console.WriteLine(a[i]);
            //}



            ////LVL 2, TSK 9

            //double[] a = new double[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //double max = 0, min = 10000, cred = 0, sum = 0;
            //int nummin = 0, numplus = 0;
            //for (int i = 0; i < a.Length; i++)
            //{
            //    if (max < a[i])
            //    {
            //        max = a[i];
            //        numplus = i;
            //    }
            //}
            //for (int i = 0; i < a.Length; i++)
            //{
            //    if (min > a[i])
            //    {
            //        min = a[i];
            //        nummin = i;
            //    }
            //}
            //if (nummin > numplus)
            //{
            //    for (int j = numplus + 1; j < nummin; j++)
            //    {
            //        sum += a[j];
            //        cred = sum / (nummin - 1 - numplus);
            //    }
            //}
            //else if (nummin < numplus)
            //{
            //    for (int j = nummin + 1; j < numplus; j++)
            //    {
            //        sum += a[j];
            //        cred = sum / (numplus - 1 - nummin);
            //    }
            //}
            //Console.WriteLine(cred);



            ////LVL 2, TSK 10

            //double[] a = new double[] { 2.5, 3, 4, -5, 6, 7, 8, 1, -9, 10 };
            //double min = a[0];
            //int nummin = 0;
            //for (int i = 0; i < a.Length; i++)
            //{
            //    if (min > a[i] & a[i] > 0)
            //    {
            //        min = a[i];
            //        nummin = i;
            //    }
            //}
            //for (int i = nummin; i < a.Length - 1; i++)
            //{
            //    a[i] = a[i + 1];
            //}
            //for (int i = 0; i < a.Length - 1; i++)
            //{
            //    Console.WriteLine(a[i]);
            //}


            ////LVL 2, TSK 11

            //double[] a = new double[] { 2.5, 3, 4, -5, 6, 7, 8, 1, -9, -10, 0 };
            //double p = 100;
            //int num = 0;
            //for (int i = a.Length - 1; i >= 0; i--)
            //{
            //    if (a[i] > 0)
            //    {
            //        num = i;
            //        break;
            //    }
            //}
            //for (int i = a.Length - 1; i > num + 1; i--)
            //{
            //    a[i] = a[i - 1];
            //}
            //a[num + 1] = p;
            //for (int i = 0; i < a.Length; i++)
            //{
            //    Console.WriteLine(a[i]);
            //}



            ////LVL 2, TSK 13

            //double[] a = new double[] { 2.5, 3, 4, -5, 6, 7, 8, 1, -9, -10 };
            //double max = 0;
            //int numplus = 0;
            //for (int i = 0; i < a.Length; i++)
            //{
            //    if (max < a[i] & (i + 1) % 2 == 0)
            //    {
            //        max = a[i];
            //        numplus = i;
            //        a[numplus] = i + 1;
            //    }
            //    Console.WriteLine(a[i]);
            //}



            ////LVL 2, TSK 15

            //Console.Write("Enter count of elements in first massive: ");
            //int m = int.Parse(Console.ReadLine());
            //double[] a = new double[m]; 
            //Console.Write("Enter count of elements in second massive: ");
            //int n = int.Parse(Console.ReadLine()); 
            //double[] b = new double[n + m + 1]; 
            //Console.Write("Enter k, after which the array will be inserted a: ");
            //int k = int.Parse(Console.ReadLine()); 
            //int z = 1, q = 0;
            //for (int i = 0; i < a.Length; i++)
            //{
            //    Console.Write($"Enter {i + 1} non-zero element of the first array: ");
            //    a[i] = double.Parse(Console.ReadLine()); 
            //    z++;
            //}
            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write($"Enter {i + 1} non-zero element of the second array: ");
            //    b[i] = double.Parse(Console.ReadLine()); 
            //}
            //for (int i = z; i < z + n; i++) 
            //{
            //    b[i] = 0;
            //}
            //for (int j = 0; j < m; j++)
            //{
            //    for (int i = b.Length - 1; i > 0; i--) 
            //    {
            //        b[i] = b[i - 1];
            //    }
            //}
            //for (int i = 0; i < m; i++) 
            //{
            //    b[k + q] = a[i];
            //    q++;
            //}
            //for (int i = 0; i < b.Length; i++)
            //{
            //    if (b[i] != 0)
            //    {
            //        Console.WriteLine(b[i]);
            //    }
            //}


            /////////////////LVL3///////////////////////////////



            ////LVL 3, TSK 1

            //double[] a = new double[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
            //double max = 0, first = 0;
            //int numplus = 0;
            //for (int i = 0; i < a.Length; i++)
            //{
            //    if (max < a[i])
            //    {
            //        max = a[i];
            //        numplus = i;
            //    }
            //}
            //for (int i = 0; i < a.Length; i += 2)
            //{
            //    if (i < numplus)
            //    {
            //        first = a[i];
            //        a[i] = a[i + 1];
            //        a[i + 1] = first;
            //    }
            //}
            //for (int i = 0; i < a.Length; i++)
            //{
            //    Console.WriteLine(a[i]);
            //}


            ////LVL3, TSK 5

            //int n = 10;
            //int[] a = new int[10] { -1, 7, 8, -5, 9, -6, 5, -7, -4, 2 };
            //int min = 0;
            //int imin = 0;

            //for (int i = 0; i < n - 2; i = i + 2)
            //{
            //    min = a[i];
            //    imin = i;
            //    for (int j = i + 2; j < n; j = j + 2)
            //    {
            //        if (a[j] < min)
            //        {
            //            min = a[j];
            //            imin = j;
            //        }
            //    }
            //    a[imin] = a[i];
            //    a[i] = min;

            //}

            //for (int i = 0; i < n; i++)
            //{
            //    Console.WriteLine(a[i]);
            //}


            ////LVL3, TSK 8

            //int n = 10;
            //int[] a = new int[10] { -1, 7, 8, -7, 9, -8, 5, -2, 4, 2 };
            //int min = 0;
            //int imin = 0;

            //for (int i = 0; i < n - 1; i++)
            //{
            //    if (a[i] < 0)
            //    {
            //        min = a[i];
            //        imin = i;
            //        for (int j = i + 1; j < n; j++)
            //        {
            //            if (a[j] > min && a[j] < 0)
            //            {
            //                min = a[j];
            //                imin = j;
            //            }
            //        }
            //        a[imin] = a[i];
            //        a[i] = min;
            //    }
            //}

            //for (int i = 0; i < n; i++)
            //{
            //    Console.WriteLine(a[i]);
            //}


            ////LVL3, TSK 9

            //int n = 12;
            //int[] a = new int[12] { -2, 7, 8, 10, -7, -9, 9, -8, 5, -1, 4, 2 };
            //int k = 1;
            //int k1 = 0;
            //int p = 1;
            //int p1 = 0;

            //for (int i = 0; i < n - 1; i++)
            //{
            //    if (a[i] < a[i + 1])
            //    {
            //        k++;
            //        if (k > k1)
            //        {
            //            k1 = k;
            //        }
            //    }
            //    else
            //    {
            //        k1 = k1;
            //        k = 1;
            //    }
            //}

            //for (int i = 0; i < n - 1; i++)
            //{
            //    if (a[i] > a[i + 1])
            //    {
            //        p++;
            //        if (p > p1)
            //        {
            //            p1 = p;
            //        }
            //    }
            //    else
            //    {
            //        p1 = p1;
            //        p = 1;
            //    }
            //}

            //if (k1 > p1)
            //{
            //    Console.WriteLine(k1);
            //}
            //else
            //{
            //    Console.WriteLine(p1);
            //}


            ////LVL3, TSK 12

            //int n = 12;
            //int[] a = new int[12] { -2, 7, 8, -3, -7, 9, -8, 5, 6, -1, 4, 2 };
            //int ind = 0;

            //for (int i = 0; i < n; i++)
            //{
            //    if (a[i] < 0)
            //    {
            //        ind = i;
            //        for (int j = ind; j < n - 1; j++)
            //        {
            //            a[j] = a[j + 1];
            //        }
            //        n--;
            //        i--;
            //    }


            //}

            //for (int i = 0; i < n; i++)
            //{
            //    Console.WriteLine(a[i]);
            //}


            ////LVL3, TSK 13

            //int n = 12;
            //int[] a = new int[12] { -2, 7, 8, -2, -7, 9, -8, 5, 7, -1, 9, 2 };


            //for (int i = 0; i < 11; i++)
            //{
            //    int p = i + 1;
            //    int y = 12;
            //    while (p < y)
            //    {
            //        if (a[i] == a[p])
            //        {
            //            for (int k = p; k < 11; k++)
            //            {
            //                a[k] = a[k + 1];
            //            }
            //            a[11] = 0;
            //            p--;
            //            y--;


            //        }
            //        else
            //        {
            //            p++;
            //        }
            //    }

            //}

            //for (int i = 0; i < 9; i++)
            //{
            //    Console.Write(a[i] + " ");

            //}
            //Console.WriteLine();


            /////////////////Additional///////////////////////////////
            ////TSK 11
            //int[] a = new int[8] { 0, 1, 2, 3, 4, 5, 6, 7 };
            //int x = 5;
            //int n = 8;
            //int ser = 0;
            //int l = 0;
            //int r = n - 1;

            //for (int i = 0; i < n; i++)
            //{
            //    ser = (l + r) / 2;
            //    if (x == a[ser])
            //    {
            //        Console.WriteLine("done");
            //        Console.WriteLine(ser);
            //        break;
            //    }
            //    if (x > a[ser])
            //    {
            //        l = ser;
            //    }
            //    if (x < a[ser])
            //    {
            //        r = ser;
            //    }
            //    if (Math.Abs(l - r) <= 1)
            //    {
            //        Console.WriteLine("element not in array");
            //        break;
            //    }
            //}


            ////TSK 12
            //int[] a = new int[4] { 0, 2, 4, 6 };
            //int[] b = new int[4] { 1, 3, 5, 7 };
            //int[] c = new int[8];

            //int ia = 0, ib = 0;

            //for (int i = 0; i < 8; i = i + 2)
            //{
            //    c[i] = a[ia];
            //    ia++;

            //}

            //for (int i = 1; i < 8; i = i + 2)
            //{
            //    c[i] = b[ib];
            //    ib++;
            //}


            //for (int i = 0; i < 8; i++)
            //{
            //    Console.Write(c[i] + " ");
            //}
            //Console.WriteLine();

            ////TSK 13
            //int n = 8;
            //int m = 4;

            //int[] a = new int[8] { 8, 6, 4, 2, 0, 7, 4, 3 };
            //int[] b = new int[4] { 7, 5, 3, 1 };
            //int[] c = new int[n + m];

            //int i = 0;
            //int j = 0;
            //int k = 0;

            //while (i < n && j < m)
            //{
            //    if (a[i] > b[j])
            //    {
            //        c[k] = a[i];
            //        k++;
            //        i++;
            //    }
            //    else
            //    {
            //        c[k] = b[j];
            //        k++;
            //        j++;
            //    }
            //    if (i == n)
            //    {
            //        while (j < m)
            //        {
            //            c[k] = b[j];
            //            k++;
            //            j++;
            //        }
            //    }
            //    if (j == m)
            //    {
            //        while (i < n)
            //        {
            //            c[k] = a[i];
            //            k++;
            //            i++;
            //        }
            //    }
            //}

            //for (int p = 0; p < 13; p++)
            //{
            //    Console.Write(c[p] + " ");
            //}
            //Console.WriteLine();


            ////TSK 14
            //int[] a = new int[4] { 0, 2, 4, 6 };
            //int[] b = new int[4] { 1, 3, 5, 7 };
            //int[] c = new int[8];

            //int j = 0;

            //for (int i = 0; i < 8; i = i + 2)
            //{
            //    c[i] = a[j];
            //    c[i + 1] = b[j];
            //    j++;
            //}

            //for (int i = 0; i < 8; i++)
            //{
            //    Console.Write(c[i] + " ");
            //}
            //Console.WriteLine();


            ////TSK 15
            //int[] a = new int[8] { 1, 5, 7, 3, 9, 5, 3, 7 };
            //int n = 7;
            //int m = 3;
            //int b = 0;


            //for (int i = 0; i < m; i++)
            //{
            //    b = a[n];
            //    for (int j = 7; j > 0; j--)
            //    {
            //        a[j] = a[j - 1];
            //    }
            //    a[0] = b;
            //}


            //for (int p = 0; p < 8; p++)
            //{
            //    Console.Write(a[p] + " ");
            //}
            //Console.WriteLine();

        }
    }
}

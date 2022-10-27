using System;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Threading;
using System.Collections.Generic;

namespace _3rd_Lab
{
    class Theory
    {
        static int Binary_search(double[] arr, int l, int r, double x)
        {
            if (arr[l] == x)
            {
                return l;
            }
            if (arr[r] == x)
            {
                return r;
            }
            if (l + 1 == r)
            {
                return -1;
            }
            if (arr[(l + r) / 2] == x)
            {
                return (l + r) / 2;
            }
            else if (arr[(l + r) / 2] < x)
            {
                return Binary_search(arr, (l+r) / 2, r, x);
            }
            else
            {
                return Binary_search(arr, l, (l+r) / 2, x);
            }
        }
        static void Main(string[] args)
        {
            
            #region Lvl_1
            #region Num_6
            {
                double[] arr = new double[5];
                double len_arr;
                double sum = 0;
                for (int i = 0; i < arr.Length; ++i)
                {
                    if ((double.TryParse(Console.ReadLine(), out double poh)) && (poh > 0))
                    {
                        arr[i] = poh;
                        sum += Math.Pow(poh, 2);
                    }
                    else
                    {
                        Console.WriteLine("Error");
                    }
                }
                Console.WriteLine($"len = {len_arr = Math.Sqrt(sum)}");
            }
            #endregion

            #region Num_10
            {
                double[] arr = new double[10];
                int count = 0;
                if (double.TryParse(Console.ReadLine(), out double p))
                {
                    if ((double.TryParse(Console.ReadLine(), out double q)) && (q > p))
                    {
                        for (int i = 0; i < arr.Length; ++i)
                        {
                            if (double.TryParse(Console.ReadLine(), out double digit))
                            {
                                arr[i] = digit;
                                if ((arr[i] > p) && (arr[i] < q))
                                {
                                    ++count;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Error");
                            }
                        }
                    }
                }
                Console.WriteLine($"belong elems = {count}");
            }
            #endregion
            
            #region Num_11
            {
                double[] arr = new double[10];
                int plus_count = 0;
                for (int i = 0; i < arr.Length; ++i)
                {
                    if (double.TryParse(Console.ReadLine(), out double digit))
                    {
                        arr[i] = digit;
                        if (digit > 0)
                        {
                            ++plus_count;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Error");
                    }
                }
                double[] second_arr = new double[plus_count];
                int j = 0;
                for (int i = 0; i < arr.Length; ++i)
                {
                    if (arr[i] > 0)
                    {
                        second_arr[j] = arr[i];
                        ++j;
                    }
                }
                for (int i = 0; i < second_arr.Length; ++i) 
                {
                    Console.WriteLine(second_arr[i]);
                }
            }
            #endregion
            
            #region Num_12
            {
                double[] arr = new double[8];
                int num = 0;
                double value = 0;
                for (int i = 0; i < arr.Length; ++i)
                {
                    if (double.TryParse(Console.ReadLine(), out double digit))
                    {
                        arr[i] = digit;
                        if (digit < 0)
                        {
                            value = digit;
                            num = i;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Error");
                    }
                }
                Console.WriteLine($"value = {value}, number = {num + 1}");
            }
            #endregion
            
            #region Num_13
            {
                double[] arr_1 = new double[10];
                double[] arr_2 = new double[5];
                double[] arr_3 = new double[5];
                int j = 0, n = 0;
                for (int i = 0; i < arr_1.Length; ++i)
                {
                    if (double.TryParse(Console.ReadLine(), out double digit))
                    {
                        arr_1[i] = digit;
                        if (i % 2 == 0)
                        {
                            arr_2[j] = digit;
                            ++j;
                        }
                        else
                        {
                            arr_3[n] = digit;
                            ++n;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Error");
                    }
                }
                for (int i = 0; i < arr_1.Length; ++i)
                {
                    Console.Write($"{arr_1[i]} ");
                }
                Console.Write("\n");
                for (int i = 0; i < arr_2.Length; ++i)
                {
                    Console.Write($"{arr_2[i]} ");
                }
                Console.Write("\n");
                for (int i = 0; i < arr_3.Length; ++i)
                {
                    Console.Write($"{arr_3[i]} ");
                }
            }
            #endregion
            #endregion
            
            #region Lvl_2
            #region Num_5
            {
                int imin = 0, imax = 0, negative_count = 0;
                double arrmax = 0, arrmin = 0;
                if ((int.TryParse(Console.ReadLine(), out int n)) && (n > 0))
                {
                    double[] arr = new double[n];
                    for (int i = 0; i < arr.Length; ++i)
                    {
                        if (double.TryParse(Console.ReadLine(), out double digit))
                        {
                            arr[i] = digit;
                            if (i == 0)
                            {
                                arrmax = arr[i];
                                arrmin = arr[i];
                            }
                            if (arr[i] > arrmax)
                            {
                                arrmax = arr[i];
                                imax = i;
                            }
                            if (arr[i] < arrmin)
                            {
                                arrmin = arr[i];
                                imin = i;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Error");
                        }
                    }
                    for (int i = Math.Min(imin, imax) + 1; i < Math.Max(imin, imax); ++i)
                    {
                        if (arr[i] < 0)
                        {
                            ++negative_count;
                        }
                    }
                    double[] arr_2 = new double[negative_count];
                    int j = 0;
                    for (int i = Math.Min(imin, imax) + 1; i < Math.Max(imin, imax); ++i)
                    {
                        if (arr[i] < 0)
                        {
                            arr_2[j] = arr[i];
                            ++j;
                        }
                    }
                    for (int i = 0; i < arr_2.Length; ++i)
                    {
                        Console.Write($"{arr_2[i]} ");
                    }
                }
            }
            #endregion

            #region Num_6
            { 
                double sum = 0;
                if (int.TryParse(Console.ReadLine(), out int p))
                {
                    if ((int.TryParse(Console.ReadLine(), out int n)) && (n > 0))
                    {
                        double[] arr = new double[n + 1];
                        for (int i = 0; i < n; ++i)
                        {
                            if (double.TryParse(Console.ReadLine(), out double digit))
                            {
                                arr[i] = digit;
                                sum += digit;
                            }
                            else
                            {
                                Console.WriteLine("Error");
                            }
                        }
                        double avg = sum / n;
                        double mindiff = 0;
                        int imin = 0;
                        for (int i = 0; i < n; ++i)
                        {
                            mindiff = Math.Abs(arr[i] - avg);
                            double diff = Math.Abs(arr[i] - avg);
                            if (diff < mindiff)
                            {
                                mindiff = diff;
                                imin = i;
                            }
                        }
                        for (int i = arr.Length - 1; i > imin; --i)
                        {
                            arr[i] = arr[i - 1];
                        }
                        arr[imin + 1] = p;
                        for (int i = 0; i < arr.Length; ++i)
                        {
                            Console.Write($"{arr[i]} ");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Error");
                    }
                }
                else
                {
                    Console.WriteLine("Error");
                }
            }
            #endregion

            #region Num_9
            { 
                int imin = 0, imax = 0, count = 0;
                double arrmax = 0, arrmin = 0, sum = 0;
                if ((int.TryParse(Console.ReadLine(), out int n)) && (n > 0))
                {
                    double[] arr = new double[n];
                    for (int i = 0; i < n; ++i)
                    {
                        if (double.TryParse(Console.ReadLine(), out double digit))
                        {
                            arr[i] = digit;
                            if (i == 0)
                            {
                                arrmax = arr[i];
                                arrmin = arr[i];
                            }
                            if (arr[i] > arrmax)
                            {
                                arrmax = arr[i];
                                imax = i;
                            }
                            if (arr[i] < arrmin)
                            {
                                arrmin = arr[i];
                                imin = i;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Error");
                        }
                    }
                    for (int i = Math.Min(imin, imax) + 1; i < Math.Max(imin, imax); ++i)
                    {
                        sum += arr[i];
                        ++count;
                    }
                    Console.WriteLine($"avg arith = {sum / count}");
                }
                else
                {
                    Console.WriteLine("Error");
                }
            }
            #endregion
            
            #region Num_10
            {
                #region Num_10
            {
                double min_plus = 0;
                int imin = 0;
                bool save = false;
                if ((int.TryParse(Console.ReadLine(), out int n)) && (n > 0))
                {
                    double[] arr = new double[n];
                    for (int i = 0; i < n; ++i)
                    {
                        if (double.TryParse(Console.ReadLine(), out double digit))
                        {
                            arr[i] = digit;
                            if (digit > 0)
                            {
                                if ((!save) || (digit < min_plus))
                                {
                                    min_plus = digit;
                                    imin = i;
                                    save = true;
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("Error");
                        }
                    }
                    double[] arr2 = new double[n - 1];
                    for (int j = 0; j < imin; ++j)
                    {
                        arr2[j] = arr[j];
                    }
                    for (int j = imin + 1; j < n; ++j)
                    {
                        arr2[j - 1] = arr[j];
                    }
                    for (int i = 0; i < n - 1; ++i)
                    {
                        Console.WriteLine($"{arr2[i]} ");
                    }
                }
                else
                {
                    Console.WriteLine("Error");
                }
            }
            #endregion
            }
            #endregion
            
            #region Num_11
            { 
                double last_plus = 0;
                int ilast = 0;
                if (int.TryParse(Console.ReadLine(), out int p))
                {
                    if ((int.TryParse(Console.ReadLine(), out int n)) && (n > 0))
                    {
                        double[] arr = new double[n + 1];
                        for (int i = 0; i < n; ++i)
                        {
                            if (double.TryParse(Console.ReadLine(), out double digit))
                            {
                                arr[i] = digit;
                                if (digit > 0)
                                {
                                    last_plus = arr[i];
                                    ilast = i;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Error");
                            }
                        }
                        for (int i = arr.Length - 1; i > ilast; --i)
                        {
                            arr[i] = arr[i - 1];
                        }
                        arr[ilast + 1] = p;
                        for (int i = 0; i < arr.Length; ++i)
                        {
                            Console.Write($"{arr[i]} ");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Error");
                    }
                }
                else
                {
                    Console.WriteLine("Error");
                }
            }
            #endregion

            #region Num_13
            {
                int imax = 0;
                double arrmax = 0;
                if ((int.TryParse(Console.ReadLine(), out int n)) && (n > 0))
                {
                    double[] arr = new double[n];
                    for (int i = 0; i < arr.Length; ++i)
                    {
                        if (double.TryParse(Console.ReadLine(), out double digit))
                        {
                            if (i == 0)
                            {
                                arrmax = arr[i];
                            }
                            arr[i] = digit;
                            if ((i % 2 == 0) && (arr[i] > arr[imax]))
                            {
                                imax = i;
                                arrmax = arr[i];
                            }
                        }
                        else
                        {
                            Console.WriteLine("Error");
                        }
                    }
                    for (int i = 0; i < arr.Length; ++i)
                    {
                        if (i == imax)
                        {
                            arr[i] = i;
                        }
                    }
                    for (int i = 0; i < arr.Length; ++i)
                    {
                        Console.WriteLine($"{arr[i]} ");
                    }
                }
                else
                {
                    Console.WriteLine("Error");
                }
            }
            #endregion
            
            #region Num_15
            if ((int.TryParse(Console.ReadLine(), out int m)) && (m > 0))
            {
                double[] b = new double[m];
                for (int i = 0; i < b.Length; ++i)
                {
                    if (double.TryParse(Console.ReadLine(), out double digit1))
                    {
                    b[i] = digit1;
                    }
                    else
                    {
                        Console.WriteLine("Error");
                    }
                }
                if ((int.TryParse(Console.ReadLine(), out int n)) && (n > 0))
                {   
                    if ((int.TryParse(Console.ReadLine(), out int k)) && (k > 0) && (k < n))
                    {
                        double[] a = new double[n];
                        for (int j = 0; j < a.Length; ++j)
                        {
                            if (double.TryParse(Console.ReadLine(), out double digit2))
                            {
                            a[j] = digit2;
                            }
                            else
                            {
                                Console.WriteLine("Error");
                            }
                        }
                        double[] c = new double[m+n];
                        for (int i = 0; i < k; ++i)
                        {
                            c[i] = a[i];
                        }
                        for (int i = 0; i < b.Length; ++i)
                        {
                            c[i + k] = b[i];
                        }
                        for (int i = k; i < a.Length; ++i)
                        {
                            c[i + b.Length] = a[i];
                        }
                        for (int i = 0; i < c.Length; ++i)
                        {   
                        Console.WriteLine($"{c[i]} ");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Error");
                    }
                }
                else
                {
                    Console.WriteLine("Error");
                }
            }
            else
            {
                Console.WriteLine("Error");
            }
            #endregion
            #endregion 
            
            #region Lvl_3

            #region Num_1
            double arrmax = 0;
            int count = 0;
            if ((int.TryParse(Console.ReadLine(), out int m)) && (m > 0))
            {
                double[] arr = new double[m];
                for (int i = 0; i < arr.Length; ++i)
                {
                    if (double.TryParse(Console.ReadLine(), out double digit))
                    {
                        arr[i] = digit;
                        if (i == 0)
                        {
                            arrmax = arr[i];
                        }
                        if (arr[i] > arrmax)
                        {
                            arrmax = arr[i];
                            count = 1;
                        }
                        if (arr[i] == arrmax)
                        {
                            ++count;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Error");
                    }
                }
                double[] arr_2 = new double[count];
                int j = 0;
                for (int n = 0; n < arr.Length; ++n)
                {
                    if (arr[n] == arrmax)
                    {
                        arr_2[j] = n;
                        ++j;
                    }
                } 
                for (int n = 0; n < arr_2.Length; ++n)
                {   
                Console.WriteLine($"{arr_2[n]} ");
                }
            }
            else
            {
                Console.WriteLine("Error");
            }
            #endregion
            
            #region Num_5
            if ((int.TryParse(Console.ReadLine(), out int n)) && (n > 0))
            {
                double[] arr = new double[n];
                for (int i = 0; i < arr.Length; ++i)
                {
                    if (double.TryParse(Console.ReadLine(), out double digit))
                    {
                        arr[i] = digit;
                    }
                    else
                    {
                        Console.WriteLine("Error");
                    }
                }
                for (int i = 0; i < n - 1; i += 2)
                {
                    for (int j = i + 2; j < n - 1; j += 2)
                    {
                        if (arr[i] > arr[j])
                        {
                            (arr[i], arr[j]) = (arr[j], arr[i]);
                        }
                    }
                }
                for (int i = 0; i < arr.Length; ++i)
                {   
                Console.WriteLine($"{arr[i]} ");
                }
            }
            else
            {
                Console.WriteLine("Error");
            }
            #endregion
            
            #region Num_8
            if ((int.TryParse(Console.ReadLine(), out int n)) && (n > 0))
            {
                double[] arr = new double[n];
                for (int i = 0; i < arr.Length; ++i)
                {
                    if (double.TryParse(Console.ReadLine(), out double digit))
                    {
                        arr[i] = digit;
                    }
                    else
                    {
                        Console.WriteLine("Error");
                    }
                }
                for (int i = 0; i < arr.Length; ++i)
                {
                    if (arr[i] < 0)
                    {
                        double maxarr = arr[i]; 
                        int maxi = i;
                        for (int j = i + 1; j < arr.Length; ++j)
                        {
                            if (arr[j] < 0)
                            {
                                if (maxarr < arr[j])
                                {
                                    maxarr = arr[j];
                                    maxi = j;
                                }
                            }
                        }
                        arr[maxi] = arr[i];
                        arr[i] = maxarr;
                    }
                }
                for (int p = 0; p < arr.Length; ++p)
                {   
                Console.WriteLine($"{arr[p]} ");
                }
            }
            else
            {
                Console.WriteLine("Error");
            }
            #endregion
            
            #region Num_9
            int neg = 0,plus = 0;
            int plus_count = 1, neg_count = 1;
            if ((int.TryParse(Console.ReadLine(), out int n)) && (n > 0))
            {
                double[] arr = new double[n];
                for (int i = 0; i < arr.Length; ++i)
                {
                    if (double.TryParse(Console.ReadLine(), out double digit))
                    {
                        arr[i] = digit;
                    }
                    else
                    {
                        Console.WriteLine("Error");
                    }
                }
                for (int i = 0; i < arr.Length - 1; ++i)
                {   
                    if (arr[i] > arr[i + 1])
                    {
                        ++neg_count;
                        neg = Math.Max(neg, neg_count);
                        plus_count = 1;
                    }
                    if (arr[i] < arr[i + 1])
                    {
                        ++plus_count;
                        plus = Math.Max(plus, plus_count);
                        neg_count = 1;
                    }
                }
            }
            else
            {
                Console.WriteLine("Error");
            }
            Console.WriteLine($"max = {Math.Max(plus, neg)}");
            #endregion
            
            #region Num_12
            int n = 12;
            double[] arr = new double[n];
            Console.WriteLine("Pls, enter >0 negative value");
            for (int i = 0; i < arr.Length; ++i)
            {
                if (double.TryParse(Console.ReadLine(), out double digit))
                {
                    arr[i] = digit;
                }
                else
                {
                    Console.WriteLine("Error");
                }
            }
            for (int i = 0; i < arr.Length; ++i)
            {
                if (arr[i] < 0)
                {
                    double[] arr_2 = new double[n-1];
                    for (int j = 0; j < i; ++j)
                    {
                        arr_2[j] = arr[j];
                    }
                    for (int j = i; j < arr.Length - 1; ++j)
                    {
                        arr_2[j] = arr[j + 1];
                    }
                    arr = arr_2;
                    --i;
                    --n;
                }
            }
            for (int p = 0; p < arr.Length; ++p)
            {   
            Console.WriteLine($"{arr[p]} ");
            }

            #endregion
            
            #region Num_13
            List<double> new_arr = new List<double>();
            int count = 0;
            if ((int.TryParse(Console.ReadLine(), out int n)) && (n > 1))
            {
                double[] arr = new double[n];
                Console.WriteLine("Pls, enter at least one duplicate value");
                for (int i = 0; i < arr.Length; ++i)
                {
                    if (double.TryParse(Console.ReadLine(), out double digit))
                    {
                        arr[i] = digit;
                    }
                    else
                    {
                        Console.WriteLine("Error");
                    }
                }
                for (int i = 0; i < arr.Length; ++i)
                {
                    count = 0;
                    for ( int j = 0; j < arr.Length; ++j)
                    {
                        if (arr[i] != arr[j])
                        {
                            ++count;
                        }
                    }
                    if (count == arr.Length - 1)
                    {
                        new_arr.Add(arr[i]);
                    }
                }
            }
            else
            {
                Console.WriteLine("Error");
            }
            Console.WriteLine(String.Join("; ", new_arr));
            #endregion

            #endregion

            #region Algorithms

            
            #region a_11
            int j;
            if ((int.TryParse(Console.ReadLine(), out int n)) && (n > 0))
            {
                double[] arr = new double[n];
                for (int i = 0; i < arr.Length; ++i)
                {
                    if (double.TryParse(Console.ReadLine(), out double digit))
                    {
                        arr[i] = digit;
                    }
                    else
                    {
                        Console.WriteLine("Error");
                    }
                }
                if (int.TryParse(Console.ReadLine(), out int x))
                {   
                    j = Binary_search(arr, 0, (n-1), x);
                    if (j == -1)
                    {
                        Console.WriteLine("Try new x");
                    }
                    else
                    {
                        Console.WriteLine($"index = {j}, value = {x}");
                    }
                }
                else
                {
                    Console.WriteLine("Error");
                }
            }
            else
            {
                Console.WriteLine("Error");
            }
            #endregion
            
            #region a_12
            if ((int.TryParse(Console.ReadLine(), out int n)) && (n > 0))
            {
                double[] arr1 = new double[n];
                for (int i = 0; i < arr1.Length; ++i)
                {
                    if (double.TryParse(Console.ReadLine(), out double digit))
                    {
                        arr1[i] = digit;
                    }
                    else
                    {
                        Console.WriteLine("Error");
                    }
                }
                if ((int.TryParse(Console.ReadLine(), out int m)) && (m > 0))
                {
                    double[] arr2 = new double[m];
                    for (int j = 0; j < arr2.Length; ++j)
                    {
                        if (double.TryParse(Console.ReadLine(), out double digit))
                        {
                            arr2[j] = digit;
                        }
                        else
                        {
                            Console.WriteLine("Error");
                        }
                    }
                    int p = Math.Min(n,m);
                    int p1 = Math.Max(n,m);
                    int leng = p + p1;
                    double[] arr3 = new double[leng];
                    int iarr1 = 0,iarr2 = 0;
                    for (int z = 0; z < p * 2; ++z)
                    {
                        if (z % 2 == 0)
                        {
                            arr3[z] = arr1[iarr1];
                            ++iarr1;
                        }
                        else
                        {
                            arr3[z] = arr2[iarr2];
                            ++iarr2;
                        }
                    }
                    for (int z = p * 2; z < leng; ++z)
                    {
                        if (n > m)
                        {
                            arr3[z] = arr1[iarr1];
                            ++iarr1;
                        }
                        if (n < m)
                        {
                            arr3[z] = arr2[iarr2];
                            ++iarr2;
                        }
                    }
                    for (int s = 0; s < arr3.Length; ++s)
                    {   
                    Console.WriteLine($"{arr3[s]} ");
                    }
                }
                else
                {
                    Console.WriteLine("Error");
                }
            }
            else
            {
                Console.WriteLine("Error");
            }
            #endregion
            
            #region a_13
            if ((int.TryParse(Console.ReadLine(), out int n)) && (n > 0))
            {
                double[] arr1 = new double[n];
                for (int i = 0; i < arr1.Length; ++i)
                {
                    if (double.TryParse(Console.ReadLine(), out double digit))
                    {
                        arr1[i] = digit;
                    }
                    else
                    {
                        Console.WriteLine("Error");
                    }
                }
                if ((int.TryParse(Console.ReadLine(), out int m)) && (m > 0))
                {
                    double[] arr2 = new double[m];
                    for (int j = 0; j < arr2.Length; ++j)
                    {
                        if (double.TryParse(Console.ReadLine(), out double digit))
                        {
                            arr2[j] = digit;
                        }
                        else
                        {
                            Console.WriteLine("Error");
                        }
                    }
                    double[] arr3 = new double[n + m];
                    int v = 0, z = 0, p = 0;
                    while ((v < n) && (z < m))
                    if (arr1[v] >= arr2[z])
                    {
                        arr3[p++] = arr1[v++];
                    }
                    else
                    {
                        arr3[p++] = arr2[z++];
                    }
                    while (v < n)
                        arr3[p++] = arr1[v++];
                    while (z < m)
                        arr3[p++] = arr2[z++];
                    for (int s = 0; s < arr3.Length; ++s)
                    {   
                    Console.WriteLine($"{arr3[s]} ");
                    }
                }
            }
            #endregion
            
            #region a_14
            if ((int.TryParse(Console.ReadLine(), out int n)) && (n > 0))
            {
                double[] arr1 = new double[n];
                for (int i = 0; i < arr1.Length; ++i)
                {
                    if (double.TryParse(Console.ReadLine(), out double digit))
                    {
                        arr1[i] = digit;
                    }
                    else
                    {
                        Console.WriteLine("Error");
                    }
                }
                double[] arr2 = new double[n];
                int j = 0;
                for (int i = n - 1; i >= 0; --i)
                {
                    arr2[j] = arr1[i];
                    ++j;
                }
                for (int s = 0; s < arr2.Length; ++s)
                {   
                Console.WriteLine($"{arr2[s]} ");
                }
            }
            else
            {
                Console.WriteLine("Error");
            }
            #endregion
            
            #region a_15
            if ((int.TryParse(Console.ReadLine(), out int n)) && (n > 0))
            {
                double[] arr1 = new double[n];
                for (int i = 0; i < arr1.Length; ++i)
                {
                    if (double.TryParse(Console.ReadLine(), out double digit))
                    {
                        arr1[i] = digit;
                    }
                    else
                    {
                        Console.WriteLine("Error");
                    }
                }
                if ((int.TryParse(Console.ReadLine(), out int m)) && (m < n))
                {
                    double[] arr2 = new double[n];
                    for (int j = 0; j < m; ++j)
                    {
                        arr2[j] = arr1[j + n - m];
                    }
                    for (int i = arr1.Length - 1; i >= m; --i)
                    {
                        arr1[i] = arr1[i - m];
                    }
                    for (int j = 0; j < m; ++j)
                    {
                        arr1[j] = arr2[j];
                    }
                    for (int s = 0; s < arr1.Length; ++s)
                    {   
                    Console.WriteLine($"{arr1[s]} ");
                    }
                }
                else
                {
                    Console.WriteLine("Error");
                }   
            }
            else
            {
                Console.WriteLine("Error");
            }
            #endregion
            
        }
    }
}

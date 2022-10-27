using System;

namespace lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            #region level 1 number 6
            Console.WriteLine("--------level 1 number 6--------");
            int n = 5;
            double L = 0;
            double x;
            Console.WriteLine("Enter 5 elements of vector");
            for (int i = 1; i <= n; i++)
            {
                double.TryParse(Console.ReadLine(), out x);
                L += x * x;
            }
            L = Math.Sqrt(L);
            Console.WriteLine("Length of vector: {0}", L);

            #endregion

            #region level 1 number 10
            Console.WriteLine("--------level 1 number 10--------");
            double[] arr = new double[10];
            double P, Q;
            int res = 0;
            Console.WriteLine("Enter 10 elements of array");
            for(int i = 0; i < 10; i++)
            {
                double.TryParse(Console.ReadLine(), out x);
                arr[i] = x;
            }
            Console.WriteLine("Enter P and Q");
            double.TryParse(Console.ReadLine(), out P);
            double.TryParse(Console.ReadLine(), out Q);
            while (P >= Q)
            {
                Console.WriteLine("P must be less than Q. Enter P and Q again");
                double.TryParse(Console.ReadLine(), out P);
                double.TryParse(Console.ReadLine(), out Q);
            }
            foreach (double el in arr)
            {
                if (el > P && el < Q) res++;
            }
            Console.WriteLine("Between P and Q: {0} elements", res);
            #endregion

            #region level 1 number 11
            Console.WriteLine("--------level 1 number 11--------");
            Console.WriteLine("Enter 10 elements of array");
            for (int i = 0; i < 10; i++)
            {
                double.TryParse(Console.ReadLine(), out x);
                arr[i] = x;
            }
            int k = 0;
            foreach (double el in arr)
            {
                if (el > 0)
                {
                    arr[k] = el;
                    k++;
                }
            }
            Console.WriteLine("Array of positive elements:");
            for (int i = 0; i < k; i++)
            {
                Console.Write("{0}  ", arr[i]);
            }
            Console.WriteLine();
            #endregion

            #region level 1 number 12
            Console.WriteLine("--------level 1 number 12--------");
            arr = new double[8];
            res = 0;
            double elem = 0;
            Console.WriteLine("Enter 8 elements of array");
            for (int i = 0; i < 8; i++)
            {
                double.TryParse(Console.ReadLine(), out x);
                arr[i] = x;
                if (arr[i] < 0)
                {
                    res = i;
                    elem = arr[i];
                }
            }
            if (res == 0) Console.WriteLine("No negative elements");
            else Console.WriteLine("Last negative element is {0} number {1}", elem, res+1);
            #endregion

            #region level 1 number 13
            Console.WriteLine("--------level 1 number 13--------");
            arr = new double[10];
            double[] arr1 = new double[5];
            double[] arr2 = new double[5];
            Console.WriteLine("Enter 10 elements of array");
            for (int i = 0; i < 10; i++)
            {
                double.TryParse(Console.ReadLine(), out x);
                arr[i] = x;
                if (i % 2 == 0) arr1[i / 2] = x;
                else arr2[i / 2] = x;
            }
            Console.WriteLine("Array 1:");
            foreach (double el in arr1) Console.Write("{0} ", el);
            Console.WriteLine();
            Console.WriteLine("Array 2:");
            foreach (double el in arr2) Console.Write("{0} ", el);
            Console.WriteLine();
            #endregion

            #region level 2 number 5
            Console.WriteLine("--------level 2 number 5--------");
            Console.WriteLine("Enter amount of elements");
            int.TryParse(Console.ReadLine(), out n);
            double[] array = new double[n];
            int indexMax = 0, indexMin = 0;
            
            Console.WriteLine("Enter {0} elements", n);
            for (int i = 0; i < n; i++)
            {
                double.TryParse(Console.ReadLine(), out x);
                array[i] = x;
            }
            double maxi = array[0], mini = array[0];
            int temp = 0;
            for (int i = 0; i < n; i++)
            {
                if (array[i] < mini)
                {
                    mini = array[i];
                    indexMin = i;
                }
                if (array[i] > maxi)
                {
                    maxi = array[i];
                    indexMax = i;
                }
            }
            if (indexMax < indexMin)
            {
                temp = indexMax;
                indexMax = indexMin;
                indexMin = temp;
            }
            Console.WriteLine("Negative elements between max and min elements:");
            for (int i = indexMin+1; i < indexMax; i++)
            {
                if (array[i] < 0) Console.Write("{0} ", array[i]);
            }
            Console.WriteLine();
            #endregion

            #region level 2 number 6
            Console.WriteLine("--------level 2 number 6--------");
            Console.WriteLine("Enter amount of elements");
            int.TryParse(Console.ReadLine(), out n);
            array = new double[n];
            Console.WriteLine("Enter P");
            double.TryParse(Console.ReadLine(), out P);

            Console.WriteLine("Enter {0} elements", n);
            double sum = 0;
            for (int i = 0; i < n; i++)
            {
                double.TryParse(Console.ReadLine(), out x);
                array[i] = x;
                sum += x;
            }
            sum = sum / n; //average
            maxi = Math.Abs(sum - array[0]);
            for (int i = 0; i < n-1; i++)
            {
                if (Math.Abs(sum - array[i]) < maxi)
                {
                    maxi = Math.Abs(sum - array[i]);
                    indexMax = i;
                }
            }
            array[indexMax + 1] = P;
            for (int i = n-1; i > indexMax+2; i--)
            {
                array[i] = array[i - 1];
            }
            Console.WriteLine("result:");
            foreach (double el in array) Console.WriteLine("{0} ", el);
            Console.WriteLine();
            #endregion

            #region level 2 number 9
            Console.WriteLine("--------level 2 number 9--------");
            Console.WriteLine("Enter amount of elements");
            int.TryParse(Console.ReadLine(), out n);
            array = new double[n];

            Console.WriteLine("Enter {0} elements", n);
            indexMax = 0;
            indexMin = 0;
            maxi = array[0];
            mini = array[0];
            for (int i = 0; i < n; i++)
            {
                double.TryParse(Console.ReadLine(), out x);
                array[i] = x;
                if (x < mini)
                {
                    mini = x;
                    indexMin = i;

                }
                if (x > maxi)
                {
                    maxi = x;
                    indexMax = i;
                }
            }
            if (indexMax < indexMin)
            {
                temp = indexMin;
                indexMin = indexMax;
                indexMax = temp;
            }
            sum = 0;
            for (int i = indexMin + 1; i < indexMax; i++)
            {
                sum += array[i];
            }
            sum = sum / (indexMax - indexMin - 1);
            Console.WriteLine("Average: {0}", sum);

            #endregion

            #region level 2 number 10
            Console.WriteLine("--------level 2 number 10--------");
            Console.WriteLine("Enter amount of elements");
            int.TryParse(Console.ReadLine(), out n);
            array = new double[n];

            Console.WriteLine("Enter {0} elements", n);
            indexMin = -1;
            mini = 99999999999;
            for (int i = 0; i < n; i++)
            {
                double.TryParse(Console.ReadLine(), out x);
                array[i] = x;
                if (x > 0 && x < mini)
                {
                    mini = x;
                    indexMin = i;
                }

            }
            if (indexMin == -1) Console.WriteLine("No positive elements");
            else
            {
                for (int i = 0; i < n; i++)
                {
                    if (array[i] != array[indexMin]) Console.Write("{0} ", array[i]);
                }
            }
            Console.WriteLine();
            #endregion

            #region level 2 number 11
            Console.WriteLine("--------level 2 number 11--------");
            Console.WriteLine("Enter amount of elements");
            int.TryParse(Console.ReadLine(), out n);
            array = new double[n];
            Console.WriteLine("Enter P");
            double.TryParse(Console.ReadLine(), out P);
            Console.WriteLine("Enter {0} elements", n);
            indexMax = 0;
            maxi = -1;
            for (int i = 0; i < n; i++)
            {
                double.TryParse(Console.ReadLine(), out x);
                array[i] = x;
                if(x > 0)
                {
                    maxi = x;
                    indexMax = i;
                }
                
            }
            if (maxi == -1) Console.WriteLine("no positive elements");
            else 
            {
                for (int i = n - 1; i > indexMax; i--)
                {
                    array[i] = array[i - 1];

                }

                Console.WriteLine("Array:");
                array[indexMax+1] = P;
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("{0} ", array[i]);
                }
            }
            Console.WriteLine();

            #endregion

            #region level 2 number 13
            Console.WriteLine("--------level 2 number 13--------");
            Console.WriteLine("Enter amount of elements");
            int.TryParse(Console.ReadLine(), out n);
            array = new double[n];
            
            Console.WriteLine("Enter {0} elements", n);
            
            for (int i = 0; i < n; i++)
            {
                double.TryParse(Console.ReadLine(), out x);
                array[i] = x;
                
            }
            indexMax = 0;
            maxi = array[0];
            for (int i = 2; i < n; i += 2)
            {
                if (array[i] > maxi)
                {
                    maxi = array[i];
                    indexMax = i;
                }
            }
            array[indexMax] = indexMax;
            foreach(double el in array)
            {
                Console.Write("{0} ", el);
            }
            Console.WriteLine();
            #endregion

            #region level 2 number 15
            Console.WriteLine("--------level 2 number 15--------");
            Console.WriteLine("Enter n");
            int.TryParse(Console.ReadLine(), out n);
            double[] arrayA = new double[n];
            int m;
            Console.WriteLine("Enter m");
            int.TryParse(Console.ReadLine(), out m);
            double[] arrayB = new double[m];
            Console.WriteLine("Enter {0} elements of A array:", n);
            for (int i = 0; i < n; i++)
            {
                double.TryParse(Console.ReadLine(), out x);
                arrayA[i] = x;

            }
            Console.WriteLine("Enter {0} elements of B array:", m);
            for (int i = 0; i < m; i++)
            {
                double.TryParse(Console.ReadLine(), out x);
                arrayB[i] = x;

            }
            Console.WriteLine("Enter k");
            int.TryParse(Console.ReadLine(), out k);
            while (k > n)
            {
                Console.WriteLine("Enter k<n");
                int.TryParse(Console.ReadLine(), out k);
            }
            Console.WriteLine("Array:");
            for (int i = 0; i < n; i++)
            {
                if (i == k + 1)
                {
                    for (int l = 0; l < m; l++)
                    {
                        Console.Write("{0} ", arrayB[l]);
                    }
                }
                Console.Write("{0} ", arrayA[i]);
            }
            Console.WriteLine();
            #endregion

            #region level 3 number 1
            Console.WriteLine("--------level 3 number 1--------");
            Console.WriteLine("Enter amount of elements");
            int.TryParse(Console.ReadLine(), out n);
            array = new double[n];

            Console.WriteLine("Enter {0} elements", n);
            double[] maxiarr = new double[n];
            maxi = -999999;
            int j = 0;
            for (int i = 0; i < n; i++)
            {
                double.TryParse(Console.ReadLine(), out x);
                array[i] = x;
                if (x > maxi)
                {
                    maxi = x;
                    j = 0;
                    maxiarr[j] = x;
                }
                else if (x == maxi)
                {
                    j++;
                    maxiarr[j] = x;
                }
            }
            Console.WriteLine("Array:");
            for (int i = 0; i<=j; i++)
            {
                Console.Write("{0} ", maxiarr[i]);
            }
            Console.WriteLine();

            #endregion

            #region level 3 number 5
            Console.WriteLine("--------level 3 number 5--------");
            Console.WriteLine("Enter amount of elements");
            int.TryParse(Console.ReadLine(), out n);
            array = new double[n];

            Console.WriteLine("Enter {0} elements", n);
            for (int i = 0; i < n; i++)
            {
                double.TryParse(Console.ReadLine(), out x);
                array[i] = x;
            }
            for (int i = 0; i < n; i += 2)
            {
                mini = array[i];
                indexMin = i;
                for (int l = i + 2; l < n; l += 2)
                {
                    if (array[l] < mini)
                    {
                        mini = array[l];
                        indexMin = l;
                    }
                }
                array[indexMin] = array[i];
                array[i] = mini;
            }
            Console.WriteLine("Array:");
            foreach (double el in array) Console.Write("{0} ", el);
            Console.WriteLine();
            #endregion

            #region level 3 number 8
            Console.WriteLine("--------level 3 number 8--------");
            Console.WriteLine("Enter amount of elements");
            int.TryParse(Console.ReadLine(), out n);
            array = new double[n];

            Console.WriteLine("Enter {0} elements", n);
            for (int i = 0; i < n; i++)
            {
                double.TryParse(Console.ReadLine(), out x);
                array[i] = x;
            }
            for (int i = 0; i < n; i++)
            {
                if (array[i] < 0)
                {
                    maxi = array[i];
                    indexMax = i;
                    for (int l = i + 1; l < n; l++)
                    {
                        if (array[l] < 0)
                        {
                            if (maxi < array[l])
                            {
                                maxi = array[l];
                                indexMax = l;
                            }
                        }
                    }
                    array[indexMax] = array[i];
                    array[i] = maxi;
                }
            }
            Console.WriteLine("Array:");
            foreach (double el in array) Console.Write("{0} ", el);
            Console.WriteLine();
            #endregion

            #region level 3 number 9
            Console.WriteLine("--------level 3 number 9--------");
            Console.WriteLine("Enter amount of elements");
            int.TryParse(Console.ReadLine(), out n);
            array = new double[n];

            Console.WriteLine("Enter {0} elements", n);
            for (int i = 0; i < n; i++)
            {
                double.TryParse(Console.ReadLine(), out x);
                array[i] = x;
            }
            int maxilen = 1;
            int minilen = 1;
            int maxii = 0;
            for (int i = 1; i < n; i++)
            {
                if (array[i] < array[i - 1])
                {
                    maxilen = 1;
                    minilen++;
                }
                else if (array[i] > array[i + 1])
                {
                    minilen = 1;
                    maxilen++;
                }
                else
                {
                    minilen = 1;
                    maxilen = 1;
                }
                maxii = Math.Max(maxii, maxilen);
                maxii = Math.Max(maxii, minilen);
            }
            Console.WriteLine("Maxi length = {0}", maxii);

            #endregion

            #region level 3 number 12
            Console.WriteLine("--------level 3 number 12--------");
            const int array_size = 12;
            array = new double[array_size];
            Console.WriteLine("Enter 12 elements of array");

            for (int i = 0; i < array_size; i++)
            {
                double.TryParse(Console.ReadLine(), out x);
                array[i] = x;
            }
            n = 12;
            for (int i = 0; i < n; i++)
            {
                if (array[i] < 0)
                {
                    for (int l = i; l < array_size - 1; l++)
                    {
                        array[l] = array[l + 1];

                    }
                    n--;
                    i--;
                }
            }
            Console.WriteLine("Array: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine();
            #endregion

            #region level 3 number 13
            Console.WriteLine("--------level 3 number 13--------");
            Console.WriteLine("Enter amount of elements");
            int.TryParse(Console.ReadLine(), out n);
            array = new double[n];
            int[] maxiar = new int[n];
            indexMax = 0;
            j = 0;
            Console.WriteLine("Enter {0} elements", n);
            for (int i = 0; i < n; i++)
            {
                double.TryParse(Console.ReadLine(), out x);
                array[i] = x;
            }
            for (int i = 0; i < n; i++)
            {
                j = 0;
                for (int l = 0; l < i; l++)
                {
                    if (array[i] == array[l]) j++;
                }
                if (j == 0)
                {
                    maxiar[indexMax] = i;
                    indexMax++;
                }
            }
            Console.WriteLine("Array");
            for (int i = 0; i < indexMax; i++)
            {
                Console.Write("{0} ",array[maxiar[i]]);
            }
            Console.WriteLine();
            #endregion

            #region algoritms 11-15 p 86
            Console.WriteLine("--------algoritms 11--------");
            Console.WriteLine("Enter amount of elements");
            int.TryParse(Console.ReadLine(), out n);
            array = new double[n];
            Console.WriteLine("Enter {0} elements", n);
            for (int i = 0; i < n; i++)
            {
                double.TryParse(Console.ReadLine(), out x);
                array[i] = x;
            }
            for (int i = 0; i < n; i++)
            {
                mini = array[i];
                indexMin = i;
                for (j = i + 1; j < n; j++)
                {
                    if (array[j] < mini)
                    {
                        mini = array[j];
                        indexMin = j;
                    }
                }
                array[indexMin] = array[i];
                array[i] = mini;
            }
            
            Console.WriteLine("Enter x");
            double.TryParse(Console.ReadLine(), out x);
            int i2 = n - 1;
            int i1 = 0;
            int aver = (i1+i2) / 2;
            while (i2 >= i1)
            {
                if (x == array[aver])
                {
                    Console.WriteLine("index {0}", aver);
                    break;
                }
                else if (x < array[aver]) i2 = aver - 1;
                else i1 = aver + 1;
                aver = (i1 + i2) / 2;
            }
            if (i2 < i1) Console.WriteLine("No element {0} in array", x);

            Console.WriteLine("--------algoritms 12--------");
            Console.WriteLine("Enter amount of elements of 1 array");
            int.TryParse(Console.ReadLine(), out int n1);
            double[] array1 = new double[n1];
            Console.WriteLine("Enter {0} elements", n1);
            for (int i = 0; i < n1; i++)
            {
                double.TryParse(Console.ReadLine(), out x);
                array1[i] = x;
            }
            Console.WriteLine("Enter amount of elements of 2 array");
            int.TryParse(Console.ReadLine(), out int n2);
            double[] array2 = new double[n2];
            Console.WriteLine("Enter {0} elements", n2);
            for (int i = 0; i < n2; i++)
            {
                double.TryParse(Console.ReadLine(), out x);
                array2[i] = x;
            }

            double[] array3 = new double[n1 + n2];
            int t = n1;
            if (n1 >= n2) t = n2;
            for(int i = 0; i < t; i++)
            {
                array3[i * 2] = array1[i];
                array3[i * 2 + 1] = array2[i];
            }
            if (n1 > n2)
            {
                for (int i = t; i < n1; i++) array3[i + t] = array1[i];
            }
            else if (n1 < n2)
            {
                for(int i = t; i < n2; i++)
                {
                    array3[i + t] = array2[i];
                }
            }
            Console.WriteLine("array:");
            foreach (double el in array3) Console.Write("{0} ", el);
            Console.WriteLine();

            Console.WriteLine("--------algoritms 13--------");
            Console.WriteLine("Enter amount of elements of 1 array");
            int.TryParse(Console.ReadLine(), out n1);
            array1 = new double[n1];
            Console.WriteLine("Enter {0} elements", n1);
            for (int i = 0; i < n1; i++)
            {
                double.TryParse(Console.ReadLine(), out x);
                array1[i] = x;
            }
            Console.WriteLine("Enter amount of elements of 2 array");
            int.TryParse(Console.ReadLine(), out n2);
            array2 = new double[n2];
            Console.WriteLine("Enter {0} elements", n2);
            for (int i = 0; i < n2; i++)
            {
                double.TryParse(Console.ReadLine(), out x);
                array2[i] = x;
            }
            int ii = 0;
            j = 0;
            k = 0;
            array3 = new double[n1 + n2];
            while (ii != n1 + n2)
            {
                if (k<n1 && j < n2)
                {
                    if (array1[k] < array2[j])
                    {
                        array3[ii] = array1[k];
                        ii++;
                        j++;
                    }
                    else
                    {
                        array3[ii] = array2[j];
                        ii++;
                        j++;
                    }
                }
                else if (k < n1)
                {
                    array3[ii] = array1[k];
                    ii++;
                    k++;
                }
                else
                {
                    array3[ii] = array2[j];
                    ii++;
                    j++;
                }
            }
            Console.WriteLine("Array:");
            foreach (double el in array) Console.Write("{0} ", el);
            Console.WriteLine();

            Console.WriteLine("--------algoritms 14--------");
            Console.WriteLine("Enter amount of elements");
            int.TryParse(Console.ReadLine(), out n);
            array = new double[n];
            Console.WriteLine("Enter {0} elements", n);
            for (int i = 0; i < n; i++)
            {
                double.TryParse(Console.ReadLine(), out x);
                array[i] = x;
            }
            double tem;
            for(int i = 0; i < n/2; i++)
            {
                tem = array[i];
                array[i] = array[n - 1 - i];
                array[n - 1 - i] = tem;
            }
            Console.WriteLine("Array:");
            foreach (double el in array) Console.Write("{0} ", el);
            Console.WriteLine();
            Console.WriteLine("--------algoritms 15--------");
            Console.WriteLine("Enter amount of elements");
            int.TryParse(Console.ReadLine(), out n);
            array = new double[n];
            Console.WriteLine("Enter {0} elements", n);
            for (int i = 0; i < n; i++)
            {
                double.TryParse(Console.ReadLine(), out x);
                array[i] = x;
            }
            Console.WriteLine("Enter m");
            int M;
            
            array1 = new double[n];
            int.TryParse(Console.ReadLine(), out M);
            for (int i = 0; i < n; i++)
            {
                array1[(i + M) % n] = array[i];
            }
            Console.WriteLine("Array:");
            foreach (double el in array1) Console.Write("{0} ", el);
            #endregion
        }
    }
}

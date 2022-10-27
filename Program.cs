using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.IO.Pipes;
using System.Runtime.ExceptionServices;
using System.Threading;
namespace Lab_3
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Lvl1
            Console.WriteLine($"Lvl 1!");
            #region #6
            Console.WriteLine($"Task 6");
            double[] x = new double[] { 1, 2, 3, 4, 5 };
            double s = 0;
            for (int i = 0; i < 5; i++)
            {
                s = s + x[i] * x[i];
            }
            Console.WriteLine($"L = {Math.Sqrt(s)}");


            #endregion 
            #region #10
            Console.WriteLine($"Task 10");
            double[] y = new double[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            double P = 3, Q = 6;
            int n = 0;
            if (P >= Q)
            {
                Console.WriteLine($"P should be less than Q");
                return;
            }
            foreach (int i in y)
            {
                if ((i > P) && (i < Q))
                {
                    n++;
                }
            }
            Console.WriteLine($"{n} elements is between P and Q");

            #endregion

            #region #11
            Console.WriteLine($"Task 11");
            double[] c = new double[] { -2, -3, -1, 0, 4, 5, 6, 7, 8, 9 };
            int v = 0;
            foreach (int i in c)
            {
                if (i > 0)
                {
                    v++;
                }
            }
            double[] cc = new double[v];
            n = 0;
            for (int i = 0; i < cc.Length; i++)
            {
                if (c[i] > 0)
                {
                    cc[n] = c[i];
                    Console.Write($"{cc[n]}");
                    n++;
                }
            }
            Console.WriteLine($"\n");

            #endregion
            #region #12 
            Console.WriteLine($"Task 12");
            double[] z = new double[8] { -4, -3, -2, -1, 1, 2, 3, 4 };
            n = 0;
            double l = 0;
            for (int i = 0; i < 8; i++)
            {
                if (z[i] < 0)
                {
                    l = z[i];
                    n = i;
                }
            }
            Console.WriteLine($"Last negative value is {l} index is {n}");
            #endregion
            #region #13
            Console.WriteLine($"Task 13");
            double[] a = new double[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            double[] even = new double[5];
            double[] odd = new double[5];
            n = 0;
            for (int i = 0; i < 9; i += 2)
            {
                even[n] = a[i];
                odd[n] = a[i + 1];
                n++;
            }
            Console.WriteLine($"even ");
            foreach (double i in even)
            {
                Console.WriteLine($"{i} ");
            }
            Console.WriteLine($"odd ");
            foreach (double i in odd)
            {
                Console.WriteLine($"{i} ");
            }
            #endregion
            #endregion
            #region Lvl2
            Console.WriteLine($"Lvl 2!");
            #region Task 5
            Console.WriteLine($"Task 5");
            int amount;
            Console.WriteLine($"Enter the amount of array elements");
            int.TryParse(Console.ReadLine(), out amount);
            if (amount <= 0)
            {
                Console.WriteLine($"amount of elements should be more than 0");
                return;
            }
            int[] q = new int[amount];
            for (int i = 0; i < q.Length; i++)
            {
                Console.WriteLine($"Enter the {i} element");
                int.TryParse(Console.ReadLine(), out q[i]);

            }
            List<double> g = new List<double>();
            int qMax = q[0], qMin = q[0], iMin = 0, iMax = 0;
            for (int i = 0; i < q.Length; i++)
            {
                if (q[i] > qMax)
                {
                    iMax = i;
                }
                if (q[i] < qMin)
                {
                    iMin = i;
                }
            }
            for (int i = Math.Min(iMin, iMax); i <= Math.Max(iMax, iMin); i++)
            {
                if (q[i] < 0)
                {
                    g.Add(q[i]);
                }
                else i++;
            }
            double[] total = g.ToArray();
            for (int i = 0; i < total.Length; i++)
            {
                Console.WriteLine("{0:f1}", total[i]);
            }
            Console.WriteLine();




            #endregion
            #region Task 6
            Console.WriteLine($"Task 6");
            Console.WriteLine($"Enter the amount of array`s elements");
            int u;
            int.TryParse(Console.ReadLine(), out u);
            if (u <= 0)
            {
                Console.WriteLine($"error");
                return;
            }
            int[] ar = new int[u + 1];
            for (int i = 0; i < ar.Length - 1; i++)
            {
                Console.WriteLine($"Enter the {i} element");
                int.TryParse(Console.ReadLine(), out ar[i]);
            }
            double div = ar.Sum() / u;
            int j = 0;
            for (int i = 0; i < u; i++)
            {
                if (Math.Abs(div - ar[j]) > Math.Abs(div - ar[i]))
                {
                    j = i;
                }
                Console.WriteLine($"Enter P");
                int p;
                int.TryParse(Console.ReadLine(), out p);
                for (int w = u - 1; w >= j; w--)
                {
                    ar[w + 1] = ar[w];

                }
                ar[j + 1] = p;
                for (int w = 0; w < ar.Length; w++)
                {
                    Console.Write("{0:d} ", ar[i]);
                }
                Console.WriteLine();
            }

            #endregion
            #region Task 9
            Console.WriteLine($"Task 9");
            amount = 0;
            Console.WriteLine($"enter the amount of elements");
            int.TryParse(Console.ReadLine(), out amount);
            if (amount <= 0)
            {
                Console.WriteLine($"incorrect");
                return;
            }
            double[] arr = new double[amount];
            for (int i = 1; i < arr.Length; i++)
            {
                Console.WriteLine($"Enter the {i} element");
                double.TryParse(Console.ReadLine(), out arr[i]);

            }
            int k = 0, imax = 0, imin = 0;
            double amax = arr[0], amin = arr[0];
            double summ = 0;
            double avg;
            for (int i = 0; i < arr.Length; i++)
            {
                if (amax < arr[i])
                {
                    amax = arr[i];
                    imax = i;
                }
                if (amin > arr[i])
                {
                    amin= arr[i];
                    imin = i;
                }

            }
            if (imax >= imin)
            {
                for (int i = imin + 1; i < imax; i++)
                {
                    summ += arr[i];
                    k++;
                }
            }
            if (imax < imin)
            {
                for (int i = imax + 1; i < imin; i++)
                {
                    summ += arr[i];
                    k++;
                }
            }
            avg = summ / k;
            Console.WriteLine($"The avg value of array elements is {avg}");


            #endregion
            #region Task 10
            Console.WriteLine($"Task 10");
            amount = 0;
            Console.WriteLine($"Enter the amount of array elements");
            int.TryParse(Console.ReadLine(), out amount);
            if (amount <= 0)
            {
                Console.WriteLine($"incorrect");
                return;
            }
            double[] ar2 = new double[amount];
            for (int i = 0; i < ar2.Length; i++)
            {
                Console.WriteLine($"Enter the {i} element" );
                double.TryParse(Console.ReadLine(), out ar2[i]);

            }
            double amin2 = ar2[0];
            int imin2 = 0;
            for (int i = 0; i < ar2.Length; i++)
            {
                if ((ar2[i] > 0) && (ar2[i] < amin2))
                {
                    amin2 = ar2[i];
                    imin2 = i;
                }
            }
            for (int i = imin2; i < ar2.Length - 1; i++)
            {
                ar2[i] = ar2[i + 1];
            }
            for (int i = 0; i < ar2.Length - 1; i++)
            {
                Console.WriteLine($"{0:f1}", ar2[i]);
            }
            Console.WriteLine();
            #endregion
            #region Task 11
            Console.WriteLine($"Task 11");
            amount = 0;
            Console.WriteLine($"Enter the amount of elements");
            int.TryParse(Console.ReadLine(), out amount);
            if (amount <= 0)
            {
                Console.WriteLine($"incorrect");
                return;
            }
            double[] ar3 = new double[amount + 1];
            for (int i = 0; i < ar3.Length - 1; i++)
            {
                Console.WriteLine($"enter the {i} element");
                double.TryParse(Console.ReadLine(), out ar3[i]);
            }
            Console.WriteLine($"enter P value");
            double.TryParse(Console.ReadLine(), out double p2);
            int aa = Array.FindLastIndex(ar3, i => i > 0);
            for (int i = amount - 2; i >= aa + 1; i--)
                ar3[i + 1] = ar3[i];
            ar3[aa + 1] = p2;
            for (int i = 0; i < ar3.Length; i++)
                Console.WriteLine("{0:f1}", ar3[i]);
            Console.WriteLine();
            #endregion
            #region Task 13
            Console.WriteLine($"Task 13");
            amount = 0;
            Console.WriteLine($"enter the amount of elements in array");
            int.TryParse(Console.ReadLine(), out amount);
            if (amount <= 0)
            {
                Console.WriteLine($"incorrect");
                return;
            }
            double[] ar4 = new double[amount];
            for (int i = 0; i < ar4.Length; i++)
            {
                Console.WriteLine($"Enter the {i} element ");
                double.TryParse(Console.ReadLine(), out ar4[j]);
            }
            double max3 = ar4[0];
            int imax3 = 0;
            for (int i = 2; i < ar4.Length; i++)
            {
                if (ar4[j] > max3)
                {
                    max3 = ar4[i];
                    imax3 = i;
                }
                ar4[imax3] = imax3;
            }
            for (int i = 0; i < ar4.Length; i++)
                Console.WriteLine("{0:f1}", ar4[i]);
            Console.WriteLine();

            #endregion
            #region Task 15
            Console.WriteLine($"Task 15");
            k = 0;
            int h = 0;
            int m = 0;
            Console.WriteLine($"Enter the size of list A");
            int.TryParse(Console.ReadLine(), out k);
            if (k <= 0)
            {
                Console.WriteLine($"incorrect");
                return;
            }
            List<int> A = new List<int>();
            for (int i = 0; i < k; i++)
            {
                Console.WriteLine($"Enter the {i} element of List A");
                int.TryParse(Console.ReadLine(), out int AA);
                A.Add(AA);
            }
            Console.WriteLine($"Enter the size of list B");
            int.TryParse(Console.ReadLine(), out m);
            if (m <= 0)
            {
                Console.WriteLine($"incorrect");
                return;
            }
            List<int> B = new List<int>();
            for (int i = 0; i < m; i++)
            {
                Console.WriteLine($"Enter the {i} element of List B");
                int.TryParse(Console.ReadLine(), out int BB);
                B.Add(BB);
            }
            Console.WriteLine($"Enter the k value ");
            int.TryParse(Console.ReadLine(), out h);
            A.InsertRange(h, B);
            int[] ne = A.ToArray();
            for (int i = 0; i < ne.Length; i++)
                Console.WriteLine("0:d", ne[i]);
            Console.WriteLine();


            #endregion
            #endregion
            #region Lvl3
            Console.WriteLine($"Lvl 3!");
            #region Task 1
            Console.WriteLine($"Task 1");
            amount = 0;
            Console.WriteLine("Enter the amount of array elements");
            int.TryParse(Console.ReadLine(), out amount);
            if (amount <= 0)
            {
                Console.WriteLine($"incorrect");
                return;
            }

            double[] ar5 = new double[amount];
            for (int i = 0; i < ar5.Length; i++)
            {
                Console.WriteLine($"Enter the {i} element");
                double.TryParse(Console.ReadLine(), out ar5[i]);
            }
            List<int> b5 = new List<int>();
            double amax5 = ar5.Max();
            for (int i = 0; i < amount; i++)
            {
                if (ar5[i] == amax5)
                {
                    b5.Add(i);
                }
            }
            int[] nar5 = b5.ToArray();
            for (int i = 0; i < nar5.Length; i++)
                Console.WriteLine("{0:d}", nar5[i]);
            Console.WriteLine();

            #endregion
            #region Task 5
            Console.WriteLine($"Task 5");
            amount = 0;
            Console.WriteLine("Enter the amount of elements in array");
            int.TryParse(Console.ReadLine(), out amount);
            if (amount <= 0)
            {
                Console.WriteLine("Incorrect");
                return;
            }

            double[] ar6 = new double[amount];
            for (int i = 0; i < ar6.Length; i++)
            {
                Console.WriteLine($"Enter the {i} element");
                double.TryParse(Console.ReadLine(), out ar6[i]);
            }
            double ll ;
            for (int i = 0; i < amount; i += 2)
            {
                for (int o = i + 2; o < amount; o += 2)
                {
                    if (ar6[i] > ar6[o])
                    {
                        ll = ar6[i];
                        ar6[i] = ar6[o];
                        ar6[o] = ll;
                    }
                }

            }
            for (int i = 0; i < amount; i++)
                Console.Write("{0:f1} ", ar6[i]);
            Console.WriteLine();
            #endregion
            #region Task 8
            Console.WriteLine($"Task 8");
            amount = 0;
            Console.WriteLine("Enter the amount of elements in array");
            int.TryParse(Console.ReadLine(), out amount);
            if (amount <= 0)
            {
                Console.WriteLine("incorrect");
                return;
            }
            int[] ar7 = new int[amount];
            for (int i = 0; i < amount; i++)
            {
                Console.WriteLine($"Enter the {i} element in array");
                int.TryParse(Console.ReadLine(), out ar7[i]);
            }
            for (int i = 0; i < amount - 1; i++)
            {
                if (ar7[i] < 0)
                {
                    int amax7 = ar7[i];
                    int imax5 = i;
                    for (int o = i + 1; o < amount; o++)
                    {
                        if (ar7[o] > amax7 && ar7[o] < 0)
                        {
                            amax7 = ar7[o];
                            imax5 = o;
                        }
                    }
                    ar7[imax5] = ar7[i];
                    ar7[i] = amax7;
                }
            }
            for (int i = 0; i < amount; i++)
                Console.Write("{0:d} ", ar7[i]);
            Console.WriteLine();
            #endregion
            #region Task 9
            Console.WriteLine($"Task 9");
            amount = 0;
            Console.WriteLine("Enter the amount of elements in array");
            int.TryParse(Console.ReadLine(), out amount);
            if (amount <= 0)
            {
                Console.WriteLine("Incorrect");
                return;
            }
            int[] ar8 = new int[amount];
            for (int i = 0; i < amount; i++)
            {
                Console.WriteLine($"Enter the {i} element ");
                int.TryParse(Console.ReadLine(), out ar8[i]);
            }
            int dbiggest = 0, dleast = 0, d = 0;
            s = 0;
            for (int i = 0; i < amount - 1; i++)
            {
                int biggest = ar8[i], least = ar8[i];
                if (ar8[i] < ar8[i + 1])
                {
                    dbiggest++;
                    dleast = 0;
                    if (dbiggest > d) d = dleast;
                }
                else if (ar8[i] > ar8[i + 1])
                {
                    dleast++;
                    dbiggest = 0;
                    if (dleast > s) s = dleast;
                }
                else
                {
                    dleast = 0; dbiggest = 0;
                }
            }
            Console.WriteLine(Math.Max(d, s) + 1);

            #endregion
            #region Task 12
            Console.WriteLine($"Task 12");
            int[] ar9 = new int[12];
            for (int i = 0; i < 12; i++)
            {
                Console.WriteLine($"Enter the {i} element");
                int.TryParse(Console.ReadLine(), out ar9[i]);
            }
            int[] nar9 = Array.FindAll(ar9, i => i > 0);
            for (int i = 0; i < nar9.Length; i++)
            {
                Console.Write("0:d", nar9[i]);
            }
            Console.WriteLine();

            #endregion
            #region Task 13
            amount = 0;
            Console.WriteLine("Enter the amount of elements in array");
            int.TryParse(Console.ReadLine(), out amount);
            if (amount <= 0)
            {
                Console.WriteLine("Incorrect");
                return;
            }
            int[] arr2 = new int[amount];
            for (int i = 0; i < amount; i++)
            {
                Console.WriteLine($"Enter the {i} element");
                int.TryParse(Console.ReadLine(), out arr2[i]);
            }
            int[] final = arr2.Distinct().ToArray();
            for (int i = 0; i < final.Length; i++)
            {
                Console.Write("{0:d}", final[i]);
            }
            Console.WriteLine();
            #endregion

            #endregion
        }
        #region Lvl4
        static void level4()
        {
            Console.WriteLine($"Level 4!");
            Random rnd = new Random();
            #region Task 11
            Console.WriteLine($"Task 11");
            int amount;
            Console.WriteLine($"Enter the amount of elements in array");
            int.TryParse(Console.ReadLine(), out amount);
            int[] ar = new int[amount];
            for (int i = 0; i < amount; i++)
            {
                ar[i] = rnd.Next(10);
            }
            for (int i = 0; i < amount; i++)
            {
                Console.WriteLine($"{0:d}", ar[i]);
            }
            Console.WriteLine($"Enter x value");
            int x, indx = 0, indx2 = amount - 1, midx = (indx + indx2) / 2;
            int.TryParse(Console.ReadLine(), out x);
            while (indx <= indx2)
            {
                if (x == ar[midx])
                {
                    Console.WriteLine($"correct");
                }
                else if (x < ar[midx])
                {
                    indx2 = midx + 1;
                }
                else
                {
                    indx = midx + 1;
                }
                midx = (indx + indx2) / 2;
            }
            if (indx > indx2)
            {
                Console.WriteLine($"incorrect");
            }


            #endregion
            #region Task 12
            Console.WriteLine($"Task 12");
            amount = 0;
            int amount2 = 0;
            Console.WriteLine($"Enter the amount of elements in first array");
            int.TryParse(Console.ReadLine(), out amount);
            Console.WriteLine($"Enter the amount of elements in second array");
            int.TryParse(Console.ReadLine(), out amount2);
            double[] s1 = new double[amount];
            double[] s2 = new double[amount2];
            for (int i = 0; i < amount; i++)
            {
                s1[i] = rnd.Next(50);
            }
            for (int i = 0; i < amount2; i++)
                s2[i] = rnd.Next(50);
            Console.WriteLine();
            double[] s3 = new double[amount + amount2];
            int g = 0, q = 0, u = 0;
            while (g != s1.Length & q != s2.Length)
            {
                s3[u] = s1[g];
                u++;
                g++;
                s3[u] = s2[q];
                q++;
                u++;
            }
            for (int i = u; i != s3.Length; i++)
            {
                if (s1.Length < s2.Length)
                {
                    s3[i] = s2[q];
                    q++;
                }
                else
                {

                    s3[i] = s1[g];
                    g++;
                }
            }


            foreach (double c in s3)
                Console.WriteLine(c);
            #endregion
            #region Task 13
            Console.WriteLine($"Task 13");
            amount = 0;
            amount2 = 0;
            Console.WriteLine($"Enter the amount of elements in array");
            int.TryParse(Console.ReadLine(), out amount);
            double[] ar2 = new double[amount];
            for (int i = 0; i < amount; i++)
                ar2[i] = rnd.Next(30);




            Console.WriteLine("Enter the amount of elements in second array");
            int.TryParse(Console.ReadLine(), out amount2);
            double[] ar3 = new double[amount2];
            for (int i = 0; i < amount2; i++)
                ar3[i] = rnd.Next(30);




            double[] arr = new double[ar2.Length + ar3.Length];
            int o = 0, y = 0;
            for (int i = 0; i != arr.Length; i++)
            {
                if (o < ar2.Length & y < ar3.Length)
                {
                    if (ar2[o] > ar3[y])
                    {
                        arr[i] = ar2[o];
                        o++;
                    }
                    else
                    {
                        arr[i] = ar3[y];
                        y++;
                    }
                }
                else if (o >= ar2.Length)
                {
                    arr[i] = ar3[y];
                    y++;
                }
                else
                {
                    arr[i] = ar3[o];
                    o++;
                }
            }



            foreach (double m in arr)
                Console.WriteLine(m);
            #endregion
            #region Task 14
            Console.WriteLine($"Task 14!");
            Console.WriteLine($"Enter the amount of elements in array");
            amount = 0;
            int.TryParse(Console.ReadLine(), out amount);
            int[] ar5 = new int[amount];
            for (int i = 0; i < amount; i++)
                ar5[i] = rnd.Next(50);
            Console.WriteLine();


            for (int i = 0; i < amount; i++)
                Console.Write("{0:d} ", ar5[i]);
            Console.WriteLine();


            for (int i = 0; i < amount / 2; i++)
            {
                (ar5[i], ar5[amount - i - 1]) = (ar5[amount - i - 1], ar5[i]);
            }


            for (int i = 0; i < amount; i++)
            {
                Console.Write("{0:d} ", ar5[i]);
            }
            Console.WriteLine();


            #endregion
            #region Task 15
            Console.WriteLine($"Task 15!");
            amount = 0;
            int spacing = 0;
            int s;
            Console.WriteLine($"Enter the amount of elements in array");
            int.TryParse(Console.ReadLine(), out amount);
            Console.WriteLine($"Enter the spacing");
            int.TryParse(Console.ReadLine(), out spacing);
            int[] ar6 = new int[amount];
            for (int i = 0; i < ar6.Length; i++)
            {
                ar6[i] = rnd.Next(20);
            }
            Console.WriteLine();


            for (int i = 0; i < ar6.Length; i++)
            {
                Console.WriteLine($"{0:d}", ar6[i]);
            }
            Console.WriteLine();


            for (int i = 0; i < spacing; i++)
            {
                s = ar6[amount - 1];
                for (int j = amount - 1; j > 0; j--)
                {
                    ar6[j] = ar6[j - 1];
                }
                ar6[0] = s;
            }


            for (int i = 0; i < ar6.Length; i++)
            {
                Console.WriteLine($"{0:d}", ar6[i]);
            }
            Console.WriteLine();
            Console.WriteLine($"The end.");

            

            #endregion
            #endregion

        }


    }
}
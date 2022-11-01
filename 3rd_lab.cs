using System;
using System.Collections.Generic;

namespace _3rd_lab
{
    internal class Program
    {
        static void Main()
        {

            #region 6
            double s = 0;
            Console.WriteLine("Start typing 'X':");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"x{i + 1}:");
                double x = Convert.ToDouble(Console.ReadLine());
                s += x * x;
            }
            s = Math.Pow(s, 0.5);
            Console.WriteLine($"L = {s}");
            #endregion

            #region 10
            Console.WriteLine("Enter the size of your array:");
            int rtywnde;
            if (!int.TryParse(Console.ReadLine(), out rtywnde))
            {
                Console.WriteLine("Nope");
                return;
            }
            else if (rtywnde <= 0)
            {
                Console.WriteLine("Nope");
                return;
            }
            int[] S15 = new int[rtywnde];
            Console.WriteLine("Type the array:");
            for (int i = 0; i < S15.Length; i++)
            {
                S15[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Type P:");
            int P;
            if (!int.TryParse(Console.ReadLine(), out P))
            {
                Console.WriteLine("Nope");
                return;
            }
            else if (P <= 0)
            {
                Console.WriteLine("Nope");
                return;
            }
            Console.WriteLine("Type Q:");
            int Q;
            if (!int.TryParse(Console.ReadLine(), out Q))
            {
                Console.WriteLine("Nope");
                return;
            }
            else if (Q <= 0 || Q <= P)
            {
                Console.WriteLine("Nope");
                return;
            }
            int cnt52 = 0;
            for (int i = 0; i < S15.Length; i++)
            {
                if (S15[i] > P && S15[i] < Q)
                {
                    cnt52 += 1;
                }
            }
            int[] P1 = new int[cnt52];
            cnt52 = 0;
            for (int i = 0; i < S15.Length; i++)
            {
                if (S15[i] > P && S15[i] < Q)
                {
                    P1[cnt52] = S15[i];
                    cnt52 += 1;
                }
            }
            for (int i = 0; i < P1.Length; i++)
            {
                Console.Write(P1[i] + " ");
            }
            Console.ReadLine();

            #endregion

            #region 11
            double[] W = new double[10];
            int cnt3 = 0, cnt4 = 0;
            Console.WriteLine("Type the array:");
            for (int i = 0; i < W.Length; i++)
            {
                W[i] = Convert.ToDouble(Console.ReadLine());
                if (W[i] > 0)
                {
                    cnt3 += 1;
                }
            }
            double[] W1 = new double[cnt3];
            for (int i = 0; i < W.Length; i++)
            {
                if (W[i] > 0)
                {
                    W1[cnt4] = W[i];
                    cnt4 += 1;
                }
            }
            for (int i = 0; i < W1.Length; i++)
            {
                Console.Write(W1[i] + " ");
            }
            #endregion

            #region 12
            double[] V = new double[8];
            double m = 0, n = 0, f = 0;
            Console.WriteLine("Type the array:");
            for (int i = 0; i < V.Length; i++)
            {
                V[i] = Convert.ToDouble(Console.ReadLine());
                if (V[i] < 0)
                {
                    f = 1;
                    m = V[i];
                    n = i;
                }
            }
            if (f == 0)
            {
                Console.WriteLine("Nope");
            }
            else
            {
                Console.WriteLine($"Value = {m}, " + $"index = {n}");
            }
            #endregion

            #region 13
            double[] A = new double[10];
            double[] B = new double[5];
            double[] C = new double[5];
            Console.WriteLine("Type the array:");
            for (int i = 0; i < A.Length; i++)
            {
                A[i] = Convert.ToDouble(Console.ReadLine());
                if (i % 2 == 0)
                {
                    B[i / 2] = A[i];
                }
                else
                {
                    C[(i - 1) / 2] = A[i];
                }
            }
            var str1 = string.Join(" ", B);
            var str2 = string.Join(" ", C);
            Console.WriteLine("1st array: " + str1 + "\n2nd array: " + str2);
            #endregion

            #region 2.5
            int[] a1 = new int[13] { 1, -10, 5, -6, -8, 10, 4, 3, 2, -1, 110, -2, -3 };
            int[] neg = new int[1000];
            int max = -100;
            int min = 100;
            int maxi = 0, mini = 0, k1 = 0;
            for (int i = 0; i < 13; i++)
            {
                if (a1[i] > max)
                {
                    max = a1[i];
                    maxi = i;
                }
                if (a1[i] < min)
                {
                    min = a1[i];
                    mini = i;
                }
            }
            for (int i = mini + 1; i < maxi; i++)
            {
                if (a1[i] < 0)
                {
                    neg[k1] = a1[i];
                    Console.Write($"{neg[k1]}");
                    k1++;
                }
            }
            Console.WriteLine();
            #endregion

            #region 2.6
            int d, sr = 0, p, dl = 0, ind = 0;
            Random rand = new Random();
            Console.WriteLine("enter p");
            if (!int.TryParse(Console.ReadLine(), out p))
            {
                Console.WriteLine("incorrect");
                return;
            }
            Console.Write("enter array length ");
            if (!int.TryParse(Console.ReadLine(), out d))
            {
                Console.WriteLine("incorrect length");
                return;
            }
            else if (d <= 0)
            {
                Console.WriteLine("more than 0 pls");
                return;
            }
            int[] a2 = new int[d + 1];
            for (int i = 0; i < a2.Length - 1; i++)
            {
                a2[i] = Convert.ToInt32(Console.ReadLine());
                sr += a2[i];
            }
            Console.WriteLine();
            dl = a2[0];
            sr /= d;
            for (int i = 0; i < a2.Length - 1; i++)
            {
                if (Math.Abs(a2[i] - sr) < dl)
                {
                    dl = Math.Abs(a2[i] - sr);
                    ind = i;
                }
            }
            for (int i = a2.Length - 1; i > ind; i--)
            {
                a2[i] = a2[i - 1];
            }
            a2[ind + 1] = p;
            for (int i = 0; i < a2.Length; i++)
            {
                Console.Write($" {a2[i]}  ");
            }
            #endregion

            #region 2.9
            Random rand1 = new Random();
            Console.Write("enter massive length ");
            if (!int.TryParse(Console.ReadLine(), out d))
            {
                Console.WriteLine("incorrect");
                return;
            }
            else if (d <= 0)
            {
                Console.WriteLine("more than 0 pls");
                return;
            }
            int[] a3 = new int[d];
            for (int i = 0; i < d; i++)
            {
                a3[i] = rand1.Next(-20, 20);
                Console.Write($" {a3[i]} ");
            }
            int max1 = -100;
            int min1 = 100;
            int maxi1 = 0, mini1 = 0;
            for (int i = 0; i < d; i++)
            {
                if (a3[i] > max1)
                {
                    max1 = a3[i];
                    maxi1 = i;
                }
                if (a3[i] < min1)
                {
                    min1 = a3[i];
                    mini1 = i;
                }
            }
            if (mini1 > maxi1)
            {
                maxi1 += mini1;
                mini1 = maxi1 - mini1;
                maxi1 = maxi1 - mini1;
            }
            double sr1 = 0, med = 0;

            for (int i = mini1 + 1; i < maxi1; i++)
            {
                sr1 += a3[i];
                med++;
            }
            if (med == 0)
            {
                Console.WriteLine("no medi elems");
            }
            else
            {
                sr1 /= med;
                Console.WriteLine($"med arifm = {Math.Round(sr1, 4)}");
            }
            Console.WriteLine("=====");
            #endregion

            #region 2.10
            List<int> a4 = new List<int>() { 100, 2, 5, 10, -50, -20, 1, 3, 4, -100 };
            int minn = 1000;
            int index = 0;
            for (int i = 0; i < a4.Count; i++)
            {
                if ((a4[i] > 0) && (a4[i] < minn))
                {
                    minn = a4[i];
                    index = i;
                }
            }
            a4.RemoveAt(index);
            for (int i = 0; i < a4.Count; i++)
            {
                Console.Write($"  {a4[i]}  ");
            }
            Console.WriteLine();
            Console.WriteLine("=====");
            #endregion
            
            #region 2.11
            List<int> a5 = new List<int> { 100, 2, 5, 10, -50, -20, 3, 4, -50, 34, -11, -12, 1, -3 };
            int index1 = 0;
            int pp;
            Console.WriteLine("enter P");
            if (!int.TryParse(Console.ReadLine(), out pp))
            {
                Console.WriteLine("incorrect");
                return;
            }
            for (int i = 0; i < a5.Count; i++)
            {
                if (a5[i] > 0)
                {
                    index1 = i;
                }
            }
            a5.Insert(index1 + 1, pp);
            for (int i = 0; i < a5.Count; i++)
            {
                Console.Write($"  {a5[i]}  ");
            }
            Console.WriteLine();
            Console.WriteLine("=====");
            #endregion

            #region 2.13
            List<int> a6 = new List<int> { 100, 2, 5, 10, -50, -20, 300, 4, -50, 340, -11, -12, 1, -3 };
            int maks = -10000;
            int jj = 0;
            for (int i = 0; i < a6.Count; i++)
            {
                if ((i % 2 == 0) && (a6[i] > maks))
                {
                    maks = a6[i];
                    jj = i;
                }
            }
            a6[jj] = jj;
            Console.WriteLine($"Maks={maks}\t index={jj}");
            for (int i = 0; i < a6.Count; i++)
            {
                Console.Write($" {a6[i]} ");
            }
            Console.WriteLine();
            Console.WriteLine("=====");
            #endregion

            #region 2.15
            Console.WriteLine("Enter the size of your A array:");
            int ee;
            if (!int.TryParse(Console.ReadLine(), out ee))
            {
                Console.WriteLine("incorrect");
                return;
            }
            double[] a7 = new double[ee];
            Console.WriteLine("Type the A array:");
            for (int i = 0; i < a7.Length; i++)
            {
                a7[i] = Convert.ToDouble(Console.ReadLine());
            }
            Console.WriteLine("Enter the size of your B array:");
            int nn;
            if (!int.TryParse(Console.ReadLine(), out nn))
            {
                Console.WriteLine("incorrect");
                return;
            }
            double[] BB = new double[nn];
            Console.WriteLine("Type the B array:");
            for (int i = 0; i < BB.Length; i++)
            {
                BB[i] = Convert.ToDouble(Console.ReadLine());
            }
            Console.WriteLine("Enter the k:");
            int kk;
            if (!int.TryParse(Console.ReadLine(), out kk))
            {
                Console.WriteLine("incorrect");
                return;
            }
            if (kk >= ee)
            {
                Console.WriteLine("nah");
            }
            else
            {
                for (int i = 0; i < a7.Length; i++)
                {
                    if (i == kk)
                    {
                        for (int j = 0; j < BB.Length; j++)
                        {
                            Console.Write(BB[j] + " ");
                        }
                        Console.Write(a7[i] + " ");
                    }
                    else
                    {
                        Console.Write(a7[i] + " ");
                    }
                }
            }
            #endregion
        }
    }
}

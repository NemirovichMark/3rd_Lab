using System;
using System.Collections.Generic;

namespace _3rd_lab
{
    internal class Program
    {
        static void Main()
        {

            #region 1.6
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

            #region 1.10
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

            #region 1.11
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

            #region 1.12
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

            #region 1.13
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


            #region 3.1
            Console.WriteLine("Enter the size of your array:");
            int eee = Convert.ToInt32(Console.ReadLine());
            double[] NN = new double[eee];
            List<int> IND = new List<int>();
            double maxo;
            Console.WriteLine("Type the array:");
            for (int i = 0; i < NN.Length; i++)
            {
                NN[i] = Convert.ToDouble(Console.ReadLine());
            }
            maxo = NN[0];
            for (int i = 0; i < NN.Length; i++)
            {
                if (maxo < NN[i])
                {
                    maxo = NN[i];
                    IND.Clear();

                }
                if (maxo == NN[i])
                {
                    IND.Add(i);
                }
            }
            for (int i = 0; i < IND.Count; i++)
            {
                Console.Write(IND[i] + " ");
            }
            #endregion

            #region 3.5
            Console.WriteLine("Enter the size of your array:");
            int eeee = Convert.ToInt32(Console.ReadLine());
            double[] NNN = new double[eeee];
            double mino;
            int minoi;
            Console.WriteLine("Type the array:");
            for (int i = 0; i < NNN.Length; i++)
            {
                NNN[i] = Convert.ToDouble(Console.ReadLine());
            }
            for (int i = 0; i < NNN.Length - 1; i += 2)
            {
                mino = NNN[i];
                minoi = i;
                for (int j = i + 2; j < NNN.Length; j += 2)
                {
                    if (NNN[j] < mino)
                    {
                        mino = NNN[j];
                        minoi = j;
                    }
                }
                NNN[minoi] = NNN[i];
                NNN[i] = mino;
            }
            for (int i = 0; i < NNN.Length; i++)
            {
                Console.Write(NNN[i] + " ");
            }
            #endregion

            #region 3.8
            Console.WriteLine("Enter the size of your array:");
            int qwerty = Convert.ToInt32(Console.ReadLine());
            double[] Z = new double[qwerty];
            double maximum1;
            int maximum2;
            Console.WriteLine("Type the array:");
            for (int i = 0; i < Z.Length; i++)
            {
                Z[i] = Convert.ToDouble(Console.ReadLine());
            }
            for (int i = 0; i < 12 - 1; i++)
            {
                if (Z[i] < 0)
                {
                    maximum1 = Z[i];
                    maximum2 = i;
                    for (int j = i + 1; j < 12; j++)
                    {
                        if (Z[j] < 0 && Z[j] > max1)
                        {
                            maximum1 = Z[j];
                            maximum2 = j;
                        }
                    }
                    Z[maximum2] = Z[i];
                    Z[i] = maximum1;
                }
            }
            for (int i = 0; i < Z.Length; i++)
            {
                Console.Write(Z[i] + " ");
            }
            #endregion

            #region 3.9
            Console.WriteLine("Enter the size of your array:");
            int werty = Convert.ToInt32(Console.ReadLine());
            double[] S1 = new double[werty];
            int cnt1 = 0, cnt2 = 0, max9 = 0, max2 = 0;
            Console.WriteLine("Type the array:");
            for (int i = 0; i < S1.Length; i++)
            {
                S1[i] = Convert.ToDouble(Console.ReadLine());
            }

            for (int i = 0; i < S1.Length - 1; i++)
            {
                cnt1 += 1;
                cnt2 += 1;
                if (S1[i] >= S1[i + 1])
                {
                    cnt1 = 1;
                }
                if (S1[i] <= S1[i + 1])
                {
                    cnt2 = 1;
                }
                max9 = Math.Max(max9, cnt1);
                max2 = Math.Max(max2, cnt2);
            }

            Console.Write(Math.Max(max9, max2));
            #endregion

            #region 3.12
            double[] S2 = new double[12];
            int cnt11 = 0;
            Console.WriteLine("Type the array:");
            for (int i = 0; i < S2.Length; i++)
            {
                S2[i] = Convert.ToDouble(Console.ReadLine());
            }

            for (int i = 0; i < S2.Length; i++)
            {
                if (S2[i] < 0)
                {
                    cnt11 += 1;
                }
            }
            double[] SS2 = new double[cnt11];
            cnt11 = 0;
            for (int i = 0; i < S2.Length; i++)
            {
                if (S2[i] >= 0)
                {
                    SS2[cnt11] = S2[i];
                    cnt11 += 1;
                }
            }
            for (int i = 0; i < SS2.Length; i++)
            {
                Console.Write(SS2[i] + " ");
            }
            #endregion

            #region 3.13
            Console.WriteLine("Enter the size of your array:");
            int erty = Convert.ToInt32(Console.ReadLine());
            double[] S3 = new double[erty];
            int nig;
            Console.WriteLine("Type the array:");
            for (int i = 0; i < S3.Length; i++)
            {
                S3[i] = Convert.ToDouble(Console.ReadLine());
            }
            for (int i = 0; i < S3.Length; i++)
            {
                nig = 0;
                for (int j = 0; j < S3.Length; j++)
                {
                    if (i > j && S3[i] == S3[j])
                    {
                        nig = 1;
                    }
                    if (nig == 1)
                    {
                        break;
                    }
                }
                if (nig == 0)
                {
                    Console.Write(S3[i] + " ");
                }
            }
            #endregion

            #region 3.11
            Console.WriteLine("Enter the size of your array:");
            int rty = Convert.ToInt32(Console.ReadLine());
            int[] S4 = new int[rty];
            int ind1, min5, i5, i11, i21;
            Console.WriteLine("Type the array:");
            for (int i = 0; i < S4.Length; i++)
            {
                S4[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Type the X:");
            double x5 = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < S4.Length; i++)
            {
                min5 = S4[i];
                ind1 = i;
                for (int j = i + 1; j < S4.Length; j++)
                {
                    if (S4[j] < min5)
                    {
                        min5 = S4[j];
                        ind1 = j;
                    }
                }
                S4[ind1] = S4[i];
                S4[i] = min5;
            }
            for (int i = 0; i < S4.Length; i++)
            {
                if (S4[i] >= 0)
                {
                    Console.Write(S4[i] + " ");
                }
            }
            i11 = 0;
            i21 = S4.Length;
            while (true)
            {
                i5 = (i11 + i21) / 2;
                if (i21 < i11)
                {
                    Console.WriteLine("\nNope");
                    break;
                }
                if (x5 == S4[i5])
                {
                    Console.WriteLine("\nYes, ind = " + i5);
                    break;
                }
                if (x5 < S4[i5])
                {
                    i21 = i5 - 1;
                }
                else
                {
                    i11 = i5 + 1;
                }
            }
            #endregion

            #region 3.12
            int[] a = { 3, 2 };
            int[] b = { 6 };
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i]);
                Console.Write(' ');
            }
            Console.WriteLine();
            for (int i = 0; i < b.Length; i++)
            {
                Console.Write(b[i]);
                Console.Write(' ');
            }
            Console.WriteLine();

            int[] c = new int[a.Length + b.Length];
            for (int i = 0; i < Math.Min(a.Length, b.Length); i++)
            {
                c[2 * i] = a[i];
                c[2 * i + 1] = b[i];
            }

            if (a.Length > b.Length)
            {
                for (int i = 0; i < a.Length - b.Length; i++)
                {
                    c[2 * b.Length + i] = a[b.Length + i];
                }
            }
            if (b.Length > a.Length)
            {
                for (int i = 0; i < b.Length - a.Length; i++)
                {
                    c[2 * a.Length + i] = b[a.Length + i];
                }
            }




            for (int i = 0; i < c.Length; i++)
            {
                Console.Write(c[i]);
                Console.Write(' ');
            }
            #endregion

            #region 3.13
            Console.WriteLine("Enter the size of your A array:");
            int rtyw = Convert.ToInt32(Console.ReadLine());
            int[] S8 = new int[rtyw];
            int ind2, min6;
            Console.WriteLine("Type the A array:");
            for (int i = 0; i < S8.Length; i++)
            {
                S8[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < S8.Length; i++)
            {
                min6 = S8[i];
                ind2 = i;
                for (int j = i + 1; j < S8.Length; j++)
                {
                    if (S8[j] > min6)
                    {
                        min6 = S8[j];
                        ind2 = j;
                    }
                }
                S8[ind2] = S8[i];
                S8[i] = min6;
            }

            Console.WriteLine("\nEnter the size of your B array:");
            int rtywe = Convert.ToInt32(Console.ReadLine());
            int[] S9 = new int[rtywe];
            int ind3, min7;
            Console.WriteLine("Type the B array:");
            for (int i = 0; i < S9.Length; i++)
            {
                S9[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < S9.Length; i++)
            {
                min7 = S9[i];
                ind3 = i;
                for (int j = i + 1; j < S9.Length; j++)
                {
                    if (S9[j] > min7)
                    {
                        min7 = S9[j];
                        ind3 = j;
                    }
                }
                S9[ind3] = S9[i];
                S9[i] = min7;
            }

            int[] S10 = new int[rtywe + rtyw];
            int ind4 = 0, ind5 = 0, f1 = 0, f2 = 0;
            for (int i = 0; i < S10.Length; i++)
            {
                if (ind4 >= rtyw)
                {
                    f2 = 1;
                    break;
                }
                if (ind5 >= rtywe)
                {
                    f1 = 1;
                    break;
                }
                if (S8[ind4] >= S9[ind5])
                {
                    S10[i] = S8[ind4];
                    ind4 += 1;
                }
                if (S8[ind4] < S9[ind5])
                {
                    S10[i] = S9[ind5];
                    ind5 += 1;
                }
            }
            if (f1 == 1)
            {
                for (int i = ind5; i < S10.Length; i++)
                {
                    S10[i] = S8[ind4];
                    ind4 += 1;
                }
            }
            if (f2 == 1)
            {
                for (int i = ind4; i < S10.Length; i++)
                {
                    S10[i] = S9[ind5];
                    ind5 += 1;
                }
            }
            for (int i = 0; i < S10.Length; i++)
            {
                Console.Write(S10[i] + " ");
            }
            #endregion

            #region 3.14
            Console.WriteLine("Enter the size of your array:");
            int rtywn = Convert.ToInt32(Console.ReadLine());
            int[] S11 = new int[rtywn];
            int num1;
            Console.WriteLine("Type the array:");
            for (int i = 0; i < S11.Length; i++)
            {
                S11[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < S11.Length / 2; i++)
            {
                num1 = S11[rtywn - i - 1];
                S11[rtywn - i - 1] = S11[i];
                S11[i] = num1;
            }
            for (int i = 0; i < S11.Length; i++)
            {
                Console.Write(S11[i] + " ");
            }
            #endregion

            #region 3.15
            Console.WriteLine("Enter the size of your array:");
            int rtywnd = Convert.ToInt32(Console.ReadLine());
            int[] S12 = new int[rtywnd];
            int num2;
            Console.WriteLine("Type the array:");
            for (int i = 0; i < S12.Length; i++)
            {
                S12[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Enter the m:");
            int num3 = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < num3 % rtywnd; i++)
            {
                num2 = S12[S12.Length - 1];
                for (int j = S12.Length - 1; j > 0; j--)
                {
                    S12[j] = S12[j - 1];
                }
                S12[0] = num2;
            }

            for (int i = 0; i < S12.Length; i++)
            {
                Console.Write(S12[i] + " ");
            }
            #endregion
        }
    }
}

using System;
using System.Linq;

namespace Lab_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string ERROR = "Input incorrect!";
            goto Task;

            #region Task_1_6
            Console.WriteLine("Task 1.6");
            double[] a = new double[] { 1, 2, 3, 4, 5 };
            double S = 0;
            for (int i = 0; i < 5; i++)
            {
                S = S + a[i] * a[i];
            }
            Console.WriteLine($"L={Math.Sqrt(S)}\n");
            #endregion

            #region Task_1_10
            Console.WriteLine("Task 1.10");
            double[] aa = new double[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int k = 0;
            double P = 2, Q = 5;
            if (P >= Q)
            {
                Console.WriteLine(ERROR);
                return;
            }
            foreach (double i in aa)
            {
                if (i > P && i < Q)
                {
                    k++;
                }
            }
            Console.WriteLine($"Between P and Q: {k}\n");
            #endregion

            #region Task_1_11
            Console.WriteLine("Task 1.11");
            double[] b = new double[] { -1, -2, 0, 3, 4, 5, 6, 7, 8, 9 };
            double[] bb = new double[10];
            int m = 0;
            foreach (double i in b)
            {
                if (i > 0)
                {
                    bb[m] = i;
                    m++;
                }
            }

            for (int i = 0; i < m; i++)
            {
                Console.Write($"{bb[i]} ");
            }
            Console.WriteLine("\n");
            #endregion

            #region Task_1_12
            Console.WriteLine("Task 1.12");
            double[] aaa = new double[8] { -1, -2, -3, 4, 5, 6, 7, 8 };
            double n = 0;
            k = 0;
            for (int i = 0; i < 8; i++)
            {
                if (aaa[i] < 0)
                {
                    n = aaa[i];
                    k = i;
                }
            }
            Console.WriteLine($"The last negative {n} and it's indeks {k}\n");
            #endregion

            #region Task_1_13
            Console.WriteLine("Task 1.13");
            double[] array = new double[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            double[] array1 = new double[5];
            double[] array2 = new double[5];
            int v = 0;
            for (int i = 0; i < 9; i = i + 2)
            {
                array1[v] = array[i];
                array2[v] = array[i + 1];
                v++;
            }
            Console.Write("array1: ");
            foreach (double i in array1)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
            Console.Write("array2: ");
            foreach (double i in array2)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine("\n");
            #endregion

            #region Task_2_5
            Console.WriteLine("Task 2.5");
            int nn;
            Console.Write("Please enter the length massive: ");
            if (!int.TryParse(Console.ReadLine(), out nn))
            {
                Console.WriteLine(ERROR);
                return;
            }
            double[] mas = new double[nn];
            double[] amountot = new double[nn - 2];
            double x;
            for (int i = 0; i < mas.Length; i++)
            {
                Console.Write("Please enter the 'X': ");
                if (!double.TryParse(Console.ReadLine(), out x))
                {
                    Console.WriteLine("Please enter the correct data");
                    continue;
                }
                mas[i] = x;
            }
            double max = mas[0];
            double min = mas[0];
            int index_max = 0;
            int index_min = 0;
            for (int i = 0; i < mas.Length; i++)
            {
                if (max < mas[i])
                {
                    max = mas[i];
                    index_max = i;
                }
                if (min > mas[i])
                {
                    min = mas[i];
                    index_min = i;
                }
            }
            int mm = 0;
            if (index_max > index_min)
            {
                for (int i = index_min + 1; i < index_max; i++)
                {
                    if (mas[i] < 0)
                    {
                        amountot[mm] = mas[i];
                        mm++;
                    }
                }
            }
            if (mm == 0) mm = 0;
            if (index_max < index_min)
            {
                for (int i = index_max + 1; i < index_min; i++)
                {
                    if (mas[i] < 0)
                    {
                        amountot[mm] = mas[i];
                        mm++;
                    }
                }
            }
            for (int i = 0; i < mm; i++)
            {
                Console.Write(amountot[i] + " ");
            }
            Console.WriteLine("\n");
        #endregion

            #region Task_2_6
            Console.WriteLine("Task 2.6");
            Console.Write("Please enter length of massive: ");
            if (!int.TryParse(Console.ReadLine(), out k) || k < 0)
            {
                Console.WriteLine(ERROR);
                return;
            }
            Console.Write("Please enter 'P': ");
            if (!double.TryParse(Console.ReadLine(), out P))
            {
                Console.WriteLine(ERROR);
                return;
            }

            double sum = 0;
            double mid = 0;
            double[] M = new double[k + 1];
            int mid_I = 0;
            for (int i = 0; i < k; i++)
            {
                Console.Write("Pleas enter the 'X': ");
                if (!double.TryParse(Console.ReadLine(), out x))
                {
                    Console.WriteLine(ERROR);
                    return;
                }
                M[i] = x;
                sum += x;
            }
            mid = sum / k;
            for (int i = 0; i < k; i++)
            {
                if (Math.Abs(mid - M[mid_I]) > Math.Abs(mid - M[i])) mid_I = i;
            }
            for (int i = k-1; i >= mid_I +1; i--) M[i + 1] = M[i];
            M[mid_I + 1] = mid;
            for (int i = 0; i < k + 1; i++) Console.Write(M[i] + " ");
            #endregion

            #region Task_2_9
            Console.WriteLine("Task 2.9");
            Console.Write("Please enter length of massive: ");
            if (!int.TryParse(Console.ReadLine(), out k) || k < 0)
            {
                Console.WriteLine(ERROR);
                return;
            }
            M = new double[k];
            for (int i = 0; i < k; i++)
            {
                Console.Write("Write 'X': ");
                if (!double.TryParse(Console.ReadLine(), out x))
                {
                    Console.WriteLine(ERROR);
                    return;
                }
                M[i] = x;
            }
            int mini = 0, maxi = 0;
            max = M[0];
            min = M[0];
            for (int i = 1; i < k; i++)
            {
                if (max < M[i])
                {
                    max = M[i];
                    maxi = i;
                }
                if (min > M[i])
                {
                    min = M[i];
                    mini = i;
                }
            }
            sum = 0;
            n = 0;
            if (maxi == mini) Console.WriteLine("Arithmetic mean = 0\n");
            else if (maxi > mini)
            {
                for (int i = (mini + 1); i < maxi; i++)
                {
                    sum += M[i];
                    n += 1;
                }
                Console.WriteLine($"Arithmetic mean = {sum / n}\n");
            }
            else
            {
                for (int i = (maxi + 1); i < mini; i++)
                {
                    sum += M[i];
                    n += 1;
                }
                Console.WriteLine($"Arithmetic mean = {sum / n}\n");

            }
        #endregion

            #region Task_2_10
            Console.WriteLine("Task 2.10");
            Console.Write("Write length of massive: ");
            mini = 0;
            min = 0;
            if (!int.TryParse(Console.ReadLine(), out k) || k <= 0)
            {
                Console.WriteLine(ERROR);
                return;
            }
            M = new double[k];
            for (int i =0; i < k; i++)
            {
                Console.Write("Write X: ");
                if (!double.TryParse(Console.ReadLine(), out x))
                {
                    Console.WriteLine(ERROR);
                    return;
                }
                M[i] = x;
                if (x > 0)
                {
                    min = x;
                    mini = i;
                }
            }
            for (int i = 0; i < k; i++)
            {
                if (M[i] > 0 && M[i] < min)
                {
                    min = M[i];
                    mini = i;
                }
            }
            Console.WriteLine(mini);
            for (int i = mini; i < k-1; i++)
            {
                M[i] = M[i+1];
            }
            for (int i = 0; i < k - 1; i++) Console.Write(M[i] + " ");
            Console.WriteLine();
        #endregion

            #region Task_2_11
            Console.WriteLine("Task 2.11");
            Console.Write("Write length of massive: ");
            if (!int.TryParse(Console.ReadLine(), out k) || k <= 0)
            {
                Console.WriteLine(ERROR);
                return;
            }
            Console.Write("Write P: ");
            if (!double.TryParse(Console.ReadLine(), out P))
            {
                Console.WriteLine(ERROR);
                return;
            }
            M = new double[k + 1];
            int N = 0;
            for (int i = 0; i < k; i++)
            {
                Console.Write("Write X: ");
                if (!double.TryParse(Console.ReadLine(), out x))
                {
                    Console.WriteLine(ERROR);
                    return;
                }
                M[i] = x;
                if (x > 0) N = i;
            }
            for (int i = k-1; i>N; i--)
            {
                M[i + 1] = M[i];
            }
            M[N + 1] = P;
            foreach (double i in M) Console.Write(i + " ");
            Console.WriteLine();
            #endregion

            #region Task_2_13
            Console.WriteLine("Task 2.13");
            Console.Write("Write length of massive: ");
            if (!int.TryParse(Console.ReadLine(), out k) || k <= 0)
            {
                Console.WriteLine(ERROR);
                return;
            }
            M = new double[k];
            for (int i = 0; i < k; i++)
            {
                Console.Write("Write X: ");
                if (!double.TryParse(Console.ReadLine(), out x))
                {
                    Console.WriteLine(ERROR);
                    return;
                }
                M[i] = x;
            }
            max = M[0];
            maxi = 0;
            for (int i = 0; i < k; i+= 2)
            {
                if (M[i] > max)
                {
                    max = M[i];
                    maxi = i;
                }
            }
            M[maxi] = maxi;
            foreach (double i in M) Console.Write(i + " ");
            #endregion

            #region Task_2_15
            Console.WriteLine("Task 2.15");
            Console.Write("Write length of A massive: ");
            if (!int.TryParse(Console.ReadLine(), out k) || k <= 0)
            {
                Console.WriteLine(ERROR);
                return;
            }
            Console.Write("Write length of B massive: ");
            if (!int.TryParse(Console.ReadLine(), out int K) || K <= 0)
            {
                Console.WriteLine(ERROR);
                return;
            }
            Console.Write("Write k: ");
            if (!int.TryParse(Console.ReadLine(), out N) || N < 0 || N > k-2)
            {
                Console.WriteLine(ERROR);
                return;
            }
            M = new double[k+K];
            double[] C = new double[K];
            for (int i = 0; i < k; i++)
            {
                Console.Write("Write X for A: ");
                if (!double.TryParse(Console.ReadLine(), out x))
                {
                    Console.WriteLine(ERROR);
                    return;
                }
                M[i] = x;
            }
            Console.WriteLine();
            for (int i = 0; i < K; i++)
            {
                Console.Write("Write X for B: ");
                if (!double.TryParse(Console.ReadLine(), out x))
                {
                    Console.WriteLine(ERROR);
                    return;
                }
                C[i] = x;
            }
            int L = k + K;
            for (int i = k+K-1; i >= L - (k-(N+1)); i--)
            {
                M[i] = M[i - K];
            }
            k = 0;
            for (int i = N+1; i <= N+K; i++)
            {
                M[i] = C[k];
                k++;
            }
            Console.WriteLine();
            foreach (double i in M) Console.Write(i + " ");
            Console.WriteLine();
        #endregion

            #region Task_3_1
            Console.WriteLine("Task 3.1");
            Console.Write("Write length of massive: ");
            if (!int.TryParse(Console.ReadLine(), out k) || k <= 0)
            {
                Console.WriteLine(ERROR);
                return;
            }
            M = new double[k];
            maxi = 0;
            C = new double[k];
            for (int i = 0; i < k; i++)
            {
                Console.Write("Write X: ");
                if (!double.TryParse(Console.ReadLine(), out x))
                {
                    Console.WriteLine(ERROR);
                    return;
                }
                M[i] = x;
                if (M[maxi] < x)
                {
                    maxi = i;
                }
            }
            L = 0;
            for(int i =0; i < k; i++)
            {
                if (M[i] == M[maxi])
                {
                    C[L] = i;
                    L++;
                }
            }
            for (int i = 0; i < L; i++)
            {
                Console.Write(C[i] + " ");
            }
            Console.WriteLine();
        #endregion

            #region Task_3_5
            Console.WriteLine("Task 3.5");
            Console.Write("Write length of massive: ");
            if (!int.TryParse(Console.ReadLine(), out k) || k <= 0)
            {
                Console.WriteLine(ERROR);
                return;
            }
            M = new double[k];
            for (int i = 0; i < k; i++)
            {
                Console.Write("Write X: ");
                if (!double.TryParse(Console.ReadLine(), out x))
                {
                    Console.WriteLine(ERROR);
                    return;
                }
                M[i] = x;
            }
            for(int i = 0; i < k; i += 2)
            {
                for (int j = i + 2; j < k; j += 2)
                {
                    if (M[i] > M[j])
                    {
                        (M[j], M[i]) = (M[i], M[j]);
                    }
                }
            }
            foreach(double i in M)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        #endregion

            #region Task_3_8
            Console.WriteLine("Task 3.8");
            Console.Write("Write length of massive: ");
            if (!int.TryParse(Console.ReadLine(), out k) || k <= 0)
            {
                Console.WriteLine(ERROR);
                return;
            }
            M = new double[k];
            C = new double[k];
            int[] A = new int[k];
            N = 0;
            for (int i = 0; i < k; i++)
            {
                Console.Write("Write X: ");
                if (!double.TryParse(Console.ReadLine(), out x))
                {
                    Console.WriteLine(ERROR);
                    return;
                }
                M[i] = x;
                if (x < 0)
                {
                    C[N] = x;
                    A[N] = i;
                    N++;
                }
            }
            for (int i = 0; i < N; i++)
            {
                for (int j = i; j<N; j++)
                {
                    if (C[i] < C[j])
                    {
                        (C[i], C[j]) = (C[j], C[i]);
                    }
                }
            }
            for (int i = 0; i < N; i++)
            {
                M[A[i]] = C[i];
            }
            foreach(double i in M)
            {
                Console.Write(i + " ");
            }
        #endregion

            #region Task_3_9
            Console.WriteLine("Task 3.9");
            Console.Write("Write length of massive: ");
            if (!int.TryParse(Console.ReadLine(), out k) || k <= 0)
            {
                Console.WriteLine(ERROR);
                return;
            }
            M = new double[k];
            int max1 = 1, max2 = 1, sh1 = 1, sh2 = 1;
            for (int i = 0; i < k; i++)
            {
                Console.Write("Write X: ");
                if (!double.TryParse(Console.ReadLine(), out x))
                {
                    Console.WriteLine(ERROR);
                    return;
                }
                M[i] = x;
            }
            for (int i = 0; i < k-1; ++i)
            {
                if (M[i] < M[i + 1])
                {
                    sh1++;
                    max2 = Math.Max(max2, sh2);
                    sh2 = 1;
                    continue;
                }
                if (M[i] > M[i + 1])
                {
                    sh2++;
                    max1 = Math.Max(max1, sh1);
                    sh1 = 1;
                    continue;
                }
                max1 = Math.Max(max1, sh1);
                max2 = Math.Max(max2, sh2);
                sh1 = 1;
                sh2 = 1;
            }
            int s = Math.Max(max1, max2);
            Console.WriteLine(s+"\n");
        #endregion

            #region Task_3_12
            Console.WriteLine("Task 3.12");
            Console.Write("Write length of massive: ");
            if (!int.TryParse(Console.ReadLine(), out k) || k <= 0)
            {
                Console.WriteLine(ERROR);
                return;
            }
            M = new double[k];
            C = new double[k];
            for (int i = 0; i < k; i++)
            {
                Console.Write("Write X: ");
                if (!double.TryParse(Console.ReadLine(), out x))
                {
                    Console.WriteLine(ERROR);
                    return;
                }
                M[i] = x;
            }
            L = 0;
            for(int i = 0; i < k; i++)
            {
                if (M[i] > 0)
                {
                    C[L] = M[i];
                    L++;
                }
            }
            for(int i = 0; i < L; i++)
            {
                Console.Write(C[i] + " ");
            }
            Console.WriteLine();
        #endregion

        Task: Console.WriteLine();
            #region Task_3_13
            Console.WriteLine("Task 3.13");
            Console.Write("Write length of massive: ");
            if (!int.TryParse(Console.ReadLine(), out k) || k <= 0)
            {
                Console.WriteLine(ERROR);
                return;
            }
            M = new double[k];
            for (int i = 0; i < k; i++)
            {
                Console.Write("Write X: ");
                if (!double.TryParse(Console.ReadLine(), out x))
                {
                    Console.WriteLine(ERROR);
                    return;
                }
                M[i] = x;
            }
            M = M.Distinct().ToArray();
            foreach (double i in M)
            {
                Console.Write(i + " ");
            }
            #endregion
        }
    }
}

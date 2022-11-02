using System;
namespace laba_3
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task 1_6
            double l, sum = 0;
            double[] a = new double[5];
            Console.WriteLine("Enter elements separated by a space");
            string s = Console.ReadLine();
            string[] c = s.Split(' ');
            for (int i = 0; i < 5; i++)
            {
                double.TryParse(c[i], out a[i]);
            }
            Console.WriteLine("Initial numbers:");
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"{a[i]} ");
                sum += a[i] * a[i];
            }
            l = Math.Sqrt(sum);
            Console.WriteLine();
            Console.WriteLine($"The length of the vector is {l}");
            #endregion

            #region Task 1_10
            double k = 0, p, q;
            double[] a = new double[10];
            Console.Write("Enter a smaller number: ");
            string vvod_p = Console.ReadLine();
            double.TryParse(vvod_p, out p);
            Console.Write("Enter a larger number: ");
            string vvod_q = Console.ReadLine();
            double.TryParse(vvod_q, out q);
            if (p > q)
            {
                Console.WriteLine("Error");
                return;
            }
            Console.WriteLine("Enter elements separated by a space");
            string s = Console.ReadLine();
            string[] c = s.Split(' ');
            for (int i = 0; i < 10; i++)
            {
                double.TryParse(c[i], out a[i]);
            }
            Console.WriteLine("Initial numbers:");
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"{a[i]} ");
                if (a[i] > p && a[i] < q)
                {
                    k += 1;
                }
            }
            Console.WriteLine();
            Console.WriteLine($"Number of elements: {k}");
            #endregion

            #region Task 1_11
            double[] a = new double[10];
            int k = 0;
            Console.WriteLine("Enter elements separated by a space");
            string s = Console.ReadLine();
            string[] c = s.Split(' ');
            for (int i = 0; i < 10; i++)
            {
                double.TryParse(c[i], out a[i]);
            }
            foreach (double x in a)
            {
                if (x > 0)
                {
                    k += 1;
                }
            }
            if (k == 0)
            {
                Console.WriteLine("There are no positive numbers");
                return;
            }
            double[] b = new double[k];
            Console.WriteLine("Initial numbers:");
            int ch = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"{a[i]} ");
                if (a[i] > 0)
                {
                    b[ch] = a[i];
                    ch += 1;
                }
            }
            Console.WriteLine();
            Console.WriteLine("Positive numbers:");
            for (int i = 0; i < k; i++)
            {
                Console.Write($"{b[i]} ");
            }
            #endregion

            #region Task 1_12
            double[] a = new double[8];
            double answ = 0;
            int answ_i = -1;
            Console.WriteLine("Enter elements separated by a space");
            string s = Console.ReadLine();
            string[] c = s.Split(' ');
            for (int i = 0; i < 8; i++)
            {
                double.TryParse(c[i], out a[i]);
            }
            Console.WriteLine("Initial numbers:");
            for (int i = 0; i < 8; i++)
            {
                Console.Write($"{a[i]} ");
                if (a[i] < 0)
                {
                    answ = a[i];
                    answ_i = i;
                }
            }
            Console.WriteLine();
            if (answ_i == -1)
            {
                Console.WriteLine("There are no negative numbers");
                return;
            }
            Console.WriteLine($"The last negative number: {answ}");
            Console.WriteLine($"The number under the number {answ_i + 1}");
            #endregion

            #region Task 1_13
            double[] a = new double[10];
            double[] even = new double[5];
            double[] uneven = new double[5];
            int ch_even = 0, ch_uneven = 0;
            Console.WriteLine("Enter elements separated by a space");
            string s = Console.ReadLine();
            string[] c = s.Split(' ');
            for (int i = 0; i < 10; i++)
            {
                double.TryParse(c[i], out a[i]);
                if (i % 2 == 0)
                {
                    double.TryParse(c[i], out even[ch_even]);
                    ch_even += 1;
                }
                else
                {
                    double.TryParse(c[i], out uneven[ch_uneven]);
                    ch_uneven += 1;
                }
            }
            Console.WriteLine("Initial numbers:");
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"{a[i]} ");
            }
            Console.WriteLine();
            Console.WriteLine("These numbers were in even places:");
            foreach (double x in even)
            {
                Console.Write($"{x} ");
            }
            Console.WriteLine();
            Console.WriteLine("These numbers were in uneven places:");
            foreach (double k in uneven)
            {
                Console.Write($"{k} ");
            }
            #endregion

            #region Task 2_5
            int n, max_i = 0, min_i = 0, min_ans, max_ans;
            double max, min;
            Console.Write("Enter the number of array elements: ");
            string vvod_n = Console.ReadLine();
            if (int.TryParse(vvod_n, out n))
            {
                int.TryParse(vvod_n, out n);
                if (n < 3)
                {
                    Console.WriteLine("Error");
                    return;
                }
            }
            else
            {
                Console.WriteLine("Error");
                return;
            }
            double[] a = new double[n];
            Console.WriteLine("Enter elements separated by a space");
            string s = Console.ReadLine();
            string[] c = s.Split(' ');
            for (int i = 0; i < n; i++)
            {
                double.TryParse(c[i], out a[i]);
            }
            Console.WriteLine("Initial numbers:");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{a[i]} ");
            }
            Console.WriteLine();
            max = a[0];
            min = a[0];
            for (int i = 0; i < n; i++)
            {
                if (max == a[i] && i != 0)
                {
                    Console.WriteLine("Enter one maximum number");
                    return;
                }
                if (max < a[i])
                {
                    max = a[i];
                    max_i = i;
                }
                if (min == a[i] && i != 0)
                {
                    Console.WriteLine($"Enter one minimum number");
                    return;
                }
                if (min > a[i])
                {
                    min = a[i];
                    min_i = i;
                }
            }
            Console.Write("Answer: ");
            int ch = 0;
            min_ans = Math.Min(min_i, max_i);
            max_ans = Math.Max(min_i, max_i);
            for (int j = min_ans + 1; j < max_ans; j++)
            {
                if (a[j] < 0)
                {
                    ch += 1;
                    Console.Write($"{a[j]} ");
                }
            }
            if (ch == 0)
            {
                Console.Write("there are no negative numbers");
                return;
            }
            #endregion

            #region Task 2_6
            double p, mid, sum = 0;
            int n = 0, mid_i = 0;
            Console.Write("Enter the number 'P': ");
            string vvod_p = Console.ReadLine();
            if (double.TryParse(vvod_p, out p))
            {
                double.TryParse(vvod_p, out p);
            }
            else
            {
                Console.WriteLine("Error");
                return;
            }
            Console.WriteLine("Enter elements separated by a space");
            string s = Console.ReadLine();
            string[] c = s.Split(' ');
            foreach (string x in c)
            {
                n += 1;
            }
            double[] a = new double[n + 1];
            for (int i = 0; i < n; i++)
            {
                double.TryParse(c[i], out a[i]);
                sum += a[i];
            }
            mid = sum / n;
            Console.WriteLine("Initial numbers:");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{a[i]} ");
            }
            Console.WriteLine();
            double near = Math.Abs(mid - a[0]);
            for (int i = 0; i < n; i++)
            {
                if (near > (Math.Abs(mid - a[i])))
                {
                    near = Math.Abs(mid - a[i]);
                    mid_i = i;
                }
            }
            for (int i = n; i > mid_i; i--)
            {
                a[i] = a[i - 1];
            }
            a[mid_i + 1] = p;
            Console.WriteLine("New array: ");
            foreach (double k in a)
            {
                Console.Write($"{k} ");
            }
            #endregion

            #region Task 2_9
            double sum = 0, ans;
            int n = 0, ch = 0;
            int max_i = 0, min_i = 0;
            Console.WriteLine("Enter elements separated by a space");
            string s = Console.ReadLine();
            string[] c = s.Split(' ');
            foreach (string x in c)
            {
                n += 1;
            }
            double[] a = new double[n];
            for (int i = 0; i < n; i++)
            {
                double.TryParse(c[i], out a[i]);
            }
            double max = a[0], min = a[0];
            Console.WriteLine("Initial numbers:");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{a[i]} ");
                if (max < a[i])
                {
                    max_i = i;
                    max = a[i];
                }
                if (min > a[i])
                {
                    min_i = i;
                    min = a[i];
                }
            }
            Console.WriteLine();
            if (max_i > min_i)
            {
                for (int i = min_i + 1; i < max_i; i++)
                {
                    sum += a[i];
                    ch += 1;
                }
            }
            else
            {
                for (int i = max_i + 1; i < min_i; i++)
                {
                    sum += a[i];
                    ch += 1;
                }
            }
            ans = sum / ch;
            Console.WriteLine($"Answer: {ans}");
            #endregion

            #region Task 2_10
            int n = 0, ch = 0;
            int min_i = 0;
            Console.WriteLine("Enter elements separated by a space");
            string s = Console.ReadLine();
            string[] c = s.Split(' ');
            foreach (string x in c)
            {
                n += 1;
            }
            double[] a = new double[n];
            for (int i = 0; i < n; i++)
            {
                double.TryParse(c[i], out a[i]);
            }
            double min = a[0];
            Console.WriteLine("Initial numbers:");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{a[i]} ");
                if (min >= a[i] && a[i] > 0)
                {
                    min_i = i;
                    min = a[i];
                    ch += 1;
                }

            }
            Console.WriteLine();
            if (ch == 0)
            {
                Console.WriteLine("No positive numbers here");
                return;
            }
            for (int i = min_i; i < n - 1; i++)
            {
                a[i] = a[i + 1];
            }
            Console.WriteLine("New array: ");
            for (int i = 0; i < n - 1; i++)
            {
                Console.Write($"{a[i]} ");
            }
            #endregion

            #region Task 2_11
            double p;
            int n = 0, integer_i = -1;
            Console.Write("Enter the number 'P': ");
            string vvod_p = Console.ReadLine();
            if (double.TryParse(vvod_p, out p) == false)
            {
                    Console.WriteLine("Error");
                    return;
            }
            Console.WriteLine("Enter elements separated by a space");
            string s = Console.ReadLine();
            string[] c = s.Split(' ');
            foreach (string x in c)
            {
                n += 1;
            }
            double[] a = new double[n + 1];
            for (int i = 0; i < n; i++)
            {
                double.TryParse(c[i], out a[i]);
            }
            Console.WriteLine("Initial numbers:");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{a[i]} ");
                if (a[i] > 0)
                {
                    integer_i = i;
                }
            }
            Console.WriteLine();
            if (integer_i == -1)
            {
                Console.WriteLine("No positive numbers here");
                return;
            }
            for (int i = n - 1; i >= integer_i; i--)
            {
                a[i + 1] = a[i];
            }
            a[integer_i + 1] = p;
            Console.WriteLine("New array: ");
            foreach (double k in a)
            {
                Console.Write($"{k} ");
            }
            #endregion

            #region Task 2_13
            int n = 0, max_i = 0;
            Console.WriteLine("Enter elements separated by a space");
            string s = Console.ReadLine();
            string[] c = s.Split(' ');
            foreach (string x in c)
            {
                n += 1;
            }
            double[] a = new double[n];
            for (int i = 0; i < n; i++)
            {
                double.TryParse(c[i], out a[i]);
            }
            double max = a[0];
            Console.WriteLine("Initial numbers:");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{a[i]} ");
                if (i % 2 == 0 && a[i] > max)
                {
                    max_i = i;
                    max = a[i];
                }
            }
            Console.WriteLine();
            a[max_i] = max_i;
            Console.WriteLine("New array: ");
            foreach (double k in a)
            {
                Console.Write($"{k} ");
            }
            #endregion

            #region Task 2_15
            int n_a = 0, n_b = 0, max_i = 0, k;
            Console.WriteLine("Enter integer k: ");
            string vvod_k = Console.ReadLine();
            if (int.TryParse(vvod_k, out k) && k >= 0)
            {
                int.TryParse(vvod_k, out k);
            }
            else
            {
                Console.WriteLine("Error");
                return;
            }
            Console.WriteLine("Enter elements separated by a space for array A");
            string s1 = Console.ReadLine();
            string[] c1 = s1.Split(' ');
            foreach (string x in c1)
            {
                n_a += 1;
            }
            double[] a = new double[n_a];
            for (int i = 0; i < n_a; i++)
            {
                double.TryParse(c1[i], out a[i]);
            }
            if (n_a <= k)
            {
                Console.WriteLine("Error");
                return;
            }
            Console.WriteLine("Enter elements separated by a space for array B");
            string s2 = Console.ReadLine();
            string[] c2 = s2.Split(' ');
            foreach (string x in c2)
            {
                n_b += 1;
            }
            double[] b = new double[n_b];
            for (int i = 0; i < n_b; i++)
            {
                double.TryParse(c2[i], out b[i]);
            }
            double[] c = new double[n_a + n_b];
            Console.WriteLine("Initial numbers of A:");
            for (int i = 0; i < n_a; i++)
            {
                Console.Write($"{a[i]} ");
            }
            Console.WriteLine();
            Console.WriteLine("Initial numbers of B:");
            for (int i = 0; i < n_b; i++)
            {
                Console.Write($"{b[i]} ");
            }
            Console.WriteLine();
            for (int i = 0; i <= k; i++)
            {
                c[i] = a[i];
            }
            for (int i = 0; i < n_b; i++)
            {
                c[k + 1 + i] = b[i];
            }
            for (int i = k + 1; i < n_a; i++)
            {
                c[n_b + i] = a[i];
            }
            Console.WriteLine("New array: ");
            foreach (double x in c)
            {
                Console.Write($"{x} ");
            }
            #endregion

            #region Task 3_1
            int n = 0, max_i = 0;
            Console.WriteLine("Enter elements separated by a space");
            string s = Console.ReadLine();
            string[] c = s.Split(' ');
            foreach (string x in c)
            {
                n += 1;
            }
            double[] a = new double[n];
            for (int i = 0; i < n; i++)
            {
                double.TryParse(c[i], out a[i]);
            }
            Console.WriteLine("Initial numbers: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{a[i]} ");
            }
            Console.WriteLine();
            double max = a[0];
            max_i = 0;
            for (int i = 0; i < n; i++)
            {
                if (a[i] >= max)
                {
                    if (a[i] > max)
                    {
                        max_i = 0;
                        max = a[i];
                    }
                    a[max_i] = i;
                    max_i += 1;
                }
            }
            Console.WriteLine("New array: ");
            for (int i = 0; i < max_i; i++)
            {
                Console.Write($"{a[i]} ");
            }
            #endregion

            #region Task 3_5
            int n = 0, k = 0, max_i = 0;
            double max;
            Console.WriteLine("Enter elements separated by a space");
            string s = Console.ReadLine();
            string[] c = s.Split(' ');
            foreach (string x in c)
            {
                n += 1;
            }
            double[] a = new double[n];
            for (int i = 0; i < n; i++)
            {
                double.TryParse(c[i], out a[i]);
            }
            Console.WriteLine("Initial numbers: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{a[i]} ");
            }
            Console.WriteLine();
            for (int i = 0; i < n - 2; i += 2)
            {
                max = a[i];
                max_i = i;
                for (int j = i + 2; j < n; j += 2)
                {
                    if (a[j] > max)
                    {
                        max = a[j];
                        max_i = j;
                    }
                }
                a[max_i] = a[i];
                a[i] = max;
            }
            Console.WriteLine("New array: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{a[i]} ");
            }
            #endregion

            #region Task 3_8
            int n = 0, k = 0, max_j = 0;
            Console.WriteLine("Enter elements separated by a space");
            string s = Console.ReadLine();
            string[] c = s.Split(' ');
            foreach (string x in c)
            {
                n += 1;
            }
            double[] a = new double[n];
            for (int i = 0; i < n; i++)
            {
                double.TryParse(c[i], out a[i]);
            }
            Console.WriteLine("Initial numbers: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{a[i]} ");
            }
            Console.WriteLine();
            double max = a[0];
            for (int i = 0; i < n - 1; i++)
            {
                max = a[i];
                max_j = i;
                if (a[i] < 0)
                {
                    k += 1;
                    for (int j = i + 1; j < n; j++)
                    {
                        if (a[j] < 0 && a[j] > max)
                        {
                            max = a[j];
                            max_j = j;
                        }
                    }
                }
                a[max_j] = a[i];
                a[i] = max;
            }
            if (k == 0)
            {
                Console.WriteLine("Error");
                return;
            }
            Console.WriteLine("New array: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{a[i]} ");
            }
            #endregion

            #region Task 3_9
            int n = 0, k_sm = 1, k_big = 1;
            Console.WriteLine("Enter elements separated by a space");
            string s = Console.ReadLine();
            string[] c = s.Split(' ');
            foreach (string x in c)
            {
                n += 1;
            }
            if (n < 3)
            {
                Console.WriteLine("Error");
                return;
            }
            double[] a = new double[n];
            for (int i = 0; i < n; i++)
            {
                double.TryParse(c[i], out a[i]);
            }
            Console.WriteLine("Initial numbers: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{a[i]} ");
            }
            Console.WriteLine();
            double max_sm = 0, max_big = 0;
            for (int i = 0; i < n - 1; i++)
            {
                if (a[i] > a[i + 1])
                {
                    k_sm += 1;
                }
                else
                {
                    if (max_sm < k_sm)
                    {
                        max_sm = k_sm;
                    }
                    k_sm = 1;
                }
                if (a[i] < a[i + 1])
                {
                    k_big += 1;
                }
                else
                {
                    if (max_big < k_big)
                    {
                        max_big = k_big;
                    }
                    k_big = 1;
                }
            }
            if (max_big > max_sm)
            {
                Console.WriteLine($"Answer: {max_big}");
            }
            else if (max_sm > max_big)
            {
                Console.WriteLine($"Answer: {max_sm}");
            }
            else
            {
                Console.WriteLine("There is no maximum length");
            }
            #endregion

            #region Task 3_12
            int n = 12, k = 0, ch = 0;
            Console.WriteLine("Enter elements separated by a space");
            string s = Console.ReadLine();
            string[] c = s.Split(' ');
            double[] a = new double[n];
            for (int i = 0; i < n; i++)
            {
                double.TryParse(c[i], out a[i]);
            }
            Console.WriteLine("Initial numbers: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{a[i]} ");
                if (a[i] > 0)
                {
                    k += 1;
                }
            }
            Console.WriteLine();
            double[] answ = new double[k];
            for (int j = 0; j < n; j++)
            {
                if (a[j] > 0)
                {
                    answ[ch] = a[j];
                    ch += 1;
                }
            }
            Console.WriteLine("New array");
            for (int i = 0; i < k; i++)
            {
                Console.Write($"{answ[i]} ");
            }
            #endregion

            #region Task 3_13
            int n = 0, k = 0;
            Console.WriteLine("Enter elements separated by a space");
            string s = Console.ReadLine();
            string[] c = s.Split(' ');
            foreach (string x in c)
            {
                n += 1;
            }
            double[] a = new double[n];
            for (int i = 0; i < n; i++)
            {
                double.TryParse(c[i], out a[i]);
            }
            Console.WriteLine("Initial numbers:");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{a[i]} ");
            }
            Console.WriteLine();
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n - 1; j++)
                {
                    if (a[i] == a[j])
                    {
                        k++;
                        for (int x = j; x < n - 1; x++)
                        {
                            a[x] = a[x + 1];
                        }
                        if ((a[i] == a[j]))
                        {
                            j--;
                            n--;
                        }
                    }
                }
            }
            if (k == 0)
            {
                Console.WriteLine("Error");
                return;
            }
            Console.WriteLine("Answer: ");
            for (int i = 0; i < n - 1; i++)
            {
                Console.Write($"{a[i]} ");
            }
            #endregion

            #region Task 11
            int n = 0, min_i = 0, middle;
            double min = 0, x;
            Console.WriteLine("Enter elements separated by a space");
            string s = Console.ReadLine();
            string[] c = s.Split(' ');
            Console.WriteLine("Enter x: ");
            string vvod_x = Console.ReadLine();
            if (double.TryParse(vvod_x, out x))
            {
                double.TryParse(vvod_x, out x);
            }
            else
            {
                Console.WriteLine("Error");
                return;
            }
            foreach (string q in c)
            {
                n += 1;
            }
            double[] a = new double[n];
            for (int i = 0; i < n; i++)
            {
                double.TryParse(c[i], out a[i]);
            }
            for (int i = 0; i < n - 1; i++)
            {
                min = a[i];
                min_i = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (min > a[j])
                    {
                        min = a[j];
                        min_i = j;
                    }
                }
                a[min_i] = a[i];
                a[i] = min;
            }
            int start = 0, end = n - 1;
            while (start <= end)
            {
                middle = (start + end) / 2;
                if (x < a[middle])
                {
                    end = middle - 1;
                }
                else if (x > a[middle])
                {
                    start = middle + 1;
                }
                else
                {
                    Console.WriteLine($"The element exists. Its index in an ordered array: {middle}");
                    return;
                }
            }
            Console.WriteLine("The array does not exist");
            #endregion

            #region Task 12
            const int n = 7, j = 7, s = n + j;
            double[] a = new double[n] { 5.2, -1, 0, -9.3, 5, 8.6, -1.9 };
            double[] b = new double[j] { 3.6, -6.1, 2.9, -4, 8, 7, 6 };
            double[] c = new double[s];
            for (int i = 0; i < j; i++)
            {
                c[2 * i] = a[i];
                c[2 * i + 1] = b[i];
            }
            if (a.Length < b.Length)
            {
                for (int i = j; i < n; i++)
                {
                    c[i + j] = b[i];
                }
            }
            if (a.Length > b.Length)
            {
                for (int i = j; i < n; i++)
                {
                    c[i + j] = a[i];
                }
            }
            Console.WriteLine("New array: ");
            foreach (double x in c)
            {
                Console.Write($"{x} ");
            }
            #endregion

            #region Task 13
            int max_i = 0, i1 = 0, j1 = 0;
            double max = 0;
            const int n = 7, m = 4;
            double[] a = new double[n] { 5.2, -1, 0, -9.3, 5, 8.6, -1.9 };
            double[] b = new double[m] { 3.6, -6.1, 2.9, -4 };
            double[] c = new double[n + m];
            for (int i = 0; i < n - 1; i++)
            {
                max = a[i];
                max_i = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (max < a[j])
                    {
                        max = a[j];
                        max_i = j;
                    }
                }
                a[max_i] = a[i];
                a[i] = max;
            }
            for (int i = 0; i < m - 1; i++)
            {
                max = b[i];
                max_i = i;
                for (int j = i + 1; j < m; j++)
                {
                    if (max < b[j])
                    {
                        max = b[j];
                        max_i = j;
                    }
                }
                b[max_i] = b[i];
                b[i] = max;
            }
            max_i = 0;
            while (j1 < m)
            {
                while (a[i1] >= b[j1] && i1 < n)
                {
                    c[max_i] = a[i1];
                    i1++;
                    max_i++;
                    if (i1 == n)
                    {
                        break;
                    }
                }
                while (a[i1] < b[j1] && j1 < m)
                {
                    c[max_i] = b[j1];
                    j1++;
                    max_i++;
                    if (j1 == m)
                    {
                        break;
                    }
                }
            }
            if (j1 == m)
            {
                for (int i = i1; i < n; i++)
                {
                    c[max_i] = a[i];
                    max_i++;
                }
            }
            if (i1 == n)
            {
                for (int j = j1; j < m; j++)
                {
                    c[max_i] = b[j];
                    max_i++;
                }
            }
            Console.WriteLine("New array: ");
            foreach (double x in c)
            {
                Console.Write($"{x} ");
            }
            #endregion

            #region Task 14
            const int n = 7;
            int end = 0;
            double save = 0;
            double[] a = new double[n] { 5.2, -1, 0, -9.3, 10, 8.6, -1.9 };
            for (int i = 0; i < n / 2; i++)
            {
                end = n - 1 - i;
                save = a[i];
                a[i] = a[end];
                a[end] = save;
            }
            Console.WriteLine("New array: ");
            foreach (double x in a)
            {
                Console.Write($"{x} ");
            }
            #endregion

            #region Task 15
            const int n = 7;
            int m = 3;
            double save = 0;
            double[] a = new double[n] { 5.2, -1, 0, -9.3, 10, 8.6, -1.9 };
            for (int i = 0; i < m; i++)
            {
                save = a[n - 1];
                for (int j = n - 1; j > 0; j--)
                {
                    a[j] = a[j - 1];
                }
                a[0] = save;
            }
            Console.WriteLine("New array: ");
            foreach (double x in a)
            {
                Console.Write($"{x} ");
            }
            #endregion

        }
    }
}

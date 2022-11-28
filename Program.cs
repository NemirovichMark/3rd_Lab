using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.SymbolStore;
using System.Globalization;

namespace lab_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            #region I|6
            Console.WriteLine("I №6");

            double[] array = new double[5] { 0.0, 1.5, 1.0, 3.3, -1.4 };
            double answer = 0;
            foreach (double i in array) answer += i * i;
            Console.WriteLine($"Answer {Math.Sqrt(answer)}");

            Console.WriteLine("--------------------");
            #endregion

            #region I|10
            Console.WriteLine("I №10");

            array = new double[10] { 0.0, 1.5, 1.0, 3.3, -1.4, 0.0, 1.5, 1.0, 3.3, -1.4 };
            double P = 4;
            double Q = 3;
            double x;

            if (P > Q)
            {
                x = P;
                P = Q;
                Q = x;
            }

            x = 0;

            foreach (double i in array)
            {
                if (i < Q && i > P) x++;
            }
            Console.WriteLine($"Answer {x}");

            Console.WriteLine("--------------------");
            #endregion

            #region I|11
            Console.WriteLine("I №11");

            array = new double[10] { 0.0, 1.5, 1.0, 3.3, -1.4, 0.0, 1.5, 1.0, 3.3, -1.4 };
            int cnt = 0;

            foreach (double i in array) if (i > 0) cnt++;

            double[] array_answ = new double[cnt];
            cnt = 0;

            foreach (double i in array)
            {
                if (i > 0)
                {
                    array_answ[cnt] = i;
                    cnt++;
                }
            }
            
            foreach (double i in array_answ) Console.Write(i);
            Console.WriteLine();

            Console.WriteLine("--------------------");
            #endregion

            #region I|12
            Console.WriteLine("I №12");

            array = new double[8] { 0.0, 1.5, 1.0, 3.3, -1.4, 0.0, 1.5, 1.0 };
            cnt = -1;

            for (int i = 0; i < array.Length; i++) if (array[i] < 0) cnt = i;
            Console.WriteLine($"Answer {cnt}");

            Console.WriteLine("--------------------");
            #endregion

            #region I|13
            Console.WriteLine("I №13");

            array = new double[10] { 0.0, 1.5, 1.0, 3.3, -1.4, 0.0, 1.5, 1.0, 3.3, -1.4 };
            double[] array_1 = new double[5];
            double[] array_2 = new double[5];

            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 == 0) array_1[i / 2] = array[i];
                else array_2[i / 2] = array[i];
            }

            foreach (double i in array_1) Console.Write($"{i} ");
            Console.WriteLine();
            foreach (double i in array_2) Console.Write($"{i} ");
            Console.WriteLine();

            Console.WriteLine("--------------------");
            #endregion

            #region II|5
            Console.WriteLine("II №5");

            array = new double[] { 0.0, 1.5, 3.3, -1.2, -2.4, 0.0, -1.5, 1.0, 3.3, -1.4 };
            double min = array[0];
            int min_ind = 0;
            double max = array[0];
            int max_ind = 0;
            cnt = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                    max_ind = i;
                }
                if (array[i] < min)
                {
                    min = array[i];
                    min_ind = i;
                }
            }

            if (min_ind > max_ind)
            {
                cnt = max_ind;
                max_ind = min_ind;
                min_ind = cnt;
                cnt = 0;
            }

            for (int i = min_ind + 1; i < max_ind; i++) if (array[i] < 0) cnt++;

            if (cnt == 0) Console.WriteLine("That array doesn't have irregular numbers");
            else
            {
                array_answ = new double[cnt];
                cnt = 0;
                for (int i = min_ind + 1; i < max_ind; i++)
                {
                    if (array[i] < 0)
                    {
                        array_answ[cnt] = array[i];
                        cnt++;
                    }
                }
                foreach (double i in array_answ) Console.Write($"{i} ");
                Console.WriteLine();
            }

            Console.WriteLine("--------------------");
            #endregion

            #region II|6
            Console.WriteLine("II №6");

            array = new double[] { 0.0, 1.5, 3.3, -1.2, -2.4, 0.0, -1.5, 1.0, 3.3, -1.4 };
            array_answ = new double[array.Length + 1];
            P = 92387;
            double sr_arif = 0;
            min_ind = 0;

            foreach (double i in array) sr_arif += i;
            sr_arif /= array.Length;

            for (int i = 0; i < array.Length; i++)
            {
                if (Math.Abs(array[0] - sr_arif) < x)
                {
                    min_ind = i;
                }
            }

            for (int i = 0; i <= array.Length; i++)
            {
                if (i < min_ind) array_answ[i] = array[i];
                if (i == min_ind) array_answ[i] = P;
                if (i > min_ind) array_answ[i] = array[i-1];
            }

            foreach (double i in array_answ) Console.Write($"{i} ");
            Console.WriteLine();

            Console.WriteLine("--------------------");
            #endregion

            #region II|9
            Console.WriteLine("II №9");

            array = new double[] { 0.0, 1.5, 3.3, -1.2, -2.4, 0.0, -1.5, 1.0, 3.3, -1.4 };
            min_ind = 0;
            min = array[0];
            max_ind = 0;
            max = array[0];

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                    max_ind = i;
                }
                if (array[i] < min)
                {
                    min = array[i];
                    min_ind = i;
                }
            }

            if (max_ind < min_ind)
            {
                cnt = max_ind;
                max_ind = min_ind;
                min_ind = cnt;
            }

            x = 0;

            for (int i = 1 + min_ind; i < max_ind; i++) x += array[i];

            x /= max_ind - min_ind - 1;

            Console.WriteLine($"Answer {x}");

            Console.WriteLine("--------------------");
            #endregion

            #region II|10
            Console.WriteLine("II №10");

            array = new double[] { 0.0, 1.5, 3.3, -1.2, -2.4, 0.0, -1.5, 1.0, 3.3, -1.4 };
            array_answ = new double[array.Length - 1];
            min_ind = -1;
            min = 9999999999999999999;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0 && array[i] < min)
                {
                    min = array[i];
                    min_ind = i;
                }
            }

            if (min_ind == -1) Console.WriteLine("This array doesn't have positive numbers");
            else
            {
                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (i < min_ind) array_answ[i] = array[i];
                    if (i >= min_ind) array_answ[i] = array[i + 1];
                }

                foreach (double i in array_answ) Console.Write($"{i} ");
                Console.WriteLine();
            }

            Console.WriteLine("--------------------");
            #endregion

            #region II|11
            Console.WriteLine("II №11");

            array = new double[] { 0.0, 1.5, 3.3, -1.2, -2.4, 0.0, -1.5, 1.0, 3.3, -1.4 };
            array_answ = new double[array.Length + 1];
            P = 324253;
            max_ind = -1;

            for (int i = array.Length - 1; i >= 0; i--)
            {
                if (array[i] > 0)
                {
                    max_ind = i+1;
                    break;
                }
            }

            if (max_ind == -1) Console.WriteLine("This array doesn't have positive numbers");
            else
            {
                for (int i = 0; i < array.Length + 1; i++)
                {
                    if (i < max_ind) array_answ[i] = array[i];
                    if (i == max_ind) array_answ[i] = P;
                    if (i > max_ind) array_answ[i] = array[i - 1];
                }

                foreach (double i in array_answ) Console.Write($"{i} ");
                Console.WriteLine();
            }

            Console.WriteLine("--------------------");
            #endregion

            #region II|13
            Console.WriteLine("II №13");

            array = new double[] { 0.0, 1.5, 3.3, -1.2, -2.4, 0.0, -1.5, 1.0, 3.3, -1.4 };
            x = 0;

            max = array[0];
            max_ind = 0;

            for (int i = 0; i < array.Length; i += 2)
            {
                if (array[i] > max)
                {
                    max = array[i];
                    max_ind = i;
                }
            }

            array[max_ind] = max_ind;

            foreach (double i in array) Console.Write($"{i} ");
            Console.WriteLine();

            Console.WriteLine("--------------------");
            #endregion

            #region II|15
            Console.WriteLine("II №15");

            const int n = 6;
            const int m = 4;
            array_1 = new double[n] {0.0, 1.5, 3.3, -1.2, -2.4, 0.0};
            array_2 = new double[m] { 0.0, 1.5, 3.3, -1.2 };
            array_answ = new double[n + m];
            int k = 3;

            for (int i = 0; i < array_1.Length + array_2.Length; i++)
            {
                if (i <= k) array_answ[i] = array_1[i];
                if (i > k && i <= k + m) array_answ[i] = array_2[i - k - 1];
                if (i > k && i > k + m) array_answ[i] = array_1[i - m];
            }

            foreach (double i in array_answ) Console.Write($"{i} ");
            Console.WriteLine();

            Console.WriteLine("--------------------");
            #endregion

            #region III|1
            Console.WriteLine("III №1");

            array = new double[] { 0.0, 1.5, 3.3, -1.2, 3.3, 0.0 };
            array_answ = new double[0];
            max = array[0];
            max_ind = 0;
            cnt = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                    max_ind = i;
                    array_answ = new double[1] { i };
                }
                else if (array[i] == max)
                {
                    Array.Resize(ref array_answ, array_answ.Length + 1);
                    array_answ[array_answ.Length - 1] = i;
                }
            }

            foreach (double i in array_answ) Console.Write($"{i} ");
            Console.WriteLine();

            Console.WriteLine("--------------------");
            #endregion

            #region III|5
            Console.WriteLine("III №5");

            array = new double[] { 4, 1.5, 3.3, -1.2, 3.3, 0.0 };
            max = array[0];
            max_ind = 0;

            for (int i = 0; i < array.Length; i += 2)
            {
                min = array[i];
                min_ind = i;
                for (int j = i + 2; j < array.Length; j += 2)
                {
                    if (array[j] < min)
                    {
                        min = array[j];
                        min_ind = j;
                    }
                }
                array[min_ind] = array[i];
                array[i] = min;
            }

            foreach (double i in array) Console.Write($"{i} ");
            Console.WriteLine();

            Console.WriteLine("--------------------");
            #endregion

            #region III|8
            Console.WriteLine("III №8");

            array = new double[] { 0.0, -1.5, 3.3, -1.2, 3.3, 0.0 };
            max = 0;
            max_ind = 0;

            for (int i = 0; i < array.Length; i ++)
            {
                if (array[i] < 0)
                {
                    max = array[i];
                    max_ind = i;
                    for (int j = i + 1; j < array.Length; j++)
                    {
                        if (array[j] < 0 && array[j] > max)
                        {
                            max = array[j];
                            max_ind = j;
                        }
                    }
                    array[max_ind] = array[i];
                    array[i] = max;
                }
            }

            foreach (double i in array) Console.Write($"{i} ");
            Console.WriteLine();

            Console.WriteLine("--------------------");
            #endregion

            #region III|9
            Console.WriteLine("III №9");

            array = new double[] { 0.0, 1.5, 3.3, 3.3, -1.2, -1.5, -1.6, 3.3, 0.0 };
            max = 1;
            cnt = 1;
            x = 0;

            for (int i = 0; i < array.Length - 1; i++)
            {
                if (max < cnt) max = cnt;
                if (array[i] < array[i + 1])
                {
                    if (x > 0) cnt++;
                    else
                    { 
                        cnt = 2;
                        x = 1;
                    }
                }
                else if (array[i] > array[i + 1])
                {
                    if (x < 0) cnt++;
                    else
                    {
                        cnt = 2;
                        x = -1;
                    }
                }
                else
                {
                    cnt = 1;
                    x = 0;
                }
            }

            Console.WriteLine(max);

            Console.WriteLine("--------------------");
            #endregion

            #region III|12
            Console.WriteLine("III №12");

            array = new double[12] { 0.0, 1.5, 3.3, -1.2, 3.3, 0.0, 0.0, 1.5, 3.3, -1.2, 3.3, 0.0};
            array_answ = new double[0];

            foreach (double i in array)
            {
                if (i >= 0)
                {
                    Array.Resize(ref array_answ, array_answ.Length + 1);
                    array_answ[array_answ.Length - 1] = i;
                }
            }

            foreach (double i in array_answ) Console.Write($"{i} ");
            Console.WriteLine();

            Console.WriteLine("--------------------");
            #endregion

            #region III|13
            Console.WriteLine("III №13");

            array = new double[12] { 0.0, 1.5, 3.3, -1.2, 3.3, 0.0, 0.0, 1.5, 3.3, -1.2, 3.3, 0.0 };
            array_answ = new double[0];

            foreach (double i in array)
            {
                if (array_answ.Contains(i) != true)
                {
                    Array.Resize(ref array_answ, array_answ.Length + 1);
                    array_answ[array_answ.Length - 1] = i;
                }
            }

            foreach (double i in array_answ) Console.Write($"{i} ");
            Console.WriteLine();

            Console.WriteLine("--------------------");
            #endregion

            #region 11
            Console.WriteLine("--- 11 ---");

            array = new double[n] {0.0, 1.5, 3.3, -1.2, 3.3, 0.0};
            Array.Sort(array);
            x = 3.3;
            int i1 = 0, i2 = n - 1;
            cnt = (i1 + i2) / 2;

            while(x != array[cnt])
            {
                if (i2 < i1)
                {
                    Console.WriteLine($"{x} is not in this array");
                    break;
                }
                if (x < array[cnt]) i2 = cnt - 1;
                if (x > array[cnt]) i1 = cnt + 1;
                cnt = (i1 + i2) / 2;
            }

            if (x == array[cnt]) Console.WriteLine(cnt);

            Console.WriteLine("--------------------");
            #endregion

            #region 12
            Console.WriteLine("--- 12 ---");

            array_1 = new double[n] { 0.0, 1.5, 3.3, -1.2, 3.3, 0.0 };
            array_2 = new double[n+1] { 0.0, 1.5, 3.3, -1.2, 3.3, 0.0, 4};
            
            if (array_1.Length < array_2.Length) cnt = array_1.Length;
            else cnt = array_2.Length;
            
            array = new double[cnt*2];

            for (int i = 0; i < cnt * 2; i++)
            {
                if (i % 2 == 0) array[i] = array_1[i / 2];
                else array[i] = array_2[i / 2];
            }

            foreach (double i in array) Console.Write($"{i} ");
            Console.WriteLine();

            Console.WriteLine("--------------------");
            #endregion

            #region 13
            Console.WriteLine("--- 13 ---");

            array_1 = new double[n] { 3.3, 3.3, 1.5, 0.0, 0.0, -1.2 };
            array_2 = new double[n + 1] { 3.3, 3.3, 1.5, 0.0, 0.0, -1.2, -1.5};

            if (array_1.Length < array_2.Length) cnt = array_1.Length;
            else cnt = array_2.Length;

            array = new double[cnt * 2];

            int q1 = 0, q2 = 0;

            for (int i = 0; i < cnt*2; i++)
            {
                if (q1 < cnt)
                    if (array_1[q1] >= array_2[q2] && q2 < cnt)
                    {
                        array[i] = array_1[q1];
                        q1++;
                    }
                    else
                    {
                        array[i] = array_2[q2];
                        q2++;
                    }
                else
                {
                    array[i] = array_2[q2];
                    q2++;
                }
            }

            foreach (double i in array) Console.Write($"{i} ");
            Console.WriteLine();

            Console.WriteLine("--------------------");
            #endregion

            #region 14
            Console.WriteLine("--- 14 ---");

            array = new double[n] { 3.3, 3.3, 1.5, 0.0, 0.0, -1.2};

            for (int i = 0; i < n/2; i++)
            {
                x = array[n - i - 1];
                array[n - i - 1] = array[i];
                array[i] = x;
            }

            foreach (double i in array) Console.Write($"{i} ");
            Console.WriteLine();

            Console.WriteLine("--------------------");
            #endregion

            #region 15
            Console.WriteLine("--- 15 ---");

            array = new double[n] { 3.3, 3.3, 1.5, 0.0, 0.0, -1.2 };
            cnt = 3;

            for (int j = 0; j < cnt; j++)
            {
                x = array[n-1];
                for (int i = n - 1; i != 0; --i) array[i] = array[i - 1];
                array[0] = x;
            }

            foreach (double i in array) Console.Write($"{i} ");
            Console.WriteLine();

            Console.WriteLine("--------------------");
            #endregion
        }
    }
}
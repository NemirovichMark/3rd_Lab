using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static List<double> inputLists() //Method for entering simbols in list
        {
            var A = new List<double>();
            Int16 ok;
            int n = 0;

            ok = 0;
            while (ok == 0)
            {
                try
                {
                    Console.WriteLine("Enter amount of simbols");
                    n = Convert.ToInt32(Console.ReadLine());
                    ok = 1;
                }
                catch
                {
                    Console.WriteLine("Enter a right simbol");
                }
            }

            for (int i = 0; i < n; i++)
            {
                ok = 0;
                while (ok == 0)
                {
                    try
                    {
                        A.Add(Convert.ToInt32(Console.ReadLine()));
                        ok = 1;
                    }
                    catch
                    {
                        Console.WriteLine("Enter a right simbol");
                    }
                }
            }

            return A;
        }


        static double[] inputArrays() //Method for entering simbols in array
        {
            double[] A;
            Int16 ok;
            int n = 0;

            ok = 0;
            while (ok == 0)
            {
                try
                {
                    Console.WriteLine("Enter amount of simbols");
                    n = Convert.ToInt32(Console.ReadLine());
                    ok = 1;
                }
                catch
                {
                    Console.WriteLine("Enter a right simbol");
                }
            }

            A = new double[n];
            for (int i = 0; i < n; i++)
            {
                ok = 0;
                while (ok == 0)
                {
                    try
                    {
                        A[i] = Convert.ToInt32(Console.ReadLine());
                        ok = 1;
                    }
                    catch
                    {
                        Console.WriteLine("Enter a right simbol");
                    }
                }
            }

            return A;
        }


        static void Main(string[] args)
        {
            //TASKS

            
            //part 1
            /*#region 6
                double number, summ;
                summ = 0;
                double[] a;
                a = new double[5];
                for (int i = 0; i < 5; i++)
                {
                    int ok = 0;
                    while (ok == 0)
                    {
                        try
                        {
                            number = int.Parse(Console.ReadLine());
                            a[i] = number;
                            ok = 1;
                        }
                        catch
                        {
                            Console.WriteLine("Enter right simbol");
                        }
                    }
                }
                for (int i = 0; i < 5; i++)
                    summ += a[i] * a[i];
                Console.WriteLine(Math.Sqrt(summ));
            #endregion


            #region 10
                int[] ints = new int[] { 32, 54, 8, 65, 125, 4, 78, 96, 10, 1};
                int P, Q, indP, indQ;
                P = 8;
                Q = 96;
                indP = indQ = 0;
                for (int i = 0; i < 10; i++)
                {
                    if (P == ints[i])
                        indP = i;
                    if (Q == ints[i])
                        indQ = i;
                }
                Console.WriteLine(Math.Abs(indQ - indP - 1));   
            #endregion


            #region 11
                int[] ints, plusints;
                ints = new int[] { 32, -54, 8, -65, -125, -4, 0, 96, 10, 1 };
                plusints = new int[5];
                int count = 0;
                for (int i = 0; i < 10; i++)
                {
                    if (ints[i] > 0)
                    {
                        plusints[count] = ints[i];
                        count++;
                    }
                }
                for (int i = 0; i < 5; i++)
                Console.Write(plusints[i] + " ");
            #endregion


            #region 12
                int[] ints = new int[] { 32, -54, 8, 0, -125, -4, 78, 8 };
                int count, last;
                count = 0;
                last = 0;
                for (int i = 0; i < ints.Length; i++)
                {
                    if (ints[i] < 0)
                    {
                        last = ints[i];
                        count = i;
                    }
                }
                Console.WriteLine("index = {0}, number = {1}", count, last);
            #endregion


            #region 13
                int[] ints, ints1, ints2;
                ints = new int[] { 32, -54, 9, 2, -125, -4, 77, 8, 25, 99 };
                ints1 = new int[5];
                ints2 = new int[5];
                int count1, count2;
                count1 = count2 = 0;
                for (int i = 0; i < ints.Length; i++)
                {
                    if (ints[i] % 2 == 0)
                    {
                        ints2[count2] = ints[i];
                        count2++;
                    }
                    else
                    {
                        ints1[count1] = ints[i];
                        count1++;                    
                    }
                }
                for (int i = 0; i < 5; i++)
                    Console.WriteLine("even = {0}, odd = {1}", ints2[i], ints1[i]);
            #endregion


            //part 2
            #region 5
                int[] mass = new int[] { 32, -54, 9, 2, 125, -4, -77, -8, 25, 99, -5 };
                int massmax, massmin, indmax, indmin;
                massmax = massmin = mass[0];
                indmax = indmin = 0;
                for (int i = 1; i < mass.Length; i++)
                {
                    if (mass[i] > massmax)
                    {
                        massmax = mass[i];
                        indmax = i;
                    }
                    if (mass[i] < massmin)
                    {
                        massmin = mass[i];
                        indmin = i;
                    }
                }

                int length = Math.Abs(indmax - indmin) - 1;
                int first_index_in_list = 0;

                if (indmax > indmin)
                    first_index_in_list = indmin;
                else if (indmax < indmin)
                    first_index_in_list = indmax;

                int count = 0;
                for (int i = 1; i <= length; i++)
                {
                    if (mass[first_index_in_list + i] < 0)
                    {
                        count++;
                    }
                }

                int[] negative = new int[count];
                count = 0;
                for (int i = 1; i <= length; i++)
                {
                    if (mass[first_index_in_list + i] < 0)
                    {
                        negative[count] = mass[first_index_in_list + i];
                        count++;
                    }
                }
                for (int i = 0; i < negative.Length; i++)
                    Console.WriteLine(negative[i]);
            #endregion


            #region 6
                int[] ints = new int[] { 32, -54, 9, 2, 125, -4, -77, -8, 25, 99, -5 };
                int P = 34;
                int sum, srsum;
                sum = 0;
                for (int i = 0; i < ints.Length; i++)
                    sum += ints[i];
                srsum = sum / ints.Length;

                int[] proximity_degree = new int[ints.Length];
                for (int i = 0; i < ints.Length; i++)
                    proximity_degree[i] = Math.Abs(ints[i] - srsum);

                int proxmin, indmin;
                indmin = 0;
                proxmin = proximity_degree[0];
                for (int i = 0; i < proximity_degree.Length; i++)
                    if (proximity_degree[i] < proxmin)
                    {
                        proxmin = proximity_degree[i];
                        indmin = i;
                    }
                int[] newints = new int[ints.Length + 1];
                for (int i = 0; i <= indmin; i++)
                    newints[i] = ints[i];

                newints[indmin + 1] = P;

                for (int i = indmin + 1; i <= ints.Length; i++)
                    newints[i] = ints[i];

                for (int i = 0; i < newints.Length; i++)
                    Console.WriteLine(newints[i]);
            #endregion

            #region 9
                int maxi = 0, mini = 0;
                var a = inputLists();
                double max = -1000000000;
                double min = 1000000000;
                double sum = 0, count = 0;
                for (int i = 0; i < a.Count; i++)
                {
                    if (a[i] > max)
                    {
                        max = a[i];
                        maxi = i;
                    }
                    if (a[i] < min)
                    {
                        min = a[i];
                        mini = i;
                    }
                }
                if (mini < maxi)
                {
                    for (int i = mini + 1; i < maxi; i++)
                    {
                        sum += a[i];
                        count++;
                    }
                }
                else if (maxi < mini)
                {
                    for (int i = maxi + 1; i < mini; i++)
                    {
                        sum += a[i];
                        count++;
                    }
                }
                if (count > 0)
                {
                    Console.WriteLine(sum / count);
                }
            #endregion


            #region 10
                var a = inputLists();
                double min = 1000000000;
                int k = 0;
                for (int i = 0; i < a.Count; i++)
                {
                    if (a[i] < min && a[i] > 0)
                    {
                        min = a[i];
                        k = i;
                    }
                }
                a.RemoveAt(a.IndexOf(k));
            #endregion

            #region 11
                Int16 ok = 0;
                int P = 0;
                while (ok == 0)
                {
                    try
                    {
                        P = Convert.ToInt32(Console.ReadLine());
                        ok = 1;
                    }
                    catch
                    {
                        Console.WriteLine("Enter a right simbol");
                    }
                }
                var a = inputLists();
                int k = 0;
                for (int i = 0; i < a.Count; i++)
                {
                    if (a[i] > 0) k = i;
                }
                a.Insert(k + 1, P);
                for (int i = 0; i < a.Count + 1; i++)
                {
                    Console.Write(a[i] + " ");
                }
            #endregion

            #region 13
                var a = inputLists();
                int p = 0;
                double max = a[0];
                double min = a[0];
                for (int i = 0; i < a.Count; i++)
                {
                    if (a[i] > max && i % 2 == 0)
                    {
                        p = i;
                        max = a[i];
                    }
                }
                a[p] = p;
                for (int i = 0; i < a.Count; i++)
                {
                    Console.Write(a[i] + " ");
                }
            #endregion

            #region 15
                int k = Convert.ToInt32(Console.ReadLine());
                var A = inputLists();
                var B = inputLists();
                A.InsertRange(k, B);
                for (int i = 0; i < A.Count; i++)
                {
                    Console.Write(A[i] + " ");
                }
            #endregion


            //part 3
            #region 1
                var A = inputLists();
                var B = new List<int>();
                double k = 0;
                double max = A.Max();
                for (int i = 0; i < n; i++)
                {
                    if (A[i] == max) 
                        B.Add(i);
                }
                for (int i = 0; i < B.Count; i++)
                {
                    Console.Write(B[i] + " ");
                }
            #endregion
 
            #region 5
                var A = inputLists();
                var B = new List<double>();
                for (int i = 0; i < A.Count; i++)
                    Console.Write(A[i] + " ");
 
                for (int i = 0; i < A.Count; i++)
                    if (i % 2 == 0)
                        B.Add(A[i]);
                B.Sort();
                int count = 0;
                for (int i = 0; i < A.Count; i++)
                {
                    if (i % 2 == 0)
                    {
                        A[i] = B[count];
                        count += 1;
                    }
                }
 
                Console.WriteLine(" ");
 
                for (int i = 0; i < A.Count; i++)
                    Console.Write(A[i] + " ");
            #endregion
 
            #region 8
                var A = inputLists();
                var B = new List<double>();
                var C = new List<int>();
                int k = 0;
                int t = 0;
                double max = A.Max() + 1;
                for (int i = 0; i < A.Count; i++)
                {
                    if (A[i] < 0) { B.Add(A[i]); C.Add(i); t++; }
                }
                B.Sort();
                B.Reverse();
                if (t != 0)
                {
                    for (int i = 0; i < A.Count; i++)
                    {
                        if (C.Contains(i) == true) { A[i] = B[k]; k++; }
                    }
                }
                for (int i = 0; i < A.Count; i++)
                    Console.Write(A[i] + " ");
            #endregion
 
            #region 9
                var A = inputLists();
                var B = new List<double>();
                int count = 1;
 
                for (int i = 0; i < A.Count - 1; i++)
                {
                    if (A[i] > A[i + 1])
                        count++;
                    else
                    {
                        B.Add(count);
                        count = 1;
                    }
                }
                B.Add(count);
 
                count = 1;
 
                for (int i = 0; i < A.Count - 1; i++)
                {
                    if (A[i] < A[i + 1])
                        count++;
                    else
                    {
                        B.Add(count);
                        count = 1;
                    }
                }
                B.Add(count);
 
                Console.WriteLine(B.Max());
            #endregion

            #region 12
                int[] original = new int[12] { 32, -54, 9, 2, 125, -4, -77, -8, 25, 99, -5, 0 };
                int[] non_negative;
                int count = 0;
                for (int i = 0; i < 12; i++)
                {
                    if (original[i] >= 0)
                        count++;
                }
                non_negative = new int[count];
                count = 0;
                for (int i = 0; i < 12; i++)
                {
                    if (original[i] >= 0)
                    {
                        non_negative[count] = original[i];
                        count++;
                    }
                }
                for (int i = 0; i < non_negative.Length; i++)
                    Console.Write(non_negative[i] + " ");
            #endregion

            #region 13
                double[] original = inputArrays();
                var indexes = new List<int>();
                Int16 ok = 0;
                for (int i = 0; i < original.Length; i++) //находим индексы повторяющихся чисел
                {
                    ok = 1;
                    for (int j = 0; j < indexes.Count; j++) //проверяем есть ли в массиве с индексами повторяющихся чисел этот индекс
                        if (i == indexes[j])
                        {
                            ok = 0;
                            break;
                        }
                    if (ok == 1)
                    { 
                        for (int j = i + 1; j < original.Length; j++)
                            if (original[i] == original[j]) 
                                indexes.Add(j);
                    }
                }

                double[] new_array = new double[original.Length - indexes.Count];
                Int16 count = 0;
                for (int i = 0; i < original.Length; i++) //перебираем все индексы исходного массива
                {
                    ok = 1;
                    for (int j = 0; j < indexes.Count; j++) //проверяем есть ли в массиве с индексами повторяющихся чисел этот индекс
                        if (i == indexes[j])
                        {
                            ok = 0;
                            break;
                        }
                    if (ok == 1) //если проверка успешна, то добавляем число с этим индексом в новый массив
                    {
                        new_array[count] = original[i];
                        count++;
                    }
                }
                for (int i = 0; i < new_array.Length; i++)
                    Console.Write(new_array[i] + " ");
            #endregion*/


            //algorithms
            //coming soon...
        }
    }
}

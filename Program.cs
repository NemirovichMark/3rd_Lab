using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace _LABA_3_
{
    internal class Program
    {
        static void lvl1_6()
        {

            int[] a = new int[5] { 1, 2, 3, 4, 5 };
            double l = 0;
            foreach (int x in a)
            {
                l += (x * x);
            }
            Console.WriteLine(Math.Sqrt(l));

        }
        static void lvl1_10()
        {

            int p = 1;
            int q = 5;
            int n = 0;
            int[] a = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            foreach (int x in a)
            {
                if (x > p && x < q)
                {
                    n++;
                }
            }
            Console.WriteLine(n);

        }
        static void lvl1_11()
        {

            int n = 0;
            int[] a = new int[10] { -1, -5, 2, 4, 9, 15, 7, 90, 56, 88 };
            foreach (int x in a)
            {
                if (x > 0)
                {
                    n++;
                }
            }
            int[] b = new int[n];
            int i = 0;
            foreach (int x in a)
            {
                if (x > 0)
                {
                    b[i] = x;
                    Console.WriteLine(b[i]);
                    i++;
                }
            }

        }
        static void lvl1_12()
        {

            int i = 0;
            int[] a = new int[8] { 0, -50, 20, 55, 111, -70, 3, -2 };
            for (int min = a.Length - 1; min >= 0; min--)
            {
                if (a[min] < 0)
                {
                    Console.WriteLine("Элемент= " + a[min] + " его индекс= " + (min + 1));
                    break;
                }
            }

        }
        static void lvl1_13()
        {
            int[] a = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] b = new int[5];
            int[] c = new int[5];
            for (int x = 0; x < a.Length; x++)
            {
                if (x % 2 == 0)
                {
                    b[x / 2] = a[x];
                }
                else
                {
                    c[x / 2] = a[x];
                }
            }
            Console.WriteLine("Содержимое массива B ");
            foreach (int i in b)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Содержимое массива C ");
            foreach (int k in c)
            {
                Console.Write(k + " ");
            }
        }
        static void lvl2_5()
        {
            int x;
            int imax = 0;
            int imin = 0;
            int n = 0;
            int z = 0;
            Console.WriteLine("Введите количество элеметов массива");
            while (!int.TryParse(Console.ReadLine(), out x))
            {
            }
            int[] a = new int[x];
            Console.WriteLine("Введите элементы массива");
            int max = int.MinValue;
            int min = int.MaxValue;
            for (int i = 0; i < x; i++)
            {
                while (!int.TryParse(Console.ReadLine(), out a[i]))
                {
                }
                if (a[i] > max)
                {
                    max = a[i];
                    imax = i;
                }
                if (a[i] < min)
                {
                    min = a[i];
                    imin = i;
                }
            }
            Console.WriteLine("Максимальное значение =" + max + " его индекс= " + imax);
            Console.WriteLine("Минимальное значение =" + min + " его индекс= " + imin);
            if (imax < imin)
            {
                int j = imax;
                imax = imin;
                imin = j;
            }
            imax = imax - 1;
            imin = imin + 1;
            for (int k = imin; k <= imax; k++)
            {
                if (a[k] < 0)
                {
                    n++;
                }
            }
            Console.WriteLine("Количество отрицательных элементов =" + n);
            int[] f = new int[n];
            for (int q = imin; q <= imax; q++)
            {
                if (a[q] < 0)
                {
                    f[z] = a[q];
                    z++;
                }
            }
            Console.WriteLine("Новый массив: ");
            foreach (int s in f)
            {
                Console.Write(s + " ");
            }
        }
        static void lvl2_6()
        {

            int x;
            double sr = 0;
            double sum = 0;
            double min = double.MaxValue;
            int imin = 0;
            double q = 0;
            int l = 0;
            int p;
            Console.WriteLine("Введите число p");
            while (!int.TryParse(Console.ReadLine(), out p))
            {

            }
            Console.WriteLine("Введите количество элементов массива");
            while (!int.TryParse(Console.ReadLine(), out x))
            {

            }
            int[] a = new int[x];
            Console.WriteLine("Введите элементы массива");
            for (int i = 0; i < x; i++)
            {
                while (!int.TryParse(Console.ReadLine(), out a[i]))
                {

                }
                sum += a[i];
            }
            sr = sum / x;
            Console.WriteLine("Среднее арифметическое =" + sr);
            for (int j = 0; j < x; j++)
            {
                double delta = Math.Abs(a[j] - sr);
                if (delta < min)
                {
                    min = delta;
                    l = j;
                }
                Console.WriteLine(delta);
            }
            Console.WriteLine("Число, после которого должно стоять p =" + a[l]);
            Console.WriteLine("Индекс этого числа =" + l);
            int[] b = new int[x + 1];
            for (int s = 0; s <= l; s++)
            {
                b[s] = a[s];
            }
            b[l + 1] = p;
            for (int d = l + 1; d < x; d++)
            {
                b[d + 1] = a[d];
            }
            foreach (int u in b)
            {
                Console.WriteLine(u);
            }


        }
        static void lvl2_9()
        {
            int x;
            int min = int.MaxValue;
            int max = int.MinValue;
            double s = 0;
            double sr = 0;
            int imin = 0;
            int imax = 0;

            Console.WriteLine("Введите количество элементов массива");
            while (!int.TryParse(Console.ReadLine(), out x))
            {

            }
            int[] a = new int[x];
            Console.WriteLine("Введите элементы массива");
            for (int i = 0; i < x; i++)
            {
                while (!int.TryParse(Console.ReadLine(), out a[i]))
                {

                }
                if (a[i] < min)
                {
                    min = a[i];
                    imin = i;
                }
                if (a[i] > max)
                {
                    max = a[i];
                    imax = i;
                }
            }
            int k = 0;

            if (imin > imax)
            {
                int z = imax;
                imax = imin;
                imin = z;
            }
            for (int j = imin + 1; j < imax; j++)
            {
                s += a[j];
                k++;
            }
            if (k == 0)
            {
                Console.WriteLine("нет таких элементов");
            }
            sr = s / k;
            Console.WriteLine("Среднее значение =" + sr);
        }
        static void lvl2_10()
        {
            int x;
            int k = 0;
            int q = 0;
            int min = int.MaxValue;
            Console.WriteLine("Введите количество элементов массива");
            while (!int.TryParse(Console.ReadLine(), out x))
            {

            }
            int[] a = new int[x];
            Console.WriteLine("Введите элементы массива");
            q = -1;
            for (int i = 0; i < x; i++)
            {
                while (!int.TryParse(Console.ReadLine(), out a[i]))
                {

                }
                if (a[i] < min && a[i] > 0)
                {
                    min = a[i];
                    q = i;
                }
            }
            if (q == -1)
            {
                Console.WriteLine("Нет положительных элементов");
                return;
            }

            Console.WriteLine("Минимальный положительный элемент = " + min);
            Console.WriteLine("Его индекс = " + q);
            Console.WriteLine("Элементы без минимального положительного");
            int[] b = new int[x - 1];
            for (int j = 0; j < q; j++)
            {
                b[j] = a[j];
            }
            for (int s = q + 1; s < x; s++)
            {
                b[s - 1] = a[s];
            }
            foreach (int u in b)
            {
                Console.WriteLine(u);
            }

        }
        static void lvl2_11()
        {
            int p;
            int x;
           
            int l = -1;
            Console.WriteLine("Введите число p");
            while (!int.TryParse(Console.ReadLine(), out p))
            {

            }
            Console.WriteLine("Введите количество элементов массива");
            while (!int.TryParse(Console.ReadLine(), out x))
            {

            }
            int[] a = new int[x];
            Console.WriteLine("Введите элементы массива");
            for (int i = 0; i < x; i++)
            {
                while (!int.TryParse(Console.ReadLine(), out a[i]))
                {

                }
                if (a[i] > 0)
                {
                  
                    l = i;
                }
            }
            if (l == -1)
            {
                Console.WriteLine("Нет положительных чисел");
                return;
            }
            int[] b = new int[x + 1];
            for (int j = 0; j <= l; j++)
            {
                b[j] = a[j];
            }
            b[l + 1] = p;
            for (int s = l + 1; s < x; s++)
            {
                b[s + 1] = a[s];
            }
            foreach (int u in b)
            {
                Console.WriteLine(u);
            }
        }
        static void lvl2_13()
        {
            int x;
            int max = int.MinValue;
            int q = 0;
            Console.WriteLine("Введите количество элементов массива");
            while (!int.TryParse(Console.ReadLine(), out x))
            {

            }
            int[] a = new int[x];
            Console.WriteLine("Введите элементы массива");
            for (int i = 0; i < x; i++)
            {
                while (!int.TryParse(Console.ReadLine(), out a[i]))
                {

                }
                if (i % 2 == 0 && a[i] > max)
                {
                    max = a[i];
                    q = i;
                }
            }
            Console.WriteLine("Максимальный элемент с четным индексом = " + max);
            Console.WriteLine("Его индекс = " + q);
            Console.WriteLine();
            int[] b = new int[x];
            for (int j = 0; j < q; j++)
            {
                b[j] = a[j];
            }
            b[q] = q;
            for (int s = q + 1; s < x; s++)
            {
                b[s] = a[s];
            }
            foreach (int u in b)
            {
                Console.WriteLine(u);
            }
        }
        static void lvl2_15()
        {
            int k = 1;
            int n;
            Console.WriteLine("Введите количество элементов массива A");
            while (!int.TryParse(Console.ReadLine(), out n))
            {

            }
            int[] a = new int[n];
            Console.WriteLine("Введите элементы массива");
            for (int i = 0; i < n; i++)
            {
                while (!int.TryParse(Console.ReadLine(), out a[i]))
                {

                }
            }

            int m;
            Console.WriteLine("Введите количество элементов массива B");
            while (!int.TryParse(Console.ReadLine(), out m))
            {

            }
            int[] b = new int[m];
            Console.WriteLine("Введите элементы массива");
            for (int t = 0; t < m; t++)
            {
                while (!int.TryParse(Console.ReadLine(), out b[t]))
                {

                }
            }
            int[] c = new int[n + m];
            int ci = 0;
            for (int j = 0; j <= k; j++)
            {

                c[ci++] = a[j];

            }

            for (int z = 0; z < m; z++)
            {
                c[ci++] = b[z];

            }
            for (int q = k + 1; q < n; q++)
            {
                c[ci++] = a[q];

            }
            foreach (int u in c)
            {
                Console.WriteLine(u);
            }
        }
        static void lvl3_1()
        {
            string s = null;
           
            List<int> a = new List<int>();
            Console.WriteLine("Введите элементы, нажмите q для зваершения");
            while (s !="q")
            {
                s = Console.ReadLine();
                int b = 0;
                 if (   int.TryParse(s, out b))
                {
                    a.Add(b);
                }
                
            }

            foreach(int u in a)
            {
                Console.WriteLine(u);
            }

            int max = int.MinValue;
           
            List <int> c = new List<int>();
            for (int i=0; i<a.Count; i++)
            {
                if (a[i]>max)
                {
                 
                    max = a[i];
                    c.Clear();
                    c.Add(i);
                }
                else  if  (a[i]==max)
                {
                    c.Add(i);
                }
              
            }
            Console.WriteLine("Максимальное значение = " + max);
            foreach (int v in c)
            {
               
                Console.WriteLine("Индексы максимальных значений = " + v);
            }

        }
        static void lvl3_5()
        {
            string s = null;
            List<int> a = new List<int>();
            Console.WriteLine("Введите элементы, для завершения нажмите q");
            while (s!="q")
            {
                s = Console.ReadLine();
                int b = 0;
                if (int.TryParse(s, out b))
                {
                    a.Add(b);
                }
                

            }
            Console.WriteLine("Массив");
            foreach (int u in a)
            {
                Console.WriteLine(u);
            }
            Console.WriteLine("упорядоченный по возрастанию элементов с четными индексами массив");
            int temp;
            List<int>c = new List<int>();
            
            for (int i=0; i<a.Count;i++)
            {
               for ( int j=0; j<a.Count-2-i; j++)
                {
                    if (a[j] > a[j+2] && j%2==0)
                    {
                        temp = a[j];
                        a[j]= a[j+2];
                        
                        a[j + 2] = temp;
                       
                    }
                }
            }
           for (int d=0; d<a.Count;d++)
            {
                Console.WriteLine(a[d]);
            }
        }
        static void lvl3_8()
        {
            string s = null;
            List<int> a = new List<int>();
            Console.WriteLine("Введите элемента массива, для завершения нажмите q");
            while(s!="q")
            {
                s = Console.ReadLine();
                int b = 0;
                if (int.TryParse(s, out b ))
                {
                    a.Add(b);
                }
            }
            Console.WriteLine("Массив");
            foreach(int u in a)
            {
                Console.WriteLine(u);
            }
            Console.WriteLine("Упорядоченный массив");
            int temp;
            
            List<int> c = new List<int>();
            for (int i = 0; i < a.Count; i++)
            {
                if (a[i]<0)
                {
                    for (int j=i; j<a.Count; j++)
                    {
                        if (a[i] < a[j] && a[j]<0)
                        {
                            temp = a[i];
                            a[i] = a[j];
                            a[j] = temp;
                        }
                    }
                }
                
            }
            for (int d = 0; d < a.Count; d++)
            {
                Console.WriteLine(a[d]);
            }
 

        }
        static void lvl3_9()
        {
            string s = null;
            Console.WriteLine("Введите элементы массива , для завершения нажмите q");
            List<int> a = new List<int>();
            while (s != "q")
            {
                s = Console.ReadLine();
                int b = 0;
                if (int.TryParse(s, out b))
                {
                    a.Add(b);
                }
            }
            Console.WriteLine("Массив");
            foreach (int u in a)
            {
                Console.WriteLine(u);
            }
            int ub = 1;
            int voz = 1;
            int maxvoz = 1;
            int maxub = 1;
            for (int i = 0; i < a.Count - 1; i++)
            {
                if (a[i] <= a[i + 1])
                {
                    voz++;
                    if (voz > maxvoz)
                    {
                        maxvoz = voz;
                    }
                }
                else
                {
                    voz = 1;
                }
                if (a[i] >= a[i + 1])
                {
                    ub++;
                    if (ub > maxub)
                    {
                        maxub = ub;

                    }
                }
                else
                {
                    ub = 1;
                }
            }
            if (maxvoz > maxub)
            {
                Console.WriteLine("Наибольшая последовательность - последовательность по возрастанию обладает длиной " + maxvoz);
            }
            else
            {
                Console.WriteLine("Наибольшая последовательность - последовательность по убыванию обладает длиной " + maxub);
            }
        }
        static void lvl3_12()
        {
            string s = null;
            Console.WriteLine("Введите элементы массива , для завершения нажмите q");
            List<int> a = new List<int>();
            while (s != "q")
            {
                s = Console.ReadLine();
                int b = 0;
                if (int.TryParse(s, out b))
                {
                    a.Add(b);
                }
            }
            Console.WriteLine("Массив");
            foreach (int u in a)

            {
                Console.WriteLine(u);
            }
            Console.WriteLine("Новый массив");
            
                    a.RemoveAll(i=>i<0);
                
            
            for (int d=0; d<a.Count; d++)
            {
                Console.WriteLine(a[d]);
            }
        }
        static void lvl3_13()
        {
            string s = null;
            Console.WriteLine("Введите элементы массива , для завершения нажмите q");
            List<int> a = new List<int>();
            while (s != "q")
            {
                s = Console.ReadLine();
                int b = 0;
                if (int.TryParse(s, out b))
                {
                    a.Add(b);
                }
            }
           
            Console.WriteLine("Массив");
            foreach (int u in a)

            {
                Console.WriteLine(u);
            }
            Console.WriteLine("Новый массив");
            for (int i = 0; i < a.Count; i++)
            {
                for (int j = i+1; j < a.Count; j++)
                {
                    if (a[i] == a[j])
                    {
                        a.RemoveAt(j);
                    }
                }
            }

            for (int d = 0; d < a.Count; d++)
            {
                Console.WriteLine(a[d]);
            }
        }

        static void alkoritm_11()
        {
            Console.WriteLine("Введите число x");
            int x;
           while(!int.TryParse(Console.ReadLine(), out x))
            {

            }
            List<int>a = new List<int>();
            string s = null;
            Console.WriteLine("Введите элементы, для завершения нажмите q");
            while(s != "q")
            {
                s= Console.ReadLine();
                int b = 0;
                if (int.TryParse(s, out b))
                {
                    a.Add(b);
                }
            }
            Console.WriteLine("Массив");
            foreach(int u in a)
            {
                Console.WriteLine(u);
            }

            int l = 0;
            int p = a.Count - 1;
            bool flag = false;
            while (l<= p)
            {
                int q = (l + p) / 2;
                if (a[q] == x)
                {
                    flag = true;
                    Console.WriteLine("Искомый элемент = " +x);
                    Console.WriteLine("Его индекс = " + q);
                    break;
                }
                if (a[q] < x)
                {
                    l = q+1;
                }
                if (a[q] > x)
                {
                    p = q-1;
                }
               
            }
            
            if (!flag)
            {
                Console.WriteLine("Такого элемента нет");
            }

            

        }
        static void alkoritm_12()
        {
            List<int> a = new List<int>();
            string s = null;
            Console.WriteLine("Введите элементы массива А, для завершения нажмите q");
            while (s != "q")
            {
                s = Console.ReadLine();
                int b = 0;
                if (int.TryParse(s, out b))
                {
                    a.Add(b);
                }
            }
            Console.WriteLine("Массив A");
            foreach (int u in a)
            {
                Console.WriteLine(u);
            }

            List<int> f = new List<int>();
            string v = null;
            Console.WriteLine("Введите элементы массива В, для завершения нажмите q");
            while (v != "q")
            {
                v = Console.ReadLine();
                int l = 0;
                if (int.TryParse(v, out l))
                {
                    f.Add(l);
                }
            }
            Console.WriteLine("Массив B");
            foreach (int d in f)
            {
                Console.WriteLine(d);
            }
            int x = Math.Min(a.Count, f.Count);
            
            List<int> m = new List<int>();
            for (int k=0; k<x*2; k++)
            {
                if (k%2==0)
                {
                    m.Add(a[k / 2]);
                }
                else
                {
                    m.Add(f[k / 2]);
                }
            }
            
            if (a.Count>x)
            {
                for (int p=x; p<a.Count; p++)
                {
                    m.Add(a[p]);
                }
            }
            if (f.Count>x)
            {
                for (int t=x; t<f.Count; t++)
                {
                    m.Add(f[t]);
                }
            }
            Console.WriteLine("Новый массив C");
            foreach(int z in m)
            {
                Console.WriteLine(z);
            }

        }
        static void alkoritm_13()
        {
            List<int> a = new List<int>();
            string s = null;
            Console.WriteLine("Введите элементы массива А, для завершения нажмите q");
            while (s!="q")
            {
                s = Console.ReadLine();
                int b = 0;
                if (int.TryParse(s, out b))
                {
                    a.Add(b);
                }
            }
            Console.WriteLine("Массив А");
            foreach (int u in a)
            {
                Console.WriteLine(u);
            }
            List<int> f = new List<int>();
            string v = null;
            Console.WriteLine("Введите элементы массива В, для завершения нажмите q");
            while (v != "q")
            {
                v = Console.ReadLine();
                int l = 0;
                if (int.TryParse(v, out l))
                {
                    f.Add(l);
                }
            }
            Console.WriteLine("Массив B");
            foreach (int d in f)
            {
                Console.WriteLine(d);
            }
           
            List<int> c = new List<int>();
            int x = a.Count + f.Count;
            int ai = 0;
            int fi = 0;
           for (int i=0; i<x; i++)
            {
                if ((ai<a.Count) && (fi>=f.Count || a[ai] > f[fi]))
                {
                    c.Add(a[ai]);
                    ai++;
                }
                else
                {
                    c.Add(f[fi]);
                    fi++;
                }
            }
            c.Sort();
            Console.WriteLine("Новый массив С");
            for (int y=0; y<c.Count; y++)
            {
                Console.WriteLine(c[y]);
            }

            }
        static void alkoritm_14()
        {
           List<int> a = new List<int>();
            string s = null;
            Console.WriteLine("Введите элементы, для завершения нажмите q");
            while(s!="q")
            {
              s= Console.ReadLine();
                int b = 0;
                if (int.TryParse(s, out b))
                {
                    a.Add(b);
                }
            }
            Console.WriteLine("Массив");
            foreach(int u in a)
            {
                Console.WriteLine(u);
            }
            int temp = 0;
            Console.WriteLine("Новый массив");
           for (int i =0; i < a.Count/2; i++)
            {
                temp = a[i];
                a[i] = a[a.Count-i-1];
                a[a.Count - i-1] = temp;
                
            }
            foreach (int u in a)
            {
                Console.WriteLine(u);
            }
        }

        static void alkoritm_15()
        {
            List<int> a = new List<int>();
            string s = null;
            Console.WriteLine("Введите элементы, для завершения нажмите q");
            while (s != "q")
            {
                s = Console.ReadLine();
                int b = 0;
                if (int.TryParse(s, out b))
                {
                    a.Add(b);
                }
            }
            Console.WriteLine("Массив");
            foreach (int u in a)
            {
                Console.WriteLine(u);
            }
            Console.WriteLine("Введите количество элементов для сдвига");
            int k;
            while (!int.TryParse(Console.ReadLine(), out k))
            {

            }
            Console.WriteLine();
            for (int z = 0; z < k; z++)
            {
                int temp;
                temp = a[a.Count - 1];
                for (int i = a.Count - 1; i > 0; i--)
                {
                    a[i] = a[i - 1];
                }
                a[0] = temp;
            }
            foreach(int v in a)
            {
                Console.WriteLine(v);
            }
        }


            static void Main(string[] args)
            {
            // lvl1_6();

            //  lvl1_10();

            //  lvl1_11();

            //  lvl1_12();

            //  lvl1_13();

            // lvl2_5();


            // lvl2_6();


            //   lvl2_9();

            //  lvl2_10();

            //   lvl2_11();



            //   lvl2_13();




            //  lvl2_15();


            //  lvl3_1();




            //    lvl3_5();


            //      lvl3_8();



             //   lvl3_9();

            //   lvl3_12();



            //  lvl3_13();  


            //   alkoritm_11();

            //  alkoritm_12();


           //  alkoritm_13();

           // alkoritm_14();



          //alkoritm_15();


            }
        }
    }


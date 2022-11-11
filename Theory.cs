using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace labara3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region L1Task6
            //double[] a = new double[5];
            //for (int i = 0; i < 5; i++)
            //{
            //    a[i] = i;
            //}
            //double q = 0;
            //for (int l = 0; l < 5; l++)
            //{
            //    q += Math.Pow(a[l], 2);
            //}
            //Console.WriteLine(Math.Sqrt(q));
            #endregion

            #region L1Task10
            //int[] aa = new int[10];
            //int P;
            //int Q;
            //int k = 0;
            //Console.WriteLine("Введите P (от 0 до 9)");
            //P = int.Parse(Console.ReadLine());
            //Console.WriteLine("Введите Q (от P до 9)");
            //Q = int.Parse(Console.ReadLine());
            //if (Q <= P)
            //{
            //    Console.WriteLine("неверное значение Q");
            //}
            //else
            //{
            //    for (int i = 0; i < 10; i++)
            //    {
            //        aa[i] = i;
            //        if ((aa[i] < Q) && (aa[i] > P))
            //        {
            //            k += 1;
            //        }
            //    }

            //}
            //Console.WriteLine(k);
            #endregion

            #region L1Task11
            //int[] aaa = new int[10];
            //Console.WriteLine("Введите элементы массива через пробел");
            //string s = Console.ReadLine();
            //string[] c = s.Split(' ');
            //for (int i = 0; i < 10; i++)
            //{
            //    aaa[i] = int.Parse(c[i]);

            //}
            //for (int i = 0; i < 10; i++)
            //{
            //    if (aaa[i] > 0)
            //    {
            //        Console.Write($"{aaa[i]} ");
            //    }
            //}
            #endregion

            #region L1Task12
            //int[] aaaa = new int[8];
            //Console.WriteLine(" Введите элементы массива через пробел");
            //string ss = Console.ReadLine();
            //string[] cc = ss.Split(' ');
            //int index=0;
            //for (int i = 0; i < 8; i++)
            //{
            //    aaaa[i] = int.Parse(cc[i]);
            //}
            //int amin = a[0];
            //for (int i = 0; i < 8; i++)
            //{
            //    if (aaaa[i] < amin)
            //    {
            //        amin = aaaa[i];
            //        index= i;
            //    }
            //}
            //Console.WriteLine($"мин значение:  {amin}; индекс:  {index}");
            #endregion

            #region L1Task13
            //int[] aaaaa = new int[10];
            //Console.WriteLine(" Введите элементы массива через пробел");
            //string sss = Console.ReadLine();
            //string[] ccc = sss.Split(' ');
            //for (int i = 0; i < 10; i++)
            //{
            //    aaaaa[i] = int.Parse(ccc[i]);
            //}
            //int k = 0;
            //int b = 0;
            //int[] chet = new int[5];
            //int[] nechet = new int[5];
            //foreach (int x in aaaaa)
            //{
            //    if (x / 2 == 0)
            //    {
            //        chet[k] = x;
            //        k += 1;
            //    }
            //    else if (x / 2 == 1)
            //    {
            //        nechet[b] = x;
            //        b += 1;
            //    }
            //}
            //for (int i = 0; i < k; i++)
            //    Console.Write("{0:f1}", chet[i]);
            //Console.WriteLine();
            //for (int i = 0; i < b; i++)
            //    Console.Write("{0:f1}", nechet[i]);
            //Console.WriteLine();
            #endregion

            #region L2Task5
            //int mmin = a[0];
            //int mmax = a[0];
            //int z = 0;
            //int immin = 0, immax = 0;
            //int[] m=new int[6];
            //int[] a = new int[6] {-45, -4, -3, 4, 7, 10};
            //for (int i = 0; i < 6; i++)
            //{ 
            //    if (a[i] < mmin)
            //    {
            //        mmin = a[i];
            //        immin = i;
            //    }
            //    if (a[i] > mmax)
            //    {
            //        mmax = a[i];
            //        immax = i;
            //    }
            //}
            //if (immin<immax)
            //    for (int i = immin+1; i < immax; i++)
            //    { 
            //        if (a[i]<0)
            //            m[i] = a[i];
            //        z += a[i];
            //    }
            //if (immax<immin)
            //    for (int i = immax+1; i < immin; i++)
            //    {
            //        if (a[i] < 0)
            //            m[i] = a[i];
            //        z += a[i];
            //    }
            //for (int i = 0; i < m.Length; i++)
            //{
            //    if (m[i] != 0)
            //        Console.Write(m[i]);
            //}
            #endregion

            #region L2Task6
            //int p = 100;
            //double l = 0;
            //int immin = 0;
            //int[] a = new int[6] { 8, 2, 4, 5, 7, 10 }; //36 6/6=6
            //double mmin = a[0];
            //double sr = 0;
            //for (int i = 0; i < 6; i++)
            //{
            //    sr += a[i];
            //}
            //for (int i = 0; i < 6; i++)
            //{
            //    l = Math.Abs(a[i] - (sr/6));
            //    if (l < mmin)
            //    {
            //        mmin = l;
            //        immin = i;
            //    }
            //}
            //int[] b= new int[7];
            //for (int i = 0; i < 7; i++)
            //{
            //    if (i<=immin)
            //        b[i] = a[i];
            //    else if (i ==(immin+1)) b[i] = p;
            //    else b[i] = a[i-1];
            //}
            //for (int i = 0; i < 7; i++)
            //    Console.Write(" {0:d} ", b[i]);
            #endregion

            #region L2Task9
            //Console.WriteLine("введите размер массива");
            //int n;
            //int.TryParse(Console.ReadLine(), out n);
            //Console.WriteLine("напишите массив длиной " + n);
            //int[] a = new int[n];
            //double sr = 0, t = 0;
            //int count = 0;
            //int mmin = a[0], mmax = a[0], immin = 0, immax = 0;
            //string s = Console.ReadLine();
            //string[] c = s.Split(' ');
            //for (int i = 0; i < n; i++)
            //{
            //    a[i] = int.Parse(c[i]);
            //    if (a[i] < mmin)
            //    {
            //        mmin = a[i];
            //        immin = i;
            //    }
            //    if (a[i] > immax)
            //    {
            //        mmax = a[i];
            //        immax = i;
            //    }
            //}
            //if (immin < immax)
            //{
            //    for (int j = immin + 1; j < immax; j++)
            //    {
            //        sr += a[j];
            //        count++;
            //    }
            //    t = sr / count;
            //}
            //if (immin > immax)
            //{
            //    for (int j = immax + 1; j < immin; j++)
            //    {
            //        sr += a[j];
            //        count++;
            //    }
            //    t = sr / count;
            //}
            //if (count > 0)
            //{
            //    Console.WriteLine(t);
            //}
            //else
            //{
            //    Console.WriteLine(0);
            //}
            #endregion

            #region L2Task10
            //Console.WriteLine("введите размер массива ");
            //int n;
            //int mmin = a[0];
            //int immin = 0;
            //int.TryParse(Console.ReadLine(), out n);
            //int[] a=new int[n];
            //Console.WriteLine("введите массив ");
            //string s=Console.ReadLine();
            //string[] c = s.Split(' ');
            //for (int i=0; i<n; i++)
            //{
            //    a[i]=int.Parse(c[i]);
            //    if (a[i]<mmin && a[i]>0)
            //    {
            //        mmin=a[i];
            //        immin=i;
            //    }
            //}
            //n = n - 1;
            //for (int i = immin; i < n; i++)
            //    a[i] = a[i + 1];
            //for (int i = 0; i < n; i++)
            //    Console.Write("{0:d} ", a[i]);
            #endregion

            #region L2Task11
            //int n;
            //Console.WriteLine("введите размер массива ");
            //int.TryParse(Console.ReadLine(), out n);
            //int[] a = new int[n];
            //int mmin = a[0];
            //int immin= 0;
            //Console.WriteLine("введите массив длиной " + n);
            //string s= Console.ReadLine();
            //string [] c = s.Split(' ');
            //for (int i = 0; i < n; i++)
            //{
            //    a[i] = int.Parse(c[i]);
            //    if (a[i]<mmin && a[i]>0)
            //    {
            //        mmin= a[i];
            //        immin = i;
            //    }
            //}
            //n = n - 1;
            //for (int i = immin; i < n; i++)
            //    a[i] = a[i + 1];
            //for (int i = 0; i < n; i++)
            //    Console.Write(" {0:d} ", a[i]);
            #endregion

            #region L2Task13
            //int n;
            //Console.WriteLine("введите размер массива ");
            //int.TryParse(Console.ReadLine(), out n);
            //int[] a = new int[n];
            //int mmax = a[0];
            //int immax = 0;
            //Console.WriteLine("введите массив длиной " + n);
            //string s = Console.ReadLine();
            //string[] c = s.Split(' ');
            //for (int i = 0; i < n; i++)
            //{
            //    a[i] = int.Parse(c[i]);
            //    if (a[i] > mmax && i / 2 == 0)
            //    {
            //        mmax = a[i];
            //        immax = i;
            //    }
            //}
            //a[immax] = immax;
            //for (int i = 0; i < n; i++)
            //    Console.Write("{0:d} ", a[i]);
            #endregion //   ..        

            #region L2Task15
            //Console.WriteLine("введите n ");
            //int n = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("введите m ");
            //int m = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("введике к ");
            //int k = Convert.ToInt32(Console.ReadLine());
            //var a = new List<int>();
            //var b = new List<int>();
            //double sum = 0;
            //double sred = 0;
            //Console.WriteLine("введите массив а ");
            //for (int i = 0; i < n; i++)
            //{
            //    a.Add(Convert.ToInt32(Console.ReadLine()));
            //}
            //Console.WriteLine("введите массив б ");
            //for (int i = 0; i < m; i++)
            //{
            //    b.Add(Convert.ToInt32(Console.ReadLine()));
            //}
            //a.InsertRange(k, b);
            //Console.WriteLine("New array: ");
            //for (int i = 0; i < n + m; i++)
            //{
            //    Console.Write(a[i] + " ");
            //}
            #endregion

            #region L3Task1
            //int n;
            //Console.WriteLine("введите размер массива ");
            //int.TryParse(Console.ReadLine(), out n);
            //int[] a = new int[n];
            //int[] b=new int[n];
            //int mmax = a[0];
            //int immax = 0;
            //int count = 0;
            //Console.WriteLine("введите массив длиной " + n);
            //string s = Console.ReadLine();
            //string[] c = s.Split(' ');
            //for (int i = 0; i < a.Length; i++)
            //{
            //    a[i] = int.Parse(c[i]);
            //    if (a[i] > mmax)
            //    {
            //        mmax = a[i];
            //        count = 0;

            //    }
            //    if (a[i] == mmax)
            //    {
            //        immax = i;
            //        b[i] = immax;
            //        count += 1;
            //    }
            //}
            //for (int f = 0; f < b.Length; f++)
            //{
            //    if (b[f] != 0)
            //        Console.Write(b[f]);
            //}
            #endregion

            #region L3Task5
            //int n;
            //Console.WriteLine("введите размер массива ");
            //int.TryParse(Console.ReadLine(), out n);
            //int[] a = new int[n];
            //Console.WriteLine("введите массив длиной " + n);
            //string s = Console.ReadLine();
            //string[] c = s.Split(' ');
            //int tmp=0;
            //for (int i = 0; i < n; i++)
            //{
            //    a[i] = int.Parse(c[i]);
            //}
            //for (int i = 0; i < a.Length; i++)
            //{
            //    for (int j = 1; j < a.Length-1; j++)
            //    {
            //        if (a[j] < a[i])
            //        {
            //            if (a[j] % 2 == 1)
            //            {
            //                tmp = a[i];
            //                a[i] = a[j];
            //                a[j] = tmp;
            //            }
            //        }
            //    }
            //}
            //for (int i = 0; i < n; i++)
            //    Console.Write(a[i]);
            #endregion

            #region L3Task8
            //int n;
            //Console.WriteLine("введите размер массива ");
            //int.TryParse(Console.ReadLine(), out n);
            //int[] a = new int[n];
            //Console.WriteLine("введите массив длиной " + n);
            //string s = Console.ReadLine();
            //string[] c = s.Split(' ');
            //int tmp = 0;
            //for (int i = 0; i < n; i++)
            //{
            //    a[i] = int.Parse(c[i]);
            //}
            //for (int i = 0; i < a.Length; i++)
            //{
            //    if (a[i] < 0)
            //    {

            //        for (int j = i + 1; j < a.Length; j++)
            //        {
            //            if (a[j] < 0 && a[i] < a[j])
            //            {
            //                tmp = a[i];
            //                a[i] = a[j];
            //                a[j] = tmp;
            //            }
            //        }
            //    }
            //}
            //for (int i = 0; i < n; i++)
            //    Console.Write(a[i]);
            #endregion

            #region L3Task9
            //int[] a = new int[11] { 3, 6, 8, 3, 2, 1, -1, 0, 2, 1, 0 };
            //int len = 1;
            //int maxlen = 1;
            //for (int i = 0; i < 10; ++i)
            //{
            //    if (a[i + 1] >= a[i])
            //    {
            //        len++;
            //    }
            //    else
            //    {
            //        if (len > maxlen)
            //        {
            //            maxlen = len;
            //            len = 1;
            //        }
            //        len = 1;
            //    }
            //}
            //if (len > maxlen)
            //    maxlen = len;
            //len = 1;
            //for (int i = 0; i < 10; i++)
            //{
            //    if (a[i] >= a[i + 1])
            //    {
            //        len++;
            //    }
            //    else
            //    {
            //        if (len > maxlen)
            //        {
            //            maxlen = len;
            //            len = 1;
            //        }
            //        len = 1;
            //    }
            //}

            //if (len > maxlen) maxlen = len;
            //Console.WriteLine(maxlen);

            #endregion

            #region L3task12
            //int n = 12;
            //int[] a = new int[n];
            //Console.WriteLine("введите массив длиной " + n);
            //string s = Console.ReadLine();
            //string[] c = s.Split(' ');
            //for (int i = 0; i < n; i++)
            //{
            //    a[i] = int.Parse(c[i]);
            //}
            //for (int i = 1; i < a.Length - 1; i++)
            //{
            //    if (a[i] < 0)
            //    {
            //        a[i] = 0;
            //    }
            //}
            //for (int i = 0; i < a.Length; i++)
            //{
            //    if (a[i] != 0)
            //        Console.Write(a[i]);
            //}
            #endregion

            #region L3Task13
            //Console.WriteLine("напишите размер массива ");
            //int.TryParse(Console.ReadLine(), out int n);
            //Console.WriteLine("напишите массив длиной " + n);
            //int[] a = new int[n];
            //string s = Console.ReadLine();
            //string[] c = s.Split(' ');
            //for (int i = 0; i < n; i++)
            //{
            //    a[i] = int.Parse(c[i]);
            //}
            //var result = a.ToArray().Distinct().ToList();
            //foreach (var item in result)
            //{
            //    Console.Write($"{item} ");
            //}
            #endregion
        }
    }
}
  


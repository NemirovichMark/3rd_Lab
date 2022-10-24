using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace laba3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            double[] a = new double[5];//1.6
            double s=0;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Введите переменную");
                a[i]=double.Parse(Console.ReadLine());
                s = s + Math.Pow(a[i],2);
            }
            Console.WriteLine($"Длина вектора = {Math.Sqrt(s)}");


            double P, Q,sum=0;//1.10
            double[] a1 = new double[10];
            Random rnd=new Random();
            Console.WriteLine("Введите значение P");// Для наглядности от 0-100 
            P=double.Parse(Console.ReadLine());
            Console.WriteLine("Введите знаечение Q");// Для наглядности от 0-100 (так как использую рандом)
            Q=double.Parse(Console.ReadLine());
            Console.WriteLine("------");
            if (P < Q)
            {
                for (int i = 0; i < 10; i++)
                {
                    a1[i] = rnd.Next(0, 100);
                    Console.WriteLine(a1[i]);
                    if (a1[i] > P && a1[i] < Q)
                    {
                        sum += 1;
                    }
                }
            }
            else Console.WriteLine("P должно быть меньше Q");
            Console.WriteLine("------");
            Console.WriteLine($"Количество элементов = {sum}");



            double[] a2 = new double[10] {-5,2,7,8,10,-4,-1,-10,9,-8};//1.11
            for (int i = 0; i < 10; i++)
            {
                if (a2[i] > 0)
                {
                    Console.WriteLine(a2[i]);
                }
            }
            Console.WriteLine("-----");


            double[] a3 = new double[8] { 1, 2, 3, 4, 5, -7, -8, 10 };//1.12
            double imin = 0,ii=0;
            for (int i=0; i<8; i++)
            {
                if (a3[i]<0)
                {
                    imin = a3[i];
                    ii = i;
                }
            }
            Console.WriteLine($"Значение последнего отриц элемента = {imin}\t Номер последнего элемента = {ii+1}");


            double[] a4 = new double[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };//1.13
            double[] b = new double[5];
            double[] b1 = new double[5];
            int k = 0;
            int k1 = 0;
            bool trigger = true;
            foreach(double xxx in a4)
            {
                if (trigger)
                {
                    b[k]= xxx;
                    k++;
                }
                else
                {
                    b1[k1] = xxx;
                    k1++;
                }
                trigger = !trigger;
            }
            Console.Write("Изначальныйй массив:\t ");
            foreach (var xxx in a4)
                Console.Write($"{xxx} ");
            Console.WriteLine();

            Console.Write("Нечетные: ");
            foreach (var odd in b)
                Console.Write($"{odd} ");
            Console.WriteLine();

            Console.Write("Четные: ");
            foreach (var even in b1)
                Console.Write($"{even} ");
            Console.WriteLine();
            Console.WriteLine("------");


            int[] a5 = new int[13] { 1, -10, 5, -6, -8, 10, 4, 3, 2, -1, 110, -2, -3 };//2.5
            int[] neg = new int[1000];
            int max = -100;
            int min = 100;
            int maxi=0, mini=0,k5=0; 
            for (int i = 0; i < 13; i++)
            {
                if (a5[i]>max)
                {
                    max = a5[i];
                    maxi = i;
                }
                if (a5[i]<min)
                {
                    min = a5[i];
                    mini = i;
                } 
            }
            for (int i = mini+1;i<maxi; i++)
            {
                if (a5[i] < 0)
                {
                    neg[k5] = a5[i];
                    Console.Write($"{neg[k5]}");
                    k5++;
                }
            }
            Console.WriteLine();

            
            int n, suma = 0, sr = 0, p, dlina = 100, mind = 100, ind = 0 ;//2.6
            Random rand = new Random();
            Console.WriteLine("Введите p");
            p=int.Parse(Console.ReadLine());
            Console.Write("введите длину массива ");
            if (!int.TryParse(Console.ReadLine(), out n))
            {
                Console.WriteLine("Постарайтесь ввести правильную длину массива");
                return;
            }
            else if (n <= 0)
            {
                Console.WriteLine("Желательно больше нуля");
                return;
            }
            int[] a6 = new int[n];
            for (int i = 0; i < n; i++) 
            {
                a6[i] = rand.Next(-20, 20);
                Console.Write($" {a6[i]} ");
            }
            for (int i = 0; i < n; i++)
            {
                suma += a6[i];
            }
            sr = suma / n;
            for (int i = 0; i < n; i++)
            {
                dlina = (Math.Abs(sr-a6[i]));
                if (dlina < mind)
                {
                    mind = dlina;
                    ind = i;
                }
            }
            a6[ind + 1] = p;
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                Console.Write($"  {a6[i]}  ");
            }
            Console.WriteLine();

            
            Random rand1 = new Random();//2.9
            Console.Write("введите длину массива ");
            if (!int.TryParse(Console.ReadLine(), out n))
            {
                Console.WriteLine("Постарайтесь ввести правильную длину массива");
                return;
            }
            else if (n <= 0)
            {
                Console.WriteLine("Желательно больше нуля");
                return;
            }
            int[] a7 = new int[n];
            for (int i = 0; i < n; i++)
            {
                a7[i] = rand1.Next(-20, 20);
                Console.Write($" {a7[i]} ");
            }
            int max1 = -100;
            int min1 = 100;
            int maxi1=0, mini1=0;
            for (int i = 0; i < n; i++)
            {
                if (a7[i] > max1)
                {
                    max1 = a7[i];
                    maxi1 = i;
                }
                if (a7[i] < min1)
                {
                    min1 = a7[i];
                    mini1 = i;
                }
            }
            if (mini1>maxi1)
            {
                maxi1 += mini1;
                mini1 = maxi1 - mini1;
                maxi1 = maxi1 - mini1;
            }
            double sr1 = 0,mejdu=0;
            
            for (int i = mini1+1; i < maxi1; i++) 
            {
                sr1 += a7[i];
                mejdu++;
            }
            if (mejdu==0)
            {
                Console.WriteLine("Элементов между макс и мини нет");
            }
            else
            {
                sr1 /= mejdu;
                Console.WriteLine($"Среднее арифм = {Math.Round(sr1,4)}");
            }
            Console.WriteLine("--------");


            List<int> a8 = new List<int>() { 100, 2, 5, 10, -50, -20,1, 3, 4, -100 };//2.10
            int minn = 1000;
            int index = 0;
            for (int i = 0; i < a8.Count; i++)
            {
                if ((a8[i] > 0) && (a8[i]<minn))
                {
                    minn = a8[i];
                    index = i;
                }
            }
            a8.RemoveAt(index);
            for (int i = 0; i < a8.Count; i++)
            {
                Console.Write($"  {a8[i]}  ");
            }
            Console.WriteLine();
            Console.WriteLine("--------");


            List<int> a9 = new List<int> { 100, 2, 5, 10, -50, -20, 3, 4, -50, 34, -11, -12, 1, - 3 };//2.11
            int index1=0;
            int pp;
            Console.WriteLine("Введите P");
            pp = int.Parse(Console.ReadLine());
            for (int i = 0; i < a9.Count; i++)
            {
                if (a9[i] > 0)
                {
                    index1 = i;
                }
            }
            a9.Insert(index1+1, pp);
            for (int i = 0; i < a9.Count; i++)
            {
                Console.Write($"  {a9[i]}  ");
            }
            Console.WriteLine();
            Console.WriteLine("-------");


            List<int> a10 = new List<int> { 100, 2, 5, 10, -50, -20, 300, 4, -50, 340, -11, -12, 1, -3 };//2.13
            int maks = -10000;
            int jj = 0;
            for (int i = 0; i < a10.Count; i++) 
            {
                if ((i % 2 == 0) && (a10[i] > maks))
                    {
                    maks = a10[i];
                    jj = i;
                }
            }
            a10[jj] = jj;
            Console.WriteLine($"Maks={maks}\t index={jj}");
            for (int i = 0; i < a10.Count; i++)
            {
                Console.Write($" {a10[i]} ");
            }
            Console.WriteLine();
            Console.WriteLine("------");



            Console.WriteLine("Enter the size of your A array:");//2.15
            int ee = int.Parse((Console.ReadLine()));
            double[] AA = new double[ee];
            Console.WriteLine("Type the A array:");
            for (int i = 0; i < AA.Length; i++)
            {
                AA[i] = Convert.ToDouble(Console.ReadLine());
            }
            Console.WriteLine("Enter the size of your B array:");
            int nn = int.Parse((Console.ReadLine()));
            double[] BB = new double[nn];
            Console.WriteLine("Type the B array:");
            for (int i = 0; i < BB.Length; i++)
            {
                BB[i] = Convert.ToDouble(Console.ReadLine());
            }
            Console.WriteLine("Enter the k:");
            int kk = Convert.ToInt32(Console.ReadLine());
            if (kk >= ee)
            {
                Console.WriteLine("Nope");
            }
            else
            {
                for (int i = 0; i < AA.Length; i++)
                {
                    if (i == kk)
                    {
                        for (int j = 0; j < BB.Length; j++)
                        {
                            Console.Write(BB[j] + " ");
                        }
                        Console.Write(AA[i] + " ");
                    }
                    else
                    {
                        Console.Write(AA[i] + " ");
                    }
                }
            }


            int[] a12 = new int[12] { 1, -5, -9, -111, 2, 5, 7, 120, 8, 120, -10, 120 };//3.1
            List<int> a13 = new List<int>();
            int maximus = 1;
            for (int i = 0; i < 12; i++)
            {
                if (a12[i]==maximus)
                {
                   a13.Add(i);
                }
                if (a12[i]>maximus)
                {
                    maximus = a12[i];
                    a13.Clear();
                    a13.Add(i);
                }
            }
            for (int i = 0; i < a13.Count; i++)
            {
                Console.Write($"  {a13[i]}  ");
            }
            Console.WriteLine();


            int[] a14 = new int[12] { 1, -5, -9, -111, 2, 5, 7, 120, 8, 120, -10, 120 };//3.5
            int minimind = 0;
            int minimum = 0;
            for (int i = 0; i < 12-1; i+=2)
            {
                minimum=a14[i];
                minimind = i;
                for (int j = i+2; j < 12; j+=2)
                {
                    if (a14[j]<minimum)
                    {
                        minimum = a14[j];
                        minimind=j;
                    }
                }
                a14[minimind] = a14[i];
                a14[i] = minimum;
            }
            for (int i = 0; i < 12; i++)
            {
                Console.Write($"  {a14[i]}  ");
            }
            Console.WriteLine();


            int[] a15 = new int[12] { 1, -5, -9, -111, 2, 5, 7, 120, 8, 120, -10, 120 };//3.8
            int maximus1 = 0;
            int maximusindd = 0;
            for (int i = 0; i < 12-1; i++)
            {
                if (a15[i]<0)
                {
                    maximus1 = a15[i];
                    maximusindd = i;
                    for (int j=i+1;j<12;j++)
                    {
                        if (a15[j]<0 && a15[j]>maximus1)
                        {
                            maximus1 = a15[j];
                            maximusindd = j;
                        }
                    }
                    a15[maximusindd] = a15[i];
                    a15[i] = maximus1;
                }
            }
            for (int i = 0; i < 12; i++)
            {
                Console.Write($"  {a15[i]}  ");
            }
            Console.WriteLine();


            int[] a16 = new int[14] { 1, 2, 3, 4, 0, -10, -8, -7, -6, -5, -4, -3, -2, -1 };
            int maxlength = 0;
            int length = 0;
            int c = 0;
            int z = 0;
            for (int i=1; i<14 ;i++)
            {
                if (a16[i - 1] > a16[i])
                {
                    length = 2;
                    z = i;
                    while ((a16[z - 1] > a16[z]) && (z<13))
                    {
                        z += 1;
                        length += 1;
                    }
                }
                if (length > maxlength)
                    maxlength = length;
                if (a16[i-1]<a16[i])
                {
                    length = 2;
                    c = i;
                    while ((a16[c - 1] < a16[c]) && (c<13))
                    {
                        c += 1;
                        length += 1;
                    }
                }
                if (length>maxlength)
                    maxlength = length;

            }
            Console.WriteLine(maxlength);


            int[] a17 = new int[12];//3.12
            Random rand2 = new Random();
            for (int i=0; i<12; i++)
            {
                a17[i] = rand2.Next(-20,20);
                Console.Write($" {a17[i]}  ");
            }
            Console.WriteLine();
            for (int i=0; i<12; i++)
            {
                if (a17[i]>0)
                    Console.Write($"  {a17[i]}  ");
            }
            Console.WriteLine();



            int[] a18 = new int[12] { 1, 2, 3, 4, 5, 6, 7, -10, -11, -10, 2, 4 };//3.13
            int flag = 0;
            for (int i = 0; i < 12; i++)
            {
                flag = 0;
                for (int j = 0; j < 12; j++)
                {
                    if (i > j && a18[i] == a18[j])
                    {
                        flag += 1;
                    }
                    if (flag == 1)
                    {
                        break;
                    }
                }
                if (flag != 1)
                {
                    Console.Write(a18[i] + " ");
                }
            }
            Console.WriteLine();



            int[] a19 = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };//11
            int x = 0;
            int i1 = 0, i2 = 0;
            int srindex = 0;
            Console.WriteLine("Введите переменную");
            if (!int.TryParse(Console.ReadLine(), out x))
            {
                Console.WriteLine("Введите норм пж");
                return;
            }
            i2 = a19.Length - 1;
            while (true)
            {
                srindex = (i1 + i2) / 2;
                if (x==a19[srindex])
                {
                    Console.WriteLine($" index = {srindex}  ");
                    break;
                }
                if (x<a19[srindex])
                {
                    i2 = srindex - 1;
                }
                if (x>a19[srindex])
                {
                    i1 = srindex + 1;
                }
                if (i2<i1)
                {
                    Console.WriteLine("Такого элемента нет");
                    break;
                }
            }
            Console.WriteLine();


            int[] a20 = new int[5] { 1, 2, 3, 4, 5 };//12
            int[] a21=new int[10] {10,9,8,7,6,5,4,3,2,1 };
            int[] a22 = new int[Math.Min(a20.Length, a21.Length) * 2];

            for (int i = 0; i < a22.Length; i++)
            {
                if (i % 2 == 0)
                {
                    a22[i] = a20[i / 2];
                }
                else
                {
                    a22[i] = a21[(i - 1) / 2];
                }
            }
            for (int i = 0; i < a22.Length; i++)
                Console.Write($" {a22[i]}  ");
            Console.WriteLine();


            int[] a23 = new int[5] { 15,14,13,12,11 };//13
            int[] a24 = new int[10] {10,9,8,7,6,5,4,3,2,1};
            int[] a25 = new int[a23.Length + a24.Length];
            int znachind1=0, znachind2=0;
            int resultindex = 0;
            bool flajok = true;
            while (flajok)
            {
                while (a23[znachind1] >= a24[znachind2])
                {
                    a25[resultindex] = a23[znachind1];
                    znachind1++;
                    resultindex++;
                    if (znachind1>=a23.Length)
                    {
                        flajok = false;
                        break;
                    }
                }
                if (!flajok)
                    break;
                while (a24[znachind2] >= a23[znachind1])
                {
                    a25[resultindex] = a24[znachind2];
                    znachind2++;
                    resultindex++;
                    if (znachind2>=a24.Length)
                    {
                        flajok=false;
                        break;
                    }
                }
            }
            if (a23.Length<=a24.Length)
            {
                while (znachind2<a24.Length)
                {
                    a25[resultindex] = a24[znachind2];
                    resultindex++;
                    znachind2++;
                }
            }
            else
            {
                while (znachind1<a23.Length)
                {
                    a25[resultindex] = a23[znachind1];
                    resultindex++;
                    znachind1++;
                }
            }
            foreach(int llol in a25)
            {
                Console.Write($"  {llol}  ");
            }
            Console.WriteLine();



            int[] a26 = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };//14
            int ggg=a26.Length;
            int kul = 0;
            for (int i= 0; i < ggg/2; i++)
            {
                kul = a26[ggg - (i + 1)];
                a26[ggg - (i + 1)] = a26[i];
                a26[i] = kul;
            }
            for (int i=0; i < ggg; i++)
            {
                Console.Write($"  {a26[i]}  ");
            }
            Console.WriteLine();


            int[] a27 = new int[7] { 1, 2, 3, 4, 5, 6, 7 };//15
            int m1 = 0;
            int haha = 0;
            Console.WriteLine("Введите m");
            m1 = int.Parse(Console.ReadLine());
            for (int i=0; i < m1 % a27.Length; i++)
            {
                haha = a27[a27.Length - 1];
                for (int j = a27.Length - 1; j > 0; j = j - 1)
                {
                    a27[j] = a27[j - 1];
                }
                a27[0] = haha;
            }
            for (int i=0; i < a27.Length; i++)
            {
                Console.Write($"  {a27[i]}  ");
            }
        }
    }
}

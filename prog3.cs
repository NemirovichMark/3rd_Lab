using System;
        #region 1task6
        Console.WriteLine("task 1");
        Console.WriteLine("ввод массива: ");
        double[] mas = new double[] { 8, 38, 58, 80, 88 };
        int i;
        double L, S = 0;
        for (i = 0; i < 5; i++)
        {
            S = S + (mas[i] * mas[i]);
            Console.Write($"{mas[i]} ");
        }
        Console.WriteLine();
        L = Math.Sqrt(S);
        Console.WriteLine($"длина={L}");

        #endregion

        #region 1task10

        double[] mass = new double[] { 8, 18, 38, 58, 68, 78, 80, 81, 89, 98 };
        int el = 0;
        double P;
        double Q;
        Console.WriteLine("P=");
        while (!double.TryParse(Console.ReadLine(), out P))
        {
            Console.WriteLine("Неверные входные данные");
            Console.Write("P=");
        }
        Console.WriteLine("Q=");
        while (!double.TryParse(Console.ReadLine(), out Q))
        {
            Console.WriteLine("Неверные входные данные");
            Console.Write("Q=");
        }
        while (P >= Q)
        {
            Console.WriteLine("P < Q");
            Console.WriteLine("Q=");
            while (!double.TryParse(Console.ReadLine(), out Q))
            {
                Console.WriteLine("Неверные входные данные");
                Console.Write("Q=");
            }
        }
        foreach (double neww in mass)
        {
            if (neww > P && neww < Q)
            {
                el++;
            }
        }
        Console.WriteLine($"между P и Q  {el} элементов");
        #endregion

        #region 1task11

        double[] nach = new double[] { -208, -18, -8, 0, 0.8, 89, 181, 298, 800, 908 };
        double[] kon = new double[10];
        int i11;
        int m = 0;
        Console.WriteLine("начальный массив: ");
        foreach (double new1 in nach)
        {
            Console.Write($"{new1} ");
            if (new1 > 0)
            {
                kon[m] = new1;
                m++;
            }
        }
        Console.WriteLine();
        Console.WriteLine("конечный массив: ");
        for (i11 = 0; i11 < m; i11++)
        {
            Console.Write($"{kon[i11]} ");
        }
        Console.WriteLine();
        #endregion

        #region 1task12
        double[] mas12 = new double[8] { -98, -86, -68, -38, -18, 0.98, 48, 118 };
        int el12;
        double num = 0, num12 = 1;
        for (el12 = 0; el12 < 8; el12++)
        {
            if (mas12[el12] < 0)
            {
                num = mas12[el12];
                num12 = (el12 + 1);
            }
        }
        Console.WriteLine($"значение отрицательного элемента {num}");
        Console.WriteLine($"номер отрицательного элемента {num12}");
        #endregion

        #region 1task13
        double[] nachmass = new double[10] { 8, 1.83, 28, 31.83, 48, 58.1, 68, 89, 98, 178 };
        double[] chetnmass = new double[5];
        double[] nechetnmass = new double[5];
        int l13;
        for (l13 = 0; l13 < 10; l13++)
        {
            if (l13 % 2 == 0)
                chetnmass[i % 5] = nachmass[i];
            else
                nechetnmass[i % 5] = nachmass[i];
        }
        for (int l1 = 0; l1 < 5; l1++)
        {

            while (!double.TryParse(Console.ReadLine(), out chetnmass[l1]))
            {
                Console.WriteLine("Неверные входные данные");
                Console.Write("четный массив=");
                Console.WriteLine($"четный массив {chetnmass[l1]}");
            }
        }

        for (int l1 = 0; l1 < 5; l1++)
        {
            while (!double.TryParse(Console.ReadLine(), out nechetnmass[l1]))
            {
                Console.WriteLine("Неверные входные данные");
                Console.Write("нечетный массив=");
                Console.WriteLine($"нечетный массив {nechetnmass[l1]}");
            }
        }
        #endregion
        #region 2taks5
        double[] massiv;
        int nn5;
        Console.Write("Введите длину массива:");
        while (!int.TryParse(Console.ReadLine(), out nn5))
        {
            Console.WriteLine("Неверные входные данные");
            Console.Write("Введите длину массива:");
        }
        massiv = new double[nn5];
        for (int ii = 0; ii < nn5; ii++)
        {
            Console.Write($"{ii + 1})");
            while (!double.TryParse(Console.ReadLine(), out massiv[ii]))
            {
                Console.WriteLine("Неверные входные данные");
                Console.Write($"{ii + 1}");
            }
        }
        double[] Itog = new double[nn5];
        double masmax = massiv[0];
        double masmin = massiv[0];
        int I = 0;

        for (int i5 = 1; i5 < 10; i5++)
        {
            if (massiv[i5] < masmin)
                masmin = massiv[i5];
            if (massiv[i5] > masmax)
                masmax = massiv[i5];
        }
        for (int i5 = 0; i5 < 10; i5++)
        {
            if ((massiv[i5] > masmin) & (massiv[i5] < masmax))
            {
                Itog[I] = massiv[i5];
                Console.WriteLine(Itog[I]);
                I += 1;
            }
        }
        #endregion

        #region 2task6 

        int n6;
        Console.Write("Введите длину массива:");
        while (!int.TryParse(Console.ReadLine(), out n6))
        {
            Console.WriteLine("Неверные входные данные");
            Console.Write("Введите длину массива:");
        }
        double[] mas6 = new double[n6 + 1];
        int t6;
        for (t6 = 0; t6 < n6; t6++)
        {
            Console.Write($"{t6 + 1})");
            while (!double.TryParse(Console.ReadLine(), out mas6[t6]))
            {
                Console.WriteLine("Неверные входные данные");
                Console.Write($"{t6 + 1}");
            }
        }
        double summa = mas6.Sum();
        double schet = mas6.Length;
        double malraznost = summa;
        double srednee = summa / schet;
        int raznost = 0;
        for (int i6 = 0; i6 < n6; i6++)
        {
            if (Math.Abs(mas6[i6] - srednee) < malraznost)
            {
                malraznost = mas6[i6];
                raznost = i6;
            }
        }
        int k6 = 0;
        Console.WriteLine(srednee);
        if (double.TryParse(Console.ReadLine(), out double p))
        {
            for (int i6 = mas6.Length - 1; (i6 - 1) != raznost; i6--)
            {
                mas6[i6] = mas6[i6 - 1];
                k6 = i6;
            }
            mas6[k6] = p;
        }
        #endregion

        #region 2task9
        int n9;
        Console.Write("Введите длину массива:");
        while (!int.TryParse(Console.ReadLine(), out n9))
        {
            Console.WriteLine("Неверные входные данные");
            Console.Write("Введите длину массива:");
        }
        double[] mas9 = new double[n9];
        int t9;
        for (t9 = 0; t9 < n9; t9++)
        {
            Console.Write($"{t9 + 1})");
            while (!double.TryParse(Console.ReadLine(), out mas9[t9]))
            {
                Console.WriteLine("Неверные входные данные");
                Console.Write($"{t9 + 1}");
            }
        }
        double minax = mas9[0];
        double maxax = mas9[0];
        int max9 = 0, min9 = 0, n, c9 = 0;
        for (int i9 = 0; i9 < n9; i9++)
        {
            if (mas9[i9] < minax)
            {
                minax = mas9[i9];
                min9 = i9;
            }
        }
        for (int i9 = 0; i9 < n9; i9++)
        {
            if (mas9[i9] > maxax)
            {
                maxax = mas9[i9];
                max9 = i9;
            }
        }
        if (max9 < min9)
        {
            n = min9;
            min9 = max9;
            max9 = n;

        }
        double sum9 = 0;
        while (min9 < max9 - 1)
        {
            sum9 += mas9[min9 + 1];
            c9 += 1;
            min9 += 1;

        }
        Console.WriteLine(sum9 / c9);
        #endregion

        #region 2task10
        
        int n10;
        Console.Write("Введите длину массива:");
        while (!int.TryParse(Console.ReadLine(), out n10))
        {
            Console.WriteLine("Неверные входные данные");
            Console.Write("Введите длину массива:");
        }
        double[] massiv10;
        double min10 = 0;
        int i_min10 = 0;
        massiv10 = new double[n10];
        int t;
        for (t = 0; t < n10; t++)
        {
            Console.Write($"{t + 1})");
            while (!double.TryParse(Console.ReadLine(), out massiv10[t]))
            {
                Console.WriteLine("Неверные входные данные");
                Console.Write($"{t + 1}");
            }
        }
        bool flag = true;
        t = 0;
        while (t < n10 && flag)
        {
            if (massiv10[t] > 0)
            {
                min10 = massiv10[t];
                i_min10 = t;
                flag = false;
            }
            t++;
        }
        if (!flag)
        {
            for (int i10 = t + 1; i10 < n10; i10++)
            {
                if ((massiv10[i10] > 0) & (massiv10[i10] < min10))
                {
                    min10 = massiv10[i10];
                    i_min10 = i10;
                }
            }
            if (min10 != massiv10.Length - 1)
            {
                for (int i10 = i_min10; i10 < n10 - 1; i10++)
                {
                    massiv10[i10] = massiv10[i10 + 1];
                }

            }
            Array.Resize(ref massiv10, n10 - 1);
            for (int i10 = 0; i10 < massiv10.Length; i10++)
            {
                Console.WriteLine(massiv10[i10]);
            }
        }
        else Console.WriteLine("В массиве нет положительных элементов");
#endregion


#region 2task11
Console.WriteLine("2.11");
int n11;
Console.WriteLine("Введите длину массива:");
while (!int.TryParse(Console.ReadLine(), out n11))
{
    Console.WriteLine("Введите длину массива:");
}
n11++;
Console.WriteLine("Введите число P11");
int p11;
while (!int.TryParse(Console.ReadLine(), out p11))
{
    Console.WriteLine("Неверные входные данные");
    Console.WriteLine("Введите число P11");
}
double[] massiv21;
massiv21 = new double[n11];
Console.WriteLine("Введите элементы массива");
int k = -1;
for (int i21 = 0; i21 < n11 - 1; i21++)
{
    Console.Write($"{i21 + 1})");
    while (!double.TryParse(Console.ReadLine(), out massiv21[i21]))
    {
        Console.WriteLine("Неверные входные данные");
        Console.Write($"{i21 + 1})");
    }
    if (massiv21[i21] > 0)
        k = i21;
}
if (k != -1)
{
    for (int i21 = n11 - 2; i21 >= k + 1; i21--)
    {
        massiv21[i21 + 1] = massiv21[i21];
    }
    massiv21[k + 1] = p11;
    for (int i21 = 0; i21 < n11; i21++)
        Console.Write($"{massiv21[i21]} ");
    Console.WriteLine();
}
else
    Console.WriteLine("В массиве нет положительнх элементов");
#endregion
#region 2task13
Console.WriteLine("2.13");
int n13 = 0;
double[] massiv13;
int t21;
Console.Write("Введите длину массива:");
while (!int.TryParse(Console.ReadLine(), out n13))
{
    Console.WriteLine("Неверные входные данные");
    Console.Write("Введите длину массива:");
}
massiv13 = new double[n13];
int[] im = new int[n13];
for (t21 = 0; t21 < n13; t21++)
{
    Console.Write($"{t21 + 1})");
    while (!double.TryParse(Console.ReadLine(), out massiv13[t21]))
    {
        Console.WriteLine("Неверные входные данные");
        Console.Write($"{t21 + 1})");
    }
}
double amax = massiv13[1];
int k13 = 1;
for (int i13 = 0; i13 < n13; i13++)
{
    if (massiv13[i13] > amax)
    {
        amax = massiv13[i13];
        k13 = 0;
        im[k13] = i13;
    }
    else if (massiv13[i13] == amax)
    {
        k13 = k13 + 1;
        im[k13] = i13;
    }
}
for (int i13 = 0; i13 <= k13; i13++)
{
    massiv13[im[i13]] = im[i13];
}
for (int i13 = 0; i13 < n13; i13++)
    Console.WriteLine($"{massiv13[i13]} ");
Console.WriteLine();
#endregion
#region 2task15
Console.WriteLine("2.15");
int n15;
int n16;
double[] mas2;
double[] mas1;
int K;
Console.Write("Введите длину массива A:");
while (!int.TryParse(Console.ReadLine(), out n15))
{
    Console.WriteLine("Неверные входные данные");
    Console.Write("Введите длину массива:");
}


Console.Write("Введите длину массива B:");
while (!int.TryParse(Console.ReadLine(), out n16))
{
    Console.WriteLine("Неверные входные данные");
    Console.Write("Введите длину массива:");
}
mas2 = new double[n16];
int ii25;
mas1 = new double[n15 + n16];
Console.Write("Введите K");
while (!int.TryParse(Console.ReadLine(), out K) & K > 0 & K < (mas1.Length - 1))
{
    Console.WriteLine("Неверные входные данные");
    Console.Write("Введите K");
}
Console.WriteLine("Введите массив А");
for (ii25 = 0; ii25 < n15; ii25++)
{
    Console.Write($"{ii25 + 1})");
    while (!double.TryParse(Console.ReadLine(), out mas1[ii25]))
    {
        Console.WriteLine("Неверные входные данные");
        Console.Write($"{ii25 + 1})");
    }
}
Console.WriteLine("Введите массив B");
for (ii25 = 0; ii25 < n16; ii25++)
{
    Console.Write($"{ii25 + 1})");
    while (!double.TryParse(Console.ReadLine(), out mas2[ii25]))
    {
        Console.WriteLine("Неверные входные данные");
        Console.Write($"{ii25 + 1})");
    }
}
for (ii25 = n16 + n15 - 1; ii25 >= n16; ii25--)
{
    mas1[ii25] = mas1[ii25 - n16];
}
for (ii25 = K; ii25 <= n16; ii25++)
    mas1[ii25] = mas2[ii25 - K];
for (ii25 = 0; ii25 < n16 + n15; ii25++)
    Console.Write($"{mas1[ii25]} ");
Console.WriteLine();
#endregion
#region 3task_1
int n31;
    int c31 = 0;
    Console.Write("Введите длину массива:");
    while (!int.TryParse(Console.ReadLine(), out n31))
    {
        Console.WriteLine("Неверные входные данные");
        Console.Write("Введите длину массива:");
    }
    double[] mas31 = new double[n31];
    for (int i31 = 0; i31 < n31; i31++)
    {
        while (!double.TryParse(Console.ReadLine(), out mas31[i31]))
        {
            Console.WriteLine("Неверные входные данные");
        }
    }
    int[] mas_max31 = new int[n31];
    double maksimum31 = mas31[0];
    mas_max31[0] = 0;
    for (int i31 = 1; i31 < n31; i31++)
    {
        if (maksimum31 <= mas31[i31])
        {
            if (maksimum31 == mas31[i31])
            {
                c31++;
                mas_max31[c31] = i31;
            }
            if (maksimum31 < mas31[i31])
            {
                c31 = 0;
                mas_max31[c31] = i31;
            }
        }
    }
#endregion
#region 3task_5
int n35, i35;
Console.Write("Введите длину массива:");
while (!int.TryParse(Console.ReadLine(), out n35))
{
    Console.WriteLine("Неверные входные данные");
    Console.Write("Введите длину массива:");
}
double[] mas35 = new double[n35];
for (i35 = 0; i35 < n35; i35++)
{
    while (!double.TryParse(Console.ReadLine(), out mas35[i35]))
    {
        Console.WriteLine("Неверные входные данные");
    }
}
bool flag35 = true;
i35 = 0;
int j35;
double dop35;
int dopp35 = n35;
while (i35 < n35 && flag35)
{
    flag35 = false;
    for (j35 = 3; j35 < dopp35; j35 += 2)
    {
        if (mas35[j35 - 2] > mas35[j35])
        {
            dop35 = mas35[j35];
            mas35[j35] = mas35[j35 - 2];
            mas35[j35 - 2] = dop35;
            flag35 = true;
        }
    }
    dopp35 -= 2;
    i35++;
}
for (int i38 = 0; i38 < n35; i38++)
    Console.Write($"{mas35[i38]} ");

#endregion
#region 3task_8
int n38;
Console.Write("Введите длину массива:");
while (!int.TryParse(Console.ReadLine(), out n38))
{
    Console.WriteLine("Неверные входные данные");
    Console.Write("Введите длину массива:");
}
double[] mas38 = new double[n38];
Console.WriteLine("Введите массив:");
bool flag38 = true;
double dop;
int dop_i;
int prev_i = 0;
for (int i38 = 0; i38 < n38; i38++)
{
    while (!double.TryParse(Console.ReadLine(), out mas38[i38]))
    {
        Console.WriteLine("Неверные входные данные");
    }
    if (mas38[i38] < 0 && flag38)
    {
        flag38 = false;
        prev_i = i38;
    }
}
if (!flag38)
    for (int i38 = 0; i38 < n38; i38++)
    {
        dop_i = prev_i;
        for (int i338 = prev_i + 1; i338 < n38; i338++)
            if (mas38[i338] < 0)
            {
                if (mas38[i338] > mas38[dop_i])
                {
                    dop = mas38[i338];
                    mas38[i338] = mas38[dop_i];
                    mas38[dop_i] = dop;
                    dop_i = i338;
                }
                else
                    dop_i = i338;
            }

    }
else Console.WriteLine("В массиве нет отриательных элементов");
for (int i38 = 0; i38 < n38; i38++)
    Console.Write($"{mas38[i38]} ");
#endregion
#region task3_9
int n39, i39;
Console.Write("Введите длину массива:");
while (!int.TryParse(Console.ReadLine(), out n39))
{
    Console.WriteLine("Неверные входные данные");
    Console.Write("Введите длину массива:");
}
double[] mas39 = new double[n39];
for (i39 = 0; i39 < n39; i39++)
{
    while (!double.TryParse(Console.ReadLine(), out mas39[i39]))
    {
        Console.WriteLine("Неверные входные данные");
    }
}
int c39u = 1, c39d = 1, max_u = 1, max_d = 1;
for (i39 = 0; i39 < n39 - 1; i39++)
{
    if (mas39[i39 + 1] > mas39[i39])
    {
        c39u++;
        if (c39u > max_u) max_u = c39u;
        c39d = 1;
    }
    else
    {
        c39d++;
        if (c39d > max_d) max_d = c39d;
        c39u = 1;
    }
}
if (max_u > max_d)
    Console.WriteLine($"Наибольшая возростающая-{max_u}");
else
{
    if (max_d < max_u)
        Console.WriteLine($"Наибольшая убывающая-{max_d}");
    else
        Console.WriteLine($"Убывающая и возрастающая равны-{max_u}");
}
#endregion
#region task3_12

int j312, k312 = 0;
double[] mas312 = { -1, -2, -3, -4, -5, -6, -7, 8, 9, 10, 11, -12 };
int n312 = 12;
for (int i312 = 0; i312 < n312; i312++)
{
    if (mas312[i312] < 0)
    {
        for (j312 = i312; j312 < 11 - k312; j312++)
            mas312[j312] = mas312[j312 + 1];
        k312++;
        i312--;
        n312--;
    }
}
Array.Resize(ref mas312, 12 - k312);
for (int it = 0; it < n312; it++)
    Console.Write($"{mas312[it]} ");

#endregion

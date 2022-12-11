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
double[] nachmass = new double[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
double[] chetnmass = new double[5];
double[] nechetnmass = new double[5];
int l13;
int i113 = 0;
for (l13 = 0; l13 < 10; l13++)
{
    if (l13 % 2 == 0)
    {
        chetnmass[i113] = nachmass[l13];
    }
    else
    {
        nechetnmass[i113] = nachmass[l13];
        i113++;
    }

}
Console.Write("четный массив=");
for (int l1 = 0; l1 < 5; l1++)
{

    Console.Write($"{chetnmass[l1]} ");
}
Console.WriteLine();
Console.Write("нечетный массив=");
for (int l1 = 0; l1 < 5; l1++)
{

    Console.Write($"{nechetnmass[l1]} ");
}
Console.WriteLine();
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
        Console.Write($"{ii + 1})");
    }
}
double[] Itog = new double[nn5];
double masmax = massiv[0];
int maxind = 0;
double masmin = massiv[0];
int minind = 0;
int I = 0;

for (int i5 = 1; i5 < nn5; i5++)
{
    if (massiv[i5] < masmin)
    {
        minind = i5;
        masmin = massiv[i5];
    }

    if (massiv[i5] > masmax)
    {
        maxind = i5;
        masmax = massiv[i5];
    }
}
int m15 = 0, mi15 = 0;
if (maxind >= minind)
{
    m15 = maxind;
    mi15 = minind;
}
else
{
    m15 = minind;
    mi15 = maxind;
}
for (int i5 = mi15; i5 < m15; i5++)
{
    if ((massiv[i5] > masmin) && (massiv[i5] < masmax) && massiv[i5] < 0)
    {
        Itog[I] = massiv[i5];
        I += 1;
    }
}
if (I != 0)
{

    Console.Write("Исходный массив:");
    for (int i5 = 0; i5 < I; i5++)
        Console.Write($"{Itog[i5]} ");
}
else
    Console.WriteLine("Таких элементов нет");
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
        Console.Write($"{t6 + 1})");
    }
}
double p;
Console.Write("Введите Р:");
while (!double.TryParse(Console.ReadLine(), out p))
{
    Console.WriteLine("Неверные входные данные");
    Console.Write("Введите Р:");
}
double summa = mas6.Sum();
double schet = mas6.Length;
double malraznost;
double srednee = summa / schet;
malraznost = srednee - mas6[0];
int raznost = 0;
for (int i6 = 1; i6 < n6; i6++)
{
    if (Math.Abs(mas6[i6] - srednee) < malraznost)
    {
        malraznost = Math.Abs(mas6[i6] - srednee);
        raznost = i6;
    }
}
for (int i6 = n6 - 1; i6 != raznost; i6--)
{
    mas6[i6 + 1] = mas6[i6];
}
mas6[raznost + 1] = p;
Console.WriteLine($"Среднее значение-{srednee}");
Console.Write("Массив: ");
for (int i6 = 0; i6 < n6 + 1; i6++)
    Console.Write($"{mas6[i6]} ");
Console.WriteLine();
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
c9 = max9 - min9 - 1;
double sum9 = 0;
for (int i9 = min9 + 1; i9 < max9; i9++)
    sum9 += mas9[i9];
if (c9 != 0)
    Console.WriteLine($"Среднее значение:{sum9 / c9}");
else
    Console.WriteLine("Между макс и мин эл нет элементов");

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
        Console.Write($"{t + 1})");
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
    Console.WriteLine("Массив: ");
    for (int i10 = 0; i10 < massiv10.Length; i10++)
    {
        Console.Write($"{massiv10[i10]} ");
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
while (!int.TryParse(Console.ReadLine(), out n13) || n13 <= 0)
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
double amax = massiv13[0];
int k13 = 0;
for (int i13 = 2; i13 < n13; i13 += 2)
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
Console.WriteLine("Массив: ");
for (int i13 = 0; i13 < n13; i13++)
    Console.Write($"{massiv13[i13]} ");
Console.WriteLine();
#endregion
#region 2task15
Console.WriteLine("2.15");
int n15;
int n16;
double[] mas2;
double[] mas1;
int K;
Console.Write("Введите длину массива A(>1):");
while (!int.TryParse(Console.ReadLine(), out n15) || n15 <= 1)
{
    Console.WriteLine("Неверные входные данные");
    Console.Write("Введите длину массива A:");
}


Console.Write("Введите длину массива B:");
while (!int.TryParse(Console.ReadLine(), out n16))
{
    Console.WriteLine("Неверные входные данные");
    Console.Write("Введите длину массива B:");
}
mas2 = new double[n16];
int ii25;
mas1 = new double[n15 + n16];
Console.Write("Введите K:");
while (!int.TryParse(Console.ReadLine(), out K) || K <= 0 || K >= n15)
{
    Console.WriteLine("Неверные входные данные");
    Console.Write("Введите K:");
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
int dop_ik = 0;
for (ii25 = n15 - 1; ii25 != K - 1; ii25--)
    mas1[ii25 + n16] = mas1[ii25];
for (ii25 = K; dop_ik < n16; ii25++)
{
    mas1[ii25] = mas2[dop_ik];
    dop_ik++;
}
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
    Console.Write($"{i31 + 1})");
    while (!double.TryParse(Console.ReadLine(), out mas31[i31]))
    {
        Console.WriteLine("Неверные входные данные");
        Console.Write($"{i31 + 1})");
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
            Array.Clear(mas_max31);
            mas_max31[c31] = i31;
            maksimum31 = mas31[i31];
        }
    }
}
Console.Write("Массив из индексов: ");
for (int i31 = 0; i31 <= c31; i31++)
    Console.Write($"{mas_max31[i31]} ");
Console.WriteLine();
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
    Console.Write($"{i35 + 1})");
    while (!double.TryParse(Console.ReadLine(), out mas35[i35]))
    {
        Console.WriteLine("Неверные входные данные");
        Console.Write($"{i35 + 1})");
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
    for (j35 = 2; j35 < dopp35; j35 += 2)
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
    Console.Write($"{i38 + 1})");
    while (!double.TryParse(Console.ReadLine(), out mas38[i38]))
    {
        Console.WriteLine("Неверные входные данные");
        Console.Write($"{i38 + 1})");
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
Console.WriteLine("Введите массив:");
for (i39 = 0; i39 < n39; i39++)
{
    Console.Write($"{i39 + 1})");
    while (!double.TryParse(Console.ReadLine(), out mas39[i39]))
    {
        Console.WriteLine("Неверные входные данные");
        Console.Write($"{i39 + 1})");
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
    if (max_d > max_u)
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
#region alg11
int left = 0;
int alg11;
Console.Write("Введите длину массива:");
while (!int.TryParse(Console.ReadLine(), out alg11))
{
    Console.WriteLine("Неверные входные данные");
    Console.Write("Введите длину массива:");
}
double[] masal11 = new double[alg11];
Console.WriteLine("Введите массив:");
int al11;
for (al11 = 0; al11 < alg11; al11++)
{
    Console.Write($"{al11 + 1})");
    while (!double.TryParse(Console.ReadLine(), out masal11[al11]))
    {
        Console.WriteLine("Неверные входные данные");
        Console.Write($"{al11 + 1})");
    }
}
int right = alg11 - 1;
double x;
Console.WriteLine("Введите символ для поиска");
while (!double.TryParse(Console.ReadLine(), out x))
{
    Console.WriteLine("Неверные входные данные");
}
int sred;
bool flagal11 = true;
while (flagal11 && right >= left)
{
    sred = (right + left) / 2;
    if (x == masal11[sred])
        flagal11 = false;
    if (x < masal11[sred])
        right = sred - 1;
    else
        left = sred + 1;

}
if (!flagal11)
    Console.WriteLine("УАР НАШЛИ");
else
    Console.WriteLine($"{x} нет в массиве");
#endregion
#region alg12
int alg12A;
int alg12B;
Console.Write("Введите длину массива А:");
while (!int.TryParse(Console.ReadLine(), out alg12A))
{
    Console.WriteLine("Неверные входные данные");
    Console.Write("Введите длину массива:");
}
Console.Write("Введите длину массива В:");
while (!int.TryParse(Console.ReadLine(), out alg12B))
{
    Console.WriteLine("Неверные входные данные");
    Console.Write("Введите длину массива:");
}
double[] masal12A = new double[alg12A];
double[] masal12B = new double[alg12B];
Console.WriteLine("Введите массив A:");
int al12;
for (al12 = 0; al12 < alg12A; al12++)
{
    Console.Write($"{al12 + 1})");
    while (!double.TryParse(Console.ReadLine(), out masal12A[al12]))
    {
        Console.WriteLine("Неверные входные данные");
        Console.Write($"{al12 + 1})");
    }
}
Console.WriteLine("Введите массив B:");
for (al12 = 0; al12 < alg12B; al12++)
{
    Console.Write($"{al12 + 1})");
    while (!double.TryParse(Console.ReadLine(), out masal12B[al12]))
    {
        Console.WriteLine("Неверные входные данные");
        Console.Write($"{al12 + 1})");
    }
}
int minal14 = 0;
if (alg12A <= alg12B)
    minal14 = alg12A;
else
    minal14 = alg12B;
double[] masal12C = new double[alg12A + alg12B];
masal12C[0] = masal12A[0];
for (al12 = 1; al12 < minal14; al12++)
{
    masal12C[2 * al12] = masal12A[al12];
    masal12C[2 * al12 - 1] = masal12B[al12 - 1];
}
masal12C[2 * al12 - 1] = masal12B[al12 - 1];
if (alg12A > alg12B)
    for (al12 = 0; al12 < alg12A - minal14; al12++)
        masal12C[al12 + 2 * minal14] = masal12A[al12 + minal14];
else
    if (alg12A < alg12B)
    for (al12 = 0; al12 < alg12B - minal14; al12++)
        masal12C[al12 + 2 * minal14] = masal12B[al12 + minal14];
Console.Write("Массив С: ");
for (al12 = 0; al12 < alg12A + alg12B; al12++)
{
    Console.Write($"{masal12C[al12]} ");
}
#endregion
#region 13alg
int alg13A;
int alg13B;
Console.Write("Введите длину массивa A:");
while (!int.TryParse(Console.ReadLine(), out alg13A))
{
    Console.WriteLine("Неверные входные данные");
    Console.Write("Введите длину массива:");
}
Console.Write("Введите длину массивa B:");
while (!int.TryParse(Console.ReadLine(), out alg13B))
{
    Console.WriteLine("Неверные входные данные");
    Console.Write("Введите длину массива:");
}
double[] masal13A = new double[alg13A];
double[] masal13B = new double[alg13B];
Console.WriteLine("Введите массив A:");
int al13;
for (al13 = 0; al13 < alg13A; al13++)
{
    Console.Write($"{al13 + 1})");
    while (!double.TryParse(Console.ReadLine(), out masal13A[al13]))
    {
        Console.WriteLine("Неверные входные данные");
        Console.Write($"{al13 + 1})");
    }
}
Console.WriteLine("Введите массив B:");
for (al13 = 0; al13 < alg13B; al13++)
{
    Console.Write($"{al13 + 1})");
    while (!double.TryParse(Console.ReadLine(), out masal13B[al13]))
    {
        Console.WriteLine("Неверные входные данные");
        Console.Write($"{al13 + 1})");
    }
}
double[] masal13C = new double[alg13A + alg13B];
int iA = 0, iB = 0;
al13 = 0;
for (al13 = 0; al13 < alg13A + alg13B; al13++)
{
    if (iA < alg13A && iB < alg13B)
    {
        if (masal13A[iA] >= masal13B[iB])
        {
            masal13C[al13] = masal13A[iA];
            iA++;
        }
        else
        {
            masal13C[al13] = masal13B[iB];
            iB++;
        }
    }
    else
    {
        if (iA < alg13A)
        {
            masal13C[al13] = masal13A[iA];
            iA++;
        }
        else
        {
            masal13C[al13] = masal13B[iB];
            iB++;
        }
    }
}


Console.Write("Массив С: ");
for (al13 = 0; al13 < alg13A + alg13B; al13++)
{
    Console.Write($"{masal13C[al13]} ");
}
#endregion
#region 14alg
int alg14A;
Console.Write("Введите длину массивa A:");
while (!int.TryParse(Console.ReadLine(), out alg14A))
{
    Console.WriteLine("Неверные входные данные");
    Console.Write("Введите длину массива:");
}
double[] masal14A = new double[alg14A];
Console.WriteLine("Введите массив A:");
int al14;
for (al14 = 0; al14 < alg14A; al14++)
{
    Console.Write($"{al14 + 1})");
    while (!double.TryParse(Console.ReadLine(), out masal14A[al14]))
    {
        Console.WriteLine("Неверные входные данные");
        Console.Write($"{al14 + 1})");
    }
}
al14 = 0;
double dopal14;
for (al14 = 0; al14 < alg14A / 2; al14++)
{
    dopal14= masal14A[al14];
    masal14A[al14] = masal14A[alg14A - 1 - al14];
    masal14A[alg14A - 1 - al14] = dopal14;
}

Console.Write("Массив A: ");
for (al14 = 0; al14 < alg14A; al14++)
{
    Console.Write($"{masal14A[al14]} ");
}
#endregion
#region 
int alg15A;
Console.Write("Введите длину массивa A:");
while (!int.TryParse(Console.ReadLine(), out alg15A))
{
    Console.WriteLine("Неверные входные данные");
    Console.Write("Введите длину массива:");
}
double[] masal15A = new double[alg15A];
Console.WriteLine("Введите массив A:");
int al15;
for (al15 = 0; al15 < alg15A; al15++)
{
    Console.Write($"{al15 + 1})");
    while (!double.TryParse(Console.ReadLine(), out masal15A[al15]))
    {
        Console.WriteLine("Неверные входные данные");
        Console.Write($"{al15 + 1})");
    }
}
int algn15;
Console.Write($"На сколько сдвинуть массив <={alg15A}?:");
while (!int.TryParse(Console.ReadLine(), out algn15))
{
    Console.WriteLine("Неверные входные данные");
    Console.Write($"На сколько сдвинуть массив <={alg15A}?:");

}
al15 = 0;
int dop15 = 0;
Console.WriteLine("Var1");
double[] dopmas15 = new double[algn15];
for (al15 = alg15A - algn15; al15 < alg15A; al15++)
{
    dopmas15[dop15] = masal15A[al15];
    dop15++;
}
for (al15 = alg15A - 1; al15 >= algn15; al15--)
{
    masal15A[al15] = masal15A[al15 - algn15];
}

for (al15 = 0; al15 < algn15; al15++)
    masal15A[al15] = dopmas15[al15];
Console.Write("Массив A: ");
for (al15 = 0; al15 < alg15A; al15++)
{
    Console.Write($"{masal15A[al15]} ");
}
Console.WriteLine();
Console.WriteLine("Var2");
double dope15 = 0;
for (int i15 = 0; i15 < algn15; i15++)
{
    dope15 = masal15A[alg15A - 1];
    for (al15 = alg15A - 1; al15 > 0; al15--)
        masal15A[al15] = masal15A[al15 - 1];
    masal15A[0] = dope15;
}
Console.Write("Массив A: ");
for (al15 = 0; al15 < alg15A; al15++)
{
    Console.Write($"{masal15A[al15]} ");
}
#endregion

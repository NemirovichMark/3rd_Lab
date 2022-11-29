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
        foreach (double neww in mass)//и так ясно что 10 элементов
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

            while (!double.TryParse(Console.ReadLine(), out chetnmass[l1]))//за длину массива выходит
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
        double min10 = 0;//значение минимального положительного
        int i_min10 = 0;//индекс минимального положительного 
        massiv10 = new double[n10];// массив длиной n
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
        if (!flag)// вдруг нет положительных элементов в массиве 
        {
            for (int i10 = t + 1; i10 < n10; i10++)// минимальный 
            {
                if ((massiv10[i10] > 0) & (massiv10[i10] < min10))
                {
                    min10 = massiv10[i10];
                    i_min10 = i10;
                }
            }
            if (min10 != massiv10.Length - 1)//удаляем минимальный 
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
        int n11=0;
        double[] massiv11;
        create(ref n11, out massiv11);
        int new11 = 0;
        maksim(massiv11,ref new11,n11);
        if (new11 == -1)
        {
            Console.WriteLine("Введите положительное число пж");

        }
        else
        {
            if (double.TryParse(Console.ReadLine(), out double P11))
            {
                task2_11(ref massiv11, n11, new11, P11);
                foreach (double e in massiv11)
                {
                    Console.WriteLine(e);
                }
            }
        }
        #endregion
        #region 2task13
        Console.WriteLine("2.13");
    int n13 = 0, n133 = 0;
    double[] bigmassiv13;
    double[] massiv13;
    int t133 = 0;
    create_for_task2_13(ref n13, out massiv13, out bigmassiv13, ref t133, ref n133);
    complete_t213(ref bigmassiv13, ref massiv13, n13);
    foreach (double all in massiv13)
        Console.WriteLine(all);
    #endregion
    #region 2task15
    Console.WriteLine("2.15");
    int n15;
int n16;
double[] mas2;
double[] mas1;
int K;
create_t215(out mas1, out mas2, out n15, out n16, out K);
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
    //[0,2,3,4,5,6,7,8] пусть будет сортировка ..... пузырёк
    i35 = 0;
    int j35;
    double dop35;
    while (i35 < n35 && flag35)
    {
        flag35 = false;
        for (j35 = i35 + 2; j35 < n35; j35 += 2)
        {
            if (mas35[j35 - 2] > mas35[j35])
            {
                dop35 = mas35[j35];
                mas35[j35] = mas35[j35 - 2];
                mas35[j35 - 2] = dop35;
                flag35 = true;
            }
        }
        n35 -= 2;
    }
    #endregion
    #region 3task_8
    int n38, i38;
    Console.Write("Введите длину массива:");
    while (!int.TryParse(Console.ReadLine(), out n38))
    {
        Console.WriteLine("Неверные входные данные");
        Console.Write("Введите длину массива:");
    }
    double[] mas38 = new double[n38];
    for (i38 = 0; i38 < n38; i38++)
    {
        while (!double.TryParse(Console.ReadLine(), out mas38[i38]))
        {
            Console.WriteLine("Неверные входные данные");
        }
    }
    bool flag38 = true
    i38 = 0;
    int j38, d38;
    double dop38;
    for (i38 = 0; mas38[i38] > 0; i38++) { }
    Console.WriteLine($"{i38},!!!");
    while (i38 < n38 && flag38)
    {
        flag38 = false;
        d38 = i38;
        for (j38 = i38 + 1; j38 < n38; j38++)
        {
            if (mas38[j38] < 0)
            {
                if (mas38[j38] > mas38[d38])
                {
                    Console.WriteLine($"HEHEHE{j38}");
                    dop38 = mas38[j38];
                    mas38[j38] = mas38[d38];
                    mas38[d38] = dop38;
                    flag38 = true;
                    d38 = j38;
                }
                else d38 = j38;
            }
        }
        Console.WriteLine("_______________________\n");
        n38 = d38 + 1;
    }
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
        if (mas39[i39 + 1] > mas39[i39])//1 2 3 4 2 1 3 4 5 6
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
    #endregion
    static void create(ref int n, out double[] massiv1)
    {
        Console.Write("Введите длину массива:");
        while (!int.TryParse(Console.ReadLine(), out n))
        {
            Console.WriteLine("Неверные входные данные");
            Console.Write("Введите длину массива:");
        }
        massiv1 = new double[n];
        int t;
        for (t = 0; t < n; t++)
        {
            Console.Write($"{t + 1})");
            while (!double.TryParse(Console.ReadLine(), out massiv1[t]))
            {
                Console.WriteLine("Неверные входные данные");
                Console.Write($"{t + 1}");
            }
        }
        return;
    }
    static void maksim(double[] massiv11, ref int new11, int n11)
    {
        for (int i_11 = 1; i_11 < n11; i_11++)
        {
            if (massiv11[i_11] > 0)
            {
                new11 = i_11;
            }
        }
    }
    static void task2_11(ref double[] massiv11, int n11, int new11, double P11)
    {
        int r11 = 0;
        Array.Resize(ref massiv11, massiv11.Length + 1);
        for (int i_11 = (massiv11.Length - 1); (i_11 - 1) != new11; i_11--)
        {
            massiv11[i_11] = massiv11[i_11 - 1];
            r11 = i_11;
        }
        for (r11 = 0; r11 < n11; r11++)
        {
            Console.Write($"{r11 + 1})");
            while (!double.TryParse(Console.ReadLine(), out massiv11[r11]))
            {
                Console.WriteLine("Неверные входные данные");
                Console.Write($"{r11 + 1}");
            }
        }
        massiv11[(r11 - 1)] = P11;
    }
    static void create_for_task2_13(ref int n13, out double[] massiv13, out double[] bigmassiv13, ref int t133, ref int n133)
    {
        Console.Write("Введите длину массива:");
        while (!int.TryParse(Console.ReadLine(), out n13))
        {
            Console.WriteLine("Неверные входные данные");
            Console.Write("Введите длину массива:");
        }
        massiv13 = new double[n13];

        Console.Write("Введите длину массива:");
        while (!int.TryParse(Console.ReadLine(), out n133))
        {
            Console.WriteLine("Неверные входные данные");
            Console.Write("Введите длину массива:");
        }
        while (!int.TryParse(Console.ReadLine(), out t133))
        {
            Console.WriteLine("Неверные входные данные");
            Console.Write("Введите длину массива:");
        }
        bigmassiv13 = new double[t133];
        for (t133 = 0; t133 < n13; t133++)
        {
            Console.Write($"{t133 + 1})");
            while (!double.TryParse(Console.ReadLine(), out bigmassiv13[n133]))
            {
                Console.WriteLine("Неверные входные данные");
                Console.Write($"{t133 + 1}");
            }
        }
    }
    static void complete_t213(ref double[] bigmassiv13, ref double[] massiv13, int n13)
    {
        for (int i13 = 0; i13 < n13; i13++)
        {
            if (massiv13[i13] == bigmassiv13[0])
                massiv13[i13] = i13;
        }
    }
static void create_t215(out double[] mas1, out double[] mas2, out int n15, out int n16, out int K)
{
    Console.Write("Введите длину массива:");
    while (!int.TryParse(Console.ReadLine(), out n15))
    {
        Console.WriteLine("Неверные входные данные");
        Console.Write("Введите длину массива:");
    }


    Console.Write("Введите длину массива:");
    while (!int.TryParse(Console.ReadLine(), out n16))
    {
        Console.WriteLine("Неверные входные данные");
        Console.Write("Введите длину массива:");
    }
    mas2 = new double[n16];
    int i;
    mas1 = new double[n15 + n16];
    while (int.TryParse(Console.ReadLine(), out K) & K >= 0 & K < (mas1.Length - 1))
    {
        Console.WriteLine("Неверные входные данные");
        Console.Write("Введите K");
    }
    for (i = 0; i < K; i++)
    {
        Console.Write($"{i + 1})");
        while (!double.TryParse(Console.ReadLine(), out mas1[i]))
        {
            Console.WriteLine("Неверные входные данные");
            Console.Write($"{i + 1}");
        }
    }
    for (i = K + 1; i < n15 + n16; i++)
    {
        Console.Write($"{i + 1})");
        while (!double.TryParse(Console.ReadLine(), out mas1[i]))
        {
            Console.WriteLine("Неверные входные данные");
            Console.Write($"{i + 1}");
        }
    }
    for (i = K; i < n16 + K; i++)
    {
        mas1[i] = mas2[i];
    }
}
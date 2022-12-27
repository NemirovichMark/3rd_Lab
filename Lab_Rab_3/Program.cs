#region Task 6

Console.WriteLine("Level 1 Task 6: \n");
int[] vector = new int[5];
double vector_lenght = 0;
Console.WriteLine("Введите координаты вектора (вводите числа!)");
for (int i = 0; i < vector.Length; i++)
{
    Int32.TryParse(Console.ReadLine(), out vector[i]);
}
for (int i = 0; i < vector.Length; i++)
{
    vector_lenght += vector[i] * vector[i];
}
vector_lenght = Math.Sqrt(vector_lenght);
Console.WriteLine($"Длина вектор равна: {vector_lenght}\n");

#endregion


#region Task 10

Console.WriteLine("Level 1 Task 10: \n");

double[] a_1_10 = new double[10];
double P_1_10 = 0;
double Q_1_10 = 0;
int count = 0;

Console.WriteLine("Введите элементы массива (вводите числа): ");
for (int i = 0; i < a_1_10.Length; i++)
{
    double.TryParse(Console.ReadLine(), out a_1_10[i]);
}

Console.Write("Введите значение числа P : \t");
double.TryParse(Console.ReadLine(), out P_1_10);

Console.Write("Введите значение числа Q (Q > P): \t");
double.TryParse(Console.ReadLine(), out Q_1_10);

for (int i = 0; i < a_1_10.Length; i++)
{
    if (a_1_10[i] < Q_1_10 && a_1_10[i] > P_1_10)
    {
        count++;
    }
}

Console.WriteLine($"Количество чисел, которые лежат между P и Q, равно {count} \n");

#endregion


#region Task 11

Console.WriteLine("Level 1 Task 11: \n");
double[] a_1_11 = new double[10];
double[] b_1_11 = new double[10];
Console.WriteLine("Введите элементы массива: ");
for (int i = 0; i < a_1_11.Length; i++)
{
    double.TryParse(Console.ReadLine(), out a_1_11[i]);
}
for (int i = 0; i < a_1_11.Length; i++)
{
    if (a_1_11[i] > 0)
    {
        b_1_11[i] = a_1_11[i];
    }
}
var result = string.Join(", ", b_1_11.Where(x => x > 0));
Console.WriteLine($"Получившийся массив: {result} \n");

#endregion


#region Task 12

Console.WriteLine("Level 1 Task 12: \n");
double[] a_1_12 = new double[8] { 3, 5, 17, -20, 32, 44, -2, 7 };
double a_last = 0;
double i_last = 0;

for (int i = 0; i < a_1_12.Length; i++)
{
    if (a_1_12[i] < 0)
    {
        a_last = a_1_12[i];
        i_last = i;
    }
}
Console.WriteLine("Изначальная строка: \t {0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}", a_1_12[0], a_1_12[1], a_1_12[2], a_1_12[3], a_1_12[4], a_1_12[5], a_1_12[6], a_1_12[7]);
Console.WriteLine($"Значение последнего отрицательного элемента: {a_last}, а его номер: {i_last + 1} \n");

#endregion


#region Task 13

Console.WriteLine("Level 1 Task 13: \n");
int[] a_1_13 = new int[10] { 1, 3, 6, 11, 54, 22, 2, 3, 8, 14 };
int[] b_1_13 = new int[5];
int[] c_1_13 = new int[5];
int n_1_13 = 1;
int indexOdd = 0;
int indexEven = 0;
foreach (var number in a_1_13)
{
    if (n_1_13 == 1)
    {
        b_1_13[indexOdd] = number;
        indexOdd++;
    }
    else
    {
        c_1_13[indexEven] = number;
        indexEven++;
    }
    n_1_13 = -n_1_13;
}
Console.WriteLine("Изначальная строка: \t {0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}", a_1_13[0], a_1_13[1], a_1_13[2], a_1_13[3], a_1_13[4], a_1_13[5], a_1_13[6], a_1_13[7], a_1_13[8], a_1_13[9]);
Console.WriteLine("Строка с элементами на чётных позициях: \t {0}, {1}, {2}, {3}, {4}", b_1_13[0], b_1_13[1], b_1_13[2], b_1_13[3], b_1_13[4]);
Console.WriteLine("Строка с элементами на нечётных позициях: \t {0}, {1}, {2}, {3}, {4}", c_1_13[0], c_1_13[1], c_1_13[2], c_1_13[3], c_1_13[4]);

#endregion


#region Task 5

Console.WriteLine("Level 2 Task 5: \n");
int n, min_2_5, max_2_5 = 0, n0, amount = 2;
Console.WriteLine("Введите количество элементов массива");
if (Int32.TryParse(Console.ReadLine(), out n))
{
    int[] mas1 = new int[n];
    Console.WriteLine("Введите элементы массива: ");
    for (int i = 0; i < mas1.Length; i++)
    {
        Int32.TryParse(Console.ReadLine(), out mas1[i]);
    }
    for (int j = 0; j < mas1.Length; j++)
    {
        if (mas1[j] > max_2_5)
        {
            max_2_5 = mas1[j];
        }
    }
    min_2_5 = max_2_5;
    for (int i = 0; i < mas1.Length; i++)
    {
        if (mas1[i] < min_2_5)
        {
            min_2_5 = mas1[i];
        }
    }
    n0 = min_2_5;
    for (int i = 0; i < mas1.Length; i++)
    {
        if (mas1[i] < 0)
        {
            if (mas1[i] != min_2_5 && mas1[i] != max_2_5)
            {
                amount++;
            }
        }
    }
    int[] mas2 = new int[amount];
    mas2[0] = n0;
    for (int i = 1; i < n; i++)
    {
        if (mas1[i] < 0)
        {
            if (mas1[i - 1] != min_2_5 && mas1[i - 1] != max_2_5)
            {
                mas2[i] = mas1[i - 1];
            }
            else
            {
                if (mas1[i - 1] == min_2_5 || mas1[i - 1] == max_2_5)
                {
                    mas2[i] = mas1[i];
                    i++;
                }
            }

        }
    }
    mas2[amount - 1] = max_2_5;
    Console.WriteLine("Task5: получившийся массив -");
    for (int i = 0; i < mas2.Length; i++)
    {
        Console.WriteLine(mas2[i]);
    }
}

#endregion


#region Task 6

Console.WriteLine("Level 2 Task 6: \n");
int p_2_6, summ_2_6 = 0, mid_2_6, midnum_2_6 = 0, p_num_2_6 = 0;
Console.Write("Введите количество элементов в массиве: \t");
if (Int32.TryParse(Console.ReadLine(), out n))
{
    int[] mas6 = new int[n];
    Console.WriteLine("Введите элементы массива:");
    for (int i = 0; i < mas6.Length; i++)
    {
        Int32.TryParse(Console.ReadLine(), out mas6[i]);
    }
    Console.Write("Введите число P: \t");
    Int32.TryParse(Console.ReadLine(), out p_2_6);
    for (int i = 0; i < mas6.Length; i++)
    {
        if (mas6[i] == p_2_6)
        {
            p_num_2_6 = i;
        }
        summ_2_6 += mas6[i];
    }
    mid_2_6 = summ_2_6 / n;
    for (int i = 1; i < n; i++)
    {
        mas6[i - 1] = mas6[i - 1];
        if ((i - 1) >= p_num_2_6)
        {
            mas6[i - 1] = mas6[i];
        }
    }
    for (int i = 1; i < mas6.Length; i++)
    {
        if (Math.Abs(mid_2_6 - mas6[i - 1]) < Math.Abs(mid_2_6 - mas6[i]))
        {
            midnum_2_6 = i - 1;
        }
    }
    for (int i = 1; i < (n - 1); i++)
    {
        mas6[n - i] = mas6[n - (i + 1)];
    }
    mas6[midnum_2_6 + 1] = p_2_6;
    Console.WriteLine("Полученный массив - ");
    for (int j = 0; j < mas6.Length; j++)
    {
        Console.WriteLine(mas6[j]);
    }
}

#endregion


#region Task 9

Console.WriteLine("Level 2 Task 9: \n");
int max_2_9 = 0, min_2_9, max_i_2_9 = 0, min_i_2_9 = 0;
double n_2_9 = 0, answer_2_9;
Console.Write("Введите количество элементов массива: \t");
if (Int32.TryParse(Console.ReadLine(), out n))
{
    int[] mas9 = new int[n];
    Console.Write("Введите элементы массива:");
    for (int i = 0; i < n; i++)
    {
        Int32.TryParse(Console.ReadLine(), out mas9[i]);
    }
    for (int i = 0; i < mas9.Length; i++)
    {
        if (max_2_9 < mas9[i])
        {
            max_2_9 = mas9[i];
            max_i_2_9 = i;
        }
    }
    min_2_9 = max_2_9;
    for (int i = 0; i < mas9.Length; i++)
    {
        if (min_2_9 > mas9[i])
        {
            min_2_9 = mas9[i];
            min_i_2_9 = i;
        }
    }
    if (min_i_2_9 < max_i_2_9)
    {
        for (int i = min_i_2_9 + 1; i < max_i_2_9; i++)
        {
            summ_2_6 += mas9[i];
        }
        n_2_9 = max_i_2_9 - min_i_2_9 - 1;
    }
    else
    {
        for (int i = max_i_2_9 + 1; i < min_i_2_9; i++)
        {
            summ_2_6 += mas9[i];
        }
        n_2_9 = min_i_2_9 - max_i_2_9 - 1;
    }
    answer_2_9 = summ_2_6 / n_2_9;
    Console.WriteLine($"Ответ: {answer_2_9}");
}

#endregion


#region Task 10

Console.WriteLine("Level 2 Task 10: \n");
int[] array_2_10 = { -7, -8, -9, 1, 2, 3, 4, 5, };
int index_2_10 = 0;
int min_2_10 = 10000;
for (int i = 0; i < array_2_10.Length; i++)
{
    if (array_2_10[i] > 0)
    {
        if (array_2_10[i] < min_2_10)
        {
            min_2_10 = array_2_10[i];
            index_2_10 = i;
        }
    }

}
int n_2_10 = array_2_10.Length - 1;
for (int i = index_2_10; i < n_2_10; i++)
{
    array_2_10[i] = array_2_10[i + 1];
}
for (int i = 0; i < array_2_10.Length - 1; i++)
{
    Console.Write(array_2_10[i]);
    Console.Write(" ");
}

#endregion

#region Task 11
Console.WriteLine("Level 2 Task 11: \n");
int n_2_11;
Console.Write("Введите длину массива:");
int.TryParse(Console.ReadLine(), out n_2_11);
int[] array_2_11 = new int[n_2_11];
Console.WriteLine("Введите число P");
int P_2_11;
int.TryParse(Console.ReadLine(), out P_2_11);
for (int i = 0; i < n_2_11 - 1; i++)
{
    Console.WriteLine($"Введите {i} элемент массива");
    int lk;
    int.TryParse(Console.ReadLine(), out lk);
    array_2_11[i] = lk;
}
int indexn_2_11 = 0;
int maxn_2_11 = 0;
for (int i = 0; i < array_2_11.Length; i++)
{

    if (array_2_11[i] > 0 & array_2_11[i] > maxn_2_11)
    {
        maxn_2_11 = array_2_11[i];
        indexn_2_11 = i;
    }
}
for (int i = n_2_11 - 2; i >= indexn_2_11 + 1; i--)
{
    array_2_11[i + 1] = array_2_11[i];

}
array_2_11[indexn_2_11 + 1] = P_2_11;
foreach (int i in array_2_11)
{
    Console.Write(i);
    Console.Write(" ");
}

#endregion


#region Task 13

Console.WriteLine("Level 2 Task 13: \n");
int max_2_13 = 0, max_i_2_13 = 0;
max_2_13 = 0;
max_i_2_13 = 0;
Console.Write("Введите количество элементов массива: \t");
if (Int32.TryParse(Console.ReadLine(), out n))
{
    int[] mas13 = new int[n];
    Console.WriteLine("Введите элементы массива:");
    for (int i = 0; i < n; i++)
    {
        Int32.TryParse(Console.ReadLine(), out mas13[i]);
    }
    for (int i = 0; i < n; i = i + 2)
    {
        if (max_2_13 < mas13[i])
        {
            max_2_13 = mas13[i];
            max_i_2_13 = i;
        }
    }
    mas13[max_i_2_13] = max_i_2_13;
    Console.WriteLine("Task 13: получившийся массив -");
    for (int i = 0; i < n; i++)
    {
        Console.WriteLine(mas13[i]);
    }
}

#endregion


#region Task 15

Console.WriteLine("Level 2 Task 15: \n");
int m, k_2_15;
Console.Write("Введите количество элементов 1 массива: \t");
Int32.TryParse(Console.ReadLine(), out n);
Console.Write("Введите количество элементов 2 массива: \t");
Int32.TryParse(Console.ReadLine(), out m);
int[] A = new int[n];
int[] B = new int[m];
Console.WriteLine("Введите элементы 1 массива:");
for (int i = 0; i < A.Length; i++)
{
    Int32.TryParse(Console.ReadLine(), out A[i]);
}
Console.WriteLine("Введите элементы 2 массива:");
for (int i = 0; i < B.Length; i++)
{
    Int32.TryParse(Console.ReadLine(), out B[i]);
}
Console.Write("Введите K: \t");
Int32.TryParse(Console.ReadLine(), out k_2_15);
int[] C = new int[n + m];
int result_i = 0;
//Ввожу первую часть значений массива А 
for (int i = 0; i < k_2_15; i++)
{
    C[result_i] = A[i];
    result_i++;
}
//Ввожу значения массива B
for (int j = 0; j < m; j++)
{
    C[result_i] = B[j];
    result_i++;
}
//Ввожу вторую часть значений массива А 
for (int i = k_2_15; i < n; i++)
{
    C[result_i] = A[i];
    result_i++;
}
Console.WriteLine("Task 15: получившийся массив - ");
for (int i = 0; i < C.Length; i++)
{
    Console.WriteLine(C[i]);
}

#endregion


#region Task 1

Console.WriteLine("Level 3 Task 1: \n");
int max_3_1;
Console.Write("Введите длину массива: \t");
if (Int32.TryParse(Console.ReadLine(), out n))
{
    int[] a1 = new int[n];
    Console.WriteLine("Введите элементы массива: ");
    for (int i = 0; i < n; i++)
    {
        Int32.TryParse(Console.ReadLine(), out a1[i]);
    }
    max_3_1 = a1[0];
    int[] b1 = new int[n];
    int b1_i = 0;
    for (int i = 1; i < n; i++)
    {
        if (max_3_1 == a1[i])
        {
            b1[b1_i] = i;
            b1_i++;
        }
        if (max_3_1 < a1[i])
        {
            b1_i = 0;
            max_3_1 = a1[i];
            b1[b1_i] = i;
            b1_i++;
        }
    }
    Console.WriteLine("Получившийся массив: ");
    for (int i = 0; i < b1_i; i++)
    {
        Console.WriteLine(b1[i]);
    }
}

#endregion


#region Task 5

Console.WriteLine("Level 3 Task 5: \n");
Console.Write("Введите длину массива: \t");
if (Int32.TryParse(Console.ReadLine(), out n))
{
    int[] a_3_5 = new int[n];
    Console.WriteLine("Введите элементы массива: ");
    for (int i = 0; i < n; i++)
    {
        Int32.TryParse(Console.ReadLine(), out a_3_5[i]);
    }
    for (int i = 0; i < n - 1; i = i + 2)
    {
        int amin = a_3_5[i];
        int imin = i;
        for (int j = i + 2; j < n; j = j + 2)
        {
            if (a_3_5[j] < amin)
            {
                amin = a_3_5[j];
                imin = j;
            }
        }
        a_3_5[imin] = a_3_5[i];
        a_3_5[i] = amin;
    }
    Console.WriteLine("Получившийся массив: ");
    for (int i = 0; i < n; i++)
    {
        Console.WriteLine(a_3_5[i]);
    }
}

#endregion


#region Task 8

Console.WriteLine("Level 3 Task 8: \n");
Console.Write("Введите длину массива: \t");
if (Int32.TryParse(Console.ReadLine(), out n))
{
    int[] a_3_8 = new int[n];
    Console.WriteLine("Введите элементы массива: ");
    for (int i = 0; i < n; i++)
    {
        Int32.TryParse(Console.ReadLine(), out a_3_8[i]);
    }
    for (int i = 0; i < n - 1; i = i + 1)
    {
        int amax = 0;
        int imax = 0;
        if (a_3_8[i] < 0)
        {
            amax = a_3_8[i];
            imax = i;
            for (int j = i + 1; j < n; j++)
            {
                if (a_3_8[j] < 0)
                {
                    if (a_3_8[j] > amax)
                    {
                        amax = a_3_8[j];
                        imax = j;
                    }
                }
            }
            a_3_8[imax] = a_3_8[i];
            a_3_8[i] = amax;
        }
    }
    Console.WriteLine("Получившийся массив: ");
    for (int i = 0; i < n; i++)
    {
        Console.WriteLine(a_3_8[i]);
    }
}

#endregion


#region Task 9

Console.WriteLine("Level 3 Task 9: \n");
int[] a_3_9 = new int[] { -9, -11, 83, -32, -5, -2, -1, 22, 44, 2, 101, 204 };
int tohigh = 0, tolow = 0, max_3_9 = 0;
for (int i = 0; i < a_3_9.Length - 1; i++)
{
    if (tohigh > max_3_9)
    {
        max_3_9 = tohigh;
    }
    if (tolow > max_3_9)
    {
        max_3_9 = tolow;
    }
    if (a_3_9[i] > a_3_9[i + 1])
    {
        tolow++;
    }
    else tolow = 0;
    if (a_3_9[i] < a_3_9[i + 1])
    {
        tohigh++;
    }
    else tohigh = 0;
}
Console.WriteLine($"Длина самой упорядоченной последовательности: {max_3_9 + 1}");

#endregion


#region Task 12

Console.WriteLine("Level 3 Task 12: \n");
int n_3_12 = 12;
double[] array_3_12 = new double[n_3_12];
for (int i = 0; i < n_3_12; i++)
{
    double x;
    double.TryParse(Console.ReadLine(), out x);
    array_3_12[i] = x;
}

for (int i = 0; i < n_3_12; i++)
{
    if (array_3_12[i] < 0)
    {
        for (int h = i; h < n_3_12 - 1; h++)
        {
            array_3_12[h] = array_3_12[h + 1];

        }
        n_3_12--;
        i--;
    }
}
for (int i = 0; i < n_3_12; i++)
{
    Console.Write(array_3_12[i]);
    Console.Write(" ");
}

#endregion


#region Task 13

Console.WriteLine("Level 3 Task 13: \n");
Console.Write("Введите длину массива: \t");
if (int.TryParse(Console.ReadLine(), out n))
{
    int[] d_3_13 = new int[n];
    Console.WriteLine("Введите элементы массива: ");
    for (int i = 0; i < n; i++)
    {
        Int32.TryParse(Console.ReadLine(), out d_3_13[i]);
    }
    for (int i = 0; i < n - 1; i++)
    {
        int a_rep = d_3_13[i];
        for (int j = i + 1; j < n; j++)
        {
            if (d_3_13[j] == a_rep)
            {
                d_3_13[j] = 0;
                d_3_13[i] = 0;
            }
        }
    }
    Console.WriteLine("Получившийся массив: ");
    for (int i = 0; i < n; i++)
    {
        Console.WriteLine(d_3_13[i]);
    }
}

#endregion


#region Task 11

Console.WriteLine("Task 11:");
Console.Write("Введите длину массива (n): \t");
if (Int32.TryParse(Console.ReadLine(), out n))
{
    int[] a = new int[n];
    Console.WriteLine("Введите элементы массива: ");
    for (int j = 0; j < n; j++)
    {
        Int32.TryParse(Console.ReadLine(), out a[j]);
    }
    for (int j = 0; j < n - 1; j++)
    {
        int amin = a[j];
        int imin = j;
        for (int q = j + 1; q < n; q++)
        {
            if (amin > a[q])
            {
                amin = a[q];
                imin = q;
            }
        }
        a[imin] = a[j];
        a[j] = amin;
    }
    int x = 0;
    Console.Write("Введите число X: \t");
    Int32.TryParse(Console.ReadLine(), out x);
    int i, i1, i2;
    i1 = 0;
    i2 = n - 1;
    while (true)
    {
        i = (i1 + i2) / 2;

        if (i2 < i1)
        {
            Console.WriteLine("Массив не содержит X");
            break;
        }
        if (x == a[i])
        {
            Console.WriteLine($"Ответ: элемент равный Х есть и его номер - {i}");
            break;
        }
        else if (x < a[i])
        {
            i2 = i - 1;
            continue;
        }
        else if (x > a[i])
        {
            i1 = i + 1;
            continue;
        }
    }
}

#endregion


#region Task 12

Console.WriteLine("Task 12: \n");
int n, m;
Console.Write("Введите длину массива A: \t");
Int32.TryParse(Console.ReadLine(), out n);
Console.Write("Введите длину массива B: \t");
Int32.TryParse(Console.ReadLine(), out m);
int[] A_12 = new int[n];
int[] B_12 = new int[m];
Console.WriteLine("Введите элементы массива А:");
for (int i = 0; i < n; i++)
{
    Int32.TryParse(Console.ReadLine(), out A_12[i]);
}
Console.WriteLine("Введите элементы массива B:");
for (int i = 0; i < m; i++)
{
    Int32.TryParse(Console.ReadLine(), out B_12[i]);
}
if (n == m)
{
    int[] C_12 = new int[2 * n];
    int i_A = 0;
    int i_B = 0;
    for (int i = 0; i < 2 * n; i++)
    {
        if (i % 2 == 0)
        {
            C_12[i] = A_12[i_A];
            i_A++;
        }
        else
        {
            C_12[i] = B_12[i_B];
            i_B++;
        }
    }
    Console.WriteLine("Получившийся массив C:");
    for (int i = 0; i < 2 * n; i++)
    {
        Console.WriteLine(C_12[i]);
    }
}
if (n < m)
{
    int[] C_12 = new int[n + m];
    int i_A = 0;
    int i_B = 0;
    for (int i = 0; i < 2 * n; i++)
    {
        if (i % 2 == 0)
        {
            C_12[i] = A_12[i_A];
            i_A++;
        }
        else
        {
            C_12[i] = B_12[i_B];
            i_B++;
        }
    }
    i_B = n;
    for (int i = 2 * n; i < n + m; i++)
    {
        C_12[i] = B_12[i_B];
        i_B++;
    }
    Console.WriteLine("Получившийся массив C:");
    for (int i = 0; i < n + m; i++)
    {
        Console.WriteLine(C_12[i]);
    }
}
else
{
    int[] C_12 = new int[n + m];
    int i_A = 0;
    int i_B = 0;
    for (int i = 0; i < 2 * m; i++)
    {
        if (i % 2 == 0)
        {
            C_12[i] = A_12[i_A];
            i_A++;
        }
        else
        {
            C_12[i] = B_12[i_B];
            i_B++;
        }
    }
    i_A = m;
    for (int i = 2 * m; i < n + m; i++)
    {
        C_12[i] = A_12[i_A];
        i_A++;
    }
    Console.WriteLine("Получившийся массив C:");
    for (int i = 0; i < n + m; i++)
    {
        Console.WriteLine(C_12[i]);
    }
}

#endregion


#region Task 13

Console.WriteLine("Task 13:");
Console.Write("Введите длину массива A: \t");
Int32.TryParse(Console.ReadLine(), out n);
Console.Write("Введите длину массива B: \t");
Int32.TryParse(Console.ReadLine(), out m);
int[] A_13 = new int[n];
int[] B_13 = new int[m];
int[] C_13 = new int[n + m];
Console.WriteLine("Введите элементы массива А: ");
for (int i = 0; i < n; i++)
{
    Int32.TryParse(Console.ReadLine(), out A_13[i]);
}
Console.WriteLine("Введите элементы массива B: ");
for (int i = 0; i < m; i++)
{
    Int32.TryParse(Console.ReadLine(), out B_13[i]);
}
//Сортировка массива А
for (int i = 0; i < n - 1; i++)
{
    int amax = A_13[i];
    int imax = i;
    for (int j = i + 1; j < n; j++)
    {
        if (A_13[j] > amax)
        {
            amax = A_13[j];
            imax = j;
        }
    }
    A_13[imax] = A_13[i];
    A_13[i] = amax;
}
//Сортировка массива B
for (int i = 0; i < m - 1; i++)
{
    int amax = B_13[i];
    int imax = i;
    for (int j = i + 1; j < m; j++)
    {
        if (B_13[j] > amax)
        {
            amax = B_13[j];
            imax = j;
        }
    }
    B_13[imax] = B_13[i];
    B_13[i] = amax;
}
int A_i = 0, B_i = 0, C_i = 0;
bool flag = true;
while (flag)
{
    while (A_13[A_i] >= B_13[B_i])
    {
        C_13[C_i] = A_13[A_i];
        A_i++;
        C_i++;
        if (A_i >= n)
        {
            flag = false;
            break;
        }
    }
    if (flag == false)
        break;
    while (A_13[A_i] < B_13[B_i])
    {
        C_13[C_i] = B_13[B_i];
        B_i++;
        C_i++;
        if (B_i >= m)
        {
            flag = false;
            break;
        }
    }
    if (flag == false)
        break;
}
if (B_i <= m)
{
    for (; B_i < m; B_i++)
    {
        C_13[C_i] = B_13[B_i];
        C_i++;
    }
}
if (A_i <= n)
{
    for (; A_i < n; A_i++)
    {
        C_13[C_i] = A_13[A_i];
        C_i++;
    }
}
Console.WriteLine("Получившийся массив: ");
for (int i = 0; i < n + m; i++)
{
    Console.WriteLine(C_13[i]);
}

#endregion


#region Task 14

Console.WriteLine("Task 14:");
Console.Write("Введите длину массива A: \t");
Int32.TryParse(Console.ReadLine(), out n);
int[] A_14 = new int[n];
int savenum = 0;
Console.WriteLine("Введите элементы массива А:");
for (int i = 0; i < n; i++)
{
    Int32.TryParse(Console.ReadLine(), out A_14[i]);
}
for (int i = 0; i < n / 2; i++)
{
    savenum = A_14[i];
    A_14[i] = A_14[n - (i + 1)];
    A_14[n - (i + 1)] = savenum;
}
Console.WriteLine("Получившийся массив: ");
for (int i = 0; i < n; i++)
{
    Console.WriteLine(A_14[i]);
}
#endregion


#region Task 15

Console.WriteLine("_TASK_15_:");
Console.Write("Введите длину массива A: \t");
Int32.TryParse(Console.ReadLine(), out n);
int[] A_15 = new int[n];
Console.WriteLine("Введите элементы массива А:");
for (int i = 0; i < n; i++)
{
    Int32.TryParse(Console.ReadLine(), out A_15[i]);
}
Console.Write("Введите, насколько сдвигать вправо (m): \t");
Int32.TryParse(Console.ReadLine(), out m);
savenum = 0;
for (int i = 0; i < m; i++)
{
    savenum = A_15[n - 1];
    for (int j = n - 2; j >= 0; j--)
    {
        A_15[j + 1] = A_15[j];
    }
    A_15[0] = savenum;
}
Console.WriteLine("Получившийся массив: ");
for (int i = 0; i < n; i++)
{
    Console.WriteLine(A_15[i]);
}

#endregion

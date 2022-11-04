

static void lvl1Task6()
{
    try
    {
        double[] array = new double[5];
        Console.WriteLine("Enter array values");
        for (int i = 0; i < 5; i++)
        {
            array[i] = Math.Pow(Convert.ToDouble(Console.ReadLine()), 2);
        }
        Console.WriteLine(Math.Sqrt(array.Sum()));
    }
    catch { Console.WriteLine("Error"); }
}

static void lvl1Task10()
{
    double[] array = new double[10];
    int count1 = 0;
    Console.WriteLine("Enter Q and P values (P>Q)");
    try
    {
        double Q1 = Convert.ToDouble(Console.ReadLine());
        double P1 = Convert.ToDouble(Console.ReadLine());
        if (P1 > Q1)
        {
            Console.WriteLine("Enter array values:");
            for (int i = 0; i < 10; i++)
            {
                array[i] = Convert.ToDouble(Console.ReadLine());
                if (Q1 < array[i] && array[i] < P1)
                {
                    count1++;
                }
            }
            Console.WriteLine($"{count1} elements of array stand between P and Q");
        }
        else
        {
            Console.WriteLine("Error");
        }
    }
    catch { Console.WriteLine("Error"); }
}

static void lvl1Task11()
{
    try
    {
        double[] array2 = new double[10];
        int count2 = 0;
        Console.WriteLine("Enter array values");
        for (int i = 0; i < 10; i++)
        {
            array2[i] = Convert.ToDouble(Console.ReadLine());
            if (array2[i] > 0) count2++;
        }
        double[] array_positive2 = new double[count2];
        for (int i = 0; i < 10; i++)
        {
            if (array2[i] > 0)
            {
                array_positive2[count2 - 1] = array2[i];
                count2--;
            }
        }
        Console.WriteLine(string.Join("", array_positive2));
    }
    catch { Console.WriteLine("Error"); }
}

static void lvl1Task12()
{
    try
    {
        double[] array3 = new double[8];
        double negative_value3 = 0;
        double negative_index3 = 0;
        Console.WriteLine("Enter array value");
        for (int i = 0; i < 8; i++)
        {
            array3[i] = Convert.ToDouble(Console.ReadLine());
            if (array3[i] < 0)
            {
                negative_value3 = array3[i];
                negative_index3 = i;
            }
        }
        if (negative_value3 == 0)
        {
            Console.Write("You don't enter negative value");
        }
        else
        {
            Console.WriteLine($"Value - {negative_value3}\nNubmer - {negative_index3 + 1}");
        }
    }
    catch { Console.WriteLine("Error"); }
}

static void lvl1Task13()
{
    try
    {
        double[] array = new double[10];
        double[] array_1 = new double[5];
        int index1 = 0;
        double[] array_2 = new double[5];
        int index2 = 0;
        Console.WriteLine("Enter array values");
        for (int i = 0; i < 10; i++)
        {
            array[i] = Convert.ToDouble(Console.ReadLine());
        }
        for (int i = 0; i < 10; i++)
        {
            if (i % 2 == 0)
            {
                array_1[index1] = array[i];
                index1++;
            }
            if (i % 2 != 0)
            {
                array_2[index2] = array[i];
                index2++;
            }
        }
        Console.WriteLine($"1st array - {String.Join("", array_1)}");
        Console.WriteLine($"2nd array - {String.Join("", array_2)}");
    }
    catch { Console.WriteLine("Error"); }
}

static void lvl2Task5()
{
    try
    {
        Console.WriteLine("Enter count of element");
        int n = Convert.ToInt32(Console.ReadLine());
        int temp = 0;
        double[] array = new double[n];
        for (int i = 0; i < n; i++)
        {
            array[i] = Convert.ToDouble(Console.ReadLine());
        }
        int index_start = Array.IndexOf(array, array.Min());
        int index_end = Array.IndexOf(array, array.Max());
        if (index_start > index_end)
        {
            temp = index_end;
            index_end = index_start;
            index_start = temp;
        }
        temp = 0;
        int n_1 = index_end - index_start - 1;
        double[] array_1 = new double[n_1];
        for (int i = index_start + 1; i < index_end; i++)
        {
            array_1[temp] = array[i];
            temp++;
        }
        Console.WriteLine(string.Join("", array_1));
    }
    catch { Console.WriteLine("Error"); }
}

static void lvl2Task6()
{
    try
    {
        Console.WriteLine("Enter count of elements");
        int n = Convert.ToInt32(Console.ReadLine());
        int index_P = 0;
        double[] array = new double[n];
        Console.WriteLine("Enter P");
        double P = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter array values");
        for (int i = 0; i < n; i++)
        {
            array[i] = Convert.ToDouble(Console.ReadLine());
        }
        double mid = array.Sum() / n;
        for (int i = 0; i < n - 1; i++)
        {
            if (array[i] < mid & mid < array[i + 1])
            {
                index_P = i + 1;
            }
        }
        Array.Resize(ref array, n + 1);
        for (int i = n - 1; i >= index_P - 1; i--)
        {
            array[i + 1] = array[i];
        }
        array[index_P] = P;
        Console.WriteLine($"{string.Join("", array)}");
    }
    catch { Console.WriteLine("Error"); }
}

static void lvl2Task9()
{
    try
    {
        Console.WriteLine("Enter count of element");
        int temp = 0;
        double mid = 0;
        int n = Convert.ToInt32(Console.ReadLine());
        double[] array = new double[n];
        Console.WriteLine("Enter array values");
        for (int i = 0; i < n; i++)
        {
            array[i] = Convert.ToDouble(Console.ReadLine());
        }
        int index_start = Array.IndexOf(array, array.Min());
        int index_end = Array.IndexOf(array, array.Max());
        if (index_start > index_end)
        {
            temp = index_end;
            index_end = index_start;
            index_start = temp;
        }
        for (int i = index_start + 1; i < index_end; i++)
        {
            mid += array[i];
        }
        mid = mid / (index_end - index_start - 1);
        Console.WriteLine(mid);
    }
    catch { Console.WriteLine("Error"); }
}

static void lvl2Task10()
{
    try
    {
        Console.WriteLine("Enter count of element");
        double min_positive = double.PositiveInfinity;
        int index_min = 0;
        int n = Convert.ToInt32(Console.ReadLine());
        double[] array = new double[n];
        Console.WriteLine("Enter array values");
        for (int i = 0; i < n; i++)
        {
            array[i] = Convert.ToDouble(Console.ReadLine());
            if (array[i] > 0 & array[i] < min_positive)
            {
                min_positive = array[i];
                index_min = i;
            }
        }
        double[] array_1 = new double[n - 1];
        for (int i = 0; i < index_min; i++)
        {
            array_1[i] = array[i];
        }
        for (int i = index_min + 1; i < n; i++)
        {
            array_1[i - 1] = array[i];
        }
        array = array_1;
        Console.WriteLine(string.Join("", array));
    }
    catch { Console.WriteLine("Error"); }
}


static void lvl2Task11()
{
    try
    {
        Console.WriteLine("Enter count of element");
        int n = Convert.ToInt32(Console.ReadLine());
        double max = 0;
        Console.WriteLine("Enter P");
        double P = Convert.ToDouble(Console.ReadLine());
        double[] array = new double[n];
        Console.WriteLine("Enter array values");
        for (int i = 0; i < n; i++)
        {
            array[i] = Convert.ToDouble(Console.ReadLine());
            if (array[i] > 0 & array[i] > max)
            {
                max = array[i];
            }
        }
        int index_max = Array.IndexOf(array, max);
        Array.Resize(ref array, n + 1);
        for (int i = n - 1; i >= index_max; i--)
        {
            array[i + 1] = array[i];
        }
        array[index_max + 1] = P;
        Console.WriteLine("------------------------");
        for (int i = 0; i < n + 1; i++)
        {
            Console.WriteLine(string.Join("", array[i]));
        }
    }
    catch { Console.WriteLine("Error"); }
}

static void lvl2Task13()
{
    try
    {
        Console.WriteLine("Enter count of element");
        double max = double.NegativeInfinity;
        int index_max = 0;
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter elements");
        double[] array = new double[n];
        for (int i = 0; i < n; i++)
        {
            array[i] = Convert.ToDouble(Console.ReadLine());
            if (array[i] > max & i % 2 == 0)
            {
                max = array[i];
                index_max = i;
            }
        }
        array[index_max] = index_max;
        Console.WriteLine(string.Join("", array));
    }
    catch { Console.WriteLine("Error"); }

}

static void lvl2Task15()
{
    try
    {
        int temp = 0;
        Console.WriteLine("Enter count of element array A");
        int n = Convert.ToInt32(Console.ReadLine());
        double[] array_A = new double[n];
        Console.WriteLine("Enter count of element array B");
        int m = Convert.ToInt32(Console.ReadLine());
        double[] array_B = new double[m];
        Console.WriteLine("Enter K");
        int k = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter A element");
        for (int i = 0; i < n; i++)
        {
            array_A[i] = Convert.ToDouble(Console.ReadLine());
        }
        Console.WriteLine("Enter B element");
        for (int i = 0; i < m; i++)
        {
            array_B[i] = Convert.ToDouble(Console.ReadLine());
        }
        double[] array_C = new double[n + m];
        int c = 0;
        for (int i = 0; i <= k; i++)
        {
            array_C[i] = array_A[i];
            c = i;
        }
        c += 1;
        for (int i = 0; i < m; i++)
        {
            array_C[c] = array_B[i];
            c++;
        }
        for (int i = k + 1; i < n; i++)
        {
            array_C[c] = array_A[i];
            c++;
        }
        Console.WriteLine(string.Join("", array_C));
    }
    catch { Console.WriteLine("Error"); }
}

static void lvl3Task1()
{
    try
    {
        int n = Convert.ToInt32(Console.ReadLine());
        double[] array = new double[n];
        string s = "";
        for (int i = 0; i < n; i++)
        {
            array[i] = Convert.ToDouble(Console.ReadLine());
        }
        double x = array.Max();
        for (int i = 0; i < n; i++)
        {
            if (array[i] == x)
            {
                s += Convert.ToString(i);
            }
        }
        string[] str = s.Split();
        int[] result = new int[str.Length];
        for (int i = 0; i < str.Length; i++)
        {
            result[i] = Convert.ToInt32(str[i]);
        }
        Console.WriteLine(string.Join("", result));
    }
    catch { Console.WriteLine("Error"); }

}

static void lvl3Task5()
{
    try
    {
        Console.WriteLine("Enter count array");
        int n = Convert.ToInt32(Console.ReadLine());
        double temp = 0;
        double[] array = new double[n];
        int c = 0;
        Console.WriteLine("---------");
        for (int i = 0; i < n; i++)
        {
            array[i] = Convert.ToDouble(Console.ReadLine());
        }
        for (int i = 0; i < n; i += 2)
        {
            for (int j = 0; j < n - 2; j += 2)
            {
                if (array[j] > array[j + 2])
                {
                    temp = array[j];
                    array[j] = array[j + 2];
                    array[j + 2] = temp;
                }
            }
        }
        Console.WriteLine(string.Join(" ", array));
    }
    catch { Console.WriteLine("Error"); }
}

static void lvl3Task8()
{
    try
    {
        Console.WriteLine("Enter count array");
        int n = Convert.ToInt32(Console.ReadLine());
        double amax = 0;
        int imax = 0;
        double[] array = new double[n];
        Console.WriteLine("---------");
        for (int i = 0; i < n; i++)
        {
            array[i] = Convert.ToDouble(Console.ReadLine());
        }
        for (int i = 0; i < n - 1; i++)
        {
            if (array[i] < 0)
            {
                amax = array[i];
                imax = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (array[j] > amax)
                    {
                        amax = array[j];
                        imax = j;
                    }
                }
                array[imax] = array[i];
                array[i] = amax;
            }
        }
        Console.WriteLine(string.Join(" ", array));
    }
    catch { Console.WriteLine("Error"); }

}

static void lvl3Task9()
{
    try
    {
        Console.WriteLine("Enter count array");
        int n = Convert.ToInt32(Console.ReadLine());
        double[] array = new double[n];
        Console.WriteLine("---------");
        for (int i = 0; i < n; i++)
        {
            array[i] = Convert.ToDouble(Console.ReadLine());
        }
        int max_pos = 0;
        int max_neg = 0;
        int max = 0;
        int temp = 1;
        for (int i = 0; i < n - 1; i++)
        {
            if (array[i] < array[i + 1])
            {
                temp++;
                max_pos = Math.Max(max_pos, temp);
            }
            else
            {
                temp = 1;
            }
        }
        temp = 1;
        for (int i = 0; i < n - 1; i++)
        {
            if (array[i] > array[i + 1])
            {
                temp++;
                max_neg = Math.Max(max_neg, temp);
            }
            else
            {
                temp = 1;
            }
        }
        max = Math.Max(max_pos, max_neg);
        Console.WriteLine(max);
    }
    catch { Console.WriteLine("Error"); }
}

static void lvl3Task12()
{
    try
    {
        Console.WriteLine("Enter count array");
        int c = 0;
        double temp = 0;
        int n = Convert.ToInt32(Console.ReadLine());
        double[] array = new double[n];
        Console.WriteLine("---------");
        for (int i = 0; i < n; i++)
        {
            array[i] = Convert.ToDouble(Console.ReadLine());
            if (array[i] < 0)
            {
                c++;
            }
        }
        for (int i = 0; i < n; i++)
        {
            if (array[i] < 0)
            {
                array[i] = 0;
            }
        }
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n - 1; j++)
            {
                if (array[j] == 0)
                {
                    temp = array[j + 1];
                    array[j + 1] = array[j];
                    array[j] = temp;
                }
            }
        }
        Array.Resize(ref array, n - c);
        Console.WriteLine(String.Join(" ", array));
    }
    catch { Console.WriteLine("Error"); }
}

static void lvl3Task13()
{
    try
    {
        Console.WriteLine("Enter count values");
        int n = Convert.ToInt32(Console.ReadLine());
        double[] array = new double[n];
        Console.WriteLine("---------");
        for (int i = 0; i < n; i++)
        {
            array[i] = Convert.ToDouble(Console.ReadLine());
        }
        string value = "";
        for (int i = 0; i < n; i++)
        {
            if (value.Contains(Convert.ToString(array[i])))
            {
                continue;
            }
            else
            {
                value += Convert.ToString(array[i]);
            }
        }
        string[] str = value.Split();
        double[] array2 = new double[str.Length];
        for (int i = 0; i < str.Length; i++)
        {
            array2[i] = Convert.ToDouble(str[i]);
        }
        array = array2;
        Console.WriteLine(string.Join(" ", array2));
    }
    catch { Console.WriteLine("Error"); }
}

Console.WriteLine("1st part:");
Console.WriteLine("1.6");
lvl1Task6();
Console.WriteLine("1.10");
lvl1Task10();
Console.WriteLine("1.11");
lvl1Task11();
Console.WriteLine("1.12");
lvl1Task12();
Console.WriteLine("1.13");
lvl1Task13();
Console.WriteLine("2.5");
lvl2Task5();
Console.WriteLine("2.6");
lvl2Task6();
Console.WriteLine("2.9");
lvl2Task9();
Console.WriteLine("2.10");
lvl2Task10();
Console.WriteLine("2.11");
lvl2Task11();
Console.WriteLine("2.13");
lvl2Task13();
Console.WriteLine("2.15");
lvl2Task15();
Console.WriteLine("3.1");
lvl3Task1();
Console.WriteLine("3.5");
lvl3Task5();
Console.WriteLine("3.8");
lvl3Task8();
Console.WriteLine("3.9");
lvl3Task9();
Console.WriteLine("3.12");
lvl3Task12();
Console.WriteLine("3.13");
lvl3Task13();
Console.WriteLine("-------------------------");

static int Z11(double[] array, double x)
{
    int i1 = 0;
    int i2 = array.Length - 1;
    int i = (i1 + i2) / 2;
    while (i2 > i1)
    {
        if (array[i] == x)
        {
            return i;
        }
        else
        {
            if (array[i] > x)
            {
                i2 = i + 1;
                i = (i1 + i2) / 2;
            }
            else
            {
                i1 = i + 1;
                i = (i1 + i2) / 2;
            }
        }
    }
    return -1;
}

static int[] Z12(int[] a, int[] b)
{
    int[] c = new int[a.Length + b.Length];

    int min = Math.Min(a.Length, b.Length);
    for (int i = 0; i < min; i++)
    {
        c[2 * i] = a[i];
        c[2 * i + 1] = b[i];
    }
    if (a.Length != b.Length)
    {
        int count = min * 2;
        if (a.Length > b.Length)
        {
            for (int i = min; i < a.Length; i++)
            {
                c[count] = a[i];
                count++;
            }
        }
        else
        {
            for (int i = min; i < b.Length; i++)
            {
                c[count] = b[i];
                count++;
            }
        }
    }
    return c;
}


static int[] Z13(int[] a, int[] b)
{
    int temp = 0;
    for (int i = 0; i < a.Length; i++)
    {
        for (int j = i + 1; j < a.Length; j++)
        {
            if (a[i] < a[j])
            {
                a[i] = a[j];
                a[j] = temp;
            }
        }
    }
    temp = 0;
    for (int i = 0; i < b.Length; i++)
    {
        for (int j = i + 1; j < b.Length; j++)
        {
            if (b[i] < b[j])
            {
                b[i] = b[j];
                b[j] = temp;
            }
        }
    }

    int index_a = 0;
    int index_b = 0;
    int[] c = new int[a.Length + b.Length];

    for (int i = 0; i < c.Length; i++)
    {
        if (index_a == a.Length)
        {
            c[i] = b[index_b];
            index_b++;
            continue;
        }
        if (index_b == b.Length)
        {
            c[i] = a[index_a];
            index_a++;
            continue;
        }
        if (a[index_a] > b[index_b])
        {
            c[i] = a[index_a];
            index_a++;
        }
        else
        {
            c[i] = b[index_b];
            index_b++;
        }
    }
    return c;
}

static int[] Z14(int[] array)
{
    for (int i = 0; i < array.Length / 2; i++)
    {
        int temp = array[i];
        array[i] = array[array.Length - i - 1];
        array[array.Length - i - 1] = temp;
    }
    return array;
}

static int[] Z15 (int[] array)
{
    int[] result = new int[array.Length];
    int count = 0;
    int f = Convert.ToInt32(Console.ReadLine());
    for (int i = array.Length - (f % array.Length); i < array.Length; i++)
    {
        result[count] = array[i];
        count++;
    }

    for (int i = 0; i < array.Length - (f % array.Length); i++)
    {
        result[count] = array[i];
        count++;
    }
    return result;
}

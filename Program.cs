using System;

class HelloWorld
{
    static void Main(String[] args)
    {
        #region 12
        Console.WriteLine("--- 12 ---");

        const int n = 6;
        double[] array_1 = new double[n] { 0, 2, 4, 6, 8, 10 };
        double[] array_2 = new double[n + 1] { 1, 3, 5, 7, 9, 11, 12 };
        double[] array = new double[array_1.Length + array_2.Length];
        double x = 0;
        int cnt = array_1.Length;

        if (array_1.Length < array_2.Length)
        {
            cnt = array_1.Length;
            x = 1;
        }
        else if (array_2.Length < array_1.Length)
        {
            cnt = array_2.Length;
            x = 2;
        }

        for (int i = 0; i < cnt * 2; i++)
        {
            if (i % 2 == 0) array[i] = array_1[i / 2];
            else array[i] = array_2[i / 2];
        }


        if (x == 1) for (int i = array_1.Length * 2; i < array_2.Length + array_1.Length; i++) array[i] = array_2[i - array_1.Length];
        else if (x == 2) for (int i = array_2.Length * 2; i < array_1.Length + array_2.Length; i++) array[i] = array_1[i - array_2.Length];

        foreach (double i in array) Console.Write($"{i} ");

        Console.WriteLine();

        Console.WriteLine("--------------------");
        #endregion

        #region 13
        Console.WriteLine("--- 13 ---");

        const int m = 4;
        array_1 = new double[n] { 3.3, 3.3, 1.5, 0.0, 0.0, -1.2 };
        array_2 = new double[m] { 3.3, 3.3, 1.5, 0.0 };
        array = new double[n + m];

        if (array_1.Length < array_2.Length) cnt = array_1.Length;
        else cnt = array_2.Length;

        int q1 = 0, q2 = 0;

        for (int i = 0; i < n + m; i++)
        {
            if (q1 >= n)
            {
                array[i] = array_2[q2];
                q2++;
            }
            else if (q2 >= m)
            {
                array[i] = array_1[q1];
                q1++;
            }
            else
            {
                if (array_1[q1] <= array_2[q2])
                {
                    array[i] = array_2[q2];
                    q2++;
                }
                else
                {
                    array[i] = array_1[q1];
                    q1++;
                }
            }
        }


        foreach (double i in array) Console.Write($"{i} ");
        Console.WriteLine();

        Console.WriteLine("--------------------");
        #endregion

    }
}
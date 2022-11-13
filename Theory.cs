using System;

namespace _3rd_Lab
{
    class Theory
    {
        static void Main(string[] args)
        {
           //1 уровень
//6
using System.Collections.Specialized;

int[] a = new int [5];
int l = 0;
for (int i = 0; i < a.Length; i++)
{
    Console.Write($"число с индексом{i}:");
    a[i] = int.Parse(Console.ReadLine());
}
for (int i=0; i<a.Length;i++)
{
    l += (int)Math.Pow(a[i], 2);
}
Console.WriteLine(Math.Sqrt(l));
Console.ReadLine();
//10
double[] b = new double[10];
string st;
double p, q;
string znach;
int k = 0;
for (int i=0; i<10; i++)
{
    st = Console.ReadLine();
    b[i] = int.Parse(st);
    znach = Console.ReadLine();
    p = double.Parse(znach);
    q=double.Parse(znach);
    if (b[i] > p & b[i]<q)
    {
        k = k + 1;
    }
}
Console.WriteLine(k);
//11
int[] h = new int[10] { 12, -1, -5, 8, 2, -9, 6, 3, 7, -3 };
int count = 0;
int index = 0;
for (int i=0; i<10; i++)
{
    if (h[i]>0)
    {
        count++;
    }
}
int[] j = new int[count];
for (int i=0; i<count; i++)
{
    if (j[i]>0)
    {
        j[index] = j[i];
        index += 1;
    }
}
for (int i = 0; i < j.Length; i++)
    Console.Write("{0:d}", j[i]);
Console.WriteLine();
//12
double[] d = new double[8];
int ii,k1 = 0;
for (ii = 0; ii < 8; ii++)
    Console.Write(d[ii]);
    Console.Write("");
    Console.Write("{0:f1}", d[ii]);
Console.WriteLine();
for (ii = 4; ii >=0; ii--)
    if (d[ii]<0)
    {
        k1 = ii;
        break;
    }
Console.WriteLine(k1);
//13
double[] e = new double[10];
double[] f = new double[5];
double[] g = new double[5];
int k4 = 0;
int k5 = 0;
Console.WriteLine("Введите числа");
Console.WriteLine("Введите числа");
for (int i1 = 0; i1 < e.Length; i1++)
{
    e[i1] = int.Parse(Console.ReadLine());


    foreach (double x in e)
    {
        if (x % 2 == 0)
        {
            f[k4] = x;
            k4 = k4 + 1;
        }
        else
        {
            g[k5] = x;
            k5 = k5 + 1;
        }
    }
    for (int i = 0; i < k4; i++)
        Console.Write("{0:f1}", f[i]);
    Console.WriteLine();
    for (int i = 0; i < k5; i++)
        Console.Write("{0:f1}", g[i]);
    Console.WriteLine();
}
//2 уровень
//5
Console.Write("Введите кол-во элементов массива str: ");
int kol = int.Parse(Console.ReadLine());
int[] h = new int[kol];
int amax = h[0];
int amin = h[0];
int imax = 0;
int imin = 0;
int Count = 0;
int index = 0;
Console.WriteLine("Введите числа");
for (int i = 0; i < h.Length; i++)
{
    Console.Write($"Элемент с индексом {i} равен: ");
    h[i] = int.Parse(Console.ReadLine());


}
for (int i = 0; i < h.Length; i++)
{
    if (h[i] > amax)
    {
        amax = h[i];
        imax = i;
    }


}
for (int i = 0; i < h.Length; i++)
{
    if (h[i] < amin)
    {
        amin = h[i];
        imin = i;
    }
}
for (int i = imin + 1; i < imax; i++)
{
    if (h[i] < 0)
    {
        Count++;
    }
}
int[] j = new int[Count];

for (int i = imin + 1; i < imax; i++)
{
    if (j[i] < 0)
    {
        j[index] = j[i];
        index += 1;
    }
}
for (int i = 0; i < j.Length; i++)
    Console.Write("{0:d} ",j[i]);
Console.ReadLine();
//6
Console.Write("Введите кол-во элементов массива q1: ");
int kolvo = int.Parse(Console.ReadLine());
Console.Write("Введите число P ");
int P = int.Parse(Console.ReadLine());
int[] q1 = new int[kol];
int sum = 0;
int count = 0;
var srednee = 0;
var i_pered_srend = 0;
for (int i = 0; i < q1.Length - 1; i++)
{
    Console.Write($"Элемент с индексом {i} равен: ");
    q1[i] = int.Parse(Console.ReadLine());


}
foreach (int x in q1)
{
    sum += x;
    count++;
}
srednee = sum / count;
for (int i = 0; i < q1.Length; i++)
{
    if (Math.Abs((q1[i] - srednee)) < 1)
    {
        i_pered_srend = i;
    }
}
for (int i = q1.Length - 2; i > i_pered_srend; i--)
{
    q1[i + 1] = q1[i];
}
q1[i_pered_srend + 1] = P;
for (int i = 0; i < q1.Length; i++)
    Console.Write("{0:d} ", q1[i]);
Console.ReadLine();
//9
Console.Write("Введите кол-во элементов массива z: ");
int kolz = int.Parse(Console.ReadLine());
double[] z = new double[kolz];
double minz = z[0];
int nomminz = 0;
double maxz = z[0];
int nommaxz = 0;
int lenz = z.Length;
double srznz = 0;
int col = 0;
Console.WriteLine("Введите числа");
for (int i = 0; i < lenz; i++)
{
    Console.Write($"Элемент с индексом {i} равен: ");
    z[i] = int.Parse(Console.ReadLine());


}
for (int i = 0; i < lenz; i++)
{
    if (z[i] < minz)
    {
        nomminz = i;
        minz = b[i];
    }
    if (z[i] > maxz)
    {
        nommaxz = i;
        maxz = z[i];
    }
}
if (nomminz > nommaxz)
{
    int v = nommaxz;
    nommaxz = nomminz;
    nomminz = v;
}

for (int i = nomminz + 1; i < nommaxz; i++)
{
    srznz = srznz + z[i];
    col = col + 1;
}
srznz = srznz / col;
Console.WriteLine(srznz);
//10
List<int> a10 = new List<int>() { 10,-9,3,6,-4,2,14,-7,1,8 };
int minn = 1000;
int ind = 0;
for (int i = 0; i < a10.Count; i++)
{
    if ((a10[i] > 0) && (a10[i] < minn))
    {
        minn = a10[i];
        index = i;
    }
}
a10.RemoveAt(index);
for (int i = 0; i < a10.Count; i++)
{
    Console.Write($"  {a10[i]}  ");
}
Console.WriteLine();
//11
List<int> a11 = new List<int> { 10, 2, 15, 16, -5, -20, 3, 4, -9, 10, -1, -7, 1, 19 };
int ind1 = 0;
int pp;
Console.WriteLine("enter P");
if (!int.TryParse(Console.ReadLine(), out pp))
{
    Console.WriteLine("incorrect");
    return;
}
for (int i = 0; i < a11.Count; i++)
{
    if (a11[i] > 0)
    {
        ind1 = i;
    }
}
a11.Insert(ind1 + 1, pp);
for (int i = 0; i < a11.Count; i++)
{
    Console.Write($"  {a11[i]}  ");
}
Console.WriteLine();
//13
List<int> a13 = new List<int> { 10, 2, 15, 16, -5, -20, 3, 4, -9, 10, -1, -7, 1, 19 };
int maks = -10000;
int jj = 0;
for (int i = 0; i < a13.Count; i++)
{
    if ((i % 2 == 0) && (a13[i] > maks))
    {
        maks = a13[i];
        jj = i;
    }
}
a13[jj] = jj;
Console.WriteLine($"Maks={maks}\t index={jj}");
for (int i = 0; i < a13.Count; i++)
{
    Console.Write($" {a13[i]} ");
}
Console.WriteLine();
Console.WriteLine("=====");
//15
Console.WriteLine("Enter the size of your A array:");
int ee;
if (!int.TryParse(Console.ReadLine(), out ee))
{
    Console.WriteLine("incorrect");
    return;
}
double[] a7 = new double[ee];
Console.WriteLine("Type the A array:");
for (int i = 0; i < a7.Length; i++)
{
    a7[i] = int.Parse(Console.ReadLine());
}
Console.WriteLine("Enter the size of your B array:");
int nn;
if (!int.TryParse(Console.ReadLine(), out nn))
{
    Console.WriteLine("incorrect");
    return;
}
double[] BB = new double[nn];
Console.WriteLine("Type the B array:");
for (int i = 0; i < BB.Length; i++)
{
    BB[i] = int.Parse(Console.ReadLine());
}
Console.WriteLine("Enter the k:");
int kk;
if (!int.TryParse(Console.ReadLine(), out kk))
{
    Console.WriteLine("incorrect");
    return;
}
if (kk >= ee)
{
    Console.WriteLine("nah");
}
else
{
    for (int i = 0; i < a7.Length; i++)
    {
        if (i == kk)
        {
            for (int j1 = 0; j1 < BB.Length; j1++)
            {
                Console.Write(BB[j1] + " ");
            }
            Console.Write(a7[i] + " ");
        }
        else
        {
            Console.Write(a7[i] + " ");
        }
    }
}
//3
//1
Console.WriteLine("Enter the size of your array:");
int eee = int.Parse(Console.ReadLine());
double[] NN = new double[eee];
List<int> IND = new List<int>();
double maxo;
Console.WriteLine("Type the array:");
for (int i = 0; i < NN.Length; i++)
{
    NN[i] = int.Parse(Console.ReadLine());
}
maxo = NN[0];
for (int i = 0; i < NN.Length; i++)
{
    if (maxo < NN[i])
    {
        maxo = NN[i];
        IND.Clear();

    }
    if (maxo == NN[i])
    {
        IND.Add(i);
    }
}
for (int i = 0; i < IND.Count; i++)
{
    Console.Write(IND[i] + " ");
}


//5
Console.WriteLine("Enter the size of your array:");
int eeee = int.Parse(Console.ReadLine());
double[] NNN = new double[eeee];
double mino;
int minoi;
Console.WriteLine("Type the array:");
for (int i = 0; i < NNN.Length; i++)
{
    NNN[i] = int.Parse(Console.ReadLine());
}
for (int i = 0; i < NNN.Length - 1; i += 2)
{
    mino = NNN[i];
    minoi = i;
    for (int j3 = i + 2; j3 < NNN.Length; j3 += 2)
    {
        if (NNN[j3] < mino)
        {
            mino = NNN[j3];
            minoi = j3;
        }
    }
    NNN[minoi] = NNN[i];
    NNN[i] = mino;
}
for (int i = 0; i < NNN.Length; i++)
{
    Console.Write(NNN[i] + " ");
}

//8
Console.WriteLine("Enter the size of your array:");
int s13 = int.Parse(Console.ReadLine());
double[] Z = new double[s13];
double maximum1;
int maximum2;
Console.WriteLine("Type the array:");
for (int i = 0; i < Z.Length; i++)
{
    Z[i] = int.Parse(Console.ReadLine());
}
for (int i = 0; i < 12 - 1; i++)
{
    if (Z[i] < 0)
    {
        maximum1 = Z[i];
        maximum2 = i;
        for (int j2 = i + 1; j2 < 12; j2++)
        {
            if (Z[j2] < 0 && Z[j2] > maximum1)
            {
                maximum1 = Z[j2];
                maximum2 = j2;
            }
        }
        Z[maximum2] = Z[i];
        Z[i] = maximum1;
    }
}
for (int i = 0; i < Z.Length; i++)
{
    Console.Write(Z[i] + " ");
}

//9
            Console.WriteLine("Enter the size of your array:");
            int werty = int.Parse(Console.ReadLine());
            double[] S1 = new double[werty];
            int cnt1 = 0, cnt2 = 0, max9 = 0, max2 = 0;
            Console.WriteLine("Type the array:");
            for (int i = 0; i < S1.Length; i++)
            {
                S1[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < S1.Length - 1; i++)
            {
                if ((S1[i] > S1[i + 1])&(S1[i] != S1[i+1]))
                {
                    cnt1 = 1;
                }
                if ((S1[i] < S1[i + 1])&(S1[i] != S1[i + 1]))
                {
                    cnt2 = 1;
                }
                cnt1 += 1;
                cnt2 += 1;
                max9 = Math.Max(max9, cnt1);
                max2 = Math.Max(max2, cnt2);
            }

            Console.Write(Math.Max(max9, max2));

//12
double[] S2 = new double[12];
int cnt11 = 0;
Console.WriteLine("Type the array:");
for (int i = 0; i < S2.Length; i++)
{
    S2[i] = int.Parse(Console.ReadLine());
}

for (int i = 0; i < S2.Length; i++)
{
    if (S2[i] < 0)
    {
        cnt11 += 1;
    }
}
double[] SS2 = new double[cnt11];
cnt11 = 0;
for (int i = 0; i < S2.Length; i++)
{
    if (S2[i] >= 0)
    {
        SS2[cnt11] = S2[i];
        cnt11 += 1;
    }
}
for (int i = 0; i < SS2.Length; i++)
{
    Console.Write(SS2[i] + " ");
}

//13
Console.WriteLine("Enter the size of your array:");
int erty = int.Parse(Console.ReadLine());
double[] S3 = new double[erty];
int nig;
Console.WriteLine("Type the array:");
for (int i = 0; i < S3.Length; i++)
{
    S3[i] = int.Parse(Console.ReadLine());
}
for (int i = 0; i < S3.Length; i++)
{
    nig = 0;
    for (int j4 = 0; j4 < S3.Length; j4++)
    {
        if (i > j4 && S3[i] == S3[j4])
        {
            nig = 1;
        }
        if (nig == 1)
        {
            break;
        }
    }
    if (nig == 0)
    {
        Console.Write(S3[i] + " ");
    }
}
        }
    }
}
//11
int n;
Console.Write("Enter length of array (n): ");
if (Int32.TryParse(Console.ReadLine(), out n))
{
    int[] a1 = new int[n];
    Console.WriteLine("Enter elements of array: ");
    for (int j = 0; j < n; j++)
    {
        Int32.TryParse(Console.ReadLine(), out a[j]);
    }

    for (int j = 0; j < n - 1; j++)
    {
        int min_a = a1[j];
        int min_i = j;

        for (int q = j + 1; q < n; q++)
        {
            if (min_a > a1[q])
            {
                min_a = a1[q];
                min_i = q;
            }
        }

        a1[min_i] = a1[j];
        a1[j] = min_a;
    }

    int x = 0;
    Console.Write("Enter X: ");
    Int32.TryParse(Console.ReadLine(), out x);

    int i, i1, i2;
    i1 = 0;
    i2 = n - 1;

    while (true)
    {
        i = (i1 + i2) / 2;

        if (i2 < i1)
        {
            Console.WriteLine("Array doesn't contain X");
            break;
        }

        if (x == a1[i])
        {
            Console.WriteLine($"Answer: element rqual Х is its number - {i}");
            break;
        }

        else if (x < a1[i])
        {
            i2 = i - 1;
            continue;
        }

        else if (x > a1[i])
        {
            i1 = i + 1;
            continue;
        }
    }
}
        
    


#endregion

            #region 3.12
            Console.WriteLine("Enter the size of your A array:");
            int ty;
            if (!int.TryParse(Console.ReadLine(), out ty))
            {
                Console.WriteLine("Nope");
                return;
            }
            else if (ty <= 0)
            {
                Console.WriteLine("Nope");
                return;
            }
            int[] S5 = new int[ty];
            Console.WriteLine("Type the A array:");
            for (int i = 0; i < S5.Length; i++)
            {
                S5[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Enter the size of your B array:");
            int ti;
            if (!int.TryParse(Console.ReadLine(), out ti))
            {
                Console.WriteLine("Nope");
                return;
            }
            else if (ti <= 0)
            {
                Console.WriteLine("Nope");
                return;
            }
            int[] S6 = new int[ti];
            Console.WriteLine("Type the B array:");
            for (int i = 0; i < S6.Length; i++)
            {
                S6[i] = Convert.ToInt32(Console.ReadLine());
            }
            int[] S7 = new int[S6.Length + S5.Length];
            int c10 = 0, c11 = 0;
            for (int i = 0; i < S7.Length - 1; i += 2)
            {
                if (c10 < S5.Length)
                {
                    S7[i] = S5[c10];
                    c10 += 1;
                }
                else
                {
                    S7[i] = S6[c11];
                    c11 += 1;
                }
                if (c11 < S6.Length)
                {
                    S7[i + 1] = S6[c11];
                    c11 += 1;
                }
                else
                {
                    S7[i + 1] = S5[c10];
                    c10 += 1;
                }
            }
            for (int i = 0; i < S7.Length; i++)
            {
                Console.Write(S7[i] + " ");
            }
            Console.ReadLine();
            #endregion
//13
 int n, m;
Console.Write("Enter length of array A: ");
Int32.TryParse(Console.ReadLine(), out n);

Console.Write("Enter length of array B: ");
Int32.TryParse(Console.ReadLine(), out m);

int[] a = new int[n];
int[] b = new int[m];
int[] c = new int[n + m];

Console.WriteLine("Enter elements of array A: ");
for (int i = 0; i < n; i++)
{
    Int32.TryParse(Console.ReadLine(), out a[i]);
}

Console.WriteLine("Enter elements of array B: ");
for (int i = 0; i < m; i++)
{
    Int32.TryParse(Console.ReadLine(), out b[i]);
}

for (int i = 0; i < n - 1; i++)
{
    int max_a = a[i];
    int max_i = i;

    for (int j = i + 1; j < n; j++)
    {
        if (a[j] > max_a)
        {
            max_a = a[j];
            max_i = j;
        }
    }
    a[max_i] = a[i];
    a[i] = max_a;
}

for (int i = 0; i < m - 1; i++)
{
    int max_a = b[i];
    int max_i = i;

    for (int j = i + 1; j < m; j++)
    {
        if (b[j] > max_a)
        {
            max_a = b[j];
            max_i = j;
        }
    }
    b[max_i] = b[i];
    b[i] = max_a;
}

int a_i = 0, b_i = 0, c_i = 0;
bool flag = true;

while (flag)
{
    while (a[a_i] >= b[b_i])
    {
        c[c_i] = a[a_i];
        a_i++;
        c_i++;

        if (a_i >= n)
        {
            flag = false;
            break;
        }
    }

    if (flag == false)
        break;

    while (a[a_i] < b[b_i])
    {
        c[c_i] = b[b_i];
        b_i++;
        c_i++;

        if (b_i >= m)
        {
            flag = false;
            break;
        }
    }

    if (flag == false)
        break;

}

if (b_i <= m)
{
    for (; b_i < m; b_i++)
    {
        c[c_i] = b[b_i];
        c_i++;
    }
}

if (a_i <= n)
{
    for (; a_i < n; a_i++)
    {
        c[c_i] = a[a_i];
        c_i++;
    }
}


Console.WriteLine("Final array: ");
for (int i = 0; i < n + m; i++)
{
    Console.WriteLine(c[i]);
}
        
    


#endregion

//14
int n;
Console.Write("Enter length of array A: ");
Int32.TryParse(Console.ReadLine(), out n);

int[] a = new int[n];
int savenum = 0;

Console.WriteLine("Enetr elements of array A: ");
for (int i = 0; i < n; i++)
{
    Int32.TryParse(Console.ReadLine(), out a[i]);
}

for (int i = 0; i < n / 2; i++)
{
    savenum = a[i];
    a[i] = a[n - (i + 1)];
    a[n - (i + 1)] = savenum;
}

Console.WriteLine("Final array: ");
for (int i = 0; i < n; i++)
{
    Console.WriteLine(a[i]);
}
        
    


#endregion

//15
int n, m;
Console.Write("Enter length of array: ");
Int32.TryParse(Console.ReadLine(), out n);

int[] a = new int[n];

Console.WriteLine("Enter elements of array: ");
for (int i = 0; i < n; i++)
{
    Int32.TryParse(Console.ReadLine(), out a[i]);
}

Console.Write("Enter, how much to shift right (m): ");
Int32.TryParse(Console.ReadLine(), out m);

int savenum = 0;

for (int i = 0; i < m; i++)
{
    savenum = a[n - 1];
    for (int j = n - 2; j >= 0; j--)
    {
        a[j + 1] = a[j];
    }

    a[0] = savenum;

}

Console.WriteLine("Final array: ");
for (int i = 0; i < n; i++)
{
    Console.WriteLine(a[i]);
}
        
    


#endregion

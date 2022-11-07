#region Task 1 - 6

double[] lenght_vect = new double[5];
for (int i = 0; i < lenght_vect.Length; i++)
{
    lenght_vect[i] = Convert.ToDouble(Console.ReadLine());
}

double L = 0;

for (int i = 0; i < lenght_vect.Length; i++)
{
    L += Math.Pow(lenght_vect[i], 2);
}

Console.WriteLine("Длинна вектора " + Math.Sqrt(L));

#endregion


#region Task 1 - 10

double[] arr1 = new double[10];
Console.WriteLine("Введите элементы массива:");
for (int i = 0; i < arr1.Length; i++)
{
    arr1[i] = Convert.ToDouble(Console.ReadLine());
}
Console.WriteLine("Введите P:");
double P = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите Q:");
double Q = Convert.ToDouble(Console.ReadLine());
int count1 = 0;
for (int i = 0; i < arr1.Length; i++)
{
    if ((arr1[i] >= P) && (arr1[i] <= Q))
    {
        count1++;
    }
}

Console.WriteLine("Колличество элементов, расположенных между P и Q: " + count1);

#endregion

#region Task 1 - 11

double[] arr12_1 = new double[10];
double arr12_i;
double[] arr12_2 = new double[0];

for (int i = 0; i < 10; i++)
{
    arr12_i = Convert.ToDouble(Console.ReadLine());
    arr12_1[i] = arr12_i;
}

int count12 = 0;
for (int i = 0; i < 10; i++)
{
    if (arr12_1[i] > 0)
    {
        Array.Resize(ref arr12_2, arr12_2.Length + 1);
        arr12_2[count12] = arr12_1[i];
        count12++;
    }
}

foreach (double i in arr12_2)
{
    Console.Write(i + " ");
}

#endregion

#region Task 1 - 12

double[] arr13 = new double[8];
int l_n_i = -1;
for (int i = 0; i < 8; i++)
{
    arr13[i] = Convert.ToDouble(Console.ReadLine());
    if (arr13[i] < 0)
    {
        l_n_i = i;
    }
}

if (l_n_i != -1)
{
    Console.WriteLine(arr13[l_n_i] + " " + l_n_i);
}
else
{
    Console.WriteLine("Такого элемента нет");
}

#endregion

#region Task 1 - 13

double[] arr14 = new double[10];
double[] arr15_1 = new double[5];
double[] arr15_2 = new double[5];

for (int i = 0; i < 10; i++)
{
    arr14[i] = Convert.ToDouble(Console.ReadLine());
}

for (int i = 0; i < 10; i++)
{
    if (i % 2 == 0)
    {
        arr15_1[i / 2] = arr14[i];
    }
    else
    {
        arr15_2[i / 2] = arr14[i];
    }
}

for (int i = 0; i < 5; i++)
{
    Console.Write(arr15_1[i] + " ");
}
Console.WriteLine();
for (int i = 0; i < 5; i++)
{
    Console.Write(arr15_2[i] + " ");
}

#endregion

#region Task 2 - 5
double max1 = -1 * Math.Pow(10, 10);
double min1 = Math.Pow(10, 10);
double[] arr2 = new double[0];
string arr2_i1 = Console.ReadLine();
int count3 = 0;
int count2 = 0;

int st = 0;
int mid = 0;
int end = 0;

while (arr2_i1 != "")
{
    Array.Resize(ref arr2, arr2.Length + 1);
    arr2[count3] = Convert.ToDouble(arr2_i1);
    if (max1 < arr2[count3])
    {
        max1 = arr2[count3];
        st = count3;
    }

    if (min1 > arr2[count3])
    {
        min1 = arr2[count3];
        end = count3;
    }

    arr2_i1 = Console.ReadLine();
    count3++;
}

if (st > end)
{
    mid = st;
    st = end;
    end = mid;
}


for (int i = st + 1; i < end; i++)
{
    if (arr2[i] < 0)
    {
        count2 += 1;
    }
}

double[] arr3 = new double[count2];


for (int i = st + 1; i < end; i++)
{
    if (arr2[i] < 0)
    {
        arr3[arr3.Length - count2] = arr2[i];
        count2--;
    }
}

foreach (int i in arr3)
{
    Console.Write(i + " ");
}

#endregion

#region Task 2 - 6

double[] arr4 = new double[0];
string arr4_i = Console.ReadLine();
int count4 = 0;
double mid_value = 0;
while (arr4_i != "")
{
    Array.Resize(ref arr4, arr4.Length + 1);
    arr4[count4] = Convert.ToDouble(arr4_i);
    mid_value += arr4[count4];
    count4++;
    arr4_i = Console.ReadLine();
}

mid_value /= (count4 + 1);

double close = Math.Pow(10, 10);
int close_i = 0;
double P3 = Convert.ToDouble(Console.ReadLine());

for (int i = 0; i < arr4.Length; i++)
{
    if (Math.Abs(mid_value - arr4[i]) < close)
    {
        close = Math.Abs(mid_value - arr4[i]);
        close_i = i;
    }
}


Array.Resize(ref arr4, arr4.Length + 1);
double k1_1 = arr4[close_i + 1];
double k2_1 = arr4[close_i + 1];


for (int i = close_i + 2; i < arr4.Length; i++)
{
    k2_1 = arr4[i];
    arr4[i] = k1_1;
    k1_1 = k2_1;
}
arr4[close_i + 1] = P3;
foreach (double i in arr4)
{
    Console.Write(i + " ");
}
#endregion

#region Task 2 - 9

double[] arr5 = new double[0];
string arr5_i = Console.ReadLine();
int count5 = 0;
double max2 = -1 * Math.Pow(10, 10);
double min2 = Math.Pow(10, 10);
int max2_i = 0;
int min2_i = 0;
double mid_value_2 = 0;
while (arr5_i != "")
{
    Array.Resize(ref arr5, arr5.Length + 1);
    arr5[count5] = Convert.ToDouble(arr5_i);
    if (arr5[count5] > max2)
    {
        max2 = arr5[count5];
        max2_i = count5;
    }

    if (arr5[count5] < min2)
    {
        min2 = arr5[count5];
        min2_i = count5;
    }

    arr5_i = Console.ReadLine();
    count5++;
}
int m;
if (max2_i < min2_i)
{
    m = min2_i;
    min2_i = max2_i;
    max2_i = m;
}

for (int i = min2_i + 1; i < max2_i; i++)
{
    mid_value_2 += arr5[i];
}

mid_value_2 /= (max2_i - min2_i - 1);
Console.WriteLine(mid_value_2);

#endregion


#region Task 2 - 10

double[] arr6 = new double[0];
string arr6_i = Console.ReadLine();
int count6 = 0;
double min3 = Math.Pow(10, 10);
int min3_i = 0;
while (arr6_i != "")
{
    Array.Resize(ref arr6, arr6.Length + 1);
    arr6[count6] = Convert.ToDouble(arr6_i);
    if ((arr6[count6] > 0) && (arr6[count6] < min3))
    {
        min3 = arr6[count6];
        min3_i = count6;
    }
    arr6_i = Console.ReadLine();
    count6++;
}

for (int i = min3_i; i < arr6.Length - 1; i++)
{
    arr6[i] = arr6[i + 1];
}

double[] arr7 = new double[arr6.Length - 1];

for (int i = 0; i < arr7.Length; i++)
{
    arr7[i] = arr6[i];
}

for (int i = 0; i < arr7.Length; i++)
{
    Console.Write(arr7[i] + " ");
}

#endregion


#region Task 2 - 11

double[] arr8 = new double[0];
string arr8_i = Console.ReadLine();
int count8 = 0;
int pol_l_i = 0;
int fl = 1;

while (arr8_i != "")
{
    Array.Resize(ref arr8, arr8.Length + 1);
    arr8[count8] = Convert.ToDouble(arr8_i);
    if (arr8[count8] > 0)
    {
        fl = 0;
        pol_l_i = count8;
    }
    arr8_i = Console.ReadLine();
    count8++;
}

if (fl == 0)
{
    double P2 = Convert.ToDouble(Console.ReadLine());
    Array.Resize(ref arr8, arr8.Length + 1);
    double k1_2 = arr8[pol_l_i + 1];
    double k2_2 = arr8[pol_l_i + 1];

    for (int i = pol_l_i + 2; i < arr8.Length; i++)
    {
        k1_2 = arr8[i];
        arr8[i] = k2_2;
        k1_2 = k2_2;
    }

    arr8[pol_l_i + 1] = P2;

    for (int i = 0; i < arr8.Length; i++)
    {
        Console.Write(arr8[i] + " ");
    }
}
else
{
    for (int i = 0; i < arr8.Length; i++)
    {
        Console.Write(arr8[i] + " ");
    }
}
#endregion


#region Task 2 - 13

double[] arr9 = new double[0];
string arr9_i = Console.ReadLine();
int count9 = 0;
double mx_ev_in = -1 * Math.Pow(10, 10);
int mx_ex_in_i = 0;

while (arr9_i != "")
{
    Array.Resize(ref arr9, arr9.Length + 1);
    arr9[count9] = Convert.ToDouble(arr9_i);
    if ((arr9[count9] > mx_ev_in) & (count9 % 2 == 0))
    {
        mx_ev_in = arr9[count9];
        mx_ex_in_i = count9;
    }
    arr9_i = Console.ReadLine();
    count9++;
}


arr9[mx_ex_in_i] = mx_ex_in_i;

for (int i = 0; i < arr9.Length; i++)
{
    Console.Write(arr9[i] + " ");
}

#endregion

#region Task 2 - 15

double[] arr10_1 = new double[0];
string arr10_1_i = Console.ReadLine();
int count10_1 = 0;

while (arr10_1_i != "")
{
    Array.Resize(ref arr10_1, arr10_1.Length + 1);
    arr10_1[count10_1] = Convert.ToDouble(arr10_1_i);
    arr10_1_i = Console.ReadLine();
    count10_1++;
}

double[] arr10_2 = new double[0];
string arr10_2_i = Console.ReadLine();
int count10_2 = 0;

while (arr10_2_i != "")
{
    Array.Resize(ref arr10_2, arr10_2.Length + 1);
    arr10_2[count10_2] = Convert.ToDouble(arr10_2_i);
    arr10_2_i = Console.ReadLine();
    count10_2++;
}

double k1_3 = Convert.ToInt32(Console.ReadLine());
double k2_3 = k1_3 + 1 + arr10_2.Length;

count10_1 = 0;
count10_2 = 0;

double[] arr11 = new double[arr10_1.Length + arr10_2.Length];
for (int i = 0; i < arr11.Length; i++)
{
    if ((k1_3 < i) && (k2_3 > i))
    {
        arr11[i] = arr10_2[count10_2];
        count10_2++;
    }
    else
    {
        arr11[i] = arr10_1[count10_1];
        count10_1++;
    }
}

for (int i = 0; i < arr11.Length; i++)
{
    Console.Write(arr11[i] + " ");
}

#endregion


#region Task 3 - 1

double[] arr16 = new double[0];
double[] max_arr16 = new double[1];
string arr16_i = Console.ReadLine();
int count16 = 0;
double mx_arr16 = Convert.ToDouble(arr16_i);
max_arr16[0] = 0;
while (arr16_i != "")
{
    Array.Resize(ref arr16, arr16.Length + 1);
    arr16[count16] = Convert.ToDouble(arr16_i);
    arr16_i = Console.ReadLine();
    count16++;
}

for (int i = 1; i < arr16.Length; i++)
{
    if (arr16[i] == mx_arr16)
    {
        Array.Resize(ref max_arr16, max_arr16.Length + 1);
        max_arr16[max_arr16.Length - 1] = i;
    }
    else
    {
        if (arr16[i] > mx_arr16)
        {
            mx_arr16 = arr16[i];
            Array.Resize(ref max_arr16, 1);
            max_arr16[max_arr16.Length - 1] = i;
        }
    }
}

foreach (double i in max_arr16)
{
    Console.Write(i + " ");
}

#endregion



#region Task 3 - 5

double[] arr17 = new double[0];
double[] arr17_2 = new double[0];
string arr17_i = Console.ReadLine();
int count17 = 0;
while(arr17_i != "")
{
    Array.Resize(ref arr17, arr17.Length + 1);
    arr17[count17] = Convert.ToDouble(arr17_i);
    arr17_i = Console.ReadLine();
    count17++;
}

for(int i = 0; i < arr17.Length; i++)
{
    if(i % 2 == 0)
    {
        Array.Resize(ref arr17_2, arr17_2.Length + 1);
        arr17_2[i / 2] = arr17[i];
    }
}

Array.Sort(arr17_2);
for(int i = 0; i < arr17.Length; i++)
{
    if(i % 2 == 0)
    {
        arr17[i] = arr17_2[i / 2];
    }
}

foreach(double i in arr17)
{
    Console.Write(i + " ");
}

#endregion



#region Task 3 - 8

double[] arr18 = new double[0];
string arr18_i = Console.ReadLine();
double[] arr18_neg = new double[0];
int count18 = 0, count18_neg = 0;

while(arr18_i != "")
{
    Array.Resize(ref arr18, arr18.Length + 1);
    arr18[count18] = Convert.ToDouble(arr18_i);
    if (arr18[count18] < 0)
    {
        Array.Resize(ref arr18_neg, arr18_neg.Length + 1);
        arr18_neg[count18_neg] = arr18[count18];
        count18_neg++;
    }
    arr18_i = Console.ReadLine();
    count18++;
}

count18 = 0;
Array.Sort(arr18_neg);
Array.Reverse(arr18_neg);

for (int i = 0; i < arr18.Length; i++)
{
    if (arr18[i] < 0)
    {
        arr18[i] = arr18_neg[count18];
        count18++;
    }    
}

foreach(double i in arr18)
{
    Console.Write(i + " ");
}

#endregion



#region Task 3 - 12

double[] arr19 = new double[12];
for(int i = 0; i < 12; i++)
{
    arr19[i] = Convert.ToDouble(Console.ReadLine());
}

arr19 = arr19.Where(val => val > 0).ToArray();

foreach(double i in arr19)
{
    Console.Write(i + " ");
}

#endregion



#region Task 3 - 13

double[] arr20 = new double[0];
string arr20_i = Console.ReadLine();
int count20 = 0;

while(arr20_i != "")
{
    Array.Resize(ref arr20, arr20.Length + 1);
    arr20[count20] = Convert.ToDouble(arr20_i);
    count20++;
    arr20_i = Console.ReadLine();
}

double[] q = arr20.Distinct().ToArray();

foreach (int i in q)
{
    Console.Write(i + " ");
}

#endregion



#region Extra -  11

double[] arr21 = new double[0];
string arr21_i = Console.ReadLine();
int count21 = 0;
int flag2 = 0;
while(arr21_i != "")
{
    Array.Resize(ref arr21, arr21.Length + 1);
    arr21[count21] = Convert.ToDouble(arr21_i);
    arr21_i = Console.ReadLine();
    count21++;
}

Array.Sort(arr21);
Console.WriteLine("Введите искомое число");
double unknown = Convert.ToDouble(Console.ReadLine());

int left = 0, right = count21;
if (arr21[left] == unknown)
{
    Console.WriteLine("Индекс искомого числа - " + left);
    flag2++ ;
}
else
{
    while ((left + 1 != right) && (left != right))
    {
        if (arr21[(left + right) / 2] < unknown)
        {
            left = (left + right) / 2;
        }
        else
        {
            if (arr21[(left + right) / 2] > unknown)
            {
                right = (left + right) / 2;
            }
            else
            {
                Console.WriteLine("Индекс искомого числа - " + ((left + right) / 2));
                flag2++;
                break;
            }
        }
    }
}

if(flag2 == 0)
{
    Console.WriteLine("Такого числа нет в массиве");
}

#endregion



#region Extra - 12

int size_A = 0;
int size_B = 0;

double[] arr_A = new double[size_A];
double[] arr_B = new double[size_B];
Console.WriteLine("Введите массив А");
string arr_A_i = Console.ReadLine();

while (arr_A_i != "")
{
    Array.Resize(ref arr_A, size_A + 1);
    arr_A[size_A] = Convert.ToDouble(arr_A_i);
    size_A++;
    arr_A_i = Console.ReadLine();
}

Console.WriteLine("Введите массив B");
string arr_B_i = Console.ReadLine();

while (arr_B_i != "")
{
    Array.Resize(ref arr_B, size_B + 1);
    arr_B[size_B] = Convert.ToDouble(arr_B_i);
    size_B++;
    arr_B_i = Console.ReadLine();
}

if (size_A > size_B)
{
    size_A = size_B;
}
else
{
    size_B = size_A;
}

double[] arr_C = new double[size_A * 2];
for(int i = 0; i < arr_C.Length; i++)
{
    if (i % 2 == 0)
    {
        arr_C[i] = arr_A[i / 2];
    }
    else
    {
        arr_C[i] = arr_B[i / 2];
    }
}

for(int i = 0; i < arr_C.Length; i++)
{
    Console.Write(arr_C[i] + " ");
}

#endregion



#region Extra  - 13

int size_A_2 = 0;
int size_B_2 = 0;
double[] arr_A_2 = new double[size_A_2];
double[] arr_B_2 = new double[size_B_2];
Console.WriteLine("Введите массив А");
string arr_A_2_i = Console.ReadLine();

while (arr_A_2_i != "")
{
    Array.Resize(ref arr_A_2, arr_A_2.Length + 1);
    arr_A_2[size_A_2] = Convert.ToDouble(arr_A_2_i);
    size_A_2++;
    arr_A_2_i = Console.ReadLine();
}

Console.WriteLine("Введите массив В");
string arr_B_2_i = Console.ReadLine();

while (arr_B_2_i != "")
{
    Array.Resize(ref arr_B_2, arr_B_2.Length + 1);
    arr_B_2[size_B_2] = Convert.ToDouble(arr_B_2_i);
    size_B_2++;
    arr_B_2_i = Console.ReadLine();
}

Array.Sort(arr_A_2);
Array.Reverse(arr_A_2);

Array.Sort(arr_B_2);
Array.Reverse(arr_B_2);

double[] arr_C_2 = new double[size_A_2 + size_B_2];
size_A_2 = 0;
size_B_2 = 0;

for(int i = 0; i < arr_C_2.Length; i++)
{
    if(size_A_2 < arr_A_2.Length)
    {
        if(size_B_2 < arr_B_2.Length)
        {
            if(arr_A_2[size_A_2] > arr_B_2[size_B_2])
            {
                arr_C_2[i] = arr_A_2[size_A_2];
                size_A_2++;
            }
            else
            {
                arr_C_2[i] = arr_B_2[size_B_2];
                size_B_2++;
            }
        }
        else
        {
            arr_C_2[i] = arr_A_2[size_A_2];
            size_A_2++;
        }
    }
    else
    {
        arr_C_2[i] = arr_B_2[size_B_2];
        size_B_2++;
    }
}

for(int i = 0; i < arr_C_2.Length; i++)
{
    Console.Write(arr_C_2[i] + " ");
}

#endregion



#region Extra 14

double[] arr22 = new double[0];
int count22 = 0;
string arr22_i = Console.ReadLine();

while(arr22_i != "")
{
    Array.Resize(ref arr22, arr22.Length + 1);
    arr22[count22] = Convert.ToDouble(arr22_i); 
    count22++;
    arr22_i = Console.ReadLine();
}

double mid_num1;

for(int i = 0; i < arr22.Length / 2; i++)
{
    mid_num1 = arr22[i];
    arr22[i] = arr22[arr22.Length - i - 1];
    arr22[arr22.Length - i - 1] = mid_num1;
}

for(int i = 0; i < arr22.Length; i++)
{
    Console.Write(arr22[i] + " ");
}

#endregion


#region Extra 15

double[] arr23 = new double[0];
int count23 = 0;
Console.WriteLine("Введите массив");
string arr23_i = Console.ReadLine();

while (arr23_i != "")
{
    Array.Resize(ref arr23, arr23.Length + 1);
    arr23[count23] = Convert.ToDouble(arr23_i);
    count23++;
    arr23_i = Console.ReadLine();
}

Console.WriteLine("Введите колличество сдвигов");
int m2 = Convert.ToInt32(Console.ReadLine());

double mid_num2;

for(int i = 0; i < m2; i++)
{
    mid_num2 = arr23[arr23.Length - 1];
    for(int j = arr23.Length - 1; j > 0; j--)
    {
        arr23[j] = arr23[j - 1];
    }
    arr23[0] = mid_num2;
}

foreach(double i in arr23)
{
    Console.Write(i + " ");
}

#endregion

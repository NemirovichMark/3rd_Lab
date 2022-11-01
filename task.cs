
#region lvl1Task6
double[] array = new double[5];
Console.WriteLine("Enter array values");
for (int i = 0; i < 5; i++)
{
array[i] = Math.Pow(Convert.ToDouble(Console.ReadLine()), 2);
}
Console.WriteLine(Math.Sqrt(array.Sum()));

#endregion

#region lvl1Task10
double[] array = new double[10];
int count = 0;
Console.WriteLine("Enter Q and P values (P>Q)");
double Q = Convert.ToDouble(Console.ReadLine());
double P = Convert.ToDouble(Console.ReadLine());
if (P > Q)
{
    Console.WriteLine("Enter array values:");
    for (int i = 0; i < 10; i++)
    {
        array[i] = Convert.ToDouble(Console.ReadLine());
        if (Q < array[i] && array[i] < P)
        {
            count++;
        }
    }
    Console.WriteLine($"{count} elements of array stand between P and Q");
}
else
{
    Console.WriteLine("Error");
}
#endregion

#region lvl1Task11
double[] array = new double[10];
int count = 0;
Console.WriteLine("Enter array values");
for (int i = 0; i < 10; i++)
{
    array[i] = Convert.ToDouble(Console.ReadLine());
    if (array[i] > 0) count++;
}
double[] array_positive = new double[count];
for (int i = 0; i < 10; i++)
{
    if (array[i] > 0)
    {
        array_positive[count - 1] = array[i];
        count--;
    }
}
Console.WriteLine(string.Join("", array_positive));
#endregion

#region lvl1Task12
double[] array = new double[8];
double negative_value = 0;
double negative_index = 0;
Console.WriteLine("Enter array value");
for (int i = 0; i < 8; i++)
{
    array[i] = Convert.ToDouble(Console.ReadLine());
    if (array[i] < 0)
    {
        negative_value = array[i];
        negative_index = i;
    }
}
if (negative_value == 0)
{
    Console.Write("You don't enter negative value");
}
else
{
    Console.WriteLine($"Value - {negative_value}\nNubmer - {negative_index + 1}");
}
#endregion

#region lvl1Task13
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
#endregion

#region lvl2Task5
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
#endregion

#region lvl2Task6
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
double mid = array.Sum()/n;
for (int i = 0; i < n-1; i++)
{
if (array[i] < mid & mid < array[i + 1])
{
index_P = i+1;
}
}
Array.Resize(ref array, n + 1);
for (int i = n - 1; i >= index_P - 1; i--)
{
array[i + 1] = array[i];
}
array[index_P] = P;
Console.WriteLine($"{string.Join("", array)}");
#endregion

#region lvl2Task9
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
#endregion

#region lvl2Task10
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
double[] array_1 = new double[n-1];
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
#endregion


#region lvl2Task11
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
for (int i = n-1; i >= index_max; i--)
{
array[i+1] = array[i];
}
array[index_max+1] = P;
Console.WriteLine("------------------------");
for (int i = 0; i < n + 1; i++)
{
Console.WriteLine(string.Join("", array[i]));
}
#endregion

#region lvl2Task13
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

#endregion

#region lvl2Task15
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
double[] array_C = new double[n+m];
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
Console.WriteLine(string.Join("",array_C));
#endregion

#region lvl3Task1
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
Console.WriteLine(string.Join("",result));

#endregion

#region lvl3Task5
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
for (int j = 0; j < n-2; j+=2)
{
if (array[j] > array[j + 2])
{
temp = array[j];
array[j] = array[j+2];
array[j+2] = temp;
}
}
}
Console.WriteLine(string.Join(" ", array));
#endregion

#region lvl3Task8
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

#endregion

#region lvl3Task9
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
for (int i = 0; i < n-1; i++)
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
#endregion

#region lvl3Task12
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
for (int j = 0; j < n-1; j++)
{
if (array[j] == 0)
{
temp = array[j+1];
array[j+1] = array[j];
array[j] = temp;
}
}
}
Array.Resize(ref array, n - c);
Console.WriteLine(String.Join(" ", array));
#endregion

#region lvl3Task13
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
#endregion

#region 11
static int BinarySearch(double[] array, double x)
{
    int i1 = 0;
    int i2 = array.Length-1;
    int i = (i1+i2) / 2;
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
                i = (i1+i2) / 2;
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
//Exemple
double[] array = new double[] { 1, 2, 3, 4, 5 };
double x = 11;
Console.WriteLine(BinarySearch(array,x));

#endregion

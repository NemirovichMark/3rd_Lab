
#region Task 2 - 10

double[] arr6 = new double[0];
string arr6_i = Console.ReadLine();
int count6 = 0;
double min3 = Math.Pow(10, 10);
int min3_i = -1;
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

if (min3_i != -1)
{
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
}
else
{
    double[] arr7 = arr6;

    for (int i = 0; i < arr7.Length; i++)
    {
        Console.Write(arr7[i] + " ");
    }
}
#endregion



#region Task 3 - 9

double[] arr8 = new double[0];
string arr8_i = Console.ReadLine();
int count8 = 0;
while (arr8_i != "")
{
    Array.Resize(ref arr8, arr8.Length + 1);
    arr8[count8] = Convert.ToDouble(arr8_i);
    arr8_i = Console.ReadLine();
    count8++;
}

int length_ar = 1;
int mx_lenght_ar = 0;
int flag = 0;
if (arr8.Length >= 2)
{
    for (int i = 1; i < arr8.Length; i++)
    {
        if (((arr8[i - 1] < arr8[i]) && (flag == 1)) || ((arr8[i - 1] > arr8[i]) && (flag == 0)))
        {
            length_ar++;
        }
        else
        {
            if ((arr8[i - 1] < arr8[i]) && (flag == 0))
            {
                flag = 1;
                mx_lenght_ar = Math.Max(length_ar, mx_lenght_ar);
                length_ar = 2;
            }
            else
            {
                flag = 0;
                mx_lenght_ar = Math.Max(length_ar, mx_lenght_ar);
                length_ar = 2;
            }
        }
    }

    Console.Write(mx_lenght_ar);
}
else
{
    Console.Write(0);
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

double[] arr_C = new double[size_A + size_B];
if (size_A > size_B) {

    for(int i = 0; i < size_B * 2; i++)
    {
        if(i % 2 == 0)
        {
            arr_C[i] = arr_A[i / 2];
        }
        else
        {
            arr_C[i] = arr_B[i / 2];
        }
    }

    for (int i = size_B; i < size_A; i++)
    {
        arr_C[i + size_B] = arr_A[i];  
    }

}
else
{

    for (int i = 0; i < size_A * 2; i++)
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

    for (int i = size_A; i < size_B; i++)
    {
        arr_C[i + size_A] = arr_B[i];
    }

}


for (int i = 0; i < arr_C.Length; i++)
{
    Console.Write(arr_C[i] + " ");
}

#endregion

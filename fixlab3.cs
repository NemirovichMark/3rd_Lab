using Microsoft.VisualBasic;
using System;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.Reflection.PortableExecutable;
using System.Threading;
using System.Transactions;
using static System.Math;
{
    /*
    string[] hga = Console.ReadLine().Split();
    double neh;
    double cou = 0;
    double maxix = 0;
    double minix = 1000;
    int maind = 0;
    int miind = 0;
    double itsum = 0;
    Console.WriteLine("N2.9:");
    for (int i = 0; i < hga.Length; i++)
    {
        bool ptp = double.TryParse(hga[i], out neh);
        if (ptp == true)
        {
            cou++;
        }
    }
    if (cou == hga.Length)
    {
        for (int i = 0; i < hga.Length; i++)
        {
            double pir = Convert.ToDouble(hga[i]);
            if (pir > maxix)
            {
                maind = i;
                maxix = pir;
            }
            if (pir < minix)
            {
                miind = i;
                minix= pir;
            }
        }
        for (int i = Min(maind, miind) + 1; i < Max(maind, miind); i++)
        {
            double xxx = Convert.ToDouble(hga[i]);
            itsum += xxx;
        }
        itsum = itsum / (Abs(miind - maind) - 1);
        Console.WriteLine($"Искомая сумма равна {itsum}");

    }
    else
    {
        Console.WriteLine("Неправильный ввод");
    }


    string[] mag = Console.ReadLine().Split();
    double gehy;
    double jik = 0;
    double mpoj = 1000;
    int impoj = 0;
    Console.WriteLine("N2.10:");
    double[] hah = new double[mag.Length];
    for (int i = 0; i < mag.Length; i++)
    {
        bool ptpp = double.TryParse(mag[i], out gehy);
        if (ptpp == true)
        {
            jik++;
        }
    }
    if (jik == mag.Length)
    {
        for (int i = 0; i < mag.Length; i++)
        {
            double jkh = Convert.ToDouble(mag[i]);
            hah[i] = jkh;
            if (hah[i] > 0 & hah[i] < mpoj)
            {
                mpoj = hah[i];
                impoj = i;
            }

        }
        hah = hah.Except(new double[] { hah[impoj] }).ToArray();
        for (int i = 0; i < hah.Length; i++)
        {
            Console.Write($"{hah[i]}  ");
        }
    }
    else
    {
        Console.WriteLine("Неверный ввод");
    }
    Console.WriteLine();


    string[] d35 = Console.ReadLine().Split();
    double[] LG1 = new double[d35.Length];
    Console.WriteLine("N3.5:");
    double S;
    double At = 0;
    double Ma = -1;
    int Inda = 0;
    for (int i = 0; i < d35.Length; i++)
    {
        bool pupy = double.TryParse(d35[i], out S);
        if (pupy == true)
        {
            At++;
        }
    }
    int Z = 0;
    if (At == d35.Length)
    {
        for (int i = 0; i < d35.Length; i += 1)
        {
            double Y = Convert.ToDouble(d35[i]);
            LG1[i] = Y;
            if (i % 2 == 0)
            {
                Z++;
            }
        }
        double[] L1 = new double[Z];
        Z = 0;
        for (int i = 0; i < LG1.Length; i += 2)
        {
            L1[Z]=LG1[i];
            LG1[i] = 2;
            Z++;
        }
        Array.Sort(L1);
        Z = 0;
        for (int i = 0; i < LG1.Length; i += 1)
        {
            if (LG1[i]==2 & i%2==0)
            {
                LG1[i] = L1[Z];
                Z++;
            }
        }
        for (int i = 0; i < LG1.Length; i += 1)
        {
            Console.Write($"{LG1[i]}  ");
        }
    }
    else
    {
        Console.WriteLine("Неправильный ввод");
    }
    Console.WriteLine();
   

    string[] D311 = Console.ReadLine().Split();
    double[] D3112 = new double[D311.Length];
    double ASW;
    double GFD = 0;
    Console.WriteLine("N3.12:");
    for (int i = 0; i < D311.Length; i++)
    {
        bool FCVB = double.TryParse(D311[i], out ASW);
        if (FCVB == true)
        {
            GFD++;
        }
    }
    if (GFD == D311.Length & GFD == 12)
    {
        for (int i = 0; i < D311.Length; i++)
        {
            double QWER = Convert.ToDouble(D311[i]);
            D3112[i] = QWER;
        }
        int zer = 0;
        while(zer<D3112.Length)
        {
            if (D3112[zer]<0)
            {
                D3112 = D3112.Except(new double[] { D3112[zer] }).ToArray();
            }
            else
            {
                zer++;
            }
        }
        for (int i = 0; i < D3112.Length; i++)
        {
            Console.Write($"{D3112[i]}  ");
        }
    }
    else
    {
        Console.WriteLine("Неверный ввод");
    }
    Console.WriteLine();
    

    Console.WriteLine("TV11:");
    string[] a = Console.ReadLine().Split();
    string[] f = Console.ReadLine().Split();
    double[] b = new double[a.Length];
    double c = 0;
    double d;
    for (int i = 0; i < a.Length; i++)
    {
        bool h = double.TryParse(a[i], out d);
        if (h == true)
        {
            c++;
            b[i] = d;
        }
    }
    for (int i = 0; i < f.Length; i++)
    {
        bool h1 = double.TryParse(f[i], out d);
        if (h1 == true)
        {
            c++;
        }
    }
    if (c == a.Length + 1)
    {
        double f1 = Convert.ToDouble(f[0]);
        int i1 = 0;
        int i2 = b.Length - 1;
        Array.Sort(f);
        while (i1 < i2)
        {
            if (i1 > i2)
            {
                Console.WriteLine($"Искомый элемент отсутвует в массиве");
                break;
            }
            int i = (i1 + i2) / 2;
            if (f1 == b[i])
            {
                Console.WriteLine($"Искомый индекс равен {i}");
                break;
            }
            if (f1 > b[i])
            {
                i1 = i + 1;
            }
            if (f1 < b[i])
            {
                i2 = i - 1;
            }
        }
    }
    else
    {
        Console.WriteLine("Неверный ввод");
    }


    Console.WriteLine("TV12:");
    string[] a1 = Console.ReadLine().Split();
    string[] b1 = Console.ReadLine().Split();
    double[] c1 = new double[a1.Length + b1.Length];
    double de = 0;
    double ikj;
    for (int i = 0; i < a1.Length; i++)
    {
        bool hgh = double.TryParse(a1[i], out ikj);
        if (hgh == true)
        {
            de++;
        }
    }
    for (int i = 0; i < b1.Length; i++)
    {
        bool ghg = double.TryParse(b1[i], out ikj);
        if (ghg == true)
        {
            de++;
        }
    }
    int ac = 0;
    int bc = 0;
    if (de == a1.Length + b1.Length)
    {
        for (int i = 0; i < c1.Length; i++)
        {
            if (i % 2 == 0)
            {
                if (ac < a1.Length)
                {
                    c1[i] = Convert.ToDouble(a1[ac]);
                    ac++;
                }
                else
                {
                    for(int j = i; j < b1.Length; j++)
                    {
                        c1[j] = Convert.ToDouble(b1[bc]);
                        bc++;
                    }
                    break;
                }
            }
            else
            {
                if (bc < b1.Length)
                {
                    c1[i] = Convert.ToDouble(b1[bc]);
                    bc++;
                }
                else
                {
                    for (int j = i; j < a1.Length; j++)
                    {
                        c1[j] = Convert.ToDouble(a1[ac]);
                        ac++;
                    }
                    break;
                }
            }
        }
        for (int i = 0; i < c1.Length; i++)
        {
            Console.Write($"{c1[i]} ");
        }
    }
    else
    {
        Console.WriteLine("Неверный ввод");
    }
    Console.WriteLine();
    


    Console.WriteLine("TV14:");
    string[] a3 = Console.ReadLine().Split();
    double[] end = new double[a3.Length];
    double ter;
    double ctr = 0;
    for (int i = 0; i < a3.Length; i++)
    {
        bool fga = double.TryParse(a3[i], out ter);
        if (fga == true)
        {
            ctr++;
            end[i] = ter;

        }
    }
    if (ctr == a3.Length)
    {
        double z = 0;
        double prom = 0;
        if (end.Length%2==0)
        {
            z = end.Length / 2;
        }
        else
        {
            z = end.Length / 2 +1;
        }
        int kon = end.Length-1;
        for(int i = 0; i < z; i++)
        {
            prom=end[i];
            end[i] = end[kon];
            end[kon] = prom;
            kon--;

        }
        for (int k = 0; k < end.Length; k++)
        {
            Console.Write($"{end[k]} ");
        }
    }
    else
    {
        Console.WriteLine("Неверный ввод");
    }
    Console.WriteLine();
    */

    string[] a13 = Console.ReadLine().Split();
    string[] b13 = Console.ReadLine().Split();
    double[] A13 = new double[a13.Length];
    double[] B13 = new double[b13.Length];
    double[] c13 = new double[a13.Length + b13.Length];
    double rgt;
    double itq = 0;
    for (int i = 0; i < a13.Length; i++)
    {
        bool reyq = double.TryParse(a13[i], out rgt);
        if (reyq== true)
        {
            itq++;
            A13[i] = rgt;
        }
    }
    for (int i = 0; i < b13.Length; i++)
    {
        bool reyqz = double.TryParse(b13[i], out rgt);
        if (reyqz == true)
        {
            itq++;
            B13[i] = rgt;
        }
    }
    int ia = 0;
    int ib = 0;
    if(itq==a13.Length+b13.Length)
    {
        for(int i = 0; i < c13.Length; i++)
        {
            if (ia >= A13.Length | ib >= B13.Length)
            {
                if (ia >= A13.Length)
                {
                    for (int j = i; j < c13.Length; j++)
                    {
                        c13[j] = B13[ib];
                        ib++;
                    }
                    break;
                }
                if (ia >= B13.Length)
                {
                    for (int j = i; j < c13.Length; j++)
                    {
                        c13[i] = A13[ia];
                        ia++;
                    }
                    break;
                }
            }
            else
            {
                if(A13[ia] > B13[ib])
                {
                    c13[i] = A13[ia];
                    ia++;
                }
                else
                {
                    c13[i] = B13[ib];
                    ib++;
                }
            }
        }
        for(int r = 0; r < c13.Length; r++)
        {
            Console.Write($"{c13[r]} ");
        }
    }
    else
    {
        Console.WriteLine("Неверный ввод");
    }
}
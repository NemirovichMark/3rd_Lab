using Microsoft.VisualBasic;
using System;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.Reflection.PortableExecutable;
using System.Threading;
using System.Transactions;
using static System.Math;
{
 
    string[] s = Console.ReadLine().Split();
    double sum = 0;
    double k = 0;
    Console.WriteLine("N1.6:");
    for (int i = 0; i < s.Length; i++)
    {
        char x = Convert.ToChar(s[i]);
        if (char.IsDigit(x)) 
        {
            k += 1;
        }
    }
    if (s.Length % 5 == 0 & k==5)
    {
        for (int i = 0; i < s.Length; i++)
        {
            double y= Convert.ToDouble(s[i]);
            y = Convert.ToDouble(s[i]);
            sum += Pow(y, 2);
        }
        Console.WriteLine($"Длина вектора с заданными координатами равна {Round(Sqrt(sum),2)}");
    }
    else
    {
        Console.WriteLine("Неправильный ввод координат");
    }

    

    string[] g = Console.ReadLine().Split(' ');
    double kolv = 0;
    double h = 0;
    double gg;
    for (int i = 0; i < g.Length; i++)
    {
        bool zz = double.TryParse(g[i],out gg);
        if (zz=true)
        {
            h += 1;
        }
    }
    double f1 = Convert.ToDouble(Console.ReadLine());
    double f2 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("N1.10:");
    if (g.Length == 10 & h == 10 & f1!=f2)
    {
        for (int i = 0; i < g.Length; i++)
        {
            double xx=Convert.ToDouble(g[i]);
            if (Max(f1, f2) > xx & xx > Min(f1, f2))
            {
                kolv++;
            }
        }
        Console.WriteLine($"{kolv} чисел лежит в заданном массиве");
    }
    else
    {
        Console.WriteLine("Неправильный ввод");
    }



    string[] r = Console.ReadLine().Split(' ');
    double g1;
    double p = 0;
    List<double> mas = new List<double>();
    Console.WriteLine("N1.11:");
    for (int i = 0; i < r.Length; i++)
    {
        bool zh = double.TryParse(r[i], out g1);
        if (zh = true)
        {
            p++;
        }
    }
    if (r.Length == 10 & p == 10)
    {
        for (int i = 0; i < r.Length; i++)
        {
            int sd = Convert.ToInt32(r[i]);
            if (sd>0)
            {
                mas.Add(sd);
            }
        }
        for (int i = 0; i < mas.Count; i++)
        {
            Console.Write($"{mas[i]}  ");
        }
    }
    else
    {
        Console.WriteLine("Неправильный ввод");
    }


    string[] st = Console.ReadLine().Split(' ');
    double gla;
    double sc = 0;
    List<double> arr = new List<double>();
    int p0=0;
    Console.WriteLine("N1.12:");
    for (int i = 0; i < st.Length; i++)
    {
        bool hz = double.TryParse(st[i], out gla);
        if (hz == true)
        {
            sc++;
        }
    }
    if (sc == 8 & st.Length == 8)
    {
        for (int i = st.Length - 1; i > 0; i--)
        {
            double el = Convert.ToDouble(st[i]);
            if (el < 0)
            {
                p0 = i;
                break;
            }
        }
        Console.WriteLine($"Последний отрицательный элемент {st[p0]} находится в массиве под номером {p0+1}");
    }
    else
    {
        Console.WriteLine("Неправильный ввод");
    }



    string[] mass = Console.ReadLine().Split(' ');
    double gal;
    double sch = 0;
    List<double> arr = new List<double>();
    int p0 = 0;
    Console.WriteLine("N1.13:");
    for (int i = 0; i < mass.Length; i++)
    {
        bool hz = double.TryParse(mass[i], out gal);
        if (hz == true)
        {
            sch++;
        }
    }
    List<double> nechet = new List<double>();
    List<double> chet = new List<double>();
    if (sch==10 & mass.Length == 10)
    {
        for (int i = 0; i < mass.Length; i++)
        {
            double zm=Convert.ToDouble(mass[i]);
            if (i % 2 == 0)
            {
                chet.Add(zm);
            }
            else
            {
                nechet.Add(zm);
            }
        }
        Console.WriteLine("Массив с нечетными индексами:");
        for (int i = 0; i < nechet.Count; i++)
        {
            Console.Write($"{nechet[i]}  ");
        }
        Console.WriteLine("");
        Console.WriteLine("Массив с четными индексами:");
        for (int i = 0; i < chet.Count; i++)
        {
            Console.Write($"{chet[i]}  ");
        }
    }
    else
    {
        Console.WriteLine("Неправильный ввод");
    }


    double maxi = 0;
    double mini = 0;
    int indma = 0;
    int indmi = 0;
    string[] mes = Console.ReadLine().Split();
    double outed;
    double counted = 0;
    List <double> news = new List <double>();
    Console.WriteLine("N2.5:");
    for(int i=0; i<mes.Length; i++)
    {
        bool zh = double.TryParse(mes[i], out outed);
        if (zh == true)
        {
            counted++;
        }
    }
    if (counted == mes.Length)
    {
        for (int i = 0; i < mes.Length; i++)
        {
          double per = Convert.ToDouble(mes[i]);
          if(per >maxi)
            {
                indma = i;
                maxi = per;
            }
        }
        for (int i = 0; i < mes.Length; i++)
        {
            double per1 = Convert.ToDouble(mes[i]);
            if (per1 < mini)
            {
                indmi = i;
                mini = per1;
            }
        }
        for(int i = Min(indmi,indma)+1; i < Max(indmi,indma); i++)
        {
           double per2=Convert.ToDouble(mes[i]);
           if (per2<0)
            {
                news.Add(per2);
            }
        }
        for (int i = 0; i < news.Count; i++)
        {
            Console.Write($"{news[i]}  ");
        }
    }
    else
    {
        Console.WriteLine("Неправильный ввод");
    }



    string[] mos = Console.ReadLine().Split();
    List<double> mesn = new List<double>();
    string[] p = Console.ReadLine().Split();
    double summa = 0;
    double pips;
    int ind = 0;
    double ggg = 0;
    double raz = 1000;
    Console.WriteLine("N2.6:");
    for (int i = 0; i < mos.Length; i++)
    {
        bool pp = double.TryParse(mos[i], out pips);
        if (pp == true)
        {
            ggg++;
        }
    }
    bool ggh = double.TryParse(p[0], out pips);
    if (ggh == true)
    {
        ggg++;
    }
    if (ggg==mos.Length+1)
    {
        for (int i = 0; i < mos.Length; i++)
        {
            double jk=Convert.ToDouble(mos[i]);
            summa += jk;
        }
        summa = summa / mos.Length;
        for (int i = 0; i < mos.Length; i++)
        {
            double kk = Convert.ToDouble(mos[i]);
            if (Abs(kk-summa)<raz)
            {
                ind = i;
                raz = Abs(kk - summa);
            }
        }
        for (int i = 0; i < mos.Length; i++)
        {
            double kk = Convert.ToDouble(mos[i]);
            if (i == ind)
            {
                mesn.Add(kk);
                mesn.Add(Convert.ToDouble(p[0]));
            }
            else
            {
                mesn.Add(kk);
            }
        }
        for (int i = 0; i < mesn.Count; i++)
        {
            Console.Write($"{mesn[i]}  ");
        }
    }
    else
    {
        Console.WriteLine("Неверный ввод");
    }


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
        }
        for (int i = 0; i < hga.Length; i++)
        {
            double pir1 = Convert.ToDouble(hga[i]);
            if (pir1 < minix)
            {
                miind = i;
                minix = pir1;
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

        }
        for(int i=0;i<hah.Length;i++)
        {
            if (hah[i]>0 & hah[i]<mpoj)
            {
                mpoj = hah[i];
                impoj = i;
            }
        }
        hah = hah.Except(new double[] {hah[impoj]}).ToArray();
        for (int i = 0; i < hah.Length; i++)
        {
            Console.Write($"{hah[i]}  ");
        }
    }
    else
    {
        Console.WriteLine("Неверный ввод");
    }


    string[] mavi = Console.ReadLine().Split();
    List<double> nuy = new List<double>();
    string[] p11 = Console.ReadLine().Split();
    double iut = 0;
    double mus;
    int yin = 0;
    Console.WriteLine("N2.11:");
    for (int i = 0; i < mavi.Length; i++)
    {
        bool ptrp = double.TryParse(mavi[i], out mus);
        if (ptrp == true)
        {
            iut++;
        }
    }
    for (int i = 0; i < p11.Length; i++)
    {
        bool ptrp = double.TryParse(p11[i], out mus);
        if (ptrp == true)
        {
            iut++;
        }
    }
    if (iut==mavi.Length+1)
    {
        for(int i=mavi.Length-1;i>=0;i--)
        {
            double tio=Convert.ToDouble(mavi[i]);
            if (tio>0)
            {
                yin = i;
                break;
            }
        }
        for(int i=0;i<mavi.Length;i++)
        {
            double otio=Convert.ToDouble(mavi[i]);
            if (i==yin)
            {
                nuy.Add(otio);
                nuy.Add(Convert.ToDouble(p11[0]));

            }
            else
            {
                nuy.Add(otio);
            }
        }
        for (int i = 0; i < nuy.Count; i++)
        {
            Console.Write($"{nuy[i]}  ");
        }
    }
    else
    {
        Console.WriteLine("Неверный ввод");
    }


    string[] d15 = Console.ReadLine().Split();
    double[] dd15= new double[d15.Length];
    double gend;
    double cntr = 0;
    double md15 = 0;
    int imd15 = 0;
    Console.WriteLine("N2.13:");
    for(int i=0; i<d15.Length; i++)
    {
        bool dsd = double.TryParse(d15[i], out gend);
        if (dsd=true)
        {
            cntr++;
        }    
    }
    if (cntr==d15.Length)
    {
        for(int i=0; i<d15.Length; i+=2)
        {
            double jpg=Convert.ToDouble(d15[i]);
            if (jpg>md15)
            {
                md15= jpg;
                imd15 = i;
            }
        }
        for(int i =0;i<d15.Length;i++)
        {
            if (i==imd15)
            {
                dd15[i] = imd15;
            }
            else
            {
                dd15[i] = Convert.ToDouble(d15[i]);
            }
        }
        for (int i = 0; i < dd15.Length; i++)
        {
            Console.Write($"{dd15[i]}  ");
        }
    }
    else
    {
        Console.WriteLine("Неверный ввод");
    }

    
    string[] d17a = Console.ReadLine().Split();
    string[] d17b = Console.ReadLine().Split();
    string[] d17k = Console.ReadLine().Split();
    List<double> d17n = new List<double>();
    double otup;
    double reda = 0;
    Console.WriteLine("N2.15:");
    for(int i = 0; i < d17a.Length; i++)
    {
        bool jfd1 = double.TryParse(d17a[i], out otup);
        if(jfd1==true)
        {
            reda++;
        }
    }
    for (int i = 0; i < d17b.Length; i++)
    {
        bool jfd2 = double.TryParse(d17b[i], out otup);
        if (jfd2 == true)
        {
            reda++;
        }
    }
    for (int i = 0; i < d17k.Length; i++)
    {
        bool jfd3 = double.TryParse(d17k[i], out otup);
        if (jfd3 == true)
        {
            reda++;
        }
    }
    double jijh = Convert.ToDouble(d17k[0]);
    if (reda == d17a.Length + d17b.Length + 1 & jijh<d17a.Length & jijh+1 < d17a.Length)
    {
        for (int i = 0; i < d17a.Length; i++)
        {
            double prp = Convert.ToDouble(d17a[i]);
            d17n.Add(prp);
            if (i == jijh)
            {
                for(int j = 0; j < d17b.Length; j++)
                {
                    double prp1=Convert.ToDouble(d17b[j]);
                    d17n.Add(prp1);
                }
            }
        }
        for(int i=0; i < d17n.Count; i++)
        {
            Console.Write($"{d17n[i]}  ");
        }
    }
    else
    {
        Console.WriteLine("Неправильный ввод");
    }


    string[] d31 = Console.ReadLine().Split();
    List<double> L= new List<double>();
    double H;
    double G = 0;
    double MAX = 0;
    Console.WriteLine("N3.1:");
    for (int i=0;i<d31.Length;i++)
    {
        bool J = double.TryParse(d31[i], out H);
        if(J==true)
        {
            G++;
        }
    }
    if (G==d31.Length)
    {
        for(int i=0;i<d31.Length;i++)
        {
            double D1 = Convert.ToDouble(d31[i]);
            if (D1>MAX)
            {
                MAX = D1;
            }
        }
        for(int i=0;i<d31.Length;i++)
        {
            double D2 = Convert.ToDouble(d31[i]);
            if (D2==MAX)
            {
                L.Add(i);
            }
        }
        for(int i=0;i<L.Count;i++)
        {
            Console.Write($"{L[i]} ");
        }
    }
    else
    {
        Console.WriteLine("Неправильный ввод");
    }


    string[] d35 = Console.ReadLine().Split();
    double[] L1 = new double[d35.Length / 2];
    Console.WriteLine("N3.5:");
    if (d35.Length%2==1)
    {
        Array.Resize(ref L1,(d35.Length / 2) + 1);
    }
    double S;
    double At=0;
    double Ma = -1;
    int Inda = 0;
    for (int i = 0; i < d35.Length; i++)
    {
        bool pupy = double.TryParse(d35[i],out S);
        if (pupy==true)
        {
            At++;
        }
    }
    int Z = 0;
    if (At==d35.Length)
    {
        for(int i = 0; i < d35.Length; i+=2)
        {
            double Y = Convert.ToDouble(d35[i]);
            L1[Z] = Y;
            Z++;
        }
        Array.Sort(L1);
        Z = 0;
        for(int i=1;i<d35.Length;i+=2)
        {
            if (Z <=L1.Length)
            {
                Console.Write($"{L1[Z]} ");
                Z++;
            }
            Console.Write($"{Convert.ToDouble(d35[i])} ");
        }
        if (d35.Length%2==1)
        {
            Console.Write($"{L1[Z]} ");
        }
    }
    else
    {
        Console.WriteLine("Неправильный ввод");
    }



    string[] IK = Console.ReadLine().Split();
    double[] I1 = new double[IK.Length];
    double FG = 0;
    double FF;
    int DD = 0;
    Console.WriteLine("N3.8:");
    for (int i = 0; i < IK.Length; i++)
    {
        bool pupy = double.TryParse(IK[i], out FF);
        if (pupy == true)
        {
            FG++;
        }
    }
    if (FG==IK.Length)
    { 
        for(int i = 0; i < IK.Length; i++)
        {
            double UU = Convert.ToDouble(IK[i]);
            if(UU>=0)
            {
                I1[i] = UU;
                DD++;
            }
        }
        double[] I2 = new double[IK.Length-DD];
        int CS = 0;
        for (int i = 0; i < IK.Length; i++)
        {
            double UK = Convert.ToDouble(IK[i]);
            if (UK < 0)
            {
                I2[CS] = UK;
                CS++;
            }
        }
        Array.Sort(I2);
        int YU = I2.Length - 1;
        for(int i = 0; i < I1.Length; i++)
        {
            if(I1[i]==0)
            {
                Console.Write($"{I2[YU]} ");
                YU--;
            }
            else
            {
                Console.Write($"{I1[i]} ");
            }
        }
    }
    else
    {
        Console.WriteLine("Неправильный ввод");
    }
   


    string[] D39 = Console.ReadLine().Split();
    double[] MASS = new double[D39.Length];
    double JJJ;
    double KAS = 0;
    double MP1 = 0;
    double MP2 = 0;
    int I10 = 0;
    double TD = 1;
    Console.WriteLine("N3.9:");
    for (int i = 0; i < D39.Length; i++)
    {
        bool YRT = double.TryParse(D39[i],out JJJ);
        if (YRT=true)
        {
            KAS++;
        }

    }
    if(KAS==D39.Length)
    {
        for(int i = 0; i < D39.Length; i++)
        {
            double YTIO = Convert.ToDouble(D39[i]);
            MASS[i] = YTIO;
        }
        while (I10+1<MASS.Length)
        {
            if (MASS[I10] > MASS[I10+1])
            {
                I10++;
                TD++;
            }
            else
            {
                if (TD>MP1)
                {
                    MP1 = TD;
                }
                TD = 1;
                I10++;
            }
        }
        if (TD>MP1)
        {
            MP1 = TD;
        }
        I10 = 0;
        TD = 1;
        while (I10 + 1 < MASS.Length)
        {
            if (MASS[I10] < MASS[I10 + 1])
            {
                I10++;
                TD++;
            }
            else
            {
                if (TD > MP2)
                {
                    MP2 = TD;
                }
                TD = 1;
                I10++;
            }
        }
        if (TD > MP2)
        {
            MP2 = TD;
        }
        MP1 = Max(MP1, MP2);
        Console.WriteLine($"Искомая максимальная длина {MP1}");
    }
    else
    {
        Console.WriteLine("Неправильный ввод");
    }


    string[] D311 = Console.ReadLine().Split();
    double[] D3112 = new double[D311.Length];
    double ASW;
    double GFD = 0;
    Console.WriteLine("N3.12:");
    for ( int i = 0; i < D311.Length; i++)
    {
        bool FCVB =double.TryParse(D311[i], out ASW);
        if(FCVB==true)
        {
            GFD++;
        }
    }
    if (GFD==D311.Length & GFD==12)
    {
        for( int i = 0; i < D311.Length; i++)
        {
            double QWER = Convert.ToDouble(D311[i]);
            D3112[i] = QWER;
        }
        List<int> D3113 = new List<int>();
        for ( int i = 0; i < D3112.Length; i++)
        {
            if(D3112[i] <0)
            {
                D3112[i] =Math.Pow(9, 10);
            }    
        }
        for(int i = 0; i < D3112.Length; i++)
        {
            if (D3112[i] != Math.Pow(9, 10))
            {
                Console.Write($"{D3112[i]} ");
            }
        }
    }
    else
    {
        Console.WriteLine("Неверный ввод");
    }
   


    string[] D312 = Console.ReadLine().Split();
    double[] D3121 = new double[D312.Length];
    double ASWR;
    double GFDO = 0;
    Console.WriteLine("N3.13:");
    for (int i = 0; i < D312.Length; i++)
    {
        bool FCVBH = double.TryParse(D312[i], out ASWR);
        if (FCVBH == true)
        {
            GFDO++;
        }
    }
    if(GFDO==D312.Length)
    {
        for (int i = 0; i < D312.Length; i++)
        {
            double QWERT = Convert.ToDouble(D312[i]);
            D3121[i] = QWERT;
        }
        double IUH = 0;
        for(int i = 0; i < D3121.Length; i++)
        {
            for(int j = i+1; j < D3121.Length; j++)
            {
                if (D3121[i] == D3121[j])
                {
                    D3121[j] = Math.Pow(9,10);
                    IUH++;
                }
            }
            if(IUH>0)
            {
                D3121[i] = Math.Pow(9, 10);
            }
            IUH = 0;
            
        }
        for (int i = 0; i < D3121.Length; i++)
        {
            if (D3121[i] != Math.Pow(9, 10))
            {
                Console.Write($"{D3121[i]} ");
            }
        }
    }
    else
    {
        Console.WriteLine("Неверный ввод");
    }
   


}

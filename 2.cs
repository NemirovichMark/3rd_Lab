using System;
{
    Console.WriteLine("TV11:");
    string[] a = Console.ReadLine().Split();
    string[] f = Console.ReadLine().Split();
    double[] b = new double[a.Length];
    double c = 0;
    double d;
    for(int i = 0; i < a.Length; i++)
    {
        bool h = double.TryParse(a[i], out d);
        if(h==true)
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
    if (c==a.Length+1)
    {
        double f1 = Convert.ToDouble(f[0]);
        int i1 = 0;
        int i2 = b.Length-1;
        while(i1<i2)
        {
            if(i1>i2)
            {
                Console.WriteLine($"Искомый элемент отсутвует в массиве");
                break;
            }    
            int i=(i1 + i2) / 2;
            if (f1== b[i])
            {
                Console.WriteLine($"Искомый индекс равен {i}");
                break;
            }
            if (f1 > b[i])
            {
                i1 = i+1;
            }
            if (f1 < b[i])
            {
                i2 = i-1;
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
        if(hgh==true)
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
    if (de==a1.Length+b1.Length)
    {
        for(int i = 0; i < c1.Length; i++)
        {
            if(i%2==0)
            {
                c1[i] = Convert.ToDouble(a1[ac]);
                ac++;
            }
            else
            {
                c1[i] = Convert.ToDouble(b1[bc]);
                bc++;
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


    Console.WriteLine("TV13:");
    string[] a2 = Console.ReadLine().Split();
    string[] b2 = Console.ReadLine().Split();
    double[] c2 = new double[a2.Length + b2.Length];
    double def = 0;
    double ikjf;
    for (int i = 0; i < a2.Length; i++)
    {
        bool hght = double.TryParse(a2[i], out ikjf);
        if (hght == true)
        {
            def++;
        }
    }
    for (int i = 0; i < b2.Length; i++)
    {
        bool ghgt = double.TryParse(b2[i], out ikjf);
        if (ghgt == true)
        {
            def++;
        }
    }
    if (def == a2.Length + b2.Length)
    {
         int ih = 0;
         var result = a2.Concat(b2);
         foreach(string s in result)
            {
            double yr = Convert.ToDouble(s);
            c2[ih] = yr;
            ih++;
            }    
         Array.Sort(c2);
        for(int i = 0; i < c2.Length; i++)
        {
            Console.Write($"{c2[i]} ");
        }    
    }
    else
    {
        Console.WriteLine("Неверный ввод");
    }


    Console.WriteLine("TV14:");
    string[] a3 = Console.ReadLine().Split();
    double[] end = new double[a3.Length];
    double ter;
    double ctr = 0;
    for(int i = 0; i < a3.Length; i++)
    {
        bool fga = double.TryParse(a3[i], out ter);
        if (fga == true)
        {
            ctr++;
            end[i] = ter;

        }
    }
    if(ctr==a3.Length)
    {
        Array.Reverse(end);
        for (int k= 0; k < end.Length; k++)
        {
          Console.Write($"{end[k]} ");
        }    

    }
    else
    {
        Console.WriteLine("Неверный ввод");
    }




    Console.WriteLine("TV15:");
    string[] a4 = Console.ReadLine().Split();
    string[] m = Console.ReadLine().Split();
    double[] b4 = new double[a4.Length];
    double teg;
    double qwe = 0;
    for (int i = 0; i < a4.Length; i++)
    { 
        bool iuy =double.TryParse(a4[i], out teg);
        if(iuy==true)
        {
            qwe++;
            b4[i] = teg;
        }
    }
    for (int i = 0; i < m.Length; i++)
    {
        bool iuyy = double.TryParse(m[i], out teg);
        if (iuyy == true)
        {
            qwe++;
        }
    }
    int ior = Convert.ToInt32(m[0]);
    if(ior>b4.Length)
    {
        ior = ior - ((ior / b4.Length)*b4.Length);
    }
    double[] c4 = new double[ior];
    if (qwe==a4.Length+1)
    {
       int yew = 0;
       for(int i = b4.Length-ior; i < b4.Length; i++)
        {
            c4[yew] = b4[i];
            yew++;
        }
        for (int i = b4.Length - 1-ior; i>=0; i--)
        {
            b4[i+ior] = b4[i];
        }
       for(int j = 0; j < ior; j++)
        {
            b4[j] = c4[j];
        }
       for(int k = 0; k < b4.Length; k++)
        {
            Console.Write($"{b4[k]} ");
        }    
    }
    else
    {
        Console.WriteLine("Неверный ввод");
    }



}



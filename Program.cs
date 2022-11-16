using System;

namespace _1st_Lesson
{
    class Program
    {
        static void levels()
        { 
            
            Console.WriteLine("6 задача 1 уровень");
            #region 1.6
            
            try 
            {
                double summa = 0;
                double[] a;
                a = new double[5];
                for (int i = 0; i <= 4; i++) 
                {
                    Console.WriteLine("Введите x" + (i + 1));
                    a[i] = Convert.ToDouble(Console.ReadLine());
                    summa += Math.Pow(a[i], 2);
                }
                Console.WriteLine("Длина вектора = " + Math.Sqrt(summa));
            }
            catch 
            {
                Console.WriteLine("Программа поддерживает только числа ");
            }        


            #endregion
            Console.WriteLine("10 задача 1 уровень");
            
            #region 1.10

            double[] b = new double [10] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            Console.WriteLine("Введите значения P и Q");
            double p = 0, q = 0;
            try{
                p = Convert.ToDouble(Console.ReadLine());
                q = Convert.ToDouble(Console.ReadLine());
            }
            catch(Exception){
                Console.WriteLine("Ошибка");
            }
            int dif = 0;
            if(p > q){
                Console.WriteLine("P должно быть меньше Q");
                return;
            }
            foreach(int i in b){
                if(i> p && i < q){
                    dif++;
                }
            }
            Console.WriteLine(dif);

            #endregion 
            
            Console.WriteLine("11 задача 1 уровень");
            #region 1.11

            List<double> plus = new List<double>(){};
            double[] c = new double [10] {-1,2,-3,4,-5,6,-7,8,-9,10};
            for (int i = 0; i <= 9; i++)
            {
                if (c[i] > 0) {
                    plus.Add(c[i]);
                } 
            }
            plus.ForEach(Console.WriteLine);
            
            #endregion 
            Console.WriteLine("12 задача 1 уровень");
            #region 1.12

            int l = 0, y = 0;
            int[] d = new int [8] {1,2,4,-5,7,-4,7,8};
            for (int i = 0; i <= 7; i++){
                if (d[i] < 0) {
                    l = d[i];
                    y = i;
                }
            }
            Console.WriteLine(l + " - последний отрицательный элемент");
            Console.WriteLine(y + " - номер его ячейки");

            #endregion 
            Console.WriteLine("13 задача 1 уровень");
            #region 1.13

            int[] e = new int [10] {1,2,4,-5,7,-4,7,8,9,10};
            List<int> e1 = new List<int>(){};
            List<int> e2 = new List<int>(){};
            {
                
            }
            for (int i = 0; i <= 9; i++) {
                if (i % 2 == 0) {
                    e1.Add(e[i]);
                }
                else {
                    e2.Add(e[i]);
                }
            }
            Console.WriteLine("1st Massive");
            e1.ForEach(Console.WriteLine);
            Console.WriteLine("2nd Massive");
            e2.ForEach(Console.WriteLine);

            #endregion 
            Console.WriteLine("5 задание 2 уровень"); 
            #region 2.5

            int min = 0, max = 0;
            int[] f = new int [7] {0, -8, 3, -2, 10, -3, 11};
            List<int> f1 = new List<int>(){};
            for (int i = 0; i <= 6; i++){
                if (f[i] < f[min]) {
                    min = i;
                }
                if (f[i] > f[max]) {
                    max = i;
                }
            }
            for (int j = min; j <= max; j++) {
                if (f[j] < 0) {
                    f1.Add(f[j]);
                }
            }
            f1.ForEach(Console.WriteLine);

            #endregion 

            Console.WriteLine("6 задание 2 часть");
            
            #region 2.6

            p = 0; 
            double sum = 0;
            bool flag = true;
            double[] g = new double [5] {1, 2, 3, 4, 5};
            List<double> g1 = new List<double>(){};
            for (int i = 0; i <= 4; i++) {
                sum += g[i];
            }
            sum = sum/5;
            for (int j = 0; j <= 4; j++) {
                if ((flag == true) & (g[j] > sum)) {
                    g1.Add(p);
                    flag = false;
                }
                g1.Add(g[j]);
            }
            g1.ForEach(Console.WriteLine);

            #endregion 
            Console.WriteLine("9 задание 2 уровень"); 
            #region 2.9 
            sum = 0;
            int counter = 0;
            min = 0; max = 0;
            f = new int [7] {5,-1,-8,3,4,8,6};
            f1 = new List<int>(){};
            for (int i = 0; i <= 6; i++){
                if (f[i] < f[min]) {
                    min = i;
                }
                if (f[i] > f[max]) {
                    max = i;
                }
            }
            for (int j = (min + 1); j < max; j++) {
                sum += f[j];
                counter += 1;
            }
            Console.WriteLine($"{sum/counter}");
            #endregion
            Console.WriteLine("10 задание 2 уровень"); 
            #region 2.10
            min = 9999;
            int[] w = new int [5] {4,-1,-2,2,5};
            List<int> w1 = new List<int> (){};
            for (int i = 0; i <= 4; i++) {
                if(w[i] > 0 & w[i] < min) {
                    min = w[i];
                }
            }
            for (int j = 0; j <= 4; j++) {
                if (w[j] != min) {
                    w1.Add(w[j]);
                }
            }
            w1.ForEach(Console.WriteLine);

            #endregion 
            Console.WriteLine("11 задание 2 уровень");
            //5 6 9 10 11 13 15
            #region 2.11

            int last = 0;
            int z = 111;
            int[] t = new int [5] {4,-1,-2,2,-5};
            List<int> t1 = new List<int> (){};

            for (int i = 0; i <= 4; i++){
                if (t[i] > 0) {
                    last = i;
                }
            }
            for (int j = 0; j <= 4; j++){
                t1.Add(t[j]);
                if (j == last){
                    t1.Add(z);
                }
            }
            t1.ForEach(Console.WriteLine);
            #endregion
            Console.WriteLine("13 задание 2 уровень");
            #region 2.13
            max = -999;
            int index = 0;    
            int[] u = new int [8] {3,7,6,5,4,3,2,1};
            List<int> u1 = new List<int>(){};
            for (int i = 0; i <= 7; i++){
                if ((u[i] > max) & (i % 2 == 0)) {
                    max = u[i];
                    index = i;
                }
            }
            for (int j = 0; j <= 7; j++){
                if (u[j] == max) {
                    u1.Add(index);
                } 
                else{
                    u1.Add(u[j]);
                }
            }
            u1.ForEach(Console.WriteLine);

            #endregion 
            Console.WriteLine("15 задание 2 уровень");
            #region 2.15

            int[] A = new int [3] {2, 4, 6};
            List<int> AB = new List<int> (){};
            int[] B = new int [5] {1, 3, 5, 7, 9};
            int k = 1;
            for (int i = 0; i <= 2; i++){
                AB.Add(A[i]);
                if (i == k) {
                    for (int j = 0; j <= 4; j++){
                        AB.Add(B[j]);
                    }
                }
            }
            AB.ForEach(Console.WriteLine);

            #endregion
            Console.WriteLine("1 задание 3 уровень");
            #region 3.1

            int[] h = new int [5] {5,4,4,-2,5};
            List<int> h1 = new List<int> (){};
            max = -999;
            for (int i = 0; i <= 4; i++){
                if (h[i] > max){
                    max = h[i];
                }
            }
            for (int j = 0; j <= 4; j ++){
                if (h[j] == max) {
                    h1.Add(j);
                }
            }
            h1.ForEach(Console.WriteLine);
            #endregion
            Console.WriteLine("5 задание 3 уровень");
            #region 3.5

            int temp;
            List<int> x = new List<int>(){9,8,7,6,5,4,3,2,1,0};
            for (int i = 0; i <= 9; i += 2) {
                for (int j = i+1; j <= 9; j += 2) {
                    temp = x[i];
                    x[i] = x[j];
                    x[j] = temp;                    
                }
            }
            x.ForEach(Console.WriteLine);
            #endregion 
            Console.WriteLine("8 задание 3 уровень");
            #region 3.8
            List<int> Z = new List<int>(){-9,-8,-7,-6,-5,-4,3,2,-1,0};
            for (int i = 0; i <= 9; i += 1) {
                for (int j = i+1; j <= 9; j += 1) {
                    if (Z[i] < 0 & Z[j] < 0) {
                        temp = Z[j];
                        Z[j] = Z[i];
                        Z[i] = temp;
                    }
                }
            }
            Z.ForEach(Console.WriteLine);

            #endregion 
            Console.WriteLine("9 задание 3 уровень");
            #region 3.9
            k = 1;
            int maximum = -9999;
            int[] m = new int [10] {1,-2,-3,-4,-5,-6,-7,-8,-9,-1};
            for (int i = 0; i <= 8; i++) {
                if (m[i] < m[i+1]) {
                    k += 1;
                }
                else {
                    if (k > maximum) {
                        maximum = k;
                    }
                    k = 1;
                }
            }
            if (k > maximum) {
                maximum = k;
            }
            k = 1;
            for(int j = 0; j <= 8; j++) {
                if (m[j] > m[j+1]) {
                    k += 1;
                }
                else {
                    if (k > maximum) {
                        maximum = k;
                    }
                    k = 1;
                }
            }
            if (k > maximum) {
                maximum = k;}


            Console.WriteLine(maximum);
            #endregion 
            Console.WriteLine("12 задание 3 уровень");
            #region 12.3

            int[] H = new int [12] {0,1,-2,3,4,5,-6,7,8,-9,-10,11};
            List<int> hp = new List<int> (){};
            for (int i = 0; i <= 11; i++) {
                if (H[i] >= 0) {
                    hp.Add(H[i]);
                }
            }
            hp.ForEach(Console.WriteLine); 

            #endregion 
            Console.WriteLine("13 задание 3 уровень");
            #region 3.13

            List<double> NA = new List<double>();
            int count = 0;
            if ((int.TryParse(Console.ReadLine(), out int n)) && (n > 1))
            {
                double[] V = new double[n];
                Console.WriteLine("Введите хотя бы одно дубл. значение");
                for (int i = 0; i < V.Length; ++i)
                {
                    if (double.TryParse(Console.ReadLine(), out double digit))
                    {
                        V[i] = digit;
                    }
                    else
                    {
                        Console.WriteLine("Error");
                    }
                }
                for (int i = 0; i < V.Length; ++i)
                {
                    count = 0;
                    for ( int j = 0; j < V.Length; ++j)
                    {
                        if (V[i] != V[j])
                        {
                            ++count;
                        }
                    }
                    if (count == V.Length - 1)
                    {
                        NA.Add(V[i]);
                    }
                }
            }
            else
            {
                Console.WriteLine("Нет");
            }
            Console.WriteLine(String.Join("; ", NA));

            #endregion
        }
        static void a11()
        {
            Console.WriteLine("Введите число x");
            int x;
            while(!int.TryParse(Console.ReadLine(), out x))
            {

            }
            List<int>a = new List<int>();
            string s = null;
            Console.WriteLine("Введите элементы, для завершения нажмите q");
            while(s != "q")
            {
                s= Console.ReadLine();
                int b = 0;
                if (int.TryParse(s, out b))
                {
                    a.Add(b);
                }
            }
            Console.WriteLine("Массив");
            foreach(int u in a)
            {
                Console.WriteLine(u);
            }

            int l = 0;
            int p = a.Count - 1;
            bool flag = false;
            while (l <= p)
            {
                int q = (l + p) / 2;
                if (a[q] == x)
                {
                    flag = true;
                    Console.WriteLine("Искомый элемент = " +x);
                    Console.WriteLine("Его индекс = " + q);
                    break;
                }
                if (a[q] < x)
                {
                    l = q+1;
                }
                if (a[q] > x)
                {
                    p = q-1;
                }
               
            }
            
            if (!flag)
            {
                Console.WriteLine("Такого элемента нет");
            }

            

        }
        static void a12()
        {
            List<int> a = new List<int>();
            string s = null;
            Console.WriteLine("Введите элементы массива А, для завершения нажмите q");
            while (s != "q")
            {
                s = Console.ReadLine();
                int b = 0;
                if (int.TryParse(s, out b))
                {
                    a.Add(b);
                }
            }
            Console.WriteLine("Массив A");
            foreach (int u in a)
            {
                Console.WriteLine(u);
            }

            List<int> f = new List<int>();
            string v = null;
            Console.WriteLine("Введите элементы массива В, для завершения нажмите q");
            while (v != "q")
            {
                v = Console.ReadLine();
                int l = 0;
                if (int.TryParse(v, out l))
                {
                    f.Add(l);
                }
            }
            Console.WriteLine("Массив B");
            foreach (int d in f)
            {
                Console.WriteLine(d);
            }
            int x = Math.Min(a.Count, f.Count);
            
            List<int> m = new List<int>();
            for (int k = 0; k < x * 2; k++)
            {
                if (k % 2==0)
                {
                    m.Add(a[k / 2]);
                }
                else
                {
                    m.Add(f[k / 2]);
                }
            }
            
            if (a.Count > x)
            {
                for (int p = x; p < a.Count; p++)
                {
                    m.Add(a[p]);
                }
            }
            if (f.Count > x)
            {
                for (int t = x; t < f.Count; t++)
                {
                    m.Add(f[t]);
                }
            }
            Console.WriteLine("Новый массив C");
            foreach(int z in m)
            {
                Console.WriteLine(z);
            }

        }
        static void a13()
        {
            List<int> a = new List<int>();
            string s = null;
            Console.WriteLine("Введите элементы массива А, для завершения нажмите q");
            while (s != "q")
            {
                s = Console.ReadLine();
                int b = 0;
                if (int.TryParse(s, out b))
                {
                    a.Add(b);
                }
            }
            Console.WriteLine("Массив А");
            foreach (int u in a)
            {
                Console.WriteLine(u);
            }
            List<int> f = new List<int>();
            string v = null;
            Console.WriteLine("Введите элементы массива В, для завершения нажмите q");
            while (v != "q")
            {
                v = Console.ReadLine();
                int l = 0;
                if (int.TryParse(v, out l))
                {
                    f.Add(l);
                }
            }
            Console.WriteLine("Массив B");
            foreach (int d in f)
            {
                Console.WriteLine(d);
            }
           
            List<int> c = new List<int>();
            int x = a.Count + f.Count;
            int ai = 0;
            int fi = 0;
           for (int i=0; i<x; i++)
            {
                if ((ai < a.Count) && (fi >= f.Count || a[ai] > f[fi]))
                {
                    c.Add(a[ai]);
                    ai++;
                }
                else
                {
                    c.Add(f[fi]);
                    fi++;
                }
            }
            c.Sort();
            Console.WriteLine("Новый массив С");
            for (int y=0; y<c.Count; y++)
            {
                Console.WriteLine(c[y]);
            }

            }
        static void a14()
        {
           List<int> a = new List<int>();
            string s = null;
            Console.WriteLine("Введите элементы, для завершения нажмите q");
            while(s!="q")
            {
              s= Console.ReadLine();
                int b = 0;
                if (int.TryParse(s, out b))
                {
                    a.Add(b);
                }
            }
            Console.WriteLine("Массив");
            foreach(int u in a)
            {
                Console.WriteLine(u);
            }
            int temp = 0;
            Console.WriteLine("Новый массив");
           for (int i =0; i < a.Count/2; i++)
            {
                temp = a[i];
                a[i] = a[a.Count-i-1];
                a[a.Count - i-1] = temp;
                
            }
            foreach (int u in a)
            {
                Console.WriteLine(u);
            }
        }
        static void a15()
        {
            List<int> a = new List<int>();
            string s = null;
            Console.WriteLine("Введите элементы, для завершения нажмите q");
            while (s != "q")
            {
                s = Console.ReadLine();
                int b = 0;
                if (int.TryParse(s, out b))
                {
                    a.Add(b);
                }
            }
            Console.WriteLine("Массив");
            foreach (int u in a)
            {
                Console.WriteLine(u);
            }
            Console.WriteLine("Введите количество элементов для сдвига");
            int k;
            while (!int.TryParse(Console.ReadLine(), out k))
            {

            }
            Console.WriteLine();
            for (int z = 0; z < k; z++)
            {
                int temp;
                temp = a[a.Count - 1];
                for (int i = a.Count - 1; i > 0; i--)
                {
                    a[i] = a[i - 1];
                }
                a[0] = temp;
            }
            foreach(int v in a)
            {
                Console.WriteLine(v);
            }
        }

    }
}

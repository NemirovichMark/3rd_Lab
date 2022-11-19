using Microsoft.VisualBasic;
using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace _3rd_Lab
{
    class Theory
    {
        static void Main(string[] args)
        {
            #region lvl1-6
            int M = 5;
            double[] vk = new double[M];
            for (int i = 0; i < vk.Length; i++)
            {
                double a;
                Console.Write($"Введите значение под индексом {i}: \t");
                double.TryParse(Console.ReadLine(), out a);
                vk[i] = a;

            }
            double l = 0;
            for (int i = 0; i < vk.Length; i++)
            {
                l += vk[i] * vk[i];
            }
            double L = Math.Sqrt(l);
            Console.WriteLine($"Длина вектора равна {L}");
            #endregion
            #region lvl1-10
            double[] lol = new double[10];
            double P, Q;
            int kl = 0;
            double.TryParse(Console.ReadLine(), out P);
            double.TryParse(Console.ReadLine(), out Q);
            if (P == Q || P > Q)
            {
                Console.WriteLine("Ошибка");
                return;
            }
            else
            {
                for (int i = 0; i < lol.Length; i++)
                {
                    lol[i] = i;
                    if ((lol[i] < Q) && (lol[i] > P))
                    {
                        kl += 1;
                    }
                }
            }
            Console.WriteLine(kl);
            #endregion
            #region lvl1-11
            int m = 10;
            int km = 0;
            double[] al = new double[m];
            int kt = 0;
            for (int i = 0; i < al.Length; i++)
            {
                double e;
                Console.WriteLine($"Введите {i} элемент");
                double.TryParse(Console.ReadLine(), out e);
                al[i] = e;
                if (e > 0)
                    km++;
            }
            double[] m2 = new double[km];
            foreach (double x in al)
            {
                if (x > 0)
                {
                    m2[kt] = x;
                    kt += 1;
                }
            }
            string s = "";
            for (int i = 0; i < km; i++)
            {
                s += m2[i].ToString() + " ";
                
            }
            Console.WriteLine(s);







            #endregion
            #region lvl1-12
            double[] mm = new double[8];
            int kmm = 0;
            double kmn = 0;

            for (int i = 0; i < mm.Length; i++)
            {
                double f;
                double.TryParse(Console.ReadLine(), out f);
                mm[i] = f;
            }
            for (int i = mm.Length - 1; i >= 0; i--)
            {
                if (mm[i] < 0)
                {
                    kmn = mm[i];
                    kmm = i;
                    break;
                }
            }
            Console.WriteLine(kmm);
            Console.WriteLine(kmn);
            #endregion
            #region lvl1-13
            double[] mm3 = new double[10];
            Console.WriteLine("Введите 5 четных и 5 нечетных элемента");
            for (int i = 0; i < mm3.Length; i++)
            {
                double n3;
                double.TryParse(Console.ReadLine(), out n3);
                mm3[i] = n3;
            }
            double [] mm4 = new double[5];
            double [] mm5 = new double[5];
            int j = 0;
            int y = 0;
            foreach (double x in mm3)
            {
                if (x % 2 == 0)
                {
                    mm4[j] = x;
                    j += 1;
                }
                else
                {
                    mm5[y] = x;
                    y += 1;
                }
            }
            for (int i = 0; i < j; i++)
                Console.Write(mm4[i]);
            Console.WriteLine();
            for (int i = 0; i < y; i++)
                Console.Write(mm5[i]);
            Console.WriteLine();


            #endregion
            #region lvl2-5
            int[] mm6 = {-7,-6,-5,-4,1,2,3,4};
            int k = 0;
            for (int i = 0; i < mm6.Length; i++)
            {
                if (mm6[i] < 0)
                {
                   k += 1;
                }
            }
            k -= 1;
            int mm6max = mm6[0];
            int mm6min = mm6[0];
            int indexmm6max = 0;
            int indexmm6min = 0;
            int[] mm6a = new int[k];
            for (int i = 0; i < mm6.Length; i++)
            {
                if (mm6[i] > mm6max)
                {
                    mm6max = mm6[i];
                    indexmm6max = i;
                }
                if (mm6[i] < mm6min)
                {
                    mm6min = mm6[i];
                    indexmm6max = i;
                }
            }
            int lm = 0;
            for (int i = indexmm6min + 1; i < indexmm6max; i++)
            {
                if (mm6[i] < 0)
                {
                    mm6a[lm] = mm6[i];
                    lm += 1;
                }
            }
            foreach (int i in mm6a)
            {
                Console.Write(i);
                Console.Write(" ");
            }



            #endregion
            #region lvl2-6
            int[] AA = new int[6] { 1, 2, 3, 4, 5,0};
            int PA = 333;
            double srA = 0;
            int kA = 0;
            for (int i = 0; i < AA.Length - 1; i++)
            {
                srA += AA[i];
                kA += 1;
            }
            srA /= kA;
            int indexA = 0;
            double maxxA = 100000;
            for (int i = 0; i < AA.Length - 1; i++)
            {
                if (Math.Abs(srA - AA[i]) < maxxA )
                {
                    maxxA = srA - AA[i];
                    indexA = i;
                }
            }
            for (int i = 4; i >= indexA + 1; i--)
            {
                AA[i + 1] = AA[i];
            }
            AA[indexA + 1] = PA;
            foreach (int i in AA)
            {
                Console.Write(i);
                Console.Write(" ");
            }
            #endregion
            #region lvl2-9
            int[] mm8 = {-7,-6,-5,-4,1,2,3,4};
            int mm8max = mm8[0];
            int mm8min = mm8[0];
            int indexmm8max = 0;
            int indexmm8min = 0;
            for (int i = 0; i < mm8.Length; i++)
            {
                if (mm8[i] > mm8max)
                {
                    mm8max = mm8[i];
                    indexmm8max = i;
                }
                if (mm8[i] < mm8min)
                {
                    mm8min = mm8[i];
                    indexmm8max = i;
                }
            }
            double sr8 = 0;
            int k8 = 0;
            for (int i = indexmm8min + 1; i < indexmm8max; i++)
            {
                sr8 += mm8[i];
                k8 += 1;
            }
            sr8 /= k8;
            Console.WriteLine(sr8);
            #endregion
            #region lvl2-10
            int[] mm9 = {-7,-8,-9,1,2,3,4,5,};
            int indexmm9 = 0;
            int minmm9 = 10000;
            for (int i = 0; i < mm9.Length; i++)
            {
                if (mm9[i] > 0)
                {
                    if (mm9[i] < minmm9)
                    {
                        minmm9 = mm9[i];
                        indexmm9 = i;
                    }
                }
               
            }
            int n9 = mm9.Length - 1;
            for (int i = indexmm9 ; i < n9; i++)
            {
                mm9[i] = mm9[i + 1];
            }
            for (int i = 0; i < mm9.Length - 1; i++)
            {
                Console.Write(mm9[i]);
                Console.Write(" ");
            }
            #endregion
            #region lvl2-11
            Console.WriteLine("Введите размер массива");
            int cv;
            int.TryParse(Console.ReadLine(), out cv);
            int[] nx = new int[cv];
            Console.WriteLine("Введите число P");
            int p;
            int.TryParse(Console.ReadLine(), out p);
            for (int i = 0; i < cv - 1; i++)
            {
                Console.WriteLine($"Введите {i} элемент массива");
                int lk;
                int.TryParse(Console.ReadLine(), out lk);
                nx[i] = lk;
            }
            int indexnx = 0;
            int maxnx = 0;
            for (int i = 0; i < nx.Length; i++)
            {
                
                if (nx[i] > 0 & nx[i] > maxnx)
                {
                    maxnx = nx[i];
                    indexnx = i;
                }
            }
            for (int i = cv - 2; i >= indexnx + 1; i--)
            {
                nx[i + 1] = nx[i];
                
            }
            nx[indexnx + 1] = p;
            foreach (int i in nx)
            {
                Console.Write(i);
                Console.Write(" ");
            }
            #endregion
            #region lvl2-13
            Console.WriteLine("Введите размер массива");
            int vb;
            int.TryParse(Console.ReadLine(), out vb);
            int[] mm10 = new int[vb];
            for (int i = 0; i < vb; i++)
            {
                Console.WriteLine($"Введите {i} элемент массива");
                int c;
                int.TryParse(Console.ReadLine(), out c);
                mm10[i] = c;
            }
            int maxmm10 = 0;
            int indexmm10 = 0;
            for (int i = 0; i < vb; i++)
            {
                if (i / 2 != 0)
                {
                    if (mm10[i] > maxmm10)
                    {
                        maxmm10 = mm10[i];
                        indexmm10 = i;
                    }
                }
            }
            for (int i = indexmm10; i < vb; i++)
            {
                mm10[i] = i;
                break;
            }
            foreach (int i in mm10)
            {
                Console.Write(i);
                Console.Write(" ");
            }
            #endregion
            #region lvl2-15
            double[] fred = new double[8] { -11, 7, -4, -2, 8, 9, -11, -10 };
            double[] fred2 = new double[3] { 2, -4, 9 };
            int q = 0;
            double[] fred3 = new double[fred.Length + fred2.Length];
            if (int.TryParse(Console.ReadLine(), out int t) && t >= 0)
            {
                for (int i = 0; i < t + 1; i++)
                {
                    fred3[i] = fred[i];
                    Console.WriteLine(fred3[i]);
                }
                for (int je = t + 1; je < t + 1 + fred2.Length; je++)
                {
                    fred3[je] = fred2[q];
                    Console.WriteLine(fred3[je]);
                    q++;
                }
                q = t + 1;
                for (int ke = t + 1 + fred2.Length; ke < fred3.Length; ke++)
                {
                    fred3[ke] = fred[q];
                    Console.WriteLine(fred3[ke]);
                    q++;
                }
            }
            #endregion
            #region lvl3-1
            int n;
            int.TryParse(Console.ReadLine(), out n);
            double[] JJ = new double[n];
            double[] JJa = new double[n];
            double maxxxxqwe = -1000000000;
            int kx = 0;
            for (int i = 0; i < n; i++)
            {
                double x;
                double.TryParse(Console.ReadLine(), out x);
                JJ[i] = x;
                if (x > maxxxxqwe)
                {
                    maxxxxqwe = x;
                    kx = 0;
                    JJa[kx] = i;
                }
                else if (x == maxxxxqwe)
                {
                    kx++;
                    JJa[kx] = i;
                }
            }
            for (int i = 0; i<=kx; i++)
            {
                Console.Write(JJa[i]);
                Console.Write(" ");
            }
            #endregion
            #region lvl3-5
            Console.WriteLine("Введите размер массива");
            int nz = 0;
            int.TryParse(Console.ReadLine(), out nz);
            double[] mm12 = new double[nz];
            Console.WriteLine("Введите элементы массива");
            for (int i = 0; i < nz; i++)
            {
               double x = 0;
               double.TryParse(Console.ReadLine(), out x);
               mm12[i] = x;
            }
            for (int i = 0; i < nz - 2; i = i + 2)
            {

              for (int z = i + 2; z < nz - 1; z = z + 2)
              {
                 if (mm12[j] > mm12[i])
                 {
                   double x = mm12[i];
                   mm12[z] = mm12[j];
                   mm12[z] = x;
                 }
              }

            }
            foreach (double x in mm12)
            {
               Console.Write(x);
               Console.Write(" ");
            }
            #endregion
            #region lvl3-8
            int nA = 0;
            Console.WriteLine("Введите размер массива");
            int.TryParse(Console.ReadLine(), out nA);
            double[] mm11 = new double[nA];
            Console.WriteLine("Введите элементы массива");
            for (int i = 0; i < nA; i++)
            {
               double xa = 0;
               double.TryParse(Console.ReadLine(), out xa);
               mm11[i] = xa;
            }
            for (int i = 0; i < nA - 1; i++)
            {
               for (int ja = i + 1; ja < nA; ja++)
               {
                   if (mm11[i] < 0 && mm11[ja] < 0)
                   {
                      if (mm11[i] < mm11[ja])
                      {
                           double x = mm11[i];
                           mm11[i] = mm11[ja];
                           mm11[ja] = x;

                      }
                   }
               }
            }
            foreach (double x in mm11)
            {    Console.Write(x);
                Console.Write(" ");
            }
            #endregion
            #region lvl3-9
            int[] dad = new int[15] {1, 2, 3, 4, 0, -2, 3, 4, 4, 6, 3, 1, -1, -3, 3};
            int k = 1;
            int k2 = 1;
            for (int i = 0; i < dad.Length - 1; i++)
            { 
                if (dad[i] < dad[i + 1])
                { 
                 k2 += 1;
                }
                if (dad[i] > dad[i + 1])
                {
                k += 1;
                }
                if (dad[i] == dad[i + 1])
                {
                    k = 1;
                    k2 = 1;
                }
            }
            if (k > k2)
            {
                Console.WriteLine(k);
            }
            else
            {
                Console.WriteLine(k2);
            }
            #endregion
            #region lvl3-12
            int n = 12;
            double[] awe = new double[n];
            for (int i = 0; i < n; i++)
            {
                double x;
                double.TryParse(Console.ReadLine(), out x);
                awe[i] = x;
            }
            
            for (int i = 0; i < n; i++)
            {
                if (awe[i] < 0)
                {
                    for (int h = i; h < n - 1; h++)
                    {
                        awe[h] = awe[h + 1];

                    }
                    n--;
                    i--;
                }
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write(awe[i]);
                Console.Write(" ");
            }
             #endregion
            #region lvl3-13
            int n15 = 0;
            Console.WriteLine("Введите размер массива");
            int.TryParse(Console.ReadLine(), out n15);
            double[] mm15 = new double[n15];
            Console.WriteLine("Введите элементы массива");
            for (int i = 0; i < n15; i++)
            {
              double x = 0;
              double.TryParse(Console.ReadLine(), out x);
              mm15[i] = x;
            }
            double c15 = 0;
            for (int i = 0; i < n15 - 1; i++)
            {
               for (int j15 = i + 1; j15 < n15; j15++)
               {
                  if (mm15[i] == mm15[j15])
                  {
                    mm15[j15] = 0;
                    c15++;
                  }
               }

                  if (c15 > 0) mm15[i] = 0;
                    c15 = 0;
            }
            for (int i = 0; i < n15; i++) 
            {
            Console.Write(mm15[i] + " ");
            }
            Console.WriteLine();
            #endregion
            #region Extra
            #region 11
            double[] aaa = new double[0];
            string arr = Console.ReadLine();
            int co = 0;
            int fl = 0;
            while(arr != "")
            {
                Array.Resize(ref aaa, aaa.Length + 1);
                aaa[co] = Convert.ToDouble(arr);
                arr = Console.ReadLine();
                co++;
            }

            Array.Sort(aaa);
            Console.WriteLine("Введите искомое число");
            double un = Convert.ToDouble(Console.ReadLine());

            int left = 0, right = co;
            if (aaa[left] == un)
            {
                Console.WriteLine("Индекс искомого числа - " + left);
                fl++ ;
            }
            else
            {
                while ((left + 1 != right) && (left != right))
                {
                    if (aaa[(left + right) / 2] < un)
                    {
                        left = (left + right) / 2;
                    }
                    else
                    {
                        if (aaa[(left + right) / 2] > un)
                        {
                            right = (left + right) / 2;
                        }
                        else
                        {
                            Console.WriteLine("Индекс искомого числа - " + ((left + right) / 2));
                            fl++;
                            break;
                        }
                    }
                }
            }

            if(fl == 0)
            {
                Console.WriteLine("Такого числа нет в массиве");
            }


            #endregion
            #region 12
            int size = 0;
            int sizeB = 0;

            double[] arr = new double[size];
            double[] arr_B = new double[sizeB];
            Console.WriteLine("Введите массив А");
            string zex = Console.ReadLine();

            while (zex != "")
            {
                Array.Resize(ref arr, size + 1);
                arr[size] = Convert.ToDouble(zex);
                size++;
                zex = Console.ReadLine();
            }

            Console.WriteLine("Введите массив B");
            string zexb = Console.ReadLine();

            while (zexb != "")
            {
                Array.Resize(ref arr_B, sizeB + 1);
                arr_B[sizeB] = Convert.ToDouble(zexb);
                sizeB++;
                zexb = Console.ReadLine();
            }

            double[] arr_C = new double[size + sizeB];
            if (size > sizeB) {

                for(int i = 0; i < sizeB * 2; i++)
                {
                    if(i % 2 == 0)
                    {
                        arr_C[i] = arr[i / 2];
                    }
                    else
                    {
                        arr_C[i] = arr_B[i / 2];
                    }
                }

                for (int i = sizeB; i < size; i++)
                {
                    arr_C[i + sizeB] = arr[i];  
                }

            }
            else
            {

                for (int i = size; i < sizeB; i++)
                {
                    arr_C[i + size] = arr_B[i];
                }

            }


            for (int i = 0; i < arr_C.Length; i++)
            {
                Console.Write(arr_C[i] + " ");
            }

            #endregion
            #region 13
            int sizeS = 0;
            int sizeSB = 0;
            double[] YYY = new double[sizeS];
            double[] UUU = new double[sizeSB];
            Console.WriteLine("Введите массив А");
            string arr_A_2_i = Console.ReadLine();

            while (arr_A_2_i != "")
            {
                Array.Resize(ref YYY, YYY.Length + 1);
                YYY[sizeS] = Convert.ToDouble(arr_A_2_i);
                sizeS++;
                arr_A_2_i = Console.ReadLine();
            }

            Console.WriteLine("Введите массив В");
            string arr_B_2_i = Console.ReadLine();

            while (arr_B_2_i != "")
            {
                Array.Resize(ref UUU, UUU.Length + 1);
                UUU[sizeSB] = Convert.ToDouble(arr_B_2_i);
                sizeSB++;
                arr_B_2_i = Console.ReadLine();
            }

            Array.Sort(YYY);
            Array.Reverse(YYY);

            Array.Sort(UUU);
            Array.Reverse(UUU);

            double[] arr_C_2 = new double[sizeS + sizeSB];
            sizeS = 0;
            sizeSB = 0;

            for(int i = 0; i < arr_C_2.Length; i++)
            {
                if(sizeS < YYY.Length)
                {
                    if(sizeSB < UUU.Length)
                    {
                        if(YYY[sizeS] > UUU[sizeSB])
                        {
                            arr_C_2[i] = YYY[sizeS];
                            sizeS++;
                        }
                        else
                        {
                            arr_C_2[i] = UUU[sizeSB];
                            sizeSB++;
                        }
                    }
                    else
                    {
                        arr_C_2[i] = YYY[sizeS];
                        sizeS++;
                    }
                }
                else
                {
                    arr_C_2[i] = UUU[sizeSB];
                    sizeSB++;
                }
            }

            for(int i = 0; i < arr_C_2.Length; i++)
            {
                Console.Write(arr_C_2[i] + " ");
            }
            #endregion
            #region 14
            double[] ggg = new double[0];
            int count22 = 0;
            string ggga = Console.ReadLine();

            while(ggga != "")
            {
                Array.Resize(ref ggg, ggg.Length + 1);
                ggg[count22] = Convert.ToDouble(ggga); 
                count22++;
                ggga = Console.ReadLine();
            }

            double mid_num1;

            for(int i = 0; i < ggg.Length / 2; i++)
            {
                mid_num1 = ggg[i];
                ggg[i] = ggg[ggg.Length - i - 1];
                ggg[ggg.Length - i - 1] = mid_num1;
            }

            for(int i = 0; i < ggg.Length; i++)
            {
                Console.Write(ggg[i] + " ");
            }

            #endregion
            #region  15
            double[] hhh = new double[0];
            int count23 = 0;
            Console.WriteLine("Введите массив");
            string hhha = Console.ReadLine();

            while (hhha != "")
            {
                Array.Resize(ref hhh, hhh.Length + 1);
                hhh[count23] = Convert.ToDouble(hhha);
                count23++;
                hhha = Console.ReadLine();
            }

            Console.WriteLine("Введите колличество сдвигов");
            int m2 = Convert.ToInt32(Console.ReadLine());

            double mid_num2;

            for(int i = 0; i < m2; i++)
            {
                mid_num2 = hhh[hhh.Length - 1];
                for(int j = hhh.Length - 1; j > 0; j--)
                {
                    hhh[j] = hhh[j - 1];
                }
                hhh[0] = mid_num2;
            }

            foreach(double i in hhh)
            {
                Console.Write(i + " ");
            }
            #endregion
            #endregion
        }
    }
}

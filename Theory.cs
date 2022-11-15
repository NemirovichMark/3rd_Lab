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
            #region lvl3-1
            int[] JJ = { 1, 3, 6, 6, 5, 6};
            int maxjj = 0;
            int indexjj = 0;
            int kJJ = 0;
            
            for (int i = 0; i < JJ.Length; i++)
            {
                if (JJ[i] > maxjj)
                {
                    maxjj = JJ[i];
                    kJJ = 0;
                }
                if (JJ[i] == maxjj)
                {
                    kJJ +=1;
                }
                
            }
            int kaa = 0;
            int[] sad = new int[kJJ];
            for (int i = 0; i < JJ.Length; i++)
            {
                if (JJ[i] == maxjj)
                {
                    
                    sad[kaa] = i;
                    kaa += 1;
                }
            }

            foreach (int i in sad)
            {
                Console.Write(i);
                Console.Write(' ');
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
            int n = 0;
            Console.WriteLine("Введите длину массива");
            int.TryParse(Console.ReadLine(), out n);
            double[] mm13 = new double[n];
            Console.WriteLine("Введите элементы массива");
            for (int i = 0; i < n; i++)
            {
                double x = 0;
                double.TryParse(Console.ReadLine(), out x);
                mm13[i] = x;
            }
            int coun = 0, max1 = 1, max2 = 1;
            for (int i = 0; i < n - 1; i++)
            {
               if (mm13[i] > mm13[i + 1])
               {
                 coun++;
                 max1 = Math.Max(max1, coun);
               }
               else
               {

                    coun = 0;
               }
            }
            for (int i = 0; i < n - 1; i++)
            {
               if (mm13[i] < mm13[i + 1])
               {
                 coun++;
                 max2 = Math.Max(max2, coun);

               }
               else
               {
                    coun = 0;
               }
            }
            Console.WriteLine(Math.Max(max1, max2));
            #endregion
            #region lvl3-12
            int n14 = 6;
            double[] mm14 = new double[n14];
            Console.WriteLine("Введите элементы массива");
            for (int i = 0; i < n14; i++)
            {
              double x = 0;
              double.TryParse(Console.ReadLine(), out x);
              mm14[i] = x;
            }
            for (int i = 0; i < n14; i++)
            {
               if (mm14[i] < 0) mm14[i] = 0;
            }
                
             for (int i = 0; i < n14; i++)
             {
                if (mm14[i] != 0) Console.Write(mm14[i] + " ");
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
            {
                int[] fad = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
                int xE = 0;
                int sE = 0;
                int eE = fad.Length - 1;
                int siE = 0;
                if (int.TryParse(Console.ReadLine(), out xE))
                {
                    while (eE - sE >= 1)
                    {
                        siE = (eE + sE) / 2;
                        if (fad[siE] == xE)
                        {
                            Console.WriteLine($"id = {siE}");
                            break;
                        }
                        else if (xE < fad[siE])
                        {
                            eE = siE;
                        }
                        else if (xE > fad[siE])
                        {
                            sE = siE;
                        }
                    }
                }
            }
            #endregion
            #region 12
            {
                int nE2 = 0;
                int.TryParse(Console.ReadLine(), out nE2);
                int zE2 = 0;
                int.TryParse(Console.ReadLine(), out zE2);
                double[] DAD = new double[nE2];
                double[] DAD2 = new double[zE2];
                double[] DAD3 = new double[nE2 + zE2];
                for (int i = 0; i < nE2; i++)
                {
                    double x = 0;
                    double.TryParse(Console.ReadLine(), out x);
                    DAD[i] = x;
                }
                for (int i = 0; i < zE2; i++)
                {
                    double q = 0;
                    double.TryParse(Console.ReadLine(), out q);
                    DAD2[i] = q;
                }
                
                int counter_Arr = 0, counter_Brr = 0;
                for (int i = 0; i < 2*Math.Min(nE2, zE2); i++)
                {
                    if (i % 2 == 0)
                    {
                        if (counter_Arr < nE2)
                        {
                            DAD3[i] = DAD[counter_Arr];
                            counter_Arr++;
                        }
                        else break;
                    }
                    if (i%2!=0)
                    {
                        DAD3[i] = DAD2[counter_Brr];
                        counter_Brr++;
                    }                       
                }
                for (int i = 2 * Math.Min(nE2, zE2); i<nE2+zE2;i++)
                {
                    if (nE2 != Math.Min(nE2, zE2))
                    {
                        for (int jf = 2*Math.Min(nE2, zE2); jf < (zE2 + nE2); jf++)
                        {
                            DAD3[jf] = DAD[counter_Arr];
                            counter_Arr++;
                        }
                    }
                    else
                    {
                        
                        for (int jf = 2*Math.Min(nE2, zE2)+1; jf < (zE2 + nE2)-1; jf++)
                        {
                            DAD3[jf] = DAD2[counter_Brr++];
                            counter_Brr++;
                        }
                    }
                }
                foreach (double x in DAD3) 
                    Console.Write(x + " ");
                Console.WriteLine();
            }
            #endregion
            #region 13
            {
                int nE3 = 0;
                int zE3 = 0;
                int.TryParse(Console.ReadLine(), out nE3);
                int.TryParse(Console.ReadLine(), out zE3);
                double[] DAD4 = new double[nE3];
                double[] DAD5 = new double[zE3];
                for (int i = 0; i < nE3; i++)
                {
                    double x;
                    double.TryParse(Console.ReadLine(), out x);
                    DAD4[i] = x;
                }
                for (int i = 0; i < zE3; i++)
                {
                    double x;
                    double.TryParse(Console.ReadLine(), out x);
                    DAD4[i] = x;
                }

                Array.Sort(DAD4);
                Array.Reverse(DAD4);

                Array.Sort(DAD5);
                Array.Reverse(DAD5);

                double[] DAD6 = new double[nE3 + zE3];
                nE3 = 0;
                zE3 = 0;

                for (int i = 0; i < DAD6.Length; i++)
                {
                    if (nE3 < DAD4.Length)
                    {
                        if (zE3 < DAD5.Length)
                        {
                            if (DAD4[nE3] > DAD5[zE3])
                            {
                                DAD6[i] = DAD5[nE3];
                                nE3++;
                            }
                            else
                            {
                                DAD6[i] = DAD5[zE3];
                                zE3++;
                            }
                        }
                        else
                        {
                            DAD6[i] = DAD4[nE3];
                            nE3++;
                        }
                    }
                    else
                    {
                        DAD6[i] = DAD5[zE3];
                        nE3++;
                    }
                }

                for (int i = 0; i < DAD6.Length; i++) 
                {
                    Console.Write(DAD6[i] + " ");
                }

            }
            #endregion
            #region 14
            { 
                int n16;
                int.TryParse(Console.ReadLine(), out n16);
                double[] DAD7 = new double[n16];
                for (int i = 0; i < n16; i++)
                {
                    double x = 0;
                    double.TryParse(Console.ReadLine(), out x);
                    DAD7[i] = x;
                }
                double DAD7A;
                for (int i = 0; i < n16 / 2; i++)
                {
                    DAD7A = DAD7[i];
                    DAD7[i] = DAD7[n16 - i - 1];
                    DAD7[n16 - i - 1] = DAD7A;
                }
                foreach (double x in DAD7) 
                    Console.Write(x + " ");
            }
            #endregion
            #region  15
            {
                int n18;
                int.TryParse(Console.ReadLine(), out n18);
                double[] DAD10 = new double[n18];
                for (int i = 0; i < n18; i++)
                {
                    double x;
                    double.TryParse(Console.ReadLine(), out x);
                    DAD10[i] = x;
                }
                Console.WriteLine("Enter m");
                double SD1, SD2;
                double.TryParse(Console.ReadLine(), out SD2);
                for (int i = 0; i < SD2; i++)
                {
                    SD1 = DAD10[n18 - 1 - i];

                    for (int jn = n18 - 2; jn >= 0; jn--)
                    {
                        DAD10[jn + 1] = DAD10[jn];
                    }
                    DAD10[i] = SD1;
                }
                for (int i = 0; i < n18; i++) 
                    Console.Write(DAD10[i] + " ");
            }
            #endregion
            #endregion
        }
    }
}

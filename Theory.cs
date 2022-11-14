static void Printing(double[] arr) { for (int i = 0; i < arr.Length; i++) Console.Write($"{arr[i]} "); }
static void Printing_For_Int(int[] arr) { for (int i = 0; i < arr.Length; i++) Console.Write($"{arr[i]} "); }
static void Printing_List(List<double> arr) { for (int i = 0; i < arr.Count; i++) Console.Write($"{arr[i]} "); }

//Firstly, I have written several methods to output various data structures
//Secondly, I didn't quite understand whether it is acceptable to use different data structures. 
//Therefore, I did the first and second levels using only arrays. In the third, I also used lists to simplify the task

#region Sixth_Task_Level_1
            int[] Nums = { 4, 11, 7, 5, 6 };
            int sum = 0;
            for(int i = 0; i<=4; i++)
            {
                sum += Nums[i] * Nums[i];
            }
            Console.WriteLine(Math.Sqrt(sum));
            #endregion
#region Tenth_Task_Level_1

            double[] Nums = { 4, -11, -7.6, 5.1, -6, 0, 20.17, 10, -8, -3.8 };
            double P = -3;
            double Q = 10;
            int sum = 0;
            int point = 0;

            for(int i = 0; i<=6; i++) if ((Nums[i] > P)&&(Nums[i] < Q)) sum += 1;

            double[] Final_Nums = new double[sum];

            for (int i = 0; i<=6; i++) if ((Nums[i] > P) && (Nums[i] < Q))
                {
                    Final_Nums[point] = Nums[i];
                    point += 1;
                }
            Printing(Final_Nums);
            #endregion
#region Eleventh_Task_Level_1

            double[] Nums = { 4, -11, -7.6, 5.1, -6, 0, 20.17, 10, -8, -3.8};
            int sum = 0;
            int point = 0;

            for(int i = 0; i<=6; i++) if (Nums[i] > 0) sum += 1;

            double[] Final_Nums = new double[sum];

            for (int i = 0; i<=6; i++) if (Nums[i] > 0)
                {
                    Final_Nums[point] = Nums[i];
                    point += 1;
                }
            

            Printing(Final_Nums);

            #endregion
#region Twelfth_Task_Level_1

            double[] Nums = { 4, -11, -7.6, 5.1, -6, 0, 20.17, 10};
            double Answer = 0;
            int point = -1;

            for (int i = 0; i <= 6; i++) if (Nums[i] < 0) { Answer = Nums[i]; point = i; }

            if (point == -1) Console.WriteLine("There is no positive number");
            else Console.WriteLine($"Значение равно {Answer}, номер в списке равен {point + 1}");
            #endregion
#region Thirteenth_Task_Level_1

            double[] Nums = { 4, -11, -7.6, 5.1, -6, 0, 20.17, 10};
            double[] Chet_Nums = new double[5];
            double[] NeChet_Nums = new double[5];
            int Chet_Point = 0;
            int NeChet_Point = 0;

            for (int i = 0; i <= 6; i++) if (i % 2 == 0)
                {
                    Chet_Nums[Chet_Point] = Nums[i];
                    Chet_Point += 1;
                }
                else
                {
                    NeChet_Nums[NeChet_Point] = Nums[i];
                    NeChet_Point += 1;
                }
            Printing(Chet_Nums);
            Console.WriteLine("\n");
            Printing(NeChet_Nums);
            #endregion

#region Fifth_Task_Level_2


            int[] Nums = { 4, 11, 7, -5, -6, -2, 1, -20, 4, 1 };
            int Maxi = Nums[0];
            int Mini = Nums[0];
            int Maxi_point = 0;
            int Mini_point = 0;

            for (int i = 0; i < Nums.Length; i++)
            {
                if (Nums[i] > Maxi) { Maxi = Nums[i]; Maxi_point = i; }
                if (Nums[i] < Mini) { Mini = Nums[i]; Mini_point = i; }
            }

            if (Mini_point > Maxi_point)
            {
                int Cache = Maxi_point;
                Maxi_point = Mini_point;
                Mini_point = Cache;
            }

            int sum = 0;

            for (int i = Mini_point + 1; i < Maxi_point; i++) if (Nums[i] < 0) sum += 1;

            int[] Final_Nums = new int[sum];
            int counter = 0;

            for (int i = Mini_point + 1; i < Maxi_point; i++) if (Nums[i] < 0) { Final_Nums[counter] = Nums[i]; counter += 1; }

            Printing_For_Int(Final_Nums);
            #endregion
#region Sixth_Task_Level_2

            double[] Nums = { 4, 11, 7, -5, -6, -2, 1, -20, 4, 1 };
            double[] Final_Nums = new double[Nums.Length + 1];
            double P = 241;
            int Point = 0;
            double Diff = 0;
            double Average_Value = 0;

            for (int i = 0; i < Nums.Length; i++) Average_Value += Nums[i];
            
            for (int i = 0; i < Nums.Length; i++) if(Math.Abs(Nums[i] - P) < Diff) { Diff = Math.Abs(Nums[i] - P); Point = i; }
            
            for (int i = 0; i < Nums.Length; i++)
            {
                if (i == Point)
                {
                    Final_Nums[i] = Nums[i];
                    Final_Nums[i + 1] = P;
                } else if (i > Point) Final_Nums[i + 1] = Nums[i];
                else Final_Nums[i] = Nums[i];
            }

            Printing(Final_Nums);
            #endregion
#region Ninth_Task_Level_2

            double[] Nums = { 4, 11, 7, -5, -6, -2, 1, -20, 4, 1 };
            double Average_Value = 0;
            double Maxi = Nums[0];
            double Mini = Nums[0];
            int Maxi_point = 0;
            int Mini_point = 0;

            for (int i = 0; i < Nums.Length; i++)
            {
                if (Nums[i] > Maxi) { Maxi = Nums[i]; Maxi_point = i; }
                if (Nums[i] < Mini) { Mini = Nums[i]; Mini_point = i; }
            }

            if (Mini_point > Maxi_point)
            {
                int Cache = Maxi_point;
                Maxi_point = Mini_point;
                Mini_point = Cache;
            }

            for (int i = Mini_point+1; i < Maxi_point; i++) Average_Value += Nums[i];

            Console.WriteLine(Average_Value / (Maxi_point - Mini_point - 1));
            #endregion
#region Tenth_Task_Level_2

            double[] Nums = { 4, 11, 7, -5, -6, -2, 1, -20, 4, 1 };
            double[] Final_Nums = new double[Nums.Length - 1];
            double Mini = Nums[0];
            int Mini_point = 0;

            for (int i = 0; i < Nums.Length; i++) if ((Nums[i] < Mini)&&(Nums[i]>0)) { Mini = Nums[i]; Mini_point = i; }

            for (int i = 0; i < Nums.Length; i++)
            {
                if (i == Mini_point) continue;

                if (i < Mini_point) Final_Nums[i] = Nums[i];
                else if (i > Mini_point) Final_Nums[i - 1] = Nums[i];
            }

            Printing(Final_Nums);
            #endregion
#region Eleventh_Task_Level_2

            double[] Nums = { 4, 11, 7, -5, -6, -2, 1, -20, 4, 1 };
            double[] Final_Nums = new double[Nums.Length + 1];
            double P = 181;
            int Point = 0;

            for (int i = 0; i < Nums.Length; i++) if (Nums[i] > 0) Point = i;

            for (int i = 0; i < Nums.Length; i++)
            {
                if (i < Point) Final_Nums[i] = Nums[i];
                else if (i > Point) Final_Nums[i + 1] = Nums[i];
                else
                {
                    Final_Nums[i] = Nums[i];
                    Final_Nums[i+1] = P;
                }
            }

            Printing(Final_Nums);
            #endregion
#region Thirteenth_Task_Level_2

            double[] Nums = { 4, 11, 7, -5, -6, -2, 1, -20, 4, 1 };
            double Maxi = Nums[0];
            int Maxi_Point = 0;

            for (int i = 0; i < Nums.Length; i+=2) if (Nums[i] > Maxi) { Maxi_Point = i; Maxi = Nums[i]; }

            Nums[Maxi_Point] = Maxi_Point;
            Printing(Nums);
            #endregion
#region Fifteenth_Task_Level_2

            double[] A = { 4, 11, 7, -5, -6, -2, 1, -20, 4, 1 };
            double[] B = { 4, 11, 7, -5, -6, -2, 1, -20, 4, 1 };
            double[] Final_Nums = new double[A.Length + B.Length];
            int counter = 0;

            for (int i = 0; i < A.Length + B.Length; i += 2)
            {
                Final_Nums[i] = A[counter];
                Final_Nums[i + 1] = B[counter];
                counter += 1;
            }

            Printing(Final_Nums);
            #endregion

#region First_Task_Level_3

            double[] Nums = { 4, 11, 7, -5, -6, 11, 11, -2, 1, -20, 4, 1 };

            List<double> Final_Nums = new List<double>();
            double Maxi = Nums[0];

            for (int i = 0; i < Nums.Length; i += 1)
            {
                if (Nums[i] > Maxi)
                {
                    Final_Nums.Clear();
                    Final_Nums.Add(i);
                    Maxi = Nums[i];
                }
                else if (Nums[i] == Maxi)
                {
                    Final_Nums.Add(i);
                }
            }
            Printing_List(Final_Nums);
            #endregion
#region Fifth_Task_Level_3

            double[] Nums = { 4, 11, 7, -5, -6, 11, 11, -2, 1, -20, 4, 1 };
            int counter = 0;
            double[] Nums_2 = new double[Nums.Length / 2];


            for (int i = 0; i < Nums.Length; i+=2) { Nums_2[counter] = Nums[i]; counter++; }

            Array.Sort(Nums_2);
            counter = 0;

            for (int i = 0; i < Nums.Length; i+=2) { Nums[i] = Nums_2[counter]; counter++; }

            Printing(Nums);

            #endregion
#region Eighth_Task_Level_3

            double[] Nums = { 4, 11, 7, -5, -6, 11, 11, -2, 1, -20, 4, 1 };
            List<double> Listed_Nums = new List<double>();
            List<int> Listed_Indexes = new List<int>();
            int counter = 0;


            for (int i = 0; i < Nums.Length; i++) if (Nums[i] < 0) { Listed_Nums.Add(Nums[i]); Listed_Indexes.Add(i); }

            Listed_Nums.Sort();
            Listed_Nums.Reverse();

            for(int i = 0; i < Listed_Nums.Count; i++) Nums[Listed_Indexes[i]] = Listed_Nums[i];

            Printing(Nums);

            #endregion
#region Ninth_Task_Level_3

            double[] Nums = { 4, 11, 7, -5, -6, 11, -2, 1, -20, 4, 1 };
            int counter = 0;
            int maxi_counter = 0;

            for(int i = 0; i<Nums.Length-1; i++)
            {

                counter = 2;
                
                if (Nums[i] > Nums[i+1])
                {
                    for (int x = i + 1; x < Nums.Length-1; x++)
                    {
                        if (Nums[x] < Nums[x + 1]) break;
                        counter += 1;
                        if (counter > maxi_counter) maxi_counter = counter;
                    }
                } else if (Nums[i] < Nums[i + 1])
                {
                    for (int x = i + 1; x < Nums.Length - 1; x++)
                    {
                        if (Nums[x] > Nums[x + 1]) break;
                        counter += 1;
                        if (counter > maxi_counter) maxi_counter = counter;
                    }
                    if (counter > maxi_counter) maxi_counter = counter;
                }
            }
            Console.WriteLine(maxi_counter);

            #endregion
#region Twelfth_Task_Level_3

            double[] Nums = { 4, 11, 7, -5, -6, 11, -2, 1, -20, 4, 1, -18};
            List<double> Final_Nums = new List<double>();

            for(int i = 0; i<Nums.Length; i++)
            {
                if (Nums[i] >= 0) Final_Nums.Add(Nums[i]);
            }

            Printing_List(Final_Nums);

            #endregion
#region Thirteenth_Task_Level_3
//It would be appropriate to remember about sets here, but I don't really know how to use them in c#
            double[] Nums = { 4, 11, 7, -5, -6, 11, -2, 1, -20, 4, 1 };
            List<double> Final_Nums = new List<double>();
            bool key = true;

            for(int i = 0; i<Nums.Length; i++)
            {
                key = true;
                foreach (double elem in Final_Nums) if (elem == Nums[i]) key = false;
                if (key == true) Final_Nums.Add(Nums[i]);
            }

            Printing_List(Final_Nums);

            #endregion

// I've done algorithms, which I hadn't done yet
#region Binary_Search
int Indexi = 0;
            double Target = 3;
            double[] Nums = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            int Left_Index = 0;
            int Right_Index = Nums.Length-1;

            while (true)
            {
                Indexi = (Left_Index + Right_Index) / 2;
                if (Target > Nums[Indexi]) Left_Index = Indexi;
                else if (Target < Nums[Indexi]) Right_Index = Indexi;
                    if (Target == Nums[Indexi]) break;
            }

            Console.WriteLine(Indexi);
#endregion
#region Arrays_Merging
double[] A = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            double[] B = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            double[] Final_Nums = new double[A.Length + B.Length];

            for(int i = 0; i < A.Length; i++)
            {
                Final_Nums[2*i] = A[i];
                Final_Nums[2*i + 1] = B[i];
            }

            Printing(Final_Nums);
#endregion
#region Ordered_Arrays_Merging
double[] A = {1, 2, 3, 4, 5, 9, 10};
            double[] B = { 1, 4, 5, 6, 6, 7};
            int A_Point = 0;
            int B_Point = 0;
            double[] Final_Nums = new double[A.Length + B.Length];

            for(int i = 0; i < A.Length+B.Length; i++)
            {
                if (B_Point == B.Length) { Final_Nums[i] = A[A_Point]; A_Point++; }
                else if (A_Point == A.Length) { Final_Nums[i] = B[B_Point]; B_Point++; }
                else if (A[A_Point] <= B[B_Point]) { Final_Nums[i] = A[A_Point]; A_Point++; }
                else { Final_Nums[i] = B[B_Point]; B_Point ++; }
            }

            Printing(Final_Nums);
#endregion
#region Reverse
double[] Nums = {1, 2, 3, 4, 5, 9, 10};
            double Cache = 0;

            for(int i = 0; i < Nums.Length/2; i++)
            {
                Cache = Nums[i];
                Nums[i] = Nums[Nums.Length - i - 1];
                Nums[Nums.Length - i - 1] = Cache;
            }

            Printing(Nums);
#endregion
#region Cyclic shift
double[] Nums = {1, 2, 3, 4, 5, 9, 10};
            double Cache = 0;
            int Shifts = 3;

            while (Shifts != 0)
            {
                Cache = Nums[Nums.Length - 1];
                for (int i = Nums.Length - 1; i > 0; i--) Nums[i] = Nums[i - 1];
                Nums[0] = Cache;

                Shifts--;
            }

            Printing(Nums);
#endregion
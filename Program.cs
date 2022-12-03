using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization.Formatters;

namespace _3rd_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task1_6();
            //Task1_10();
            //Task1_11();
            //Task1_12();
            //Task1_13();
            //Task2_5();
            //Task2_6();
            //Task2_9();
            //Task2_10();
            //Task2_11();
            //Task2_13();
            //Task2_15();
            //Task3_1();
            //Task3_5();
            //Task3_8();
            //Task3_9();
            //Task3_12();
            //Task3_13();
            //First();
            //Task12();
            //Task13_14();
            Task15();
        }

        #region Level1
        #region Task1
        static void Task1_6()
        {
            double[] array = new double[5] { 1, 4, 5, -6, 6 };
            ToolsArray.Fill(array);
            double length = 0;
            foreach (double d in array)
            {
                length += d * d;
            }
            Console.WriteLine($"Length = {Math.Sqrt(length)}");
        }
        #endregion

        #region Task2
        static void Task1_10()
        {
            int.TryParse(Console.ReadLine(), out int firstElement);
            int.TryParse(Console.ReadLine(), out int secondElement);

            int[] array = new int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            ToolsArray.Fill(array);

            int firstIndex = ToolsArray.FindElement(firstElement, array);
            int secondIndex = ToolsArray.FindElement(secondElement, array);

            if (firstIndex == -1 || secondIndex == -1)
            {
                return;
            }
            else
            {
                Console.WriteLine(Math.Abs(firstIndex - secondIndex) - 1);
            }
        }
        #endregion

        #region Task3
        static void Task1_11()
        {
            double[] commonArray = new double[10] { -1, -4, -9, 2, -5, 8, -19, 4, 5, 6 };
            ToolsArray.Fill(commonArray);
            double[] positiveArray = new double[0];

            for (int i = 0; i < commonArray.Length; i++)
            {
                if (commonArray[i] > 0)
                {
                    positiveArray = ToolsArray.Add(positiveArray, commonArray[i]);
                }
            }

            ToolsArray.Print(positiveArray);
        }
        #endregion

        #region Task4
        static void Task1_12()
        {
            double[] array = new double[8] { -1, 2, 3, -54, 5, 9, 10, 1 };
            ToolsArray.Fill(array);

            int index = ToolsArray.FindLast(array, false);
            if (index != -1)
                Console.WriteLine($"{array[index]}, №{index}");
            else
                Console.WriteLine("There is no negative number");

        }
        #endregion

        #region Task5
        static void Task1_13()
        {
            double[] commonArray = new double[10] { 10, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            ToolsArray.Fill(commonArray);
            double[] oddArray = new double[5];
            double[] evenArray = new double[5];

            for (int i = 0; i < commonArray.Length; i++)
            {
                if (i % 2 == 0)
                    evenArray[i % 5] = commonArray[i];
                else
                    oddArray[i % 5] = commonArray[i];
            }

            Console.WriteLine("Even");
            ToolsArray.Print(evenArray);
            Console.WriteLine();

            Console.WriteLine("Odd");
            ToolsArray.Print(oddArray);
        }
        #endregion
        #endregion

        #region Level2
        #region Task2_1
        static void Task2_5()
        {
            double[] array = new double[10] { 1, 2, 3, 4, 100, 3, 45, -5, -9, -49 };
            ToolsArray.Fill(array);
            int firstIndex = ToolsArray.FindMin(array);
            int secondIndex = ToolsArray.FindMax(array);
            if (firstIndex > secondIndex)
            {
                firstIndex = secondIndex + firstIndex;
                secondIndex = firstIndex - secondIndex;
                firstIndex = firstIndex - secondIndex;
            }

            int length = 0;
            for (int i = firstIndex + 1; i < secondIndex; i++)
            {
                if (array[i] < 0)
                {
                    length++;
                }
            }

            double[] subArray = new double[length];
            int index = 0;
            for (int i = firstIndex + 1; i < secondIndex; i++)
            {
                if (array[i] < 0)
                {
                    subArray[index] = array[i];
                    index++;
                }
            }

            ToolsArray.Print(subArray);
        }
        #endregion

        #region Task2_2
        static void Task2_6()
        {
            int n = ToolsArray.InitLength();
            double[] array = new double[n];
            ToolsArray.Fill(array);

            Console.Write("P = ");
            double.TryParse(Console.ReadLine(), out double number);
            int index = GetIndex(array, ToolsArray.AverageSum(array));
            double[] doubles = ToolsArray.Add(array, number, index + 1);
            ToolsArray.Print(doubles);
        }

        static int GetIndex(double[] array, double sum)
        {
            if (array != null)
            {
                int index = 0;
                double distance = GetDistance(array[index], sum);
                for (int i = 1; i < array.Length; i++)
                {
                    double currentDistance = GetDistance(array[i], sum);
                    if (currentDistance < distance)
                    {
                        index = i;
                        distance = currentDistance;
                    }
                }
                return index;
            }
            else
            {
                throw new Exception();
            }
        }

        static double GetDistance(double firstPoint, double secondPoint)
        {
            return Math.Abs(firstPoint - secondPoint);
        }
        #endregion

        #region Task2_3
        static void Task2_9()
        {
            int n = ToolsArray.InitLength();
            double[] array = new double[n];
            ToolsArray.Fill(array);

            int firstIndex = ToolsArray.FindMin(array);
            int secondIndex = ToolsArray.FindMax(array);

            if (firstIndex > secondIndex)
            {
                firstIndex = secondIndex + firstIndex;
                secondIndex = firstIndex - secondIndex;
                firstIndex = firstIndex - secondIndex;
            }

            if (firstIndex - secondIndex != 1)
            {
                double sum = ToolsArray.AverageSum(array, firstIndex, secondIndex);
                Console.WriteLine($"Sum = {sum}");
            }
        }
        #endregion

        #region Task2_4
        static void Task2_10()
        {
            int n = ToolsArray.InitLength();
            double[] array = new double[n];
            ToolsArray.Fill(array);
            double[] doubles = new double[array.Length - 1];
            int index = ToolsArray.FindMin(array, true);

            if (index == -1) return;

            for (int i = 0; i < index; i++)
            {
                doubles[i] = array[i];
            }

            int external = index;
            for (int i = index + 1; i < array.Length; i++)
            {
                doubles[external] = array[i];
                external++;
            }

            ToolsArray.Print(doubles);
        }
        #endregion

        #region Task2_5
        static void Task2_11()
        {
            int n = ToolsArray.InitLength();
            double[] array = new double[n];
            ToolsArray.Fill(array);

            Console.Write("P = ");
            double.TryParse(Console.ReadLine(), out double number);
            int index = ToolsArray.FindLast(array, true);

            if (index == -1) return;

            double[] doubles = ToolsArray.Add(array, number, index + 1);
            ToolsArray.Print(doubles);
        }
        #endregion

        #region Task2_6
        static void Task2_13()
        {
            int n = ToolsArray.InitLength();
            double[] array = new double[n];
            ToolsArray.Fill(array);

            double max = double.MinValue;
            int index = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 == 1) continue;
                if (max < array[i])
                {
                    max = array[i];
                    index = i;
                }
            }
            ToolsArray.Print(array);
            Console.WriteLine();
            array[index] = index;
            ToolsArray.Print(array);
        }
        #endregion

        #region Task2_7
        static void Task2_15()
        {
            int n = ToolsArray.InitLength();
            double[] array = new double[n];
            Console.WriteLine("Fill first array: ");
            ToolsArray.Fill(array);

            int m = ToolsArray.InitLength();
            double[] nested = new double[m];
            Console.WriteLine("Fill second array: ");
            ToolsArray.Fill(nested);

            Console.Write("input k = ");
            int.TryParse(Console.ReadLine(), out int k);

            if (k < -1)
                return;

            array = ToolsArray.Insert(array, nested, k);
            ToolsArray.Print(array);
        }
        #endregion
        #endregion

        #region Level3
        #region Task3_1
        static void Task3_1()
        {
            double epsilon = 0.0001;

            int n = ToolsArray.InitLength();
            double[] array = new double[n];
            Console.WriteLine("Fill array: ");
            ToolsArray.Fill(array);

            int index = ToolsArray.FindMax(array);
            double max = array[index];

            int[] indexes = new int[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (Math.Abs(max - array[i]) <= epsilon)
                    indexes = ToolsArray.Add(indexes, i);
            }

            ToolsArray.Print(indexes);
        }
        #endregion

        #region Task3_2
        static void Task3_5()
        {
            int n = ToolsArray.InitLength();
            double[] array = new double[n];

            for (int i = 0; i < array.Length; i += 2)
            {
                for (int j = 0; j + 2 < array.Length - i; j += 2)
                {
                    if (array[j + 2] < array[j])
                    {
                        double buff = array[j + 2];
                        array[j + 2] = array[j];
                        array[j] = buff;
                    }
                }
            }

            ToolsArray.Print(array);
        }
        #endregion

        #region Task3_3
        static void Task3_8()
        {
            int n = ToolsArray.InitLength();
            double[] array = new double[n];
            ToolsArray.Fill(array);
            double[] negativeNumbers = new double[0];

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    negativeNumbers = ToolsArray.Add(negativeNumbers, array[i]);
                }
            }

            for (int i = 0; i < negativeNumbers.Length; i++)
            {
                for (int j = 0; j + 1 < negativeNumbers.Length - i; j++)
                {
                    if (negativeNumbers[j + 1] > negativeNumbers[j])
                    {
                        double buff = negativeNumbers[j + 1];
                        negativeNumbers[j + 1] = negativeNumbers[j];
                        negativeNumbers[j] = buff;
                    }
                }
            }

            int index = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    array[i] = negativeNumbers[index];
                    index++;
                }
            }
            ToolsArray.Print(array);
        }
        #endregion

        #region Task3_4
        static void Task3_9()
        {
            int n = ToolsArray.InitLength();
            int[] array = new int[n];
            ToolsArray.Fill(array);

            Console.WriteLine("The length of the decreasing or increasing sequence? 0 or 1 (default 1)");
            int.TryParse(Console.ReadLine(), out int answer);
            
            int maxLength = GetLength(array, ref answer);
            string message = answer == 1 ? "increasing" : "decreasing";
            Console.WriteLine($"maximum length of {message} progression = {maxLength}");
        }
        
        static int GetLength(int[] array, ref int answer)
        {
            int maxLength = 0;
            int currentLength = 1;
            if(answer != 1 || answer != 0)
            {
                answer = 1;
            }

            if (answer == 1)
            {
                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (array[i] < array[i + 1])
                        currentLength++;
                    else
                    {
                        maxLength = currentLength > maxLength ? currentLength : maxLength;
                        currentLength = 1;
                    }
                }
            }
            else
            {
                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (array[i] > array[i + 1])
                        currentLength++;
                    else
                    {
                        maxLength = currentLength > maxLength ? currentLength : maxLength;
                        currentLength = 1;
                    }
                }
            }
            return maxLength;
        }
        #endregion

        #region Task3_5
        static void Task3_12()
        {
            double[] array = new double[12] { 8, 6, -3, 1, 3, -5, 7, 0, -1, 23, -412, -42, };
            Console.WriteLine("Fill array: ");
            ToolsArray.Fill(array);

            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j + 1 < array.Length - i; j++)
                {
                    if (array[j + 1] > array[j])
                    {
                        double buff = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = buff;
                    }
                }
            }

            int length = ToolsArray.FindLast(array, true, true);
            double[] doubles = new double[length + 1];
            for (int i = 0; i <= length; i++)
            {
                doubles[i] = array[i];
            }
            ToolsArray.Print(doubles);
        }
        #endregion

        #region Task3_6
        static void Task3_13()
        {
            int n = ToolsArray.InitLength();
            int[] array = new int[n];
            int[] ints = new int[0];

            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j + 1 < array.Length - i; j++)
                {
                    if (array[j + 1] < array[j])
                    {
                        int buff = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = buff;
                    }
                }
            }
            //ToolsArray.Print(array);

            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] != array[i + 1])
                {
                    ints = ToolsArray.Add(ints, array[i]);
                }

                if (i + 1 == array.Length - 1)
                    ints = ToolsArray.Add(ints, array[i + 1]);
            }
            ToolsArray.Print(ints);
        }
        #endregion
        #endregion

        #region Alg
        static void Task11()
        {
            int n = ToolsArray.InitLength();
            int[] array = new int[n];
            ToolsArray.Fill(array);
            ToolsArray.BubbleSort(array);
            ToolsArray.Print(array);
            Console.WriteLine();
            Console.WriteLine($"i = {ToolsArray.BinnarySearch(array, 9)}");
        }

        static void Task12()
        {
            int n = ToolsArray.InitLength();
            int[] array1 = new int[n];
            ToolsArray.Fill(array1);

            int m = ToolsArray.InitLength();
            int[] array2 = new int[m];
            ToolsArray.Fill(array2);

            int[] array3 = new int[n + m];
            Concate(array1, array2, array3);
            ToolsArray.Print(array3);
        }
        
        static void Concate(int[] a, int[] b, int[] c)
        {
            int external = 0;
            for(int i = 0; i < c.Length && external < a.Length; i += 2, external++)
            {
                c[i] = a[external];
            }

            if(a.Length > b.Length)
            {
                external = b.Length;
                for(int i = external * 2; i < c.Length; i++, external++)
                {
                    c[i] = a[external];
                }
            }

            external = 0;
            for(int i = 1; i < c.Length && external < b.Length; i += 2, external++)
            {
                c[i] = b[external];
            }

            if (b.Length > a.Length)
            {
                external = a.Length;
                for (int i = external * 2; i < c.Length; i++, external++)
                {
                    c[i] = b[external];
                }
            }
        }

        static void Task13_14()
        {
            int n = ToolsArray.InitLength();
            int[] array1 = new int[n];
            ToolsArray.Fill(array1);

            ToolsArray.BubbleSort(array1);
            Console.WriteLine("ordered: ");
            ToolsArray.Print(array1);
            ToolsArray.Inverse(array1);
            Console.WriteLine("inverse: ");
            ToolsArray.Print(array1);

            int m = ToolsArray.InitLength();
            int[] array2 = new int[m];
            ToolsArray.Fill(array2);
            ToolsArray.BubbleSort(array2);
            ToolsArray.Inverse(array2);

            int[] final = new int[0];

            int i = 0;
            int j = 0;

            while (i < array1.Length || j < array2.Length)
            {
                if (i >= array1.Length)
                {
                    final = ToolsArray.Add(final, array2[j]);
                    j++;
                    continue;
                }

                if (j >= array2.Length)
                {
                    final = ToolsArray.Add(final, array1[i]);
                    i++;
                    continue;
                }

                if (array1[i] > array2[j])
                {
                    final = ToolsArray.Add(final, array1[i]);
                    i++;
                    continue;
                }

                if (array2[j] > array1[i])
                {
                    final = ToolsArray.Add(final, array2[j]);
                    j++;
                    continue;
                }
            }

            ToolsArray.Print(final);
        }

        static void Task15()
        {
            int n = ToolsArray.InitLength();
            int[] array = new int[n];
            ToolsArray.Fill(array);

            int k = Get();
            for (int i = 1; i <= k; i++)
            {
                int temp = array[array.Length - 1];
                for (int j = array.Length - 1; j >= 1; j--)
                {
                    array[j] = array[j - 1];
                }
                array[0] = temp;
            }
            ToolsArray.Print(array);
        }

        static int Get()
        {
            int n;
            while (true)
            {
                Console.Write("Enter number = ");
                int.TryParse(Console.ReadLine(), out n);
                if (n > 0) break;
            }
            return n;
        }
        #endregion
    }
}

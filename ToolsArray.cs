using System;
using System.Collections.Generic;
using System.Data;
using System.Net;
using System.Runtime.Serialization;
using System.Text;

namespace _3rd_Lab
{
    internal class ToolsArray
    {
        static string message = "Ooops...";

        static void Kill()
        {
            Console.Error.WriteLine(message);
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }

        public static void Print(double[] array)
        {
            if (array == null)
            {
                Kill();
            }

            foreach (var element in array)
            {
                Console.Write($"{element}\t");
            }
        }

        public static void Print(int[] array)
        {
            if (array == null)
            {
                Kill();
            }

            foreach (var element in array)
            {
                Console.Write($"{element}\t");
            }
        }

        public static void Fill(double[] array)
        {
            if (array == null)
            {
                Kill();
            }

            Console.WriteLine("Fill array: ");

            for (int i = 0; i < array.Length; i++)
            {
                double.TryParse(Console.ReadLine(), out double number);
                array[i] = number;
            }
        }

        public static void Fill(int[] array)
        {
            if (array == null)
            {
                Kill();
            }

            Console.WriteLine("Fill array: ");

            for (int i = 0; i < array.Length; i++)
            {
                int.TryParse(Console.ReadLine(), out int number);
                array[i] = number;
            }
        }

        public static int InitLength()
        {
            int n;
            while (true)
            {
                Console.Write("Enter length = ");
                int.TryParse(Console.ReadLine(), out n);
                if (n > 0) break;
            }
            return n;
        }

        #region Search
        /// <summary>
        /// Finding the minimum element of the array
        /// </summary>
        /// <param name="array"></param>
        /// <returns>
        /// index of the minimum element of the array. -1 if the desired element does not exist in this context
        /// </returns>
        /// <exception cref="Exception"></exception>
        public static int FindMin(double[] array)
        {
            if (array == null)
            {
                Kill();
            }

            int index = 0;
            double min = array[index];
            for (int i = 0; i < array.Length; i++)
            {
                if (min > array[i])
                {
                    min = array[i];
                    index = i;
                }
            }
            return index;
        }

        /// <summary>
        /// Finding the minimum element of an array among negative or positive numbers.
        /// </summary>
        /// <param name="array"></param>
        /// <param name="isPositive"></param>
        /// <returns>
        /// index of the minimum element of the array. -1 if the desired element does not exist in this context
        /// </returns>
        /// <exception cref="Exception"></exception>
        public static int FindMin(double[] array, bool isPositive)
        {
            if (array == null)
            {
                Kill();
            }

            int index = -1;
            double min = Double.MaxValue;
            if (isPositive)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] <= 0) continue;

                    if (min > array[i])
                    {
                        index = i;
                        min = array[i];
                    }
                }
            }
            else
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] >= 0) continue;

                    if (min > array[i])
                    {
                        index = i;
                        min = array[i];
                    }
                }
            }
            return index;
        }

        /// <summary>
        /// Finding the maximum array element.
        /// </summary>
        /// <param name="array"></param>
        /// <returns>Returns the index of the maximum element of the array. -1 if the desired element does not exist in this context.</returns>
        /// <exception cref="Exception"></exception>
        public static int FindMax(double[] array)
        {
            if (array == null)
            {
                Kill();
            }

            int index = 0;
            double max = array[index];
            for (int i = 0; i < array.Length; i++)
            {
                if (max < array[i])
                {
                    max = array[i];
                    index = i;
                }
            }
            return index;
        }

        public static int FindElement(int element, int[] array)
        {
            if (array == null)
            {
                Kill();
            }

            int index = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (element == array[i])
                {
                    index = i;
                    break;
                }
            }
            return index;
        }

        public static int FindFirst(double[] array, bool isPositive)
        {
            if (array == null)
            {
                Kill();
            }

            int index = -1;
            if (isPositive)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] <= 0) continue;

                    index = i;
                    return index;
                }
            }
            else
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] >= 0) continue;

                    index = i;
                    return index;
                }
            }

            return index;
        }

        public static int FindLast(double[] array, bool isPositive)
        {
            if (array == null)
            {
                Kill();
            }

            int index = -1;
            if (isPositive)
            {
                for (int i = array.Length - 1; i >= 0; i--)
                {
                    if (array[i] <= 0) continue;

                    index = i;
                    return index;
                }
            }
            else
            {
                for (int i = array.Length - 1; i >= 0; i--)
                {
                    if (array[i] >= 0) continue;

                    index = i;
                    return index;
                }
            }

            return index;
        }

        public static int FindLast(double[] array, bool isPositive, bool include)
        {
            if (array == null)
            {
                Kill();
            }

            int index = -1;
            if (isPositive)
            {
                for (int i = array.Length - 1; i >= 0; i--)
                {
                    if (array[i] < 0) continue;

                    index = i;
                    return index;
                }
            }
            else
            {
                for (int i = array.Length - 1; i >= 0; i--)
                {
                    if (array[i] > 0) continue;

                    index = i;
                    return index;
                }
            }

            return index;
        }

        public static int BinnarySearch(int[] array, int element)
        {
            if (array == null)
            {
                Kill();
            }
            int lowBound = 0;
            int upBound = array.Length - 1;

            int middle = (lowBound + upBound) / 2;

            int sourceIndex = -1;


            while (lowBound <= upBound)
            {
                if (element == array[middle])
                {
                    sourceIndex = middle;
                    return sourceIndex;
                }

                if (element > array[middle])
                {
                    lowBound = middle + 1;
                    middle = (lowBound + upBound) / 2;
                }

                if (element < array[middle])
                {
                    upBound = middle - 1;
                    middle = (lowBound + upBound) / 2;
                }
            }

            return sourceIndex;
        }

        #endregion

        #region Add
        public static double[] Add(double[] array, double element)
        {
            if (array == null)
            {
                Kill();
            }

            double[] doubles = new double[array.Length + 1];
            for (int i = 0; i < array.Length; i++)
            {
                doubles[i] = array[i];
            }
            doubles[doubles.Length - 1] = element;
            return doubles;
        }

        public static int[] Add(int[] array, int element)
        {
            if (array == null)
            {
                Kill();
            }

            int[] ints = new int[array.Length + 1];
            for (int i = 0; i < array.Length; i++)
            {
                ints[i] = array[i];
            }
            ints[ints.Length - 1] = element;
            return ints;
        }

        public static double[] Add(double[] array, double element, int index)
        {
            if (array == null || index >= array.Length + 1)
            {
                Kill();
            }

            double[] buff = new double[array.Length + 1];
            for (int i = 0; i < index; i++)
            {
                buff[i] = array[i];
            }
            buff[index] = element;
            int external = index + 1;
            for (int i = index; i < array.Length; i++)
            {
                buff[external] = array[i];
                external++;
            }

            return buff;
        }

        public static double[] Insert(double[] external, double[] nested, int index)
        {
            if (external == null && nested == null)
            {
                Kill();
            }

            int nestedIndex = 0;
            double[] source = new double[external.Length + nested.Length];
            if (index < external.Length - 1)
            {
                for (int i = 0; i <= index; i++)
                {
                    source[i] = external[i];
                }

                for (int i = index + 1; ; i++)
                {
                    source[i] = nested[nestedIndex];
                    nestedIndex++;
                    if (nestedIndex == nested.Length) break;
                }

                int externalIndex = index + 1;
                for (int i = externalIndex + nestedIndex; i < source.Length; i++)
                {
                    source[i] = external[externalIndex];
                    externalIndex++;
                }
            }
            else
            {
                for (int i = 0; i < external.Length; i++)
                {
                    source[i] = external[i];
                }

                for (int i = external.Length; i < source.Length; i++)
                {
                    source[i] = nested[nestedIndex];
                    nestedIndex++;
                }
            }

            return source;
        }
        #endregion

        #region Sum
        public static double AverageSum(double[] array)
        {
            if (array == null)
            {
                Kill();
            }

            double sum = 0;
            foreach (var element in array)
            {
                sum += element;
            }

            return sum / array.Length;
        }

        public static double AverageSum(double[] array, int lowerBound, int upperBound)
        {
            if (array == null)
            {
                Kill();
            }

            double sum = 0;
            lowerBound++;
            for (int i = lowerBound; i < upperBound; i++)
            {
                sum += array[i];
            }
            return sum / (upperBound - lowerBound);
        }
        #endregion

        #region Sort
        public static void BubbleSort(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if (array[j + 1] < array[j])
                    {
                        int buff = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = buff;
                    }
                }
            }
        }
        #endregion

        public static void Inverse(int[] array)
        {
            int temp;
            for (int i = 0; i < array.Length / 2; i++)
            {
                temp = array[i];
                array[i] = array[array.Length - i - 1];
                array[array.Length - i - 1] = temp;
            }
        }
    }
}

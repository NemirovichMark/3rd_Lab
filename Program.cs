using System;

namespace ConsoleApp1
{
    class Program
    {
        static int Min(int[] args)
        {
            var min = Math.Pow(2, 31);
            var minN = -1;
            for (var i = 0; i < args.Length; i++)
            {
                if (args[i] < min)
                {
                    min = args[i];
                    minN = i;
                }
            }

            return minN;
        }

        static int Max(int[] args)
        {
            var max = Math.Pow(2, 31);
            var maxN = -1;
            for (var i = 0; i < args.Length; i++)
            {
                if (args[i] > max)
                {
                    max = args[i];
                    maxN = i;
                }
            }

            return maxN;
        }

        public static void Main(string[] args)
        {
            #region lvl1_task6

            Console.Write("Coords (max 5): ");
            double l = 0;
            foreach (var s in Console.ReadLine().Split(' '))
            {
                var elem = int.Parse(s);
                l += Math.Pow(elem, 2);
            }

            Console.WriteLine("L: " + Math.Round(Math.Sqrt(l), 3));

            #endregion

            #region lvl1_task10

            var sum = 0;
            Console.Write("Enter P: ");
            var r = int.Parse(Console.ReadLine());
            Console.Write("Enter Q: ");
            var q = int.Parse(Console.ReadLine());
            Console.Write("Input array: ");
            foreach (var s in Console.ReadLine().Split(' '))
            {
                var elem = int.Parse(s);
                if (elem > r && elem < q)
                {
                    sum++;
                }
            }

            Console.WriteLine("(P, Q): " + sum);

            #endregion

            #region lvl1_task11

            Console.Write("Input array: ");
            var i = 0;
            List<int> arr = new List<int>(10);
            foreach (var s in Console.ReadLine().Split(' '))
            {
                var elem = int.Parse(s);
                if (elem > 0)
                {
                    arr.Add(elem);
                }
            }

            Console.Write("Output array: ");
            foreach (var elem in arr)
            {
                Console.Write(elem + " ");
            }

            Console.WriteLine();

            #endregion

            #region lvl1_task12

            var lastNegative = 0;
            var lastNegativeN = 0;
            i = 0;
            Console.Write("Input array: ");
            foreach (var s in Console.ReadLine().Split())
            {
                var elem = int.Parse(s);
                i++;
                if (elem < 0)
                {
                    lastNegative = elem;
                    lastNegativeN = i;
                }
            }

            Console.WriteLine("Last: " + lastNegative + "; N: " + lastNegativeN);

            #endregion

            #region lvl1_task13

            int[] arrEven = new int[10];
            int[] arrOdd = new int[10];
            i = 0;
            Console.Write("Input array: ");
            foreach (var s in Console.ReadLine().Split(' '))
            {
                var elem = Convert.ToInt32(s);
                if (i % 2 == 0)
                {
                    arrEven[i] = elem;
                }
                else
                {
                    arrOdd[i] = elem;
                }

                i++;
            }

            Console.Write("Even nums: ");
            for (i = 0; i < 10; i++)
            {
                if (arrEven[i] != 0)
                {
                    Console.Write(arrEven[i] + " ");
                }
            }

            Console.WriteLine();
            Console.Write("Odd nums: ");
            for (i = 0; i < 10; i++)
            {
                if (arrOdd[i] != 0)
                {
                    Console.Write(arrOdd[i] + " ");
                }
            }

            Console.WriteLine();

            #endregion

            #region lvl2_task5

            var maxN = -1;
            var minN = -1;
            var max = 0;
            double min = Math.Pow(2, 31);
            i = 0;
            Console.Write("Input array: ");
            string[] input = Console.ReadLine().Split(' ');
            int[] array = new int[input.Length];
            foreach (var s in input)
            {
                var elem = int.Parse(s);
                if (elem > max)
                {
                    max = elem;
                    maxN = i;
                }

                if (elem < min)
                {
                    min = elem;
                    minN = i;
                }

                array[i] = elem;
                i++;
            }

            int[] outArr = new int[Math.Abs(maxN - minN)];
            Console.Write("Output array: ");
            var j = 0;
            if (minN < maxN)
            {
                for (i = minN + 1; i < maxN; i++)
                {
                    if (array[i] < 0)
                    {
                        outArr[j] = array[i];
                        j++;
                    }
                }
            }
            else
            {
                for (i = maxN + 1; i < minN; i++)
                {
                    if (arr[i] < 0)
                    {
                        outArr[j] = arr[i];
                        j++;
                    }
                }
            }

            for (i = 0; i < outArr.Length; i++)
            {
                if (outArr[i] != 0)
                {
                    Console.Write(outArr[i] + " ");
                }
            }

            Console.WriteLine();

            #endregion

            #region lvl2_task6

            Console.Write("Input array: ");
            input = Console.ReadLine().Split(' ');
            var n = input.Length;
            List<double> arrDouble = new List<double>(n);
            Console.Write("Enter P: ");
            double mid = 0;
            var p = int.Parse(Console.ReadLine());
            i = 0;
            foreach (var s in input)
            {
                var elem = double.Parse(s);
                arrDouble.Add(elem);
                mid += elem;
            }

            mid /= n;
            var leastN = -1;
            var least = Math.Pow(2, 31);
            for (i = 0; i < n; i++)
            {
                if (arrDouble[i] - mid > 0 && arrDouble[i] - mid < least)
                {
                    least = arrDouble[i] - mid;
                    leastN = i;
                }
            }

            arrDouble.Insert(p, leastN);
            foreach (var elem in arrDouble)
            {
                Console.Write(elem + " ");
            }

            Console.WriteLine();

            #endregion

            #region lvl2_task9

            Console.Write("Input array: ");
            input = Console.ReadLine().Split(' ');
            n = input.Length;
            array = new int[n];
            i = 0;
            foreach (var s in input)
            {
                var elem = int.Parse(s);
                array[i] = elem;
                i++;
            }

            mid = 0;
            max = Max(array);
            min = Min(array);
            var len = Math.Abs(max - min) - 1;
            if (min > max)
            {
                for (i = max + 1; i < min; i++)
                {
                    mid += array[i];
                }
            }
            else
            {
                for (i = 0; i < max; i++)
                {
                    mid += array[i];
                }
            }

            Console.WriteLine("Mid: " + (mid / len));

            #endregion

            #region lvl2_task10

            Console.Write("Input array: ");
            input = Console.ReadLine().Split();
            n = input.Length;
            arr = new List<int>(n);
            foreach (var s in input)
            {
                var elem = int.Parse(s);
                arr.Add(elem);
            }

            min = Math.Pow(2, 31);
            minN = 0;
            for (i = 0; i < n; i++)
            {
                if (arr[i] > 0 && arr[i] < min)
                {
                    min = arr[i];
                    minN = i;
                }
            }

            arr.RemoveAt(minN);
            Console.Write("Output array: ");
            foreach (var elem in arr)
            {
                Console.Write(elem + " ");
            }

            Console.WriteLine();

            #endregion

            #region lvl2_task11

            Console.Write("Input array: ");
            input = Console.ReadLine().Split();
            Console.Write("Enter P: ");
            p = int.Parse(Console.ReadLine());
            n = input.Length;
            arr = new List<int>(n + 1);
            foreach (var s in input)
            {
                var elem = int.Parse(s);
                arr.Add(elem);
            }

            var lastPositiveN = -1;
            for (i = 0; i < n; i++)
            {
                if (arr[i] > 0)
                {
                    lastPositiveN = i + 1;
                }
            }

            arr.Insert(lastPositiveN, p);
            Console.Write("Output array: ");
            foreach (var elem in arr)
            {
                Console.Write(elem + " ");
            }

            Console.WriteLine();

            #endregion

            #region lvl2_task13

            Console.Write("Input array: ");
            input = Console.ReadLine().Split();
            n = input.Length;
            arr = new List<int>(n);
            foreach (var s in input)
            {
                var elem = int.Parse(s);
                arr.Add(elem);
            }

            max = 0;
            maxN = 0;
            for (i = 0; i < n; i++)
            {
                if (i % 2 == 0 && arr[i] > max)
                {
                    max = arr[i];
                    maxN = i;
                }
            }

            arr[maxN] = maxN;
            Console.Write("Output array: ");
            foreach (var elem in arr)
            {
                Console.Write(elem + " ");
            }

            Console.WriteLine();

            #endregion

            #region lvl2_task15

            Console.Write("Input array (A): ");
            var inputA = Console.ReadLine().Split();
            n = inputA.Length;
            Console.Write("Input array (B): ");
            var inputB = Console.ReadLine().Split();
            var m = inputB.Length;
            Console.Write("Enter K: ");
            var k = int.Parse(Console.ReadLine());
            List<int> arrA = new List<int>(n);
            List<int> arrB = new List<int>(m);
            foreach (var s in inputA)
            {
                var elem = int.Parse(s);
                arrA.Add(elem);
            }

            foreach (var s in inputB)
            {
                var elem = int.Parse(s);
                arrB.Add(elem);
            }

            arrA.InsertRange(k + 1, arrB);
            Console.Write("Output array: ");
            foreach (var elem in arrA)
            {
                Console.Write(elem + " ");
            }

            Console.WriteLine();

            #endregion

            #region lvl3_task1

            Console.Write("Input array: ");
            input = Console.ReadLine().Split();
            n = input.Length;
            arr = new List<int>(n);
            foreach (var s in input)
            {
                var elem = int.Parse(s);
                arr.Add(elem);
            }

            var dict = new Dictionary<int, List<int>>();
            var maxKey = 0;
            for (i = 0; i < n; i++)
            {
                if (dict.ContainsKey(arr[i]))
                {
                    dict[arr[i]].Add(i);
                }
                else
                {
                    if (arr[i] > maxKey)
                    {
                        maxKey = arr[i];
                    }

                    dict.Add(arr[i], new List<int> { i });
                }
            }

            Console.Write("Output array: ");
            foreach (var elem in dict[maxKey])
            {
                Console.Write(elem + " ");
            }

            Console.WriteLine();

            #endregion

            #region lvl3_task5

            Console.Write("Input array: ");
            input = Console.ReadLine().Split();
            n = input.Length;
            arr = new List<int>(n);
            foreach (var s in input)
            {
                var elem = int.Parse(s);
                arr.Add(elem);
            }

            for (i = 0; i < n; i += 2)
            {
                for (j = i; j < n; j += 2)
                {
                    if (arr[i] > arr[j])
                    {
                        (arr[i], arr[j]) = (arr[j], arr[i]);
                    }
                }
            }

            foreach (var elem in arr)
            {
                Console.Write(elem + " ");
            }

            Console.WriteLine();

            #endregion

            #region lvl3_task8

            Console.Write("Input array: ");
            input = Console.ReadLine().Split();
            n = input.Length;
            arr = new List<int>(n);
            List<int> negativesN = new List<int>();
            k = 0;
            foreach (var s in input)
            {
                var elem = int.Parse(s);
                arr.Add(elem);
                if (elem < 0)
                {
                    negativesN.Add(k);
                }

                k++;
            }

            for (i = 0; i < negativesN.Capacity - 1; i++)
            {
                for (j = i; j < negativesN.Capacity - 1; j++)
                {
                    if (arr[negativesN[i]] < arr[negativesN[j]])
                    {
                        (arr[negativesN[i]], arr[negativesN[j]]) = (arr[negativesN[j]], arr[negativesN[i]]);
                    }
                }
            }

            Console.WriteLine("Output array: ");
            foreach (var elem in arr)
            {
                Console.Write(elem + " ");
            }

            Console.WriteLine();

            #endregion

            #region lvl3_task9

            Console.Write("Input array: ");
            input = Console.ReadLine().Split();
            n = input.Length;
            arr = new List<int>(n);
            foreach (var s in input)
            {
                var elem = int.Parse(s);
                arr.Add(elem);
            }

            var maxUp = 0;
            var maxDown = 0;
            var up = 1;
            var down = 1;
            for (i = 0; i < n - 1; i++)
            {
                if (arr[i] < arr[i + 1])
                {
                    up++;
                    if (down > maxDown)
                    {
                        maxDown = down;
                    }

                    down = 1;
                }
                else
                {
                    down++;
                    if (up > maxUp)
                    {
                        maxUp = up;
                    }

                    up = 1;
                }
            }

            if (up > maxUp)
            {
                maxUp = up;
            }

            if (down > maxDown)
            {
                maxDown = down;
            }

            if (maxDown > maxUp)
            {
                Console.WriteLine("Answer: " + maxDown);
            }
            else
            {
                Console.WriteLine("Answer: " + maxUp);
            }

            #endregion

            #region lvl3_task12

            Console.Write("Input array: ");
            input = Console.ReadLine().Split();
            n = input.Length;
            arr = new List<int>(n);
            foreach (var s in input)
            {
                var elem = int.Parse(s);
                arr.Add(elem);
            }

            for (i = 0; i < n; i++)
            {
                if (arr[i] < 0)
                {
                    arr.RemoveAt(i);
                    n--;
                }
            }

            Console.Write("Output array: ");
            foreach (var elem in arr)
            {
                Console.Write(elem + " ");
            }

            Console.WriteLine();

            #endregion

            #region lvl3_task12

            Console.Write("Input array: ");
            input = Console.ReadLine().Split();
            n = input.Length;
            arr = new List<int>(n);
            List<int> duplicates = new List<int>();
            foreach (var s in input)
            {
                var elem = int.Parse(s);
                arr.Add(elem);
            }

            for (i = 0; i < n; i++)
            {
                if (duplicates.Contains(arr[i]))
                {
                    arr.RemoveAt(i);
                    n--;
                    i--;
                }
                else
                {
                    duplicates.Add(arr[i]);
                }
            }

            Console.Write("Output array: ");
            foreach (var elem in arr)
            {
                Console.Write(elem + " ");
            }

            #endregion
        }
    }
}

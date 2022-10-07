 #region lvl2Task6
            double minimum = 1000000000000;
            double value = 0;
            int huy = 0;
            Console.WriteLine("Enter count of array values");
            int n = Convert.ToInt32(Console.ReadLine());
            double[] array = new double[n];
            Console.WriteLine("Enter array values");
            for (int i = 0; i<n;i++)
            {
                array[i] = Convert.ToDouble(Console.ReadLine());
            }
            Console.WriteLine("Enter P number");
            double P = Convert.ToDouble(Console.ReadLine());
            double mid = array.Sum() / n;
            for (int i = 0; i < n; i++)
            {
                value = Math.Abs(array[i] - mid);
                if (value < minimum)
                {
                    minimum = value;
                    huy = Array.IndexOf(array,array[i]);
                }
            }
            for (int i = n-2; i >= huy +1;i--)
            {
                array[i + 1] = array[i];
                array[huy + 1] = P;
            }
            Console.WriteLine(String.Join(" ",array));
            #endregion

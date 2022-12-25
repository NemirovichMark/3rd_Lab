using System;
class AddL_12Ex {
  static void Main() {
    double[] a = {1,3};
            double[] b = {2,4,6};
            int k = 0;
            Console.Write("Array a : ");
            Console.WriteLine(string.Join(", ", a));
            Console.Write("Array b: ");
            Console.WriteLine(string.Join(", ", b));
            double [] c = new double[a.Length + b.Length];
            k = a.Length;
            if(a.Length >= b.Length) k = b.Length;
            for(int i = 0; i < k ; i++){
                c[i * 2] = a[i];
                c[i * 2 + 1] = b[i];
            }
            if( a.Length > b.Length ){
                for(int i = k; i < a.Length; i++){
                    c[i + k ] = a[i];
                }
            }else if ( a.Length < b.Length ){
                for(int i = k; i < b.Length; i++){
                    c[i + k ] = b[i];
                }
            }
            Console.Write("New array: ");
            Console.WriteLine(string.Join(", ", c));
  }
}
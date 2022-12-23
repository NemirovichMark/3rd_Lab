using System;
class AddL_12Ex {
  static void Main() {
            const int indexA = 5, indexB = 3;
            int indexC = indexA + indexB;
            double[] a = new double[indexA] { 6, 4, 2, 3, 1 };
            double[] b = new double[indexB] {8, 7, 5 };
            double[] c = new double[indexC];
            int j = 0;
            for(int i = 0; i < indexC; i++){
                if(i < indexA){
                    c[i] = a[i];
                }else{
                    c[i] = b[j]; 
                    j++;
                }
            }
            Array.Sort(c);
            foreach(int elements in c){
                Console.WriteLine(elements);
            }
  }
}
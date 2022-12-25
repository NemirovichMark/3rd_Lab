using System;
class HelloWorld {
static void Main() {
    double[] a = {8, 7, 5, 3, 1};
            double[] b = {6, 4, 2};
            Console.Write("Array a : ");
            Console.WriteLine(string.Join(", ", a));
            Console.Write("Array b: ");
            Console.WriteLine(string.Join(", ", b));
            double [] c = new double[a.Length + b.Length];
            int x = 0, y = 0, z = 0;
            while( x < a.Length && y < b.Length && z < c.Length ){
                if(a[x] >= b[y]){
                    while(a[x] >= b[y]){
                        c[z] = a[x];
                        z++;
                        x++;
                        if(x == a.Length) break;
                    }
                } else if(a[x] <= b[y]){
                    while(a[x] <= b[y]){
                        c[z] = b[y];
                        z++;
                        y++;
                        if(y == b.Length) break;
                    }
                }
            }
            if(a.Length > x){
                for(int i = x; i < a.Length; i++){
                    c[z] = a[i];
                    z++;
                }
            }
            if(b.Length > y){
                for(int i = y; i < c.Length; i++){
                    c[z] = b[i];
                    z++;
                }
            }
            Console.Write("New array: ");
            Console.WriteLine(string.Join(", ", c));
    }
}
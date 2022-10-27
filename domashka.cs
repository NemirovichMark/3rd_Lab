#region 1.6
int[] zxc = new int[5] {0,1,2,3,4}; 
double L=0, s=0; 
for (int i=0; i<=4; i++){ 
    s+=Math.Pow(zxc[i], 2); 
} 
L=Math.Sqrt(s); 
Console.WriteLine(L);
#endregion 
#region 1.10
double[] qwe=new double[10]{0,1,2,3,4,5,6,7,8,9};
Console.WriteLine("Введите значения P и Q");
double P=Convert.ToDouble(Console.ReadLine());
double Q=Convert.ToDouble(Console.ReadLine());
int res=0;
if(P>Q){
    Console.WriteLine("P должно быть меньше Q");
    return;
}
foreach(int i in qwe){
    if(i>P&&i<Q){
        res++;
    }
}
Console.WriteLine(res);
#endregion 
#region 1.11
double[] wp=new double[10]{-10,2,5,4,-22,1,-2,5,-7,1};
List<double>positives=new List<double>(){};
foreach(int i in wp){
    if(Convert.ToString(i)[0]!='-'){
        positives.Add(i);
    }
}
positives.ForEach(Console.WriteLine);
#endregion
#region 1.12
double[] wp=new double[8]{-10,2,5,4,-22,1,-2,5};
List<double>negatives=new List<double>(){};
foreach(int i in wp){
    if(Convert.ToString(i)[0]=='-'){
        negatives.Add(i);
    }
}
Console.WriteLine(negatives.Last());
#endregion
#region 1.13
double[] all=new double[10]{0,1,2,3,4,5,6,7,8,9};
List<double>chetn=new List<double>(){};
List<double>nechetn=new List<double>(){};
for(int i=0;i<10;i++){
    if(all[i]%2==0 && all[i]!=0){
        chetn.Add(all[i]);
    }
    else if(all[i]%2!=0){
        nechetn.Add(all[i]);
    }
}
Console.WriteLine("Числа с четным индексом:");
chetn.ForEach(Console.WriteLine);
Console.WriteLine("Числа с нечетным индексом:");
nechetn.ForEach(Console.WriteLine);
#endregion
#region 2.5
Console.WriteLine("Введите количество элементов массива");
int kolich=Convert.ToInt32(Console.ReadLine());
double max=0,min=0;
List<double>ishodniy=new List<double>(){};
List<double>otricat=new List<double>(){};
for(int i=1;i<=kolich;i++){
    Console.WriteLine($"Введите {i}-ый элемент");
    ishodniy.Add(Convert.ToDouble(Console.ReadLine()));
}
foreach(int i in ishodniy){
    if(i>max){
        max=i;
    }
    if(i<min){
        min=i;
    }
}
foreach(double z in ishodniy){
    if(z>min&&z<max&&z<0){
        otricat.Add(z);
    }
}
Console.WriteLine("Числа в новом массиве:");
otricat.ForEach(Console.WriteLine);
#endregion
#region 2.6 //пофиксить
Console.WriteLine("Введите количество значений в массиве");
int kol=Convert.ToInt32(Console.ReadLine());
int srZnach=0;
List<double>massiv=new List<double>(){};
for(int i=1;i<=kol;i++){
    Console.WriteLine($"Введите {i}-ое значение");
    massiv.Add(Convert.ToDouble(Console.ReadLine()));
}
Console.WriteLine("Введите значение P");
double P=Convert.ToDouble(Console.ReadLine());
for(int i=0;i<kol;i++){
    srZnach++;
}
srZnach/=kol;
List<double>a=new List<double>(){};
for(int i=0;i<kol;i++){
    a.Add(Math.Abs(srZnach-massiv[i]));
}
double min=a.IndexOf(a.Min());
massiv.Insert((Convert.ToInt32(min))+1, P);
Console.WriteLine("Новый массив:");
massiv.ForEach(Console.WriteLine);
#endregion

#region 2.10
Console.WriteLine("Введите количество значений в массиве");
int kol=Convert.ToInt32(Console.ReadLine());
double min=0;
int index_min=0;
List<double>massiv=new List<double>(){};
List<double>positive=new List<double>(){};
for(int i=1;i<=kol;i++){
    Console.WriteLine($"Введите {i}-ое значение");
    massiv.Add(Convert.ToDouble(Console.ReadLine()));
}
foreach(double i in massiv){
    if(Convert.ToString(i)[0]!='-'){
        positive.Add(i);
    }
}
for(int i=0;i<kol;i++){
    if(positive[i]<min){
        min=positive[i];
        index_min=i;
    }
}
positive.RemoveAt(index_min);
Console.WriteLine("Новый массив:");
positive.ForEach(Console.WriteLine);
#endregion
#region 2.11 
Console.WriteLine("Введите количество значений в массиве");
int kol=Convert.ToInt32(Console.ReadLine());
List<double>massiv=new List<double>(){};
for(int i=1;i<=kol;i++){
    Console.WriteLine($"Введите {i}-ое значение");
    massiv.Add(Convert.ToDouble(Console.ReadLine()));
}
Console.WriteLine("Введите значение P");
double P=Convert.ToDouble(Console.ReadLine());

List<double>a=new List<double>(){};
for(int i=0;i<kol;i++){
    if(Convert.ToString(Convert.ToString(massiv[i]))!="-"){
        a.Add(massiv[i]);
    }
}
double last=a.IndexOf(a.Last());
massiv.Insert((Convert.ToInt32(last))+1, P);
Console.WriteLine("Новый массив:");
massiv.ForEach(Console.WriteLine);
#endregion

#region 2.13
Console.WriteLine("Введите количество значений в массиве");
int kol=Convert.ToInt32(Console.ReadLine());
List<double>massiv=new List<double>(){};
for(int i=1;i<=kol;i++){
    Console.WriteLine($"Введите {i}-ое значение");
    massiv.Add(Convert.ToDouble(Console.ReadLine()));
}
for(int l=0; l<kol;l++){
   if(massiv[l]%2==0){
        //Console.WriteLine(massiv.IndexOf(massiv.Max()));
        massiv[massiv.IndexOf(massiv.Max())]=Convert.ToDouble(massiv.IndexOf(massiv.Max()));
   }
}
Console.Write($"Новый массив: \n");
massiv.ForEach(Console.WriteLine);
#endregion
#region 2.15
Console.WriteLine("Введите количество значений в массиве A");
int kolA=Convert.ToInt32(Console.ReadLine());
List<double>A=new List<double>(){};
for(int i=1;i<=kolA;i++){
    Console.WriteLine($"Введите {i}-ое значение");
    A.Add(Convert.ToDouble(Console.ReadLine()));
}

Console.WriteLine("Введите количество значений в массиве B");
int kolB=Convert.ToInt32(Console.ReadLine());
List<double>B=new List<double>(){};
for(int i=1;i<=kolB;i++){
    Console.WriteLine($"Введите {i}-ое значение");
    B.Add(Convert.ToDouble(Console.ReadLine()));
}

Console.WriteLine("Введите k-индекс, куда вставляем массив В");
int k=Convert.ToInt32(Console.ReadLine());
A.InsertRange(Convert.ToInt32(k), B);
A.ForEach(Console.WriteLine);
#endregion
#region 3.1
Console.WriteLine("Введите количество значений в массиве");
int kol=Convert.ToInt32(Console.ReadLine());
List<double>creep=new List<double>(){};
List<double>maxi=new List<double>(){};
for(int i=1;i<=kol;i++){
    Console.WriteLine($"Введите {i}-ое значение");
    creep.Add(Convert.ToDouble(Console.ReadLine()));
}
double max=creep.Max();
for(int i=0;i<kol;i++){
    if(creep[i]==max){
      
        maxi.Add(i);
    }
}
Console.WriteLine("Индексы максимальных значений:");
maxi.ForEach(Console.WriteLine);
#endregion
#region 3.13
Console.WriteLine("Введите количество значений в массиве");
int kol=Convert.ToInt32(Console.ReadLine());
List<double>creep=new List<double>(){};
for(int i=1;i<=kol;i++){
    Console.WriteLine($"Введите {i}-ое значение");
    creep.Add(Convert.ToDouble(Console.ReadLine()));
}
var result = creep.ToArray().Distinct().ToList();
foreach (var item in result){
Console.WriteLine(item);
}
#endregion
#region 3.12
int k=3;
List<double>treep=new List<double>(k){};
for(int i=1;i<=k;i++){
    Console.WriteLine($"Введите {i}-ое значение");
    treep.Add(Convert.ToDouble(Console.ReadLine()));
}
for(int i=0;i<k; i++){
    //Console.WriteLine((Convert.ToString(treep[i]))[0]);
    if(Convert.ToString((Convert.ToString(treep[i]))[0])=="-"){
        treep.RemoveAt(i);
    }
}
Console.WriteLine("Новый массив:");
treep.ForEach(Console.WriteLine);
#endregion
#region 3.5
Console.WriteLine("Введите количество значений в массиве");
int kol=Convert.ToInt32(Console.ReadLine());
List<double>creep=new List<double>(){};
List<double>chetn=new List<double>(){};
for(int i=1;i<=kol;i++){
    Console.WriteLine($"Введите {i}-ое значение");
    creep.Add(Convert.ToDouble(Console.ReadLine()));
}
for(int i=0;i<kol;i++){
    if(i%2==0){
        chetn.Add(creep[i]);
    }
}
chetn.Sort();
int l=0;
for(int y=0;y<kol;y++){ 
    if(y%2==0){
        creep[y]=chetn[l];
        l++;
    }
}
Console.WriteLine("Новый массив:");
creep.ForEach(Console.WriteLine);
#endregion
#region 3.8
Console.WriteLine("Введите количество значений в массиве");
int kol=Convert.ToInt32(Console.ReadLine());
List<double>creep=new List<double>(){};
List<double>otric=new List<double>(){};
for(int i=1;i<=kol;i++){
    Console.WriteLine($"Введите {i}-ое значение");
    creep.Add(Convert.ToDouble(Console.ReadLine()));
}
for(int i=0;i<kol;i++){
    if((Convert.ToString(creep[i]))[0]=='-'){
        otric.Add(creep[i]);
    }
}
otric.Sort();
otric.Reverse();
int l=0;
for(int y=0;y<kol;y++){ 
    if((Convert.ToString(creep[y]))[0]=='-'){
        creep[y]=otric[l];
        l++;
    }
}
Console.WriteLine("Новый массив:");
creep.ForEach(Console.WriteLine);
#endregion
#region 3.9
Console.WriteLine("Введите количество значений в массиве");
int kol=Convert.ToInt32(Console.ReadLine());
List<double>creep=new List<double>(){};
for(int i=1;i<=kol;i++){
    Console.WriteLine($"Введите {i}-ое значение");
    creep.Add(Convert.ToDouble(Console.ReadLine()));
}
int max=0;
int min=0;
for(int i=0;i<kol-1;i++){
    if(creep[i]<creep[i+1]){
        max++;
    }
    if(creep[i]>creep[i+1]){
        min++;
    }
}
if(min>max){
    Console.WriteLine($"Самая большая последовательность:{min}");
}
else{
    Console.WriteLine($"Самая большая последовательность:{max}");
}
#endregion


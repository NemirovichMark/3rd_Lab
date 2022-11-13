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
double P=0,Q=0;
try{
    P=Convert.ToDouble(Console.ReadLine());
    Q=Convert.ToDouble(Console.ReadLine());
}
catch(Exception){
    Console.WriteLine("Ошибка");
}
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
int z=0;

foreach(int i in wp){
    try{
        z=Convert.ToString(i)[0];
    }
    catch(Exception){
        Console.WriteLine("Ошибка");
    }
    if(z!='-'){
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
int kolich=0;
try{
    kolich=Convert.ToInt32(Console.ReadLine());
}
catch(Exception){
    Console.WriteLine("Ошибка");
}
double max=0,min=0;
List<double>ishodniy=new List<double>(){};
List<double>otricat=new List<double>(){};
for(int i=1;i<=kolich;i++){
    try{
        Console.WriteLine($"Введите {i}-ый элемент");
        ishodniy.Add(Convert.ToDouble(Console.ReadLine()));
        }
    catch(Exception){
        Console.WriteLine("Ошибка");
    }
}

for(int i=0;i<kolich;i++){
    if(ishodniy[i]>max){
        max=i;
    }
    if(ishodniy[i]<min){
        min=i;
    }
}
for(int z=0;z<kolich;z++){
    if(((z>min&&z<max)||(z<min&&z>max))&&ishodniy[z]<0){
        otricat.Add(ishodniy[z]);
    }
}
Console.WriteLine("Числа в новом массиве:");
otricat.ForEach(Console.WriteLine);
#endregion
#region 2.10
Console.WriteLine("Введите количество значений в массиве");
int kol=0;
try{
    kol=Convert.ToInt32(Console.ReadLine());
}
catch(Exception){
    Console.WriteLine("Ошибка");
}
double min=0;
int index_min=0,a=0;
List<double>massiv=new List<double>(){};
List<double>positive=new List<double>(){};
for(int i=1;i<=kol;i++){
    Console.WriteLine($"Введите {i}-ое значение");
    try{
        massiv.Add(Convert.ToDouble(Console.ReadLine()));
    }
    catch(Exception){
        Console.WriteLine("Ошибка");
    }
}
foreach(double i in massiv){
    try{
        a=Convert.ToString(i)[0];
    }
    catch(Exception){
        Console.WriteLine("Ошибка");
    }
    if(a!='-'){
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
int kol=0;
double P=0;
try{
    kol=Convert.ToInt32(Console.ReadLine());
}
catch(Exception){
    Console.WriteLine("Ошибка");
}
List<double>massiv=new List<double>(){};
for(int i=1;i<=kol;i++){
    Console.WriteLine($"Введите {i}-ое значение");
    try{
        massiv.Add(Convert.ToDouble(Console.ReadLine()));
    }
    catch(Exception){
        Console.WriteLine("Ошибка");
    }
}
Console.WriteLine("Введите значение P");
try{
    P=Convert.ToDouble(Console.ReadLine());
}
catch(Exception){
    Console.WriteLine("Ошибка");
}
List<double>a=new List<double>(){};
for(int i=0;i<kol;i++){
    try{
        if(Convert.ToString(Convert.ToString(massiv[i]))!="-"){
            a.Add(massiv[i]);
        }
    }
    catch(Exception){
        Console.WriteLine("Ошибка");
    }
}
double last=a.IndexOf(a.Last());
try{
    massiv.Insert((Convert.ToInt32(last))+1, P);
}
catch(Exception){
    Console.WriteLine("Ошибка");
}
Console.WriteLine("Новый массив:");
massiv.ForEach(Console.WriteLine);
#endregion

#region 2.13
Console.WriteLine("Введите количество значений в массиве");
int kol=0;
try{
    kol=Convert.ToInt32(Console.ReadLine());
}
catch(Exception){
    Console.WriteLine("Ошибка");
}
List<double>massiv=new List<double>(){};
for(int i=1;i<=kol;i++){
    try{
        Console.WriteLine($"Введите {i}-ое значение");
        massiv.Add(Convert.ToDouble(Console.ReadLine()));
    }
    catch(Exception){
        Console.WriteLine("Ошибка");
    }
}
for(int l=0; l<kol;l++){
if(massiv[l]%2==0){
        //Console.WriteLine(massiv.IndexOf(massiv.Max()));
        try{
            massiv[massiv.IndexOf(massiv.Max())]=Convert.ToDouble(massiv.IndexOf(massiv.Max()));
        }
        catch(Exception){
            Console.WriteLine("Ошибка");
        }
}
}
Console.Write($"Новый массив: \n");
massiv.ForEach(Console.WriteLine);
#endregion

#region 2.15
Console.WriteLine("Введите количество значений в массиве A");
int kolA=0;
try{
    kolA=Convert.ToInt32(Console.ReadLine());
}
catch(Exception){
    Console.WriteLine("Ошибка");
}
List<double>A=new List<double>(){};
for(int i=1;i<=kolA;i++){
    try{
        Console.WriteLine($"Введите {i}-ое значение");
        A.Add(Convert.ToDouble(Console.ReadLine()));
    }
    catch(Exception){
        Console.WriteLine("Ошибка");
    }
}

Console.WriteLine("Введите количество значений в массиве B");
int kolB=0;
try{
    kolB=Convert.ToInt32(Console.ReadLine());
}
catch(Exception){
    Console.WriteLine("Ошибка");
}
List<double>B=new List<double>(){};
for(int i=1;i<=kolB;i++){
    try{
        Console.WriteLine($"Введите {i}-ое значение");
        B.Add(Convert.ToDouble(Console.ReadLine()));
    }
    catch(Exception){
        Console.WriteLine("Ошибка");
    }
}
int k=0;
Console.WriteLine("Введите k-индекс, куда вставляем массив В");
try{
    k=Convert.ToInt32(Console.ReadLine());
}
catch(Exception){
    Console.WriteLine("Ошибка");
}
try{
A.InsertRange(Convert.ToInt32(k), B);
}
catch(Exception){
    Console.WriteLine("Ошибка");
}
A.ForEach(Console.WriteLine);
#endregion

#region 3.1
Console.WriteLine("Введите количество значений в массиве");
int x = 0;
try{
    x=Convert.ToInt32(Console.ReadLine());
}
catch(Exception){
    Console.WriteLine("Ошибка");
}

double[] FFF = new double[x];
List<int> IND = new List<int>();
double max;
Console.WriteLine("Введите значение");
for (int i = 0; i < FFF.Length; i++)
{
    try{
        FFF[i] = Convert.ToDouble(Console.ReadLine());
    }
    catch(Exception){
        Console.WriteLine("Ошибка");
    }
}
max = FFF[0];
for (int i = 0; i < FFF.Length; i++)
{
    if (max < FFF[i])
    {
        max = FFF[i];
        IND.Clear();

    }
    if (max == FFF[i])
    {
        IND.Add(i);
    }
}
for (int i = 0; i < IND.Count; i++)
{
    Console.Write(IND[i] + " ");
}

#endregion

#region 3.13
Console.WriteLine("Введите количество значений в массиве");
int kol=0;
try{
    kol=Convert.ToInt32(Console.ReadLine());
}
catch(Exception){
    Console.WriteLine("Ошибка");
}
List<double>creep=new List<double>(){};
for(int i=1;i<=kol;i++){
    try{
        Console.WriteLine($"Введите {i}-ое значение");
        creep.Add(Convert.ToDouble(Console.ReadLine()));
    }
    catch(Exception){
        Console.WriteLine("Ошибка");
    }
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
    try{
        Console.WriteLine($"Введите {i}-ое значение");
        treep.Add(Convert.ToDouble(Console.ReadLine()));
    }
    catch(Exception){
        Console.WriteLine("Ошибка");
    }
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
int kol=0;
try{
    kol=Convert.ToInt32(Console.ReadLine());
}
catch(Exception){
    Console.WriteLine("Ошибка");
}
List<double>creep=new List<double>(){};
List<double>chetn=new List<double>(){};
for(int i=1;i<=kol;i++){
    try{
        Console.WriteLine($"Введите {i}-ое значение");
        creep.Add(Convert.ToDouble(Console.ReadLine()));
    }
    catch(Exception){
        Console.WriteLine("Ошибка");
    }
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
int kol=0;
try{
    kol=Convert.ToInt32(Console.ReadLine());
}
catch(Exception){
    Console.WriteLine("Ошибка");
}
List<double>creep=new List<double>(){};
List<double>otric=new List<double>(){};
for(int i=1;i<=kol;i++){
    try{
        Console.WriteLine($"Введите {i}-ое значение");
        creep.Add(Convert.ToDouble(Console.ReadLine()));
    }
    catch(Exception){
        Console.WriteLine("Ошибка");
    }
}
double q=0;

for(int i=0;i<kol;i++){
    try{
        q=Convert.ToString(creep[i])[0];
    }
    catch(Exception){
        Console.WriteLine("Ошибка");
    }
    if(q=='-'){
        otric.Add(creep[i]);
    }
}
otric.Sort();
otric.Reverse();
int l=0;
double z=0;

for(int y=0;y<kol;y++){ 
    try{
        z=Convert.ToString(creep[y])[0];
    }
    catch(Exception){
        Console.WriteLine("Ошибка");
    }
    if(z=='-'){
        creep[y]=otric[l];
        l++;
    }
}
Console.WriteLine("Новый массив:");
creep.ForEach(Console.WriteLine);
#endregion


#region 3.9
string s = null;
Console.WriteLine("Введите элементы массива , для завершения нажмите q");
List<int> a = new List<int>(){};
while (s != "q"){
    s = Console.ReadLine();
    int b = 0;
    if (int.TryParse(s, out b))
    {
        a.Add(b);
    }
}
Console.WriteLine("Массив");
foreach (int u in a){
    Console.WriteLine(u);
}
int ub = 1;
int voz = 1;
int maxvoz = 1;
int maxub = 1;
for (int i = 0; i < a.Count - 1; i++){
    if (a[i] <= a[i + 1]){
        voz++;
        if (voz > maxvoz){
            maxvoz = voz;
        }
    }
    else{
        voz = 1;
    }
    if (a[i] >= a[i + 1]){
        ub++;
        if (ub > maxub)
        {
            maxub = ub;

        }
    }
    else{
        ub = 1;
    }
}
if (maxvoz > maxub){
    Console.WriteLine("Наибольшая последовательность - последовательность по возрастанию обладает длиной " + maxvoz);
}
else{
    Console.WriteLine("Наибольшая последовательность - последовательность по убыванию обладает длиной " + maxub);
}

#region 2.6 //пофиксить
int n=0, P=0;
Console.WriteLine("Введите размер массива: ");
try{
n = Convert.ToInt32(Console.ReadLine());
}
catch(Exception){
    Console.WriteLine("Ошибка");
}
Console.WriteLine("Введите P: ");
try{
    P = Convert.ToInt32(Console.ReadLine());
}
catch(Exception){
    Console.WriteLine("Ошибка");
}
var mas = new List<int>();
double sum = 0;
double sred = 0;
double znach;
Console.WriteLine("Введите значения массива: ");
for (int i=0; i<n; i++){
    try{
    mas.Add(Convert.ToInt32(Console.ReadLine()));
    }
    catch(Exception){
        Console.WriteLine("Ошибка");
    }
}
for (int i=0; i<n; i++){
    sum = sum + mas[i];
}
sred = sum / n;
double minsred = mas.Max();
int k = 0;
for (int i = 0; i < n; i++){
    znach = mas[i] - sred;
    if (znach < 0) znach = znach * (-1);
    if (znach < minsred) {minsred = znach; k = i;}
}
mas.Insert(k+1, P);
Console.WriteLine("Новый массив: ");
for (int i = 0; i < n+1; i++)
{
    Console.Write(mas[i] + " ");
}
#endregion

#region alg11
Console.WriteLine("Введите размер массива: ");
int n=0;
try{
    n = Convert.ToInt32(Console.ReadLine());
}
catch(Exception){
    Console.WriteLine("Ошибка");
}
var A = new List<double>();
int k = 0, t = 0, x = 0;
Console.WriteLine("Введите искомый элемент: ");
try{
    x = Convert.ToInt32(Console.ReadLine());
}
catch(Exception){
    Console.WriteLine("Ошибка");
}
Console.WriteLine("Введите массив: ");
for (int i=0; i<n; i++){
    try{
        A.Add(Convert.ToInt32(Console.ReadLine()));
    }
    catch(Exception){
        Console.WriteLine("Ошибка");
    }
}
A.Sort();
int one = 0;
int two = n - 1;
k = (one + two) / 2;
for (int i=0; i<n; i++){
    k = (one + two) / 2;
    if (A[k] == x){ 
        Console.WriteLine("Индекс искомого значения: " + k);
        t++; 
        break;
    }
    if (A[k] > x) two = k - 1;
    if (A[k] < x) one = k + 2;

}
if (t == 0){
    Console.WriteLine("Искомого значегия нет :(");
    }
#endregion

#region alg12
Console.WriteLine("Введите размер первого массива: ");
int n=0, m=0;
try{
    n = Convert.ToInt32(Console.ReadLine());
}
catch(Exception){
    Console.WriteLine("Ошибка");
}
Console.WriteLine("Введите размер первого массива: ");
try{
    m = Convert.ToInt32(Console.ReadLine());
}
catch(Exception){
    Console.WriteLine("Ошибка");
}
var A = new List<double>();
var B = new List<double>();
var C = new List<double>();
int t = 0, LB = 0, LA = 0;
Console.WriteLine("Введите значения первого массива: ");
for (int i=0; i<n; i++){
    try{
        A.Add(Convert.ToInt32(Console.ReadLine()));
    }
    catch(Exception){
        Console.WriteLine("Ошибка");
    }
}
Console.WriteLine("Введите значения второго массива: ");
for (int i = 0; i < m; i++){
    try{
        B.Add(Convert.ToInt32(Console.ReadLine()));
    }
    catch(Exception){
        Console.WriteLine("Ошибка");
    }
}
LB = B.Count();
LA = A.Count();
if (LB > LA){
    for (int i = 0; i < LA; i++)
    {
        C.Add(A[i]);
        C.Add(B[i]);
    }
    t = 1;
}
else{
    for (int i = 0; i < LB; i++){
        C.Add(A[i]);
        C.Add(B[i]);
    }
    t = 2;
}
if (t == 1){
    for (int i = 0; i < LB-LA; i++){
        C.Add(B[i]);
    }
}
if (t == 2){
    for (int i = 0; i < LA - LB; i++){
        C.Add(A[i]);
    }
}
Console.WriteLine("Новый массив: ");
for (int i=0; i<n+m; i++){
    Console.WriteLine(C[i]);
}
#endregion

#region alg13
Console.WriteLine("Введите размер первого массива: ");
int n=0, m=0;
try{
    n = Convert.ToInt32(Console.ReadLine());
}
catch(Exception){
    Console.WriteLine("Ошибка");
}
Console.WriteLine("Введите размер первого массива: ");
try{
    m = Convert.ToInt32(Console.ReadLine());
}
catch(Exception){
    Console.WriteLine("Ошибка");
}
var A = new List<double>();
var B = new List<double>();
var C = new List<double>();
int k = 0, t = 0;
Console.WriteLine("Введите значения первого массива: ");
for (int i=0; i<n; i++){
    try{
        A.Add(Convert.ToInt32(Console.ReadLine()));
    }
    catch(Exception){
        Console.WriteLine("Ошибка");
    }
}
Console.WriteLine("Введите значения второго массива: ");
for (int i = 0; i < m; i++){
    try{
        B.Add(Convert.ToInt32(Console.ReadLine()));
    }
    catch(Exception){
        Console.WriteLine("Ошибка");
    }
}
while (k < n || t < m){
    if (k == n){
        C.Add(B[t]); 
        t++; 
        continue; 
    }
    if (t == m){
        C.Add(A[k]); 
        k++;
        continue; 
    }
    if (A[k] >= B[t]){
        C.Add(A[k]);
        k++; 
    }
    else{ 
        C.Add(B[t]);
        t++;
    }
}
Console.WriteLine("Новый массив: ");
for (int i = 0; i < C.Count; i++){
    Console.WriteLine(C[i]);
}
#endregion

#region alg14
Console.WriteLine("Введите размер первого массива: ");
int n=0;
try{
    n = Convert.ToInt32(Console.ReadLine());
}
catch(Exception){
    Console.WriteLine("Ошибка");
}
var A = new List<double>();
var B = new List<double>();
var C = new List<double>();
double f;
Console.WriteLine("Введите значения массива: ");
for (int i=0; i<n; i++){
    try{
        A.Add(Convert.ToInt32(Console.ReadLine()));
    }
    catch(Exception){
        Console.WriteLine("Ошибка");
    }
}
for (int i=0; i < n/2; i++){
    f = A[i];
    A[i] = A[n-1-i];
    A[n-1-i] = f;
}
Console.WriteLine("Новый массив: ");
for (int i = 0; i < n ; i++){
    Console.WriteLine(A[i]);
}
#endregion

#region alg15
Console.WriteLine("Введите размер первого массива: ");
int n=0;
try{
    n = Convert.ToInt32(Console.ReadLine());
}
catch(Exception){
    Console.WriteLine("Ошибка");
}
Console.WriteLine("На сколько элементов сдвигать?: ");
int d=0;
try{
    d = Convert.ToInt32(Console.ReadLine());
}
catch(Exception){
    Console.WriteLine("Ошибка");
}
var A = new List<double>();
var B = new List<double>();
var C = new List<double>();
double f;
Console.WriteLine("Введите значения массива: ");
for (int i=0; i<n; i++){
    try{
        A.Add(Convert.ToInt32(Console.ReadLine()));
    }
    catch(Exception){
        Console.WriteLine("Ошибка");
    }
}
for (int i=0; i<d; i++){
    f = A[n - 1];
    for (int j = n-1; j > 0; j--){
        A[j]=A[j-1];
    }
    A[0] = f;
}
Console.WriteLine("Новый массив: ");
for (int i = 0; i < n ; i++){
    Console.WriteLine(A[i]);
}
#endregion

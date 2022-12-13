using System;
#region 2task6 

int n6;
Console.Write("Введите длину массива:");
while (!int.TryParse(Console.ReadLine(), out n6))
{
    Console.WriteLine("Неверные входные данные");
    Console.Write("Введите длину массива:");
}
double[] mas6 = new double[n6 + 1];
int t6;
for (t6 = 0; t6 < n6; t6++)
{
    Console.Write($"{t6 + 1})");
    while (!double.TryParse(Console.ReadLine(), out mas6[t6]))
    {
        Console.WriteLine("Неверные входные данные");
        Console.Write($"{t6 + 1})");
    }
}
double p;
Console.Write("Введите Р:");
while (!double.TryParse(Console.ReadLine(), out p))
{
    Console.WriteLine("Неверные входные данные");
    Console.Write("Введите Р:");
}
double summa = mas6.Sum();
double schet = mas6.Length;
double malraznost;
double srednee = summa / n6;
malraznost = Math.Abs(srednee - mas6[0]);
int raznost = 0;
for (int i6 = 1; i6 < n6; i6++)
{
    if (Math.Abs(mas6[i6] - srednee) < malraznost)
    {
        malraznost = Math.Abs(mas6[i6] - srednee);
        raznost = i6;
    }
}
for (int i6 = n6 - 1; i6 != raznost; i6--)
{
    mas6[i6 + 1] = mas6[i6];
}
mas6[raznost + 1] = p;
Console.WriteLine($"Среднее значение-{srednee}");
Console.Write("Массив: ");
for (int i6 = 0; i6 < n6 + 1; i6++)
    Console.Write($"{mas6[i6]} ");
Console.WriteLine();
#endregion


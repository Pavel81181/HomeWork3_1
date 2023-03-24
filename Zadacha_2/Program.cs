// Задача № 4
// Программа для ввода трех чисел и поиска наибольшего

Console.Clear();
Console.Write("Введите число А:");
string strNumA = Console.ReadLine();
int numA = Convert.ToInt32(strNumA);
Console.Write("Введите число B:");
string strNumB = Console.ReadLine();
int numB = Convert.ToInt32(strNumB);
Console.Write("Введите число С:");
string strNumC = Console.ReadLine();
int numC = Convert.ToInt32(strNumC);
int max = numA;

if (numB > max)
{
    max = numB;
}
if (numC > max)
{
    max = numC;
}
Console.WriteLine($"Максимальное из введенных число {max}");
Console.WriteLine($"Максимальное из введенных число {Math.Max(numA, Math.Max(numB, numC))}");
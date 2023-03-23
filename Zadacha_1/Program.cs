// Задача № 2 
// Программа для ввода двух чисел и поиска наибольшего

Console.Clear ();
Console.Write("Введите число А:");
string strNumA = Console.ReadLine();
int numA = Convert.ToInt32(strNumA);
Console.Write("Введите число B:");
string strNumB = Console.ReadLine();
int numB = Convert.ToInt32(strNumB);
if (numA > numB)
{
    Console.WriteLine($"Число А = {numA} больше чем число В = {numB}");
}
else
{
    Console.WriteLine($"Число B = {numB} больше чем число A = {numA}");
}
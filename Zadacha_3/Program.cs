// Задача № 6 
// Программа для определения четного числа

Console.Clear ();
Console.Write("Введите число: ");
string strNum = Console.ReadLine();
int num = Convert.ToInt32(strNum);
if (num%2 == 0)
{
    Console.WriteLine($"Число  {num} четное");
}
else
{
    Console.WriteLine($"Число  {num} нечетное");;
}
// Задача № 8
// Программа для вывода всех четных чисел от 1 до N

Console.Clear ();
Console.Write("Введите число N: ");
string strNumN = Console.ReadLine();
int numN = Convert.ToInt32(strNumN);
int count = 1;
Console.WriteLine($"Последовательных четных чисел от 1 до {numN}:");
while (count <= numN)
{
    if  (count%2 == 0)
    {
       Console.Write($" {count}_");
    }
count++;
}
Console.WriteLine();
/*
Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5 -> "1, 2, 3, 4, 5"
M = 4; N = 8 -> "4, 6, 7, 8"
*/

string ResultNumbers(int m, int n)
{
    if (n == m)
        return $"{m}";
    return Convert.ToInt32(m) + ", " + ResultNumbers(m + 1, n);
}

Console.Clear();
Console.WriteLine("Введите 1 число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2 число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(ResultNumbers(m, n));
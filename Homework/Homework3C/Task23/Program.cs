﻿Console.Clear();
Console.WriteLine("Программа, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N");
Console.WriteLine("Введите целое число N: ");
int N = Convert.ToInt32(Console.ReadLine());
double i = 1;
Console.Write("Кубы чисел числел: ");
while (i <= N)
{
    double B = Math.Pow(i, 3);
    i+=1;
    Console.Write($"{B} ");
}

// Console.Clear();
// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// for (int i = 1; i <= n; i++)
// Console.Write($"{i * i} ");
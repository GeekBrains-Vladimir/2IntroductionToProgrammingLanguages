//Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
Console.Clear();
Console.WriteLine("Введите сторону А: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите сторону B: ");
int B = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите сторону C: ");
int C = Convert.ToInt32(Console.ReadLine());
if ((A + B) > C && (A + C) > B && (B + C) > A) Console.WriteLine("yes");

else Console.WriteLine("no");



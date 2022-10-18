//Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10
Console.Clear();
Console.WriteLine("Введите целое положительное число: ");
int A = Convert.ToInt32(Console.ReadLine());
string result = string.Empty;
while (A != 0)
{
    int x = A % 2;
    result  = Convert.ToString(x) + result; //revers
    A = A/2;
}
Console.WriteLine(result);


//решение через рекурсию.
// 42 task

// string f(int n)
// {
// if (n == 0 || n == 1)
// return $"{n}";
// return f(n / 2) + $"{n % 2}";
// }

// Console.Clear();
// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(f(n));
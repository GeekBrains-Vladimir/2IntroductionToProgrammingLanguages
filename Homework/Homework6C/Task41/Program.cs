// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int Result(int n)
{
    int sum = 0;
    for (int i = 0; i < n; i++)
    {
        Console.Write("Введите число: ");
        int x = Convert.ToInt32(Console.ReadLine());
        if (x > 0) sum++;
    }
    return sum;
}
Console.Clear();
Console.WriteLine("Программа считает количество чисел больше 0");
Console.Write("Введите количество цифр: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Количество чисел больше 0: = {Result(n)}");

Console.Clear();
Console.WriteLine("Программа определяет значение второго по величине элемента в этой последовательности, то есть элемента, который будет наибольшим, если из последовательности удалить наибольший элемент");
int max1 = 0;
int max2 = 0;
int n = 1;
while (n != 0)
{
    Console.Write("Введите число: ");
    int m = Convert.ToInt32(Console.ReadLine());
    n = m;
    if (n > max1)
    {
        max2 = max1;
        max1 = n;
    }
    if (n < max1 && n >= max2) max2 = n;
    if (n == 0) break;
}
Console.WriteLine($"Второй максимум: {max2}");
void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-9, 10);
}

int SummaPositiveNumbers(int[] array)
{
    int summaP = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
            summaP += array[i]; //summaP = summaP + array[i];
    }
    return summaP;
}
int SummaNegativeNumbers(int[] array)
{
    int summaN = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0)
            summaN += array[i]; //summaN = summaN + array[i];
    }
    return summaN;
}
Console.Clear();
Console.WriteLine("Массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].");
Console.WriteLine("Найдите сумму отрицательных и положительных элементов массива");
int[] array = new int[12];
InputArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");
Console.WriteLine($"Сумма положительных элементов равна: {SummaPositiveNumbers(array)}");
Console.WriteLine($"Сумма отрицательных элементов равна: {SummaNegativeNumbers(array)}");
//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//Внутренние функции использовать нельзя(Max и Min)
//[3 7 22 2 78] -> 76
void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-10, 10);
}

int Max(int[] array)
{
    int Max = array[0];
    for (int i = 0; i < array.Length; i++)
    {

        while (array[i] > Max)
            Max = array[i];
    }
    return Max;
}

int Min(int[] array)
{
    int Min = array[0];
    for (int i = 0; i < array.Length; i++)
    {

        while (array[i] < Min)
            Min = array[i];
    }
   return Min; 
}

Console.Clear();
Console.WriteLine($"Введите количество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"Массив: [{String.Join(" ,", array)}]");
Max(array);
Console.WriteLine($"Максимальное значение равно: {Max(array)}");
Min(array);
Console.WriteLine($"Минимальное значение равно: {Min(array)}");
Console.WriteLine($"Разница значений равна: {Max(array) - Min(array)}");
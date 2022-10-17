// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-100, 101);
}

void SumNotEven(int[] array)
{
    int Sum = 0;
    for (int i = 1; i < array.Length; i+=2)
    {
        Sum += array[i];
    }
    Console.WriteLine($"Сумма чисел на нечётных позициях равна: {Sum}");
}

Console.Clear();
Console.WriteLine($"Введите количество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"Массив: [{String.Join(" ,", array)}]");
SumNotEven(array);
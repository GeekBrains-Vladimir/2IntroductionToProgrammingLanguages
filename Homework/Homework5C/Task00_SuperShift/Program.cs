//Дана последовательность из N целых чисел и число K.
//Необходимо сдвинуть всю последовательность (сдвиг - циклический) на |K| элементов вправо,
//если K – положительное и влево, если отрицательное.
//Входные данные
//Первая строка входного файла INPUT.TXT содержит натуральное число N, во второй строке записаны N целых чисел Ai,
//а в последней – целое число K. (1 ≤ N ≤ 105, |K| ≤ 105, |Ai| ≤ 100).
void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(1, 101);
}

void ReleaseArray(int[] array, int m)
{
    int k = m % array.Length;
    int[] ReleaseArray = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        if (i + k < array.Length && i + k >= 0)
            ReleaseArray[i + k] = array[i];
        if (i + k >= array.Length)
            ReleaseArray[i + k - array.Length] = array[i];
        if (i + k < 0)
            ReleaseArray[i + k + array.Length] = array[i];
    }
    Console.WriteLine($"Новый Массив: [{String.Join(" ,", ReleaseArray)}]");
}

Console.Clear();
Console.WriteLine($"Введите количество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"Массив: [{String.Join(" ,", array)}]");
Console.Write("На сколько будем двигать?: ");
int m = Convert.ToInt32(Console.ReadLine());
ReleaseArray(array, m);


// // SuperStep

// Console.Clear();
// int n = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[n];
// for (int i = 0; i < array.Length; i++)
// array[i] = Convert.ToInt32(Console.ReadLine());

// int[] arrayResult = new int[n];
// int k = Convert.ToInt32(Console.ReadLine());
// k = k % n;
// if (k > 0)
// {
// for (int i = 0; i < k; i++)
// arrayResult[i] = array[n - k + i];
// for (int i = 0; i < n - k; i++)
// arrayResult[k + i] = array[i];

// Console.WriteLine($"[{string.Join(", ", arrayResult)}]");
// }
// else
// {
// k = k * (-1);
// for (int i = 0; i < k; i++)
// arrayResult[n - k + i] = array[i];
// for (int i = 0; i < n - k; i++)
// arrayResult[i] = array[k + i];

// Console.WriteLine($"[{string.Join(", ", arrayResult)}]");
// }
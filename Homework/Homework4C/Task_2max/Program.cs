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

// Console.Clear();
// int n = Convert.ToInt32(Console.ReadLine());
// int firstMax = n, secondMax = -1;

// while (n != 0)
// {
// n = Convert.ToInt32(Console.ReadLine());
// if (n > firstMax)
// {
// secondMax = firstMax;
// firstMax = n;
// }
// else if (n > secondMax)
// secondMax = n;
// }
// Console.WriteLine(secondMax);

// Вариант через массив
// Console.Clear();

// void fillArray(double[]array)
// {
// for (int i = 0; i < array.Length; i++)
// {
// array[i] = Math.Round(new Random().NextDouble() * 10, 3);
// }
// }

// void findMax (double [] array, ref double nMax)
// {
// for (int i = 1; i < array.Length; i++)
// {
// if (array[i]>nMax)
// nMax = array[i];
// }
// }

// void findMin (double [] array, ref double nMin)
// {
// for (int i = 1; i < array.Length; i++)
// {
// if (array[i]<nMin)
// nMin = array [i];
// }
// }

// double [] array = new double [5];
// fillArray(array);
// Console.WriteLine($"Вот такой массив что ли [{string.Join(", ", array)}]");
// double nMax = array[0];
// double nMin = array[0];
// findMax(array, ref nMax);
// findMin(array, ref nMin);
// Console.WriteLine($"Разница между {nMax} и {nMin} = {nMax-nMin}");
// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(-10, 11);
        }
    }
}
void PrintMatrix(int[,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]} \t");
        Console.WriteLine();
    }
    Console.WriteLine();
}
void AverageValueColums(int[,] matrix)
{
    double AverageValue = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double Sum = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            Sum += (matrix[i, j]);
            AverageValue = Sum / matrix.GetLength(0);
        }
        Console.WriteLine($"Среднее значение по столбцу {j + 1}: {Math.Round(AverageValue, 3)}");
    }
}
Console.Clear();
Console.Write("Введите количество строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столобцов: ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[n, m];
InputMatrix(matrix);
Console.WriteLine();
PrintMatrix(matrix);
AverageValueColums(matrix);
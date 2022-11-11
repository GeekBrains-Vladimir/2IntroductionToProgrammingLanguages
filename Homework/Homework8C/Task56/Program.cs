/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/
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

void SearchRow(int[,] matrix)
{
    int Min = 0;
    int NumberRow = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int Sum = 0;

        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Sum += matrix[i, j];
        }
        //Console.WriteLine($"Сумма строки: {Sum}"); //Если необходимо увидеть суммы строк
        if (Sum < Min)
        {
            Min = Sum;
            NumberRow = i + 1;
        }
    }
    Console.WriteLine($"Минимальная сумма строки: {NumberRow}, равна: {Min}");
}

Console.Clear();
Console.Write("Введите количество строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столобцов: ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[n, m];
InputMatrix(matrix);
Console.WriteLine();
Console.WriteLine("Начальная матрица: ");
PrintMatrix(matrix);
SearchRow(matrix);
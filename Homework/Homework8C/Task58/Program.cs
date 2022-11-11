/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
12 16
9 6
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

void ResultMatrix(int[,] MatrixOne, int[,] MatrixTwo)
{
    int[,] ResultMatrix = new int[MatrixOne.GetLength(0), MatrixOne.GetLength(1)];
    for (int i = 0; i < MatrixOne.GetLength(0); i++)
    {
        for (int j = 0; j < MatrixOne.GetLength(1); j++)
        {
            ResultMatrix[i, j] = MatrixOne[i, j] * MatrixTwo[i, j];
            Console.Write($"{ResultMatrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}

Console.Clear();
Console.Write("Введите количество строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столобцов: ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] MatrixOne = new int[n, m];
int[,] MatrixTwo = new int[n, m];
InputMatrix(MatrixOne);
Console.WriteLine();
Console.WriteLine("Начальная матрица 1: ");
PrintMatrix(MatrixOne);
InputMatrix(MatrixTwo);
Console.WriteLine();
Console.WriteLine("Начальная матрица 2: ");
PrintMatrix(MatrixTwo);
Console.WriteLine("Произведение матриц равно: ");
ResultMatrix(MatrixOne, MatrixTwo);
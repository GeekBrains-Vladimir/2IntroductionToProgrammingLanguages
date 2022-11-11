/*Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/
void CreateMatrix(int[,] matrix)
{
    int tmp = 1, i = 0, j = 0;
    while (tmp <= matrix.GetLength(0) * matrix.GetLength(1))
    {
        matrix[i, j] = tmp;
        tmp++;
        if (i <= j + 1 && i + j < matrix.GetLength(1) - 1)
            j++;
        else if (i < j && i + j >= matrix.GetLength(0) - 1)
            i++;
        else if (i >= j && i + j > matrix.GetLength(1) - 1)
            j--;
        else
            i--;
    }
    for (i = 0; i < matrix.GetLength(0); i++)
    {
        for (j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]} \t");
        Console.WriteLine();
    }
}

Console.Clear();
Console.Write("Введите размер матрицы: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[n, n];
CreateMatrix(matrix);
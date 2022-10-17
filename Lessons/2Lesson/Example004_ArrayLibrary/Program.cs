void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrinArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write(col[position] + " ");
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;
    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int[] array = new int[20];

FillArray(array);
array[5] = 4;
array[14] = 4;
PrinArray(array);

Console.WriteLine();
int pos = IndexOf(array, 1);
Console.WriteLine(pos);

// Вывод цикла
// var str = string.Join(" ", array);
// Console.WriteLine(str);

// Вывод цикла
for (int a = 0; a < array.Length; a++)
{
Console.Write(array[a] + " ");
}
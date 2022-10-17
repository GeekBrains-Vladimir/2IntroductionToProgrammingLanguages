int[] array = { 10, 22, 34, 64, 95, 56, 77, 18, 13, 12, 35 };
int n = array.Length;
int find = 22;
int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }

        index++;
}
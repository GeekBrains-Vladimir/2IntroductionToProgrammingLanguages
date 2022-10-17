Console.Clear();
Console.WriteLine("программа выводит рандомный массив 0,1 из 8 элементов");
int[] array = new int[8];
for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(0, 2);
Console.WriteLine($"[{String.Join(", ", array)}]");

// array

int[] array = new int[8];
// int n = 10;
for (int i = 0; i < array.Length; i++)
array[i] = new Random().Next(-10, 11);

//Console.WriteLine("[" + string.Join(", ", array) + "]");
Console.WriteLine($"[{string.Join(", ", array)}]"); // интерполяция строк
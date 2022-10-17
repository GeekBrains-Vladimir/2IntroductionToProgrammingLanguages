Console.Clear();
Console.WriteLine("Программа, выводит массив из 8 элементов, введёных пользователем.");
int[] array = new int[8];
for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine("Введите целое, число: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine($"Массив из 8 элементов: [{string.Join(", ", array)}]");
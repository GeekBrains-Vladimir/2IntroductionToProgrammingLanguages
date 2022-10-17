void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-9, 10);
}
Console.Clear();
Console.WriteLine("Программа для замены элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.");
Console.Write("Введите количество элементов массива: ");
int x = Convert.ToInt32(Console.ReadLine());
int[] array = new int[x];
int[] newarray = new int[x];
InputArray(array);
Console.WriteLine($"Массив: [{String.Join(" ,", array)}]");
for (int i = 0; i < array.Length; i++)
    newarray[i] = array[i] * -1;
Console.WriteLine($"Новый массив: [{String.Join(" ,", newarray)}]");
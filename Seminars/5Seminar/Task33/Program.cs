
void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-9, 10);
}
string Search(int[] array, int number)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == number)
            return "yes";
    }
    return "no";
}
Console.Clear();
Console.WriteLine("Программа, которая определяет, присутствует ли заданное число в массиве.");
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"Массив: [{String.Join(" ,", array)}]");
Console.Write("Введите искомое значение: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{Search(array, m)}");
Console.Clear();
Console.WriteLine("Программа, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.");
Console.WriteLine("Введите целое, число: ");
int a = Convert.ToInt32(Console.ReadLine());
while (a < 100)
{
    Console.WriteLine("Не вижу третьей цифры. Введите целое ,более 2-х символов, число: ");
    a = Convert.ToInt32(Console.ReadLine());
}
string str = a.ToString();
Console.WriteLine($"Третья цифра Вашего трёхзначного числа равна: {str[2]}");